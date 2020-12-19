#Const USE_CONFIG_FILEPATH = True
#Const USE_CUSTOM_VIEWMODEL = True

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
Imports Ssepan.Application
Imports Ssepan.Io
Imports Ssepan.Utility
Imports MvcLibraryVb

Namespace MvcConsoleVb
	Public Class ConsoleView
		Implements INotifyPropertyChanged
#Region "Declarations"
        Protected disposed As [Boolean]
#If USE_CUSTOM_VIEWMODEL Then
        Protected ViewModel As MVCConsoleViewModel = Nothing
#Else
        Protected ViewModel As ConsoleViewModel(Of [String], MVCSettings, MVCModel) = Nothing
#End If
        Private Shared _ValueChangedProgrammatically As [Boolean]
#End Region

		#Region "Constructors"
		Public Sub New()
			Try
				'''/(re)define default output delegate
				'ConsoleApplication.defaultOutputDelegate = ConsoleApplication.writeLineWrapperOutputDelegate;

				'subscribe to notifications
				AddHandler Me.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate

				InitViewModel()
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
		End Sub
		#End Region

		#Region "IDisposable"
		Protected Overrides Sub Finalize()
			Try
				Dispose(False)
			Finally
				MyBase.Finalize()
			End Try
		End Sub

		Public Overridable Sub Dispose()
			' dispose of the managed and unmanaged resources
			Dispose(True)

			' tell the GC that the Finalize process no longer needs
			' to be run for this object.
			GC.SuppressFinalize(Me)
		End Sub

		Protected Overridable Sub Dispose(disposeManagedResources As Boolean)
			' process only if mananged and unmanaged resources have
			' not been disposed of.
			If Not Me.disposed Then
				'Resources not disposed
				If disposeManagedResources Then
					' dispose managed resources
					'unsubscribe from model notifications
					RemoveHandler Me.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
				End If
				' dispose unmanaged resources
				disposed = True
					'Resources already disposed
			Else
			End If
		End Sub
		#End Region

		#Region "INotifyPropertyChanged"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(propertyName As [String])
			Try

				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
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
		Protected Sub ModelPropertyChangedEventHandlerDelegate(sender As [Object], e As PropertyChangedEventArgs)
			Try
				If e.PropertyName = "IsChanged" Then
					'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", e.PropertyName));
					ApplySettings()
				ElseIf e.PropertyName = "Progress" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("{0}", Progress))
				End If
				If e.PropertyName = "StatusMessage" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("{0}", ViewModel.StatusMessage))
					e = New PropertyChangedEventArgs(e.PropertyName & ".handled")
				ElseIf e.PropertyName = "ErrorMessage" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("{0}", ViewModel.ErrorMessage))
					e = New PropertyChangedEventArgs(e.PropertyName & ".handled")
					'Note: not databound, so handle event
				ElseIf e.PropertyName = "SomeInt" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("SomeInt: {0}", ModelController(Of MVCModel).Model.SomeInt))
				ElseIf e.PropertyName = "SomeBoolean" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("SomeBoolean: {0}", ModelController(Of MVCModel).Model.SomeBoolean))
				ElseIf e.PropertyName = "SomeString" Then
					ConsoleApplication.defaultOutputDelegate([String].Format("SomeString: {0}", ModelController(Of MVCModel).Model.SomeString))
				ElseIf (e.PropertyName = "SomeOtherInt") Then
					ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherInt: {0}", ModelController(Of MVCModel).Model.SomeComponent.SomeOtherInt))
				ElseIf (e.PropertyName = "SomeOtherBoolean") Then
					ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherBoolean: {0}", ModelController(Of MVCModel).Model.SomeComponent.SomeOtherBoolean))
				ElseIf (e.PropertyName = "SomeOtherString") Then
					ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherString: {0}", ModelController(Of MVCModel).Model.SomeComponent.SomeOtherString))
				ElseIf (e.PropertyName = "SomeComponent") Then
					ConsoleApplication.defaultOutputDelegate(String.Format("SomeComponent: {0},{1},{2}", ModelController(Of MVCModel).Model.SomeComponent.SomeOtherInt, ModelController(Of MVCModel).Model.SomeComponent.SomeOtherBoolean, ModelController(Of MVCModel).Model.SomeComponent.SomeOtherString))
				Else
					'ConsoleApplication.defaultOutputDelegate(String.Format("e.PropertyName: {0}", e.PropertyName))
				End If
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
		End Sub

		''' <summary>
		''' Note: handle settings property changes manually.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Protected Sub SettingsPropertyChangedEventHandlerDelegate(sender As [Object], e As PropertyChangedEventArgs)
			Try
				If e.PropertyName = "Dirty" Then
					'apply settings that don't have databindings
					ViewModel.DirtyIconIsVisible = (SettingsController(Of MVCSettings).Settings.Dirty)
				End If
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
		End Sub
		#End Region

		#Region "Properties"
		Private _ViewName As [String] = Program.APP_NAME
		Public Property ViewName() As [String]
			Get
				Return _ViewName
			End Get
			Set
				_ViewName = value
				OnPropertyChanged("ViewName")
			End Set
		End Property

		Private _Progress As Int32 = Nothing
		Public Property Progress() As Int32
			Get
				Return _Progress
			End Get
			Set
				_Progress = value
				OnPropertyChanged("Progress")
			End Set
		End Property
		#End Region

		#Region "Methods"
		#Region "ConsoleAppBase"
		Protected Sub InitViewModel()
			Try
				'subscribe to notifications
				AddHandler ModelController(Of MVCModel).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
				'subscribe view to settings notifications
				SettingsController(Of MVCSettings).DefaultHandler = AddressOf SettingsPropertyChangedEventHandlerDelegate

				'class to handle standard behaviors
#If USE_CUSTOM_VIEWMODEL Then
                ViewModelController(Of [String], MVCConsoleViewModel).[New] _
                ( _
                    ViewName, _
                    New MVCConsoleViewModel _
                    ( _
                        AddressOf Me.ModelPropertyChangedEventHandlerDelegate, _
                        New Dictionary(Of [String], [String])() From _
                        { _
                            {"New", "New"}, _
                            {"Save", "Save"}, _
                            {"Open", "Open"}, _
                            {"Print", "Print"}, _
                            {"Copy", "Copy"}, _
                            {"Properties", "Properties"} _
                        } _
                    ) _
                )
                ViewModel = ViewModelController(Of [String], MVCConsoleViewModel).ViewModel(ViewName)
#Else
                ViewModelController(Of [String], ConsoleViewModel(Of [String], MVCSettings, MVCModel)).[New] _
                ( _
                    ViewName, _
                    New ConsoleViewModel( Of [String], MVCSettings, MVCModel) _
                    ( _
                        AddressOf Me.ModelPropertyChangedEventHandlerDelegate, _
                        New Dictionary(Of [String], [String])() From _
                        { _
                            {"New", "New"}, _
                            {"Save", "Save"}, _
                            {"Open", "Open"}, _
                            {"Print", "Print"}, _
                            {"Copy", "Copy"}, _
                            {"Properties", "Properties"} _
                        } _
                    ) _
                )
                ViewModel = ViewModelController(Of [String], ConsoleViewModel(Of [String], MVCSettings, MVCModel)).ViewModel(ViewName)
#End If

				'Init config parameters
				If Not LoadParameters() Then
					Throw New Exception([String].Format("Unable to load config file parameter(s)."))
				End If

				'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
				'Load
				If (SettingsController(Of MVCSettings).FilePath Is Nothing) OrElse (SettingsController(Of MVCSettings).Filename = SettingsController(Of MVCSettings).FILE_NEW) Then
					'NEW
					ViewModel.FileNew()
				Else
					'OPEN
					ViewModel.FileOpen()
				End If
			Catch ex As Exception
				If ViewModel IsNot Nothing Then
					ViewModel.ErrorMessage = ex.Message
				End If
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
		End Sub

		Protected Sub DisposeSettings()

			'save user and application settings 
			'Properties.Settings.Default.Save();

			If SettingsController(Of MVCSettings).Settings.Dirty Then
				'SAVE
				ViewModel.FileSave()
			End If

			'unsubscribe from model notifications
			RemoveHandler ModelController(Of MVCModel).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
		End Sub

		Public Function _Main() As Int32
			Dim returnValue As Int32 = -1
			'default to fail code
			Try
				ViewModel.StatusMessage = [String].Format("{0} starting...", ViewName)

				ViewModel.StatusMessage = [String].Format("{0} started.", ViewName)

				_Run()

				ViewModel.StatusMessage = [String].Format("{0} completing...", ViewName)

				DisposeSettings()

				ViewModel.StatusMessage = [String].Format("{0} completed.", ViewName)

				'return success code
				returnValue = 0
			Catch ex As Exception
				ViewModel.ErrorMessage = [String].Format("{0} did NOT complete: '{1}'", ViewName, ViewModel.ErrorMessage)
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			Finally
				ViewModel = Nothing
			End Try
			Return returnValue
		End Function

		Protected Sub _Run()
			ViewModel.DoSomething()

			'ModelController<MVCModel>.Model.SomeBoolean = !ModelController<MVCModel>.Model.SomeBoolean;
			'ModelController<MVCModel>.Model.SomeInt += 1;
			'ModelController<MVCModel>.Model.SomeString = DateTime.Now.ToString();

			'''/SettingsController<MVCSettings>.Settings.SomeBoolean = true;
			'''/SettingsController<MVCSettings>.Settings.SomeInt += 1;
			'''/SettingsController<MVCSettings>.Settings.SomeString = "test";
		End Sub
		#End Region

		#Region "Utility"
		''' <summary>
		''' Apply Settings to viewer.
		''' </summary>
		Private Sub ApplySettings()
			Try
				_ValueChangedProgrammatically = True

				'apply settings that have databindings
				'BindModelUi();

				'apply settings that shouldn't use databindings

				'apply settings that can't use databindings
				Console.Title = Path.GetFileName(SettingsController(Of MVCSettings).Filename) & " - " & ViewName

				'apply settings that don't have databindings
				'ViewModel.StatusBarDirtyMessage.Visible = (SettingsController<Settings>.Settings.Dirty);

				_ValueChangedProgrammatically = False
			Catch ex As Exception
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
				Throw
			End Try
		End Sub

		''' <summary>
		''' Load from app config; override with command line if present
		''' </summary>
		''' <returns></returns>
		Private Function LoadParameters() As [Boolean]
			Dim returnValue As [Boolean] = Nothing
#If USE_CONFIG_FILEPATH Then
            Dim _settingsFilename As [String] = Nothing
#End If

			Try
				If (Program.Filename IsNot Nothing) AndAlso (Program.Filename <> SettingsController(Of MVCSettings).FILE_NEW) Then
					'got filename from command line
					'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
					If Not RegistryAccess.ValidateFileAssociation(Application.ExecutablePath, "." & SettingsController(Of MVCSettings).Settings.FileTypeExtension) Then
						Throw New ApplicationException([String].Format("Settings filename not associated: '{0}'." & vbLf & "Check filename on command line.", Program.Filename))
						'it passed; use value from command line
					End If
				Else
#If USE_CONFIG_FILEPATH Then
                    'get filename from app.config
                    If Not Configuration.ReadString("SettingsFilename", _settingsFilename) Then
                        Throw New ApplicationException([String].Format("Unable to load SettingsFilename: {0}", "SettingsFilename"))
                    End If
                    If (_settingsFilename Is Nothing) OrElse (_settingsFilename = SettingsController(Of MVCSettings).FILE_NEW) Then
                        Throw New ApplicationException([String].Format("Settings filename not set: '{0}'." & vbLf & "Check SettingsFilename in app config file.", _settingsFilename))
                    End If
                    'use with the supplied path
                    SettingsController(Of MVCSettings).Filename = _settingsFilename

                    If Path.GetDirectoryName(_settingsFilename) = [String].Empty Then
                        'supply default path if missing
                        SettingsController(Of MVCSettings).Pathname = Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator()
                    End If
#End If
                End If

				returnValue = True
			Catch ex As Exception
					'throw;
				Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
			End Try
			Return returnValue
		End Function
		#End Region
		#End Region
	End Class
End Namespace
