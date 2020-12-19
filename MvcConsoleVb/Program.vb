Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
'using System.Threading.Tasks;
Imports System.Windows.Forms
Imports MvcLibraryVb
Imports Ssepan.Application
Imports Ssepan.Utility

Namespace MvcConsoleVb
	'Note: wasn't static originally; changed to match winforms
	NotInheritable Class Program
		Private Sub New()
		End Sub
		#Region "Declarations"
		Public Const APP_NAME As [String] = "MVCConsole"
		#End Region

		#Region "INotifyPropertyChanged"
		Public Shared Event PropertyChanged As PropertyChangedEventHandler
		Public Shared Sub OnPropertyChanged(propertyName As [String])
			Try

				RaiseEvent PropertyChanged(Nothing, New PropertyChangedEventArgs(propertyName))
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

				Throw
			End Try
		End Sub
		#End Region

		#Region "ModelPropertyChangedEventHandlerDelegate"
		''' <summary>
		''' Note: property changes update UI manually.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Public Shared Sub PropertyChangedEventHandlerDelegate(sender As [Object], e As PropertyChangedEventArgs)
			Try
				If e.PropertyName = "Filename" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("{0}", Filename))
				End If
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
		End Sub
		#End Region

		#Region "Properties"
		Private Shared _Filename As [String] = Nothing
		Public Shared Property Filename() As [String]
			Get
				Return _Filename
			End Get
			Set
				_Filename = value
				OnPropertyChanged("Filename")
			End Set
		End Property
		#End Region

		#Region "Methods"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		''' <param name="args"></param>
		''' <returns>Int32</returns>
		'Note: wasn't STAThread originally; changed to match winforms--SJS
        'Private Shared Function Main(args As [String]()) As Int32
        <STAThread> _
        Public Shared Function Main(args As [String]()) As Int32
            'default to fail code
            Dim returnValue As Int32 = -1

            Try
                'define default output delegate
                ConsoleApplication.defaultOutputDelegate = ConsoleApplication.writeLineWrapperOutputDelegate

                'subscribe to notifications
                AddHandler PropertyChanged, AddressOf PropertyChangedEventHandlerDelegate

                'load, parse, run switches
                DoSwitches(args)

                InitModelAndSettings()

                returnValue = New ConsoleView()._Main()
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
                Console.WriteLine([String].Format("{0} did NOT complete: '{1}'", APP_NAME, ex.Message))
            Finally
#If DEBUG Then
                Console.Write("Press ENTER to continue> ")
#End If
                Console.ReadLine()
            End Try
            Return returnValue
        End Function

		#Region "ConsoleAppBase"
		''' <summary>
		''' Note: switches are processed before Model or Settings are accessed.
		''' </summary>
		''' <param name="args"></param>
		Private Shared Sub DoSwitches(args As [String]())
			'define supported switches
			' -t -f:"filename" -h
				',
				'new CommandLineSwitch("H", "H invokes the Help command.", false, ConsoleApplication.Help)//may already be loaded
			ConsoleApplication.DoCommandLineSwitches(args, New CommandLineSwitch() {New CommandLineSwitch("t", "t tests switch.", True, AddressOf t), New CommandLineSwitch("f", "f filename; overrides app.config", True, AddressOf f)})
			'Note: switches are processed before Model or Settings are accessed.
		End Sub

		Private Shared Sub InitModelAndSettings()
			'create Settings before first use by Model
			If SettingsController(Of MVCSettings).Settings Is Nothing Then
				SettingsController(Of MVCSettings).[New]()
			End If
			'Model properties rely on Settings, so don't call Refresh before this is run.
			If ModelController(Of MVCModel).Model Is Nothing Then
				ModelController(Of MVCModel).[New]()
			End If
			ModelController(Of MVCModel).Model.UpdateHandlers()
		End Sub
		#End Region

		#Region "CommandLineSwitch Action Delegates"
		''' <summary>
		''' Instance of an action conforming to delegate Action(Of TSettings), where TSettings is String.
		''' Command 't' tests the use of parameters.
		''' </summary>
		''' <param name="value"></param>
		''' <param name="outputDelegate"></param>
		Private Shared Sub t(value As [String], outputDelegate As Action(Of [String]))
			Try
				outputDelegate([String].Format("t:" & vbTab & "{0}", value))
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
				Throw
			End Try
		End Sub

		''' <summary>
		''' Validate and set selected settings.
		''' Instance of an action conforming to delegate Action<T>, where T is String.
		''' </summary>
		''' <param name="value"></param>
		''' <param name="outputDelegate"></param>
		Private Shared Sub f(value As [String], outputDelegate As Action(Of [String]))
			Try
				#If debug Then
				outputDelegate([String].Format("s{0}" & vbTab & "{1}", ConsoleApplication.CommandLineSwitchValueSeparator, value))
				#End If

				'validate settings file path
				If Not System.IO.File.Exists(value) Then
					Throw New ArgumentException([String].Format("Invalid settings file path: '{0}'", value))
				End If
				Filename = value
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
				Throw
			End Try
		End Sub
		#End Region
		#End Region
	End Class
End Namespace
