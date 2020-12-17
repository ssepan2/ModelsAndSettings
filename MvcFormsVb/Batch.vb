Imports System.Reflection
Imports System.Drawing
Imports System.Windows.Forms
'Imports BatchProcessDialogConsoleLibrary
Imports Ssepan.Application
Imports Ssepan.Utility
Imports System.ComponentModel

Public Class Batch
    Inherits Form
    Implements INotifyPropertyChanged
#Region "Declarations"
    'cancellation hook
    Friend cancelDelegate As Action = Nothing
    'Protected disposed As [Boolean]

    Private _ValueChangedProgrammatically As [Boolean]

    Protected ViewModel As BatchViewModel = Nothing
#End Region

#Region "Constructors"
    'Public Sub New() 'required to compile

    'End Sub

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

            'BindSizeAndLocation()
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
            ElseIf e.PropertyName = "Remark" Then
                ApplySettings()
                'Status Bar
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
                'ViewModel.DirtyIconIsVisible = (SettingsController(Of Settings).Settings.Dirty)
            End If
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub
#End Region

#Region "Properties"
    Private _ViewName As [String] = "Batch" 'Program.APP_NAME
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

    Private Sub Batch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ViewModel.ParentViewModel = CType(Me.Owner, MVCView).ViewModel

        BindFormUi()

        BindModelUi()

    End Sub

    Private Sub Batch_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'ViewModel.ParentViewModel = CType(Me.Owner, MVCView).ViewModel

    End Sub
    ''' <summary>
    ''' Bind static Model controls to Model Controller
    ''' </summary>
    Private Sub BindFormUi()
        Try
            'Form

            'Controls
            'temp
            'SomeComponentsBindingSource.DataSource = ModelController(Of Model).Model.SomeComponents
            'get 1st 2 from first item
            BindField(Of Label, ModelComponent)(lblSomeString, ModelController(Of Model).Model.FirstBatchItem, "SomeString")
            'BindField(Of Label, Component)(lblNewRemark, ModelController(Of Model).Model.FirstBatchItem, "NewRemark")
            BindField(Of TextBox, Model)(txtRemark, ModelController(Of Model).Model, "Remark")

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
            BindField(Of Label, BatchViewModel)(lblNewRemark, ViewModel, "DefaultRemark")
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


            _ValueChangedProgrammatically = False
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            Throw
        End Try
    End Sub


#Region "DoSomething in background"
    Private Sub cmdProcess_Click(sender As Object, e As EventArgs) Handles cmdProcess.Click
        ViewModel.Process_click()

        'Me.Close()
    End Sub

    Private Sub backgroundWorkerDoSomething_DoWork(sender As [Object], e As DoWorkEventArgs) Handles processBackgroundWorker.DoWork
        ViewModel.BackgroundWorker_DoWork(Of [Boolean]) _
        (
            TryCast(sender, BackgroundWorker),
            e,
            Function _
            (
                worker As BackgroundWorker,
                ea As DoWorkEventArgs,
                ByRef errorMessage As [String]
            )
                Dim result As [Boolean] = Nothing


                '' Get Tuple object passed from RunWorkerAsync() method
                'Tuple<SomeType> /*Variable*/> arguments =
                '    e.Argument as Tuple<SomeType> /*Variable*/>;

                'run process
                'arguments,
                result =
                    ModelController(Of Model).Model.Process _
                    (
                        worker,
                        e,
                        errorMessage
                    )

                Return result

            End Function,
            "Unable to DoSomething."
        )
    End Sub

    Private Sub backgroundWorkerDoSomething_ProgressChanged(sender As [Object], e As ProgressChangedEventArgs) Handles processBackgroundWorker.ProgressChanged
        Dim message As [String] = [String].Empty

        Try
            If e.UserState IsNot Nothing Then
                message = e.UserState.ToString()
            End If
            'ViewModel.ParentViewModel.StatusMessage = [String].Format("{0} ({1})...{2}%", "Processing", message, e.ProgressPercentage.ToString())
            ViewModel.ParentViewModel.UpdateProgressBar([String].Format("{0} ({1})...{2}%", "Processing", message, e.ProgressPercentage.ToString()), e.ProgressPercentage)
            Application.DoEvents()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
        'ViewModel.BackgroundWorker_ProgressChanged("Doing Something", e.UserState, e.ProgressPercentage)
    End Sub

    Private Sub backgroundWorkerDoSomething_RunWorkerCompleted(sender As [Object], e As RunWorkerCompletedEventArgs) Handles processBackgroundWorker.RunWorkerCompleted
        ViewModel.BackgroundWorker_RunWorkerCompleted _
        (
            "Processed",
            TryCast(sender, BackgroundWorker),
            e,
            Nothing,
            Nothing,
            Sub()
                'If ModelController(Of Model).Model.LineErrors Then
                '    ViewModel.ErrorMessage = ModelController(Of Model).Model.LineErrorMessage
                '    System.Console.Beep()
                'End If

                'restore buttons
                'ViewModel.ButtonsEnabled(True)
                'ViewModel.ParentViewModel.StopProgressBar()
                ViewModel.ParentViewModel.StopProgressBar("Processed", ViewModel.ParentViewModel.ErrorMessage)
                Application.DoEvents()

            End Sub
        )
    End Sub
#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
#Region "FormAppBase"
    Protected Sub InitViewModel()
        Try
            'subscribe view to model notifications
            AddHandler ModelController(Of Model).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
            ''subscribe view to settings notifications
            'SettingsController(Of Settings).DefaultHandler = AddressOf SettingsPropertyChangedEventHandlerDelegate

            'Dim settingsFileDialogInfo As New FileDialogInfo(SettingsController(Of Settings).FILE_NEW, Nothing, Nothing, SettingsController(Of Settings).Settings.FileTypeExtension, SettingsController(Of Settings).Settings.FileTypeDescription, SettingsController(Of Settings).Settings.FileTypeName, _
            '    New [String]() {"XML files (*.xml)|*.xml", "All files (*.*)|*.*"}, False, Nothing, Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator())

            ''set dialog caption
            'settingsFileDialogInfo.Title = Me.Text

            'class to handle standard behaviors
            '{"New", Resources._New}, _
            '{"Save", Resources.Save}, _
            '{"Open", Resources.Open}, _
            '{"Print", Resources.Print}, _
            '{"Copy", Resources.Copy}, _
            '{"Properties", Resources.Properties} _
            ViewModelController(Of Bitmap, BatchViewModel).[New] _
            ( _
                ViewName,
                New BatchViewModel _
                (
                    AddressOf Me.ModelPropertyChangedEventHandlerDelegate,
                    New Dictionary(Of [String], Bitmap)() From _
                    {
                    }, _
                   Me _
                ) _
            )
            ViewModel = ViewModelController(Of Bitmap, BatchViewModel).ViewModel(ViewName)

            BindFormUi()


            'Display dirty state
            ModelController(Of Model).Model.Refresh()
        Catch ex As Exception
            If ViewModel IsNot Nothing Then
                ViewModel.ErrorMessage = ex.Message
            End If
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    Protected Sub DisposeSettings()
        ''save user and application settings 
        'My.MySettings.Default.Save()

        'If SettingsController(Of Settings).Settings.Dirty Then
        '    'prompt before saving
        '    Dim dialogResult__1 As DialogResult = MessageBox.Show("Save changes?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    Select Case dialogResult__1
        '        Case DialogResult.Yes
        '            If True Then
        '                'SAVE
        '                ViewModel.FileSave()

        '                Exit Select
        '            End If
        '        Case DialogResult.No
        '            If True Then
        '                Exit Select
        '            End If
        '        Case Else
        '            If True Then
        '                Throw New InvalidEnumArgumentException()
        '            End If
        '    End Select
        'End If

        'unsubscribe from model notifications
        RemoveHandler ModelController(Of Model).Model.PropertyChanged, AddressOf ModelPropertyChangedEventHandlerDelegate
    End Sub

#End Region
End Class