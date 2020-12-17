Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
'using System.Threading.Tasks;
Imports Ssepan.Application
Imports Ssepan.Utility

Namespace MvcLibraryVb
    ''' <summary>
    ''' run-time model; relies on settings
    ''' </summary>
    <TypeConverter(GetType(ExpandableObjectConverter))> _
    Public Class MVCModel
        Inherits ModelBase
#Region "Declarations"
#End Region

#Region "Constructors"
        Public Sub New()
            If SettingsController(Of MVCSettings).Settings Is Nothing Then
                SettingsController(Of MVCSettings).[New]()
            End If
            Debug.Assert(SettingsController(Of MVCSettings).Settings IsNot Nothing, "SettingsController<MVCSettings>.Settings != null")
            SomeComponents = New BindingList(Of MVCSettingsComponent)()
        End Sub

        Public Sub New(someInt__1 As Int32, someBoolean__2 As [Boolean], someString__3 As [String])
            Me.New()

            SomeInt = someInt__1
            SomeBoolean = someBoolean__2
            SomeString = someString__3
        End Sub
#End Region

#Region "IEquatable<IModel>"
        ''' <summary>
        ''' Compare property values of two specified Model objects.
        ''' </summary>
        ''' <param name="anotherSettings"></param>
        ''' <returns></returns>
        Public Overrides Function Equals(other As IModel) As [Boolean]
            Dim returnValue As [Boolean] = Nothing
            Dim otherModel As MVCModel = Nothing

            Try
                otherModel = TryCast(other, MVCModel)

                If Me Is otherModel Then
                    returnValue = True
                Else
                    If Not MyBase.Equals(other) Then
                        returnValue = False
                    ElseIf Me.SomeInt <> otherModel.SomeInt Then
                        returnValue = False
                    ElseIf Me.SomeBoolean <> otherModel.SomeBoolean Then
                        returnValue = False
                    ElseIf Me.SomeString <> otherModel.SomeString Then
                        returnValue = False
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

        Private _Key1 As String
        Public Property Key1 As String
            Get
                Return _Key1
            End Get
            Set(ByVal value As String)
                _Key1 = value
                OnPropertyChanged("Key1")
            End Set
        End Property

        Private _Key2 As String
        Public Property Key2 As String
            Get
                Return _Key2
            End Get
            Set(ByVal value As String)
                _Key2 = value
                OnPropertyChanged("Key2")
            End Set
        End Property

        Private _SomeComponents As BindingList(Of MVCSettingsComponent)
        Public Property SomeComponents As BindingList(Of MVCSettingsComponent)
            Get
                Return _SomeComponents
            End Get
            Set(ByVal value As BindingList(Of MVCSettingsComponent))
                _SomeComponents = value
                OnPropertyChanged("SomeComponents")
            End Set
        End Property


        Private Property _SelectedComponent As MVCSettingsComponent
        Public Property SelectedComponent As MVCSettingsComponent
            Get
                Return _SelectedComponent
            End Get
            Set(value As MVCSettingsComponent)
                _SelectedComponent = value
                'for completeness; will rely on internal notifications
                OnPropertyChanged("SelectedComponent")
            End Set
        End Property

        Public Property SomeInt As Int32
            Get
                Return SettingsController(Of MVCSettings).Settings.SomeInt
            End Get
            Set(value As Int32)
                SettingsController(Of MVCSettings).Settings.SomeInt = value
                OnPropertyChanged("SomeOtherInt")
            End Set
        End Property

        Public Property SomeBoolean As [Boolean]
            Get
                Return SettingsController(Of MVCSettings).Settings.SomeBoolean
            End Get
            Set(value As [Boolean])
                SettingsController(Of MVCSettings).Settings.SomeBoolean = value
                OnPropertyChanged("SomeBoolean")
            End Set
        End Property

        Public Property SomeString As [String]
            Get
                Return SettingsController(Of MVCSettings).Settings.SomeString
            End Get
            Set(value As [String])
                SettingsController(Of MVCSettings).Settings.SomeString = value
                OnPropertyChanged("SomeOtherString")
            End Set
        End Property
#End Region

#Region "Methods"
        ''' <summary>
        ''' add or update
        ''' </summary>
        Public Sub DoSomething()
            'Dim result As MVCSettingsComponent
            Try
                With ModelController(Of MVCModel).Model
                    .SomeComponents.Add _
                    (
                        New MVCSettingsComponent _
                        (
                        )
                    )

                    .Refresh()

                End With

            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            End Try
        End Sub
        ''' <summary>
        ''' remove if present
        ''' </summary>
        Public Sub DoSomethingElse()
            Dim result As MVCSettingsComponent
            Try
                With ModelController(Of MVCModel).Model
                    result = .SomeComponents.SingleOrDefault(Function(i As MVCSettingsComponent) i.SomeOtherInt = .SelectedComponent.SomeOtherInt)
                    If result IsNot Nothing Then
                        'remove
                        .SomeComponents.Remove(result)
                    Else
                        'do nothing
                    End If

                    .Refresh()

                End With
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            End Try
        End Sub
        ''' <summary>
        ''' model specific, not generic
        ''' </summary>
        Public Sub DoSomethingOnce()
            Try
                With ModelController(Of MVCModel).Model
                    .SelectedComponent.SomeOtherBoolean = Not .SelectedComponent.SomeOtherBoolean
                    .SelectedComponent.SomeOtherInt += 1
                    .SelectedComponent.SomeOtherString = DateTime.Now.ToString()
                    .SomeComponents.Add _
                    (
                        New MVCSettingsComponent _
                        (
                            .SelectedComponent.SomeOtherInt,
                            .SelectedComponent.SomeOtherBoolean,
                            .SelectedComponent.SomeOtherString
                        )
                    )

                    .Key2 = "value2" + DateTime.Now.ToString()

                    .Refresh()

                End With
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
            End Try
        End Sub
#End Region
    End Class
End Namespace
