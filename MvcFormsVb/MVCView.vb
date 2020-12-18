'#define USE_CONFIG_FILEPATH

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Ssepan.Application
Imports Ssepan.Io
Imports Ssepan.Utility
Imports MvcLibraryVb
Imports My.Resources

'Namespace MvcFormsVb
''' <summary>
''' This is the View.
''' </summary>
Partial Public Class MVCView
    Inherits Form
    Implements INotifyPropertyChanged
#Region "Declarations"
    'Protected disposed As [Boolean]

    Private _ValueChangedProgrammatically As [Boolean]

    'cancellation hook
    Private cancelDelegate As Action = Nothing
    Friend ViewModel As MVCViewModel = Nothing
    Private permitEnabledStateAdd = True
    Private rememberedStateAdd = False
    Private permitEnabledStateRemove = True
    Private rememberedStateRemove = False
#End Region

#Region "Constructors"
    Public Sub New() 'required to compile

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="args"></param>
    Public Sub New(args As [String]())
        Try
            InitializeComponent()

            '(re)define default output delegate
            'ConsoleApplication.defaultOutputDelegate = ConsoleApplication.messageBoxWrapperOutputDelegate;

            'subscribe to view's notifications
            AddHandler Me.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate

            InitViewModel()

            BindSizeAndLocation()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub
#End Region

#Region "INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As [String])
        Try
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

            Throw
        End Try
    End Sub
#End Region

#Region "PropertyChangedEventHandlerDelegates"
    ''' <summary>
    ''' Note: handle model property changes manually.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub ModelPropertyChangedEventHandlerDelegate(sender As [Object], e As PropertyChangedEventArgs)
        Try
            If e.PropertyName = "IsChanged" Then
                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", e.PropertyName));
                ApplySettings()
                'Status Bar
            ElseIf e.PropertyName = "ActionIconIsVisible" Then
                StatusBarActionIcon.Visible = (ViewModel.ActionIconIsVisible)
            ElseIf e.PropertyName = "ActionIconImage" Then
                StatusBarActionIcon.Image = (If(ViewModel IsNot Nothing, ViewModel.ActionIconImage, DirectCast(Nothing, Image)))
            ElseIf e.PropertyName = "StatusMessage" Then
                'replace default action by setting control property
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", StatusMessage));
                StatusBarStatusMessage.Text = ViewModel.StatusMessage
            ElseIf e.PropertyName = "ErrorMessage" Then
                'replace default action by setting control property
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage));
                StatusBarErrorMessage.Text = ViewModel.ErrorMessage
            ElseIf e.PropertyName = "CustomMessage" Then

                'replace default action by setting control property
                StatusBarCustomMessage.Text = ViewModel.CustomMessage
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled")

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage))

            ElseIf e.PropertyName = "ErrorMessageToolTipText" Then
                StatusBarErrorMessage.ToolTipText = ViewModel.ErrorMessageToolTipText
            ElseIf e.PropertyName = "ProgressBarValue" Then
                StatusBarProgressBar.Value = ViewModel.ProgressBarValue
            ElseIf e.PropertyName = "ProgressBarMaximum" Then
                StatusBarProgressBar.Maximum = ViewModel.ProgressBarMaximum
            ElseIf e.PropertyName = "ProgressBarMinimum" Then
                StatusBarProgressBar.Minimum = ViewModel.ProgressBarMinimum
            ElseIf e.PropertyName = "ProgressBarStep" Then
                StatusBarProgressBar.[Step] = ViewModel.ProgressBarStep
            ElseIf e.PropertyName = "ProgressBarIsMarquee" Then
                StatusBarProgressBar.Style = (If(ViewModel.ProgressBarIsMarquee, ProgressBarStyle.Marquee, ProgressBarStyle.Blocks))
            ElseIf e.PropertyName = "ProgressBarIsVisible" Then
                StatusBarProgressBar.Visible = (ViewModel.ProgressBarIsVisible)
            ElseIf e.PropertyName = "DirtyIconIsVisible" Then
                StatusBarDirtyMessage.Visible = (ViewModel.DirtyIconIsVisible)
            ElseIf e.PropertyName = "DirtyIconImage" Then
                StatusBarDirtyMessage.Image = ViewModel.DirtyIconImage
                'use if properties cannot be databound
                'else if (e.PropertyName == "SomeInt")
                '{
                '    //SettingsController<Settings>.Settings.
                '    ModelController<Model>.Model.IsChanged = true;
                '}
                'else if (e.PropertyName == "SomeBoolean")
                '{
                '    //SettingsController<Settings>.Settings.
                '    ModelController<Model>.Model.IsChanged = true;
                '}
                'else if (e.PropertyName == "SomeString")
                '{
                '    //SettingsController<Settings>.Settings.
                '    ModelController<Model>.Model.IsChanged = true;
                '}
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
                ViewModel.DirtyIconIsVisible = (SettingsController(Of Settings).Settings.Dirty)
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
        Set(value As [String])
            _ViewName = value
            OnPropertyChanged("ViewName")
        End Set
    End Property
#End Region

#Region "Events"
#Region "Form Events"
    ''' <summary>
    ''' Process Form key presses.
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As [Boolean]
        Dim returnValue As [Boolean] = Nothing
        Try
            ' Implement the Escape / Cancel keystroke
            If keyData = Keys.Cancel OrElse keyData = Keys.Escape Then
                'if a long-running cancellable-action has registered 
                'an escapable-event, trigger it
                InvokeActionCancel()

                ' This keystroke was handled, 
                'don't pass to the control with the focus
                returnValue = True
            Else
                returnValue = MyBase.ProcessCmdKey(msg, keyData)

            End If
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
        Return returnValue
    End Function

    Private Sub View_Load(sender As [Object], e As EventArgs) Handles MyBase.Load
        Try
            ViewModel.StatusMessage = [String].Format("{0} starting...", ViewName)

            ViewModel.StatusMessage = [String].Format("{0} started.", ViewName)

            _Run()
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message
            ViewModel.StatusMessage = [String].Empty

            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    Private Sub View_FormClosing(sender As [Object], e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ViewModel.StatusMessage = [String].Format("{0} completing...", ViewName)

            DisposeSettings()

            ViewModel.StatusMessage = [String].Format("{0} completed.", ViewName)
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message.ToString()
            ViewModel.StatusMessage = ""

            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        Finally
            ViewModel = Nothing
        End Try
    End Sub
#End Region

#Region "Menu Events"
    Private Sub menuFileNew_Click(sender As [Object], e As EventArgs) Handles menuFileNew.Click, buttonFileNew.Click
        ViewModel.FileNew()
    End Sub

    Private Sub menuFileOpen_Click(sender As [Object], e As EventArgs) Handles menuFileOpen.Click, buttonFileOpen.Click
        ViewModel.FileOpen()
    End Sub

    Private Sub menuFileSave_Click(sender As [Object], e As EventArgs) Handles menuFileSave.Click, buttonFileSave.Click
        ViewModel.FileSave()
    End Sub

    Private Sub menuFileSaveAs_Click(sender As [Object], e As EventArgs) Handles menuFileSaveAs.Click
        ViewModel.FileSaveAs()
    End Sub

    Private Sub menuFileExit_Click(sender As [Object], e As EventArgs) Handles menuFileExit.Click
        ViewModel.FileExit()
    End Sub

    Private Sub menuEditProperties_Click(sender As [Object], e As EventArgs) Handles menuEditProperties.Click, buttonEditProperties.Click
        ViewModel.EditProperties()
    End Sub

    Private Sub menuEditCopyToClipboard_Click(sender As [Object], e As EventArgs) Handles menuEditCopyToClipboard.Click, buttonEditCopyToClipboard.Click
        ViewModel.EditCopy()
    End Sub

    Private Sub menuHelpAbout_Click(sender As [Object], e As EventArgs) Handles menuHelpAbout.Click
        ViewModel.HelpAbout(Of AssemblyInfo)()
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        ViewModel.DoSomething()
        'ViewModel.CustomMessage = "blah";//done in DoSomething

    End Sub

#End Region
#End Region

#Region "Methods"
#Region "FormAppBase"
    Protected Sub InitViewModel()
        Try
            'subscribe view to model notifications
            AddHandler ModelController(Of MVCModel).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
            ''subscribe view to settings notifications
            'SettingsController(Of Settings).DefaultHandler = AddressOf SettingsPropertyChangedEventHandlerDelegate

            Dim settingsFileDialogInfo As New FileDialogInfo(SettingsController(Of Settings).FILE_NEW, Nothing, Nothing, SettingsController(Of Settings).Settings.FileTypeExtension, SettingsController(Of Settings).Settings.FileTypeDescription, SettingsController(Of Settings).Settings.FileTypeName, _
                New [String]() {"XML files (*.xml)|*.xml", "All files (*.*)|*.*"}, False, Nothing, Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator())

            'set dialog caption
            settingsFileDialogInfo.Title = Me.Text

            'class to handle standard behaviors
            ViewModelController(Of Bitmap, MVCViewModel).[New] _
            ( _
                ViewName, New MVCViewModel(AddressOf Me.ModelPropertyChangedEventHandlerDelegate, New Dictionary(Of [String], Bitmap)() From _
                { _
                    {"New", Resources._New}, _
                    {"Save", Resources.Save}, _
                    {"Open", Resources.Open}, _
                    {"Print", Resources.Print}, _
                    {"Copy", Resources.Copy}, _
                    {"Properties", Resources.Properties} _
                }, _
                settingsFileDialogInfo, _
                Me
                ) _
            )
            ViewModel = ViewModelController(Of Bitmap, MVCViewModel).ViewModel(ViewName)

            BindFormUi()

            'Init config parameters
            If Not LoadParameters() Then
                Throw New Exception([String].Format("Unable to load config file parameter(s)."))
            End If

            'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
            'Load
            If (SettingsController(Of Settings).FilePath Is Nothing) OrElse (SettingsController(Of Settings).Filename = SettingsController(Of Settings).FILE_NEW) Then
                'NEW
                ViewModel.FileNew()
            Else
                'OPEN
                ViewModel.FileOpen(False)
            End If

#If DEBUG Then
            'debug view
            'menuEditProperties_Click(sender, e)
#End If

            'Display dirty state
            ModelController(Of MVCModel).Model.Refresh()
        Catch ex As Exception
            If ViewModel IsNot Nothing Then
                ViewModel.ErrorMessage = ex.Message
            End If
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    Protected Sub DisposeSettings()
        'save user and application settings 
        My.MySettings.Default.Save()

        If SettingsController(Of Settings).Settings.Dirty Then
            'prompt before saving
            Dim dialogResult__1 As DialogResult = MessageBox.Show("Save changes?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Select Case dialogResult__1
                Case DialogResult.Yes
                    If True Then
                        'SAVE
                        ViewModel.FileSave()

                        Exit Select
                    End If
                Case DialogResult.No
                    If True Then
                        Exit Select
                    End If
                Case Else
                    If True Then
                        Throw New InvalidEnumArgumentException()
                    End If
            End Select
        End If

        'unsubscribe from model notifications
        RemoveHandler ModelController(Of MVCModel).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
    End Sub

    Protected Sub _Run()
        'MessageBox.Show("running", "MVC", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    End Sub
#End Region

#Region "Utility"
    ''' <summary>
    ''' Bind static Model controls to Model Controller
    ''' </summary>
    Private Sub BindFormUi()
        Try
            'Form

            'Controls

        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Bind Model controls to Model Controller
    ''' </summary>
    Private Sub BindModelUi()
        Try
            BindField(Of TextBox, MVCModel)(txtSomeInt, ModelController(Of MVCModel).Model, "SomeInt")
            BindField(Of TextBox, MVCModel)(txtSomeString, ModelController(Of MVCModel).Model, "SomeString")
            BindField(Of CheckBox, MVCModel)(chkSomeBoolean, ModelController(Of MVCModel).Model, "SomeBoolean", "Checked")

            BindField(Of TextBox, MVCModel)(txtSomeOtherInt, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherInt")
            BindField(Of TextBox, MVCModel)(txtSomeOtherString, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherString")
            BindField(Of CheckBox, MVCModel)(chkSomeOtherBoolean, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherBoolean", "Checked")
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            Throw
        End Try
    End Sub

    Private Sub BindField(Of TControl As Control, TModel)(fieldControl As TControl, model As TModel, modelPropertyName As [String], Optional controlPropertyName As [String] = "Text", Optional formattingEnabled As [Boolean] = False, Optional dataSourceUpdateMode__1 As DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged, _
        Optional reBind As [Boolean] = True)
        Try
            fieldControl.DataBindings.Clear()
            If reBind Then
                fieldControl.DataBindings.Add(controlPropertyName, model, modelPropertyName, formattingEnabled, dataSourceUpdateMode__1)
            End If
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    ''' <summary>
    ''' Apply Settings to viewer.
    ''' </summary>
    Private Sub ApplySettings()
        Try
            _ValueChangedProgrammatically = True

            'apply settings that have databindings
            BindModelUi()

            'apply settings that shouldn't use databindings

            'apply settings that can't use databindings
            Text = Path.GetFileName(SettingsController(Of Settings).Filename) & " - " & ViewName

            'apply settings that don't have databindings
            ViewModel.DirtyIconIsVisible = (SettingsController(Of Settings).Settings.Dirty)

            _ValueChangedProgrammatically = False
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Set function button and menu to enable value, and cancel button to opposite.
    ''' For now, do only disabling here and leave enabling based on biz logic 
    '''  to be triggered by refresh?
    ''' </summary>
    ''' <param name="functionButton"></param>
    ''' <param name="functionMenu"></param>
    ''' <param name="cancelButton"></param>
    ''' <param name="enable"></param>
    Private Sub SetFunctionControlsEnable(functionButton As Button, functionToolbarButton As ToolStripButton, functionMenu As ToolStripMenuItem, cancelButton As Button, enable As [Boolean])
        Try
            'stand-alone button
            If functionButton IsNot Nothing Then
                functionButton.Enabled = enable
            End If

            'toolbar button
            If functionToolbarButton IsNot Nothing Then
                functionToolbarButton.Enabled = enable
            End If

            'menu item
            If functionMenu IsNot Nothing Then
                functionMenu.Enabled = enable
            End If

            'stand-alone cancel button
            If cancelButton IsNot Nothing Then
                cancelButton.Enabled = Not enable
            End If
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    ''' <summary>
    ''' Invoke any delegate that has been registered 
    '''  to cancel a long-running background process.
    ''' </summary>
    Private Sub InvokeActionCancel()
        Try
            'execute cancellation hook
            If (Not cancelDelegate Is Nothing) Then
                cancelDelegate()
            End If
            'RaiseEvent cancelDelegate()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
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
            If (Program.Filename IsNot Nothing) AndAlso (Program.Filename <> SettingsController(Of Settings).FILE_NEW) Then
                'got filename from command line
                'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
                If Not RegistryAccess.ValidateFileAssociation(Application.ExecutablePath, "." & SettingsController(Of Settings).Settings.FileTypeExtension) Then
                    Throw New ApplicationException([String].Format("Settings filename not associated: '{0}'." & vbLf & "Check filename on command line.", Program.Filename))
                    'it passed; use value from command line
                End If
            Else
#If USE_CONFIG_FILEPATH Then
					'get filename from app.config
					If Not Configuration.ReadString("SettingsFilename", _settingsFilename) Then
						Throw New ApplicationException([String].Format("Unable to load SettingsFilename: {0}", "SettingsFilename"))
					End If
					If (_settingsFilename Is Nothing) OrElse (_settingsFilename = SettingsController(Of Settings).FILE_NEW) Then
						Throw New ApplicationException([String].Format("Settings filename not set: '{0}'." & vbLf & "Check SettingsFilename in app config file.", _settingsFilename))
					End If
					'use with the supplied path
					SettingsController(Of Settings).Filename = _settingsFilename

					If Path.GetDirectoryName(_settingsFilename) = [String].Empty Then
						'supply default path if missing
						SettingsController(Of Settings).Pathname = Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator()
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

    Private Sub BindSizeAndLocation()
        'Note:Size must be done after InitializeComponent(); do Location this way as well.--SJS
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", My.MySettings.Default, "Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", My.MySettings.Default, "Size", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClientSize = My.MySettings.Default.Size
        Me.Location = My.MySettings.Default.Location
    End Sub
#End Region
#End Region

End Class
'End Namespace
