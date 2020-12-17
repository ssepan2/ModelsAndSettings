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
Imports MvcLibraryVb

Namespace MvcConsoleVb
    ''' <summary>
    ''' Note: this class can subclass the base without type parameters.
    ''' </summary>
    Public Class MVCConsoleViewModel
        Inherits ConsoleViewModel(Of [String], MVCSettings, MVCModel)
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
        Public Sub New(propertyChangedEventHandlerDelegate As PropertyChangedEventHandler, actionIconImages As Dictionary(Of [String], [String]))
            MyBase.New(propertyChangedEventHandlerDelegate, actionIconImages)
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
        ''' model specific, not generioc
        ''' </summary>
        Friend Sub DoSomething()
            StatusMessage = [String].Empty
            ErrorMessage = [String].Empty

            Try
                '_actionIconImages["Xxx"],
                StartProgressBar("Doing something...", Nothing, Nothing, True, 33)

                ModelController(Of MVCModel).Model.SomeBoolean = Not ModelController(Of MVCModel).Model.SomeBoolean
                ModelController(Of MVCModel).Model.SomeInt += 1
                ModelController(Of MVCModel).Model.SomeString = DateTime.Now.ToString()

                ModelController(Of MVCModel).Model.SelectedComponent.SomeOtherBoolean = Not ModelController(Of MVCModel).Model.SelectedComponent.SomeOtherBoolean
                ModelController(Of MVCModel).Model.SelectedComponent.SomeOtherInt += 1
                ModelController(Of MVCModel).Model.SelectedComponent.SomeOtherString = DateTime.Now.ToString()

                'SettingsController<MVCSettings>.Settings.SomeBoolean = true;
                'SettingsController<MVCSettings>.Settings.SomeInt += 1;
                'SettingsController<MVCSettings>.Settings.SomeString = "test";

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
End Namespace
