'#Const USE_CONFIG_FILEPATH = True
'#Const USE_CUSTOM_VIEWMODEL = True
'#Const DEBUG_MODEL_PROPERTYCHANGED = True
'#Const DEBUG_SETTINGS_PROPERTYCHANGED = True

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports Ssepan.Application
Imports Ssepan.Application.MVC
Imports Ssepan.Io
Imports Ssepan.Utility
Imports MvcLibraryVb
Imports MvcLibraryVb.Properties

''' <summary>
''' This is the View.
''' </summary>
Partial Public Class MVCView
    Inherits Form
    Implements INotifyPropertyChanged
#Region "Declarations"
    Protected disposed As Boolean
    Private _ValueChangedProgrammatically As Boolean

    'cancellation hook
    Private cancelDelegate As Action = Nothing
    Protected ViewModel As MVCViewModel = Nothing
#End Region

#Region "Constructors"
    Public Sub New()
        Try
            Me.InitializeComponent()

            '''(re)define default output delegate
            'ConsoleApplication.defaultOutputDelegate = ConsoleApplication.messageBoxWrapperOutputDelegate;

            'subscribe to view's notifications
            AddHandler PropertyChanged, AddressOf PropertyChangedEventHandlerDelegate
            InitViewModel()
            BindSizeAndLocation()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub
#End Region

#Region "IDisposable"
    '~MVCView()
    '{
    '    Dispose(false);
    '}

    'public virtual void Dispose()
    '{
    '    // dispose of the managed and unmanaged resources
    '    Dispose(true);

    '    // tell the GC that the Finalize process no longer needs
    '    // to be run for this object.
    '    GC.SuppressFinalize(this);
    '}

    'protected virtual void Dispose(bool disposeManagedResources)
    '{
    '    // process only if mananged and unmanaged resources have
    '    // not been disposed of.
    '    if (!this.disposed)
    '    {
    '        //Resources not disposed
    '        if (disposeManagedResources)
    '        {
    '            // dispose managed resources
    '            //unsubscribe from model notifications
    '            if (this.PropertyChanged != null)
    '            {
    '                this.PropertyChanged -= PropertyChangedEventHandlerDelegate;
    '            }
    '        }
    '        // dispose unmanaged resources
    '        disposed = true;
    '    }
    '    else
    '    {
    '        //Resources already disposed
    '    }
    '}
#End Region

#Region "INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        Try
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
            Throw
        End Try
    End Sub
#End Region

#Region "PropertyChangedEventHandlerDelegates"
    ''' <summary>
    ''' Note: model property changes update UI manually.
    ''' Note: handle settings property changes manually.
    ''' Note: because settings properties are a subset of the model 
    '''  (every settings property should be in the model, 
    '''  but not every model property is persisted to settings)
    '''  it is decided that for now the settigns handler will 
    '''  invoke the model handler as well.
    ''' </summary>
    ''' <paramname="sender"></param>
    ''' <paramname="e"></param>
    Protected Sub PropertyChangedEventHandlerDelegate(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        Try
            'Region "Model"
            If Equals(e.PropertyName, "IsChanged") Then
                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", e.PropertyName));
                ApplySettings()
                'Status Bar
            ElseIf Equals(e.PropertyName, "ActionIconIsVisible") Then
                Me.StatusBarActionIcon.Visible = ViewModel.ActionIconIsVisible
            ElseIf Equals(e.PropertyName, "ActionIconImage") Then
                Me.StatusBarActionIcon.Image = If(ViewModel IsNot Nothing, ViewModel.ActionIconImage, Nothing)
            ElseIf Equals(e.PropertyName, "StatusMessage") Then
                'replace default action by setting control property
                'skip status message updates after Viewmodel is null
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", StatusMessage));
                Me.StatusBarStatusMessage.Text = If(ViewModel IsNot Nothing, ViewModel.StatusMessage, Nothing)
            ElseIf Equals(e.PropertyName, "ErrorMessage") Then
                'replace default action by setting control property
                'skip status message updates after Viewmodel is null
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage));
                Me.StatusBarErrorMessage.Text = If(ViewModel IsNot Nothing, ViewModel.ErrorMessage, Nothing)
            ElseIf Equals(e.PropertyName, "CustomMessage") Then
                'replace default action by setting control property
                'e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                'ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage));
                Me.StatusBarCustomMessage.Text = ViewModel.CustomMessage
            ElseIf Equals(e.PropertyName, "ErrorMessageToolTipText") Then
                Me.StatusBarErrorMessage.ToolTipText = ViewModel.ErrorMessageToolTipText
            ElseIf Equals(e.PropertyName, "ProgressBarValue") Then
                Me.StatusBarProgressBar.Value = ViewModel.ProgressBarValue
            ElseIf Equals(e.PropertyName, "ProgressBarMaximum") Then
                Me.StatusBarProgressBar.Maximum = ViewModel.ProgressBarMaximum
            ElseIf Equals(e.PropertyName, "ProgressBarMinimum") Then
                Me.StatusBarProgressBar.Minimum = ViewModel.ProgressBarMinimum
            ElseIf Equals(e.PropertyName, "ProgressBarStep") Then
                Me.StatusBarProgressBar.Step = ViewModel.ProgressBarStep
            ElseIf Equals(e.PropertyName, "ProgressBarIsMarquee") Then
                Me.StatusBarProgressBar.Style = If(ViewModel.ProgressBarIsMarquee, ProgressBarStyle.Marquee, ProgressBarStyle.Blocks)
            ElseIf Equals(e.PropertyName, "ProgressBarIsVisible") Then
                Me.StatusBarProgressBar.Visible = ViewModel.ProgressBarIsVisible
            ElseIf Equals(e.PropertyName, "DirtyIconIsVisible") Then
                Me.StatusBarDirtyMessage.Visible = ViewModel.DirtyIconIsVisible
            ElseIf Equals(e.PropertyName, "DirtyIconImage") Then
                'use if properties cannot be databound
                'else if (e.PropertyName == "SomeInt")
                '{
                '    //SettingsController<MVCSettings>.Settings.
                '    ModelController<MVCModel>.Model.IsChanged = true;
                '}
                'else if (e.PropertyName == "SomeBoolean")
                '{
                '    //SettingsController<MVCSettings>.Settings.
                '    ModelController<MVCModel>.Model.IsChanged = true;
                '}
                'else if (e.PropertyName == "SomeString")
                '{
                '    //SettingsController<MVCSettings>.Settings.
                '    ModelController<MVCModel>.Model.IsChanged = true;
                '}
                'else if (e.PropertyName == "SomeOtherBoolean")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherBoolean: {0}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean));
                '}
                'else if (e.PropertyName == "SomeOtherString")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherString: {0}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherString));
                '}
                'else if (e.PropertyName == "SomeComponent")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("SomeComponent: {0},{1},{2}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherInt, ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean, ModelController<MVCModel>.Model.SomeComponent.SomeOtherString));
                '}
                'else if (e.PropertyName == "StillAnotherInt")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherInt: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherInt));
                '}
                'else if (e.PropertyName == "StillAnotherBoolean")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherBoolean: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherBoolean));
                '}
                'else if (e.PropertyName == "StillAnotherString")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherString: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherString));
                '}
                'else if (e.PropertyName == "StillAnotherComponent")
                '{
                '    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherComponent: {0},{1},{2}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherInt, ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherBoolean, ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherString));
                '}
                Me.StatusBarDirtyMessage.Image = ViewModel.DirtyIconImage
            Else
#If DEBUG_MODEL_PROPERTYCHANGED Then
                        ConsoleApplication.defaultOutputDelegate(String.Format("e.PropertyName: {0}", e.PropertyName));
#End If
            End If
            'End Region

            'Region "Settings"
            If Equals(e.PropertyName, "Dirty") Then
                'apply settings that don't have databindings
                ViewModel.DirtyIconIsVisible = SettingsController(Of MVCSettings).Settings.Dirty
            Else
#If DEBUG_SETTINGS_PROPERTYCHANGED Then
                    ConsoleApplication.defaultOutputDelegate(String.Format("e.PropertyName: {0}", e.PropertyName));
#End If
                'End Region
            End If

        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub

#End Region

#Region "Properties"
    Private _ViewName As String = Program.APP_NAME

    Public Property ViewName As String
        Get
            Return _ViewName
        End Get
        Set(ByVal value As String)
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
    ''' <paramname="msg"></param>
    ''' <paramname="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim returnValue As Boolean = Nothing

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
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try

        Return returnValue
    End Function

    Private Sub View_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ViewModel.StatusMessage = String.Format("{0} starting...", ViewName)
            ViewModel.StatusMessage = String.Format("{0} started.", ViewName)
            _Run()
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message
            ViewModel.StatusMessage = String.Empty
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub

    Private Sub View_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ViewModel.StatusMessage = String.Format("{0} completing...", ViewName)
            DisposeSettings()
            ViewModel.StatusMessage = String.Format("{0} completed.", ViewName)
        Catch ex As Exception
            ViewModel.ErrorMessage = ex.Message.ToString()
            ViewModel.StatusMessage = ""
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        Finally
            ViewModel = Nothing
        End Try
    End Sub
#End Region

#Region "Menu Events"
    Private Sub menuFileNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuFileNew.Click, buttonFileNew.Click
        ViewModel.FileNew()
    End Sub

    Private Sub menuFileOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuFileOpen.Click, buttonFileOpen.Click
        ViewModel.FileOpen()
    End Sub

    Private Sub menuFileSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuFileSave.Click, buttonFileSave.Click
        ViewModel.FileSave()
    End Sub

    Private Sub menuFileSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuFileSaveAs.Click
        ViewModel.FileSaveAs()
    End Sub

    Private Sub menuFilePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFilePrint.Click, buttonFilePrint.Click
        ViewModel.FilePrint()
    End Sub

    Private Sub menuFileExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuFileExit.Click
        ViewModel.FileExit()
    End Sub

    Private Sub menuEditUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditUndo.Click, buttonEditUndo.Click
        ViewModel.EditUndo()
    End Sub

    Private Sub menuEditRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditRedo.Click, buttonEditRedo.Click
        ViewModel.EditRedo()
    End Sub

    Private Sub menuEditSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditSelectAll.Click
        ViewModel.EditSelectAll()
    End Sub

    Private Sub menuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditCut.Click, buttonEditCut.Click
        ViewModel.EditCut()
    End Sub

    Private Sub menuEditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditCopy.Click, buttonEditCopy.Click
        ViewModel.EditCopy()
    End Sub

    Private Sub menuEditPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditPaste.Click, buttonEditPaste.Click
        ViewModel.EditPaste()
    End Sub

    Private Sub menuEditDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditDelete.Click, buttonEditDelete.Click
        ViewModel.EditDelete()
    End Sub

    Private Sub menuEditFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditFind.Click, buttonEditFind.Click
        ViewModel.EditFind()
    End Sub

    Private Sub menuEditReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditReplace.Click, buttonEditReplace.Click
        ViewModel.EditReplace()
    End Sub

    Private Sub menuEditRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditRefresh.Click, buttonEditRefresh.Click
        ViewModel.EditRefresh()
    End Sub

    Private Sub menuEditPreferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditPreferences.Click, buttonEditPreferences.Click
        ViewModel.EditPreferences()
    End Sub

    Private Sub menuEditProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuEditProperties.Click, buttonEditProperties.Click
        ViewModel.EditProperties()
    End Sub

    Private Sub menuHelpContents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpContents.Click, buttonHelpContents.Click
        ViewModel.HelpContents()
    End Sub

    Private Sub menuHelpIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpIndex.Click
        ViewModel.HelpIndex()
    End Sub

    Private Sub menuHelpOnlineHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpOnlineHelp.Click
        ViewModel.HelpOnHelp()
    End Sub

    Private Sub menuHelpLicenceInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpLicenceInformation.Click
        ViewModel.HelpLicenceInformation()
    End Sub

    Private Sub menuHelpCheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpCheckForUpdates.Click
        ViewModel.HelpCheckForUpdates()
    End Sub

    Private Sub menuHelpAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuHelpAbout.Click
        ViewModel.HelpAbout(Of AssemblyInfo)()
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdRun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdRun.Click
        ViewModel.DoSomething()
        'ViewModel.CustomMessage = "blah";//done in DoSomething
    End Sub
#End Region
#End Region

#Region "Methods"
#Region "FormAppBase"
    Protected Sub InitViewModel()
        Try
            'tell controller how model should notify view about non-persisted properties AND including model properties that may be part of settings
            ModelController(Of MVCModel).DefaultHandler = AddressOf PropertyChangedEventHandlerDelegate

            'tell controller how settings should notify view about persisted properties
            SettingsController(Of MVCSettings).DefaultHandler = AddressOf PropertyChangedEventHandlerDelegate
            InitModelAndSettings()
            Dim settingsFileDialogInfo As FileDialogInfo = New FileDialogInfo(SettingsController(Of MVCSettings).FILE_NEW, Nothing, Nothing, SettingsBase.FileTypeExtension, SettingsBase.FileTypeDescription, SettingsBase.FileTypeName, New String() {"XML files (*.xml)|*.xml", "All files (*.*)|*.*"}, False, Nothing, Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator())

            'set dialog caption
            settingsFileDialogInfo.Title = Text

            'class to handle standard behaviors
            ViewModelController(Of Bitmap, MVCViewModel).[New](ViewName, New MVCViewModel(AddressOf Me.PropertyChangedEventHandlerDelegate, New Dictionary(Of String, Bitmap)() From {
                  {"New", My.Resources._New},
                  {"Open", My.Resources.Open},
                  {"Save", My.Resources.Save},
                  {"Print", My.Resources.Print},
                  {"Undo", My.Resources.Undo},
                  {"Redo", My.Resources.Redo},
                  {"Cut", My.Resources.Cut},
                  {"Copy", My.Resources.Copy},
                  {"Paste", My.Resources.Paste},
                  {"Delete", My.Resources.Delete},
                  {"Find", My.Resources.Find},
                  {"Replace", My.Resources.Replace},
                  {"Refresh", My.Resources.Reload},
                  {"Preferences", My.Resources.Preferences},
                  {"Properties", My.Resources.Properties},
                  {"Contents", My.Resources.Contents},
                  {"About", My.Resources.About}
                }, settingsFileDialogInfo))

            'select a viewmodel by view name
            ViewModel = ViewModelController(Of Bitmap, MVCViewModel).ViewModel(ViewName)

            BindFormUi()

            'Init config parameters
            If Not LoadParameters() Then
                Throw New Exception(String.Format("Unable to load config file parameter(s)."))
            End If

            'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
            'Load
            If Equals(SettingsController(Of MVCSettings).FilePath, Nothing) OrElse Equals(SettingsController(Of MVCSettings).Filename, SettingsController(Of MVCSettings).FILE_NEW) Then
                'NEW
                ViewModel.FileNew()
            Else
                'OPEN
                ViewModel.FileOpen(False)
            End If

#If DEBUG Then
            'debug view
            ' menuEditProperties_Click(sender, e)
#End If

            'Display dirty state
            ModelController(Of MVCModel).Model.Refresh()
        Catch ex As Exception

            If ViewModel IsNot Nothing Then
                ViewModel.ErrorMessage = ex.Message
            End If

            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub

    Protected Sub InitModelAndSettings()
        'create Settings before first use by Model
        If SettingsController(Of MVCSettings).Settings Is Nothing Then
            SettingsController(Of MVCSettings).[New]()
        End If
        'Model properties rely on Settings, so don't call Refresh before this is run.
        If ModelController(Of MVCModel).Model Is Nothing Then
            ModelController(Of MVCModel).[New]()
        End If
    End Sub

    Protected Sub DisposeSettings()
        'save user and application settings 
        My.MySettings.Default.Save() 'Properties.Settings.Default.Save()

        If SettingsController(Of MVCSettings).Settings.Dirty Then
            'prompt before saving
            Dim dialogResult = MessageBox.Show("Save changes?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialogResult
                Case dialogResult.Yes
                    'SAVE
                    ViewModel.FileSave()
                    Exit Select
                Case dialogResult.No
                    Exit Select
                Case Else
                    Throw New InvalidEnumArgumentException()
            End Select
        End If

        'unsubscribe from model notifications
        RemoveHandler ModelController(Of MVCModel).Model.PropertyChanged, AddressOf PropertyChangedEventHandlerDelegate
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
        'Form

        'Controls
        Try
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Bind Model controls to Model Controller
    ''' </summary>
    Private Sub BindModelUi()
        Try
            BindField(Of TextBox, MVCModel)(Me.txtSomeInt, ModelController(Of MVCModel).Model, "SomeInt")
            BindField(Of TextBox, MVCModel)(Me.txtSomeString, ModelController(Of MVCModel).Model, "SomeString")
            BindField(Of CheckBox, MVCModel)(Me.chkSomeBoolean, ModelController(Of MVCModel).Model, "SomeBoolean", "Checked")
            BindField(Of TextBox, MVCModel)(Me.txtSomeOtherInt, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherInt")
            BindField(Of TextBox, MVCModel)(Me.txtSomeOtherString, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherString")
            BindField(Of CheckBox, MVCModel)(Me.chkSomeOtherBoolean, ModelController(Of MVCModel).Model, "SomeComponent.SomeOtherBoolean", "Checked")
            BindField(Of TextBox, MVCModel)(Me.txtStillAnotherInt, ModelController(Of MVCModel).Model, "StillAnotherComponent.StillAnotherInt")
            BindField(Of TextBox, MVCModel)(Me.txtStillAnotherString, ModelController(Of MVCModel).Model, "StillAnotherComponent.StillAnotherString")
            BindField(Of CheckBox, MVCModel)(Me.chkStillAnotherBoolean, ModelController(Of MVCModel).Model, "StillAnotherComponent.StillAnotherBoolean", "Checked")
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
            Throw
        End Try
    End Sub

    Private Sub BindField(Of TControl As Control, TModel)(ByVal fieldControl As TControl, ByVal model As TModel, ByVal modelPropertyName As String, Optional ByVal controlPropertyName As String = "Text", Optional ByVal formattingEnabled As Boolean = False, Optional ByVal dataSourceUpdateMode As DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged, Optional ByVal reBind As Boolean = True)
        Try
            fieldControl.DataBindings.Clear()

            If reBind Then
                fieldControl.DataBindings.Add(controlPropertyName, model, modelPropertyName, formattingEnabled, dataSourceUpdateMode)
            End If

        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
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
            Text = Path.GetFileName(SettingsController(Of MVCSettings).Filename) & " - " & ViewName

            'apply settings that don't have databindings
            ViewModel.DirtyIconIsVisible = SettingsController(Of MVCSettings).Settings.Dirty
            _ValueChangedProgrammatically = False
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Set function button and menu to enable value, and cancel button to opposite.
    ''' For now, do only disabling here and leave enabling based on biz logic 
    '''  to be triggered by refresh?
    ''' </summary>
    ''' <paramname="functionButton"></param>
    ''' <paramname="functionMenu"></param>
    ''' <paramname="cancelButton"></param>
    ''' <paramname="enable"></param>
    Private Sub SetFunctionControlsEnable(ByVal functionButton As Button, ByVal functionToolbarButton As ToolStripButton, ByVal functionMenu As ToolStripMenuItem, ByVal cancelButton As Button, ByVal enable As Boolean)
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
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Invoke any delegate that has been registered 
    '''  to cancel a long-running background process.
    ''' </summary>
    Private Sub InvokeActionCancel()
        Try
            'execute cancellation hook
            If cancelDelegate IsNot Nothing Then
                cancelDelegate()
            End If

        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Load from app config; override with command line if present
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadParameters() As Boolean
        Dim returnValue As Boolean = Nothing
#If USE_CONFIG_FILEPATH Then
            String _settingsFilename = default(String);
#End If

        Try

            If Not Equals(Program.Filename, Nothing) AndAlso Not Equals(Program.Filename, SettingsController(Of MVCSettings).FILE_NEW) Then
                'got filename from command line
                'DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
                If Not RegistryAccess.ValidateFileAssociation(Application.ExecutablePath, "." & SettingsBase.FileTypeExtension) Then
                    Throw New ApplicationException(String.Format("Settings filename not associated: '{0}'." & Microsoft.VisualBasic.Constants.vbLf & "Check filename on command line.", Program.Filename))
                    'it passed; use value from command line
                End If
            Else
#If USE_CONFIG_FILEPATH Then
                    //get filename from app.config
                    if (!Configuration.ReadString("SettingsFilename", out _settingsFilename))
                    {
                        throw new ApplicationException(String.Format("Unable to load SettingsFilename: {0}", "SettingsFilename"));
                    }
                    if ((_settingsFilename == null) || (_settingsFilename == SettingsController<MVCSettings>.FILE_NEW))
                    {
                        throw new ApplicationException(String.Format("Settings filename not set: '{0}'.\nCheck SettingsFilename in app config file.", _settingsFilename));
                    }
                    //use with the supplied path
                    SettingsController<MVCSettings>.Filename = _settingsFilename;

                    if (Path.GetDirectoryName(_settingsFilename) == String.Empty)
                    {
                        //supply default path if missing
                        SettingsController<MVCSettings>.Pathname = Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator();
                    }
#End If
            End If

            returnValue = True
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error)
            'throw;
        End Try

        Return returnValue
    End Function

    Private Sub BindSizeAndLocation()
        'Note:Size must be done after InitializeComponent(); do Location this way as well.--SJS
        DataBindings.Add(New Binding("Location", My.MySettings.Default, "Location", True, DataSourceUpdateMode.OnPropertyChanged)) 'Global.Properties.Settings.Default
        DataBindings.Add(New Binding("ClientSize", My.MySettings.Default, "Size", True, DataSourceUpdateMode.OnPropertyChanged)) 'Global.Properties.Settings.Default
        ClientSize = My.MySettings.Default.Size 'Global.Properties.Settings.Default.Size
        Location = My.MySettings.Default.Location 'Global.My.Properties.Settings.Default.Location

    End Sub
#End Region
#End Region
End Class
