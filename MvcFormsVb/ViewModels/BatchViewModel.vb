Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Ssepan.Utility
Imports Ssepan.Application
Imports Ssepan.Application.WinConsole
Imports Ssepan.Application.WinForms
Imports Ssepan.Io
'Imports BatchProcessDialogConsoleLibrary

'Namespace BatchProcessDialogConsole
''' <summary>
''' Note: this class can subclass the base without type parameters.
''' </summary>
Public Class BatchViewModel
    Inherits FormsViewModel(Of Bitmap, Settings, Model, Batch)
#Region "Declarations"

#Region "Commands"
    'public ICommand FileNewCommand { get; private set; }
    'public ICommand FileOpenCommand { get; private set; }
    'public ICommand FileSaveCommand { get; private set; }
    'public ICommand FileSaveAsCommand { get; private set; }
    'public ICommand FilePrintCommand { get; private set; }
    'public ICommand FileExitCommand { get; private set; }
    'public ICommand EditCopyToClipboardCommand { get; private set; }
    'public ICommand EditPropertiesCommand { get; private set; }
    'public ICommand ViewPreviousMonthCommand { get; private set; }
    'public ICommand ViewPreviousWeekCommand { get; private set; }
    'public ICommand ViewNextWeekCommand { get; private set; }
    'public ICommand ViewNextMonthCommand { get; private set; }
    'public ICommand HelpAboutCommand { get; private set; }
#End Region
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub
    'Note: not called, but need to be present to compile--SJS
    Public Sub New _
    (
        propertyChangedEventHandlerDelegate As PropertyChangedEventHandler,
        actionIconImages As Dictionary(Of String, Bitmap),
        view_ As Batch
    )
        MyBase.New(propertyChangedEventHandlerDelegate, actionIconImages, Nothing, view_)
        Try
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub
#End Region

#Region "Properties"
    Public _ParentViewModel As MVCViewModel = Nothing
    Public Property ParentViewModel As MVCViewModel
        Get
            Return _ParentViewModel
        End Get
        Set(value As MVCViewModel)
            _ParentViewModel = value
        End Set
    End Property


    Public ReadOnly Property DefaultRemark As String
        Get
            Dim returnValue As String
             _
            If Not String.IsNullOrEmpty(ModelController(Of Model).Model.Remark) Then
                returnValue = ModelController(Of Model).Model.Remark
            Else
                returnValue = ModelController(Of Model).Model.FirstBatchItem.NewRemark
            End If
            Return returnValue
        End Get
    End Property
#End Region

#Region "Methods"
    Public Sub Process_click _
    (
    )
        Try
            ParentViewModel.StartProgressBar("Processing...", Nothing, Nothing, False, 0, Sub() Application.DoEvents())
            'StartProgressBar("Processing...", Nothing, Nothing, False, 0)

            'ButtonsEnabled(False)

            'Declare Tuple object to pass multiple params to DoWork method.
            'var arguments xxx
            '    Tuple.Create<SomeType /*xxx*/, SomeType /*yyy*/>
            '    (
            '        Xxx,
            '        Yyy
            '    );

            'set cancellation hook
            View.cancelDelegate = AddressOf View.processBackgroundWorker.CancelAsync

            'arguments
            View.processBackgroundWorker.RunWorkerAsync()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

            'clear cancellation hook
            View.cancelDelegate = Nothing

            'ParentViewModel.StopProgressBar(Nothing, ex.Message)
            'StopProgressBar(Nothing, ex.Message)
        End Try

    End Sub
#End Region

End Class
'End Namespace
