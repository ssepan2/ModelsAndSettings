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
Imports Ssepan.Application.MVC
Imports Ssepan.Application.WinForms
Imports Ssepan.Io
Imports MvcLibraryVb

'Namespace MvcFormsVb
''' <summary>
''' Note: this class can subclass the base without type parameters.
''' </summary>
Public Class MVCViewModel
    Inherits FormsViewModel(Of Bitmap, MVCSettings, MVCModel, MVCView)
#Region "Declarations"
#End Region

#Region "Constructors"
    'Note: not called, but need to be present to compile--SJS
    Public Sub New()
    End Sub

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
            StartProgressBar("Doing something...", Nothing, Nothing, True, 33)

            ModelController(Of MVCModel).Model.SomeBoolean = Not ModelController(Of MVCModel).Model.SomeBoolean
            ModelController(Of MVCModel).Model.SomeInt += 1
            ModelController(Of MVCModel).Model.SomeString = DateTime.Now.ToString()

            ModelController(Of MVCModel).Model.SomeComponent.SomeOtherBoolean = Not ModelController(Of MVCModel).Model.SomeComponent.SomeOtherBoolean
            ModelController(Of MVCModel).Model.SomeComponent.SomeOtherInt += 1
            ModelController(Of MVCModel).Model.SomeComponent.SomeOtherString = DateTime.Now.ToString()

            ModelController(Of MVCModel).Model.StillAnotherComponent.StillAnotherBoolean = Not ModelController(Of MVCModel).Model.StillAnotherComponent.StillAnotherBoolean
            ModelController(Of MVCModel).Model.StillAnotherComponent.StillAnotherInt += 1
            ModelController(Of MVCModel).Model.StillAnotherComponent.StillAnotherString = DateTime.Now.ToString()

            UpdateStatusBarMessages(Nothing, Nothing, DateTime.Now.ToLongTimeString())

            ModelController(Of MVCModel).Model.Refresh()
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])

            StopProgressBar(Nothing, [String].Format("{0}", ex.Message))
        Finally
            StopProgressBar("Did something.")
        End Try
    End Sub
#End Region

End Class
'End Namespace
