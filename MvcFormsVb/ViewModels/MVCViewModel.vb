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
Imports Ssepan.Application.WinForms
Imports Ssepan.Io
'Imports MvcLibraryVb

'Namespace MvcFormsVb
''' <summary>
''' Note: this class can subclass the base without type parameters.
''' </summary>
Public Class MVCViewModel
    Inherits FormsViewModel(Of Bitmap, Settings, Model, MVCView)
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
        actionIconImages As Dictionary(Of [String], Bitmap),
        settingsFileDialogInfo As FileDialogInfo
    )
        MyBase.New(propertyChangedEventHandlerDelegate, actionIconImages, settingsFileDialogInfo) '(In VB 2010, )VB caller cannot differentiate between members which differ only by an optional param--SJS
        Try
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub
    'Note: not called, but need to be present to compile--SJS
    Public Sub New _
    (
        propertyChangedEventHandlerDelegate As PropertyChangedEventHandler,
        actionIconImages As Dictionary(Of [String], Bitmap),
        settingsFileDialogInfo As FileDialogInfo,
        view_ As MVCView
    )
        MyBase.New(propertyChangedEventHandlerDelegate, actionIconImages, settingsFileDialogInfo, view_) '(In VB 2010, )VB caller cannot differentiate between members which differ only by an optional param--SJS
        Try
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub
#End Region

#Region "Properties"
#End Region

#Region "Methods"
    ''' <summary>
    ''' model specific, not generic
    ''' </summary>
    Public Sub DoSomething()
        StatusMessage = [String].Empty
        ErrorMessage = [String].Empty

        Try
            '_actionIconImages["Xxx"],
            'StartProgressBar("Processing...", Nothing, Nothing, True, 33)

            StatusMessage = String.Format("Remark: '{0}' Count: '{1}'", ModelController(Of Model).Model.Remark, ModelController(Of Model).Model.SomeComponents.Count.ToString())

            Dim batch As Batch = New Batch(Nothing)
            batch.ShowDialog(View)

            StatusMessage = String.Format("Remark: '{0}' Count: '{1}'", ModelController(Of Model).Model.Remark, ModelController(Of Model).Model.SomeComponents.Count.ToString())

            'UpdateStatusBarMessages(Nothing, Nothing, DateTime.Now.ToLongTimeString())
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

            'StopProgressBar(Nothing, [String].Format("{0}", ex.Message))
        Finally
            'StopProgressBar("Did something.")
        End Try
    End Sub
    ' ''' <summary>
    ' ''' model specific, not generic
    ' ''' </summary>
    'Public Sub DoSomethingElse()
    '    StatusMessage = [String].Empty
    '    ErrorMessage = [String].Empty

    '    Try
    '        '_actionIconImages["Xxx"],
    '        StartProgressBar("Doing something else...", Nothing, Nothing, True, 33)

    '        'ModelController(Of Model).Model.DoSomethingElse()

    '        UpdateStatusBarMessages(Nothing, Nothing, DateTime.Now.ToLongTimeString())
    '    Catch ex As Exception
    '        Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

    '        StopProgressBar(Nothing, [String].Format("{0}", ex.Message))
    '    Finally
    '        StopProgressBar("Did something else.")
    '    End Try
    'End Sub
    ' ''' <summary>
    ' ''' model specific, not generic
    ' ''' </summary>
    'Public Sub DoSomethingOnce()
    '    StatusMessage = [String].Empty
    '    ErrorMessage = [String].Empty

    '    Try
    '        '_actionIconImages["Xxx"],
    '        StartProgressBar("Doing something once...", Nothing, Nothing, True, 33)

    '        'ModelController(Of Model).Model.DoSomethingOnce()

    '        UpdateStatusBarMessages(Nothing, Nothing, DateTime.Now.ToLongTimeString())
    '    Catch ex As Exception
    '        Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

    '        StopProgressBar(Nothing, [String].Format("{0}", ex.Message))
    '    Finally
    '        StopProgressBar("Did something once.")
    '    End Try
    'End Sub
#End Region

End Class
'End Namespace
