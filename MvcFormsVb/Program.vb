Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms
Imports MvcLibraryVb
Imports Ssepan.Application
Imports Ssepan.Application.WinConsole
Imports Ssepan.Utility

'Namespace MvcFormsVb
NotInheritable Class Program
    Private Sub New()
    End Sub
#Region "Declarations"
    Public Const APP_NAME As [String] = "MVCView"
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
    Public Shared Sub ModelPropertyChangedEventHandlerDelegate(sender As [Object], e As PropertyChangedEventArgs)
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
        Set(value As [String])
            _Filename = Value
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
    <STAThread> _
    Public Shared Function Main(args As [String]()) As Int32
        'default to fail code
        Dim returnValue As Int32 = -1

        Try
            'define default output delegate
            ConsoleApplication.defaultOutputDelegate = ConsoleApplication.messageBoxWrapperOutputDelegate

            'subscribe to notifications
            AddHandler PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate

            'load, parse, run switches
            DoSwitches(args)

            InitModelAndSettings()

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MVCView(args))

            'return success code
            returnValue = 0
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
        Return returnValue
    End Function

#Region "FormAppBase"
    ''' <summary>
    ''' Note: switches are processed before Model or Settings are accessed.
    ''' </summary>
    ''' <param name="args"></param>
    Private Shared Sub DoSwitches(args As [String]())
        'define supported switches
        ' -t -f:"filename" -h
        'new CommandLineSwitch("H", "H invokes the Help command.", false, ConsoleApplication.Help)//may already be loaded
        ConsoleApplication.DoCommandLineSwitches(args, New CommandLineSwitch() {New CommandLineSwitch("f", "f filename; overrides app.config", True, AddressOf f)})
    End Sub

    Private Shared Sub InitModelAndSettings()
        'create Settings before first use by Model
        'If SettingsController(Of Settings).Settings Is Nothing Then
        '    SettingsController(Of Settings).[New]()
        'End If
        'Model properties rely on Settings, so don't call Refresh before this is run.
        If ModelController(Of Model).Model Is Nothing Then
            ModelController(Of Model).[New]()
        End If
    End Sub
#End Region

#Region "CommandLineSwitch Action Delegates"
    ''' <summary>
    ''' Validate and set selected settings.
    ''' Instance of an action conforming to delegate Action(Of T), where T is String.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="outputDelegate"></param>
    Private Shared Sub f(value As [String], outputDelegate As Action(Of [String]))
        Try
#If DEBUG Then
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
'End Namespace
