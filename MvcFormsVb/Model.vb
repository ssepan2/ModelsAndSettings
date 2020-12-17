Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
'Imports System.Linq.Queryable
Imports System.Reflection
Imports System.Text
'using System.Threading.Tasks;
Imports Ssepan.Application
Imports Ssepan.Utility

'Namespace BatchProcessDialogConsoleLibrary
''' <summary>
''' run-time model; relies on settings
''' </summary>
<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Model
    Inherits ModelBase
#Region "Declarations"
#End Region

#Region "Constructors"
    Public Sub New()
        If SettingsController(Of Settings).Settings Is Nothing Then
            SettingsController(Of Settings).[New]()
        End If
        Debug.Assert(SettingsController(Of Settings).Settings IsNot Nothing, "SettingsController<Settings>.Settings != null")
        SomeComponents = New BindingList(Of ModelComponent)()
    End Sub

    'Public Sub New(someInt__1 As Int32, someBoolean__2 As [Boolean], someString__3 As [String])
    '    Me.New()

    '    SomeInt = someInt__1
    '    SomeBoolean = someBoolean__2
    '    SomeString = someString__3
    'End Sub
#End Region

#Region "IEquatable<IModel>"
    ''' <summary>
    ''' Compare property values of two specified Model objects.
    ''' </summary>
    ''' <param name="other"></param>
    ''' <returns></returns>
    Public Overrides Function Equals(other As IModel) As [Boolean]
        Dim returnValue As [Boolean] = Nothing
        Dim otherModel As Model = Nothing

        Try
            otherModel = TryCast(other, Model)

            If Me Is otherModel Then
                returnValue = True
            Else
                If Not MyBase.Equals(other) Then
                    returnValue = False
                ElseIf Me.Remark <> otherModel.Remark Then
                    returnValue = False
                ElseIf Me.SomeComponents.Equals(otherModel.SomeComponents) Then
                    returnValue = False
                    'ElseIf Me.SomeInt <> otherModel.SomeInt Then
                    '    returnValue = False
                    'ElseIf Me.SomeBoolean <> otherModel.SomeBoolean Then
                    '    returnValue = False
                    'ElseIf Me.SomeString <> otherModel.SomeString Then
                    '    returnValue = False
                Else
                    returnValue = True
                End If
            End If
        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            Throw
        End Try

        Return returnValue
    End Function
#End Region

#Region "Properties"

    Private _Remark As String '= String.Empty
    Public Property Remark As String
        Get
            Return _Remark
        End Get
        Set(ByVal value As String)
            _Remark = value
            OnPropertyChanged("Remark")
        End Set
    End Property

    Private _SomeComponents As BindingList(Of ModelComponent)
    Public Property SomeComponents As BindingList(Of ModelComponent)
        Get
            Return _SomeComponents
        End Get
        Set(ByVal value As BindingList(Of ModelComponent))
            _SomeComponents = value
            OnPropertyChanged("SomeComponents")
        End Set
    End Property

    Public ReadOnly Property BatchOfSomeComponents As List(Of ModelComponent)
        Get
            Dim returnVaue As List(Of ModelComponent)
            returnVaue =
                (From item As ModelComponent In SomeComponents
                Select item).ToList()
            Return returnVaue
        End Get
    End Property

    Public ReadOnly Property FirstBatchItem As ModelComponent
        Get

            Return BatchOfSomeComponents.FirstOrDefault
        End Get
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' add or update
    ''' </summary>
    Public Sub LoadData()
        'Dim result As ModelComponent
        Try
            With ModelController(Of Model).Model
                .SomeComponents = New BindingList(Of ModelComponent)() From _
                {
                    New ModelComponent() With _
                    {
                        .SomeString = "item1",
                        .Remark = "default remark"
                    },
                    New ModelComponent() With _
                    {
                        .SomeString = "item2",
                        .Remark = "default remark"
                    },
                    New ModelComponent() With _
                    {
                        .SomeString = "item3",
                        .Remark = "default remark"
                    },
                    New ModelComponent() With _
                    {
                        .SomeString = "item4",
                        .Remark = "default remark"
                    },
                    New ModelComponent() With _
                    {
                        .SomeString = "item5",
                        .Remark = "default remark"
                    },
                    New ModelComponent() With _
                    {
                        .SomeString = "item6",
                        .Remark = "default remark"
                    }
                }

                .Refresh()

            End With

        Catch ex As Exception
            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        End Try
    End Sub

    Public Function Process _
    (
        worker As BackgroundWorker,
        e As DoWorkEventArgs,
        ByRef errorMessage As String
    ) As Boolean
        Dim returnValue As [Boolean] = Nothing
        Dim percentComplete As Int32 = 0
        Dim countComplete As Int32 = 0
        Dim countTotal As Int32 = 0

        Try
            If worker.CancellationPending Then
                e.Cancel = True
            Else

                'countComplete = 0;
                'countTotal = 0;
                percentComplete = 0
                worker.ReportProgress(percentComplete, "processing started ...")

                countTotal = BatchOfSomeComponents.Count '1 steps: process data

                'process
                For Each item As ModelComponent In ModelController(Of Model).Model.BatchOfSomeComponents
                    worker.ReportProgress(percentComplete, item.SomeString) 'ParentViewModel.StatusMessage = item.SomeString
                    'Application.DoEvents() 'ViewModel.ParentViewModel.View.Refresh()

                    Threading.Thread.Sleep(3000)

                    'report progress (1)
                    countComplete += 1
                    percentComplete = CType(((CType(countComplete, Double) / CType(countTotal, Double)) * 100), Int32)
                    'worker.ReportProgress(percentComplete, "processing...")
                Next

                'report progress
                percentComplete = 100
                worker.ReportProgress(percentComplete, "procesing finished.")
            End If

            returnValue = True

        Catch ex As Exception
            errorMessage = ex.Message

            Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
        Finally
            'Running = False
        End Try
        Return returnValue
    End Function
#End Region
End Class
'End Namespace
