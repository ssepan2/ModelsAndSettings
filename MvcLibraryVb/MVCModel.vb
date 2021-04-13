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
Imports Ssepan.Application.MVC
Imports Ssepan.Utility

'Namespace MvcLibraryVb
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
        'init SomeComponent property backed by setting component
        If SettingsController(Of MVCSettings).Settings Is Nothing Then
            SettingsController(Of MVCSettings).[New]()
        End If
        Debug.Assert(SettingsController(Of MVCSettings).Settings IsNot Nothing, "SettingsController<MVCSettings>.Settings != null")
        'init some other component property Not backed by settings, but backed by model component
        StillAnotherComponent = New MVCModelComponent()
    End Sub

    Public Sub New(ByVal someInt As Integer, ByVal someBoolean As Boolean, ByVal someString As String)
        Me.New()
        Me.SomeInt = someInt
        Me.SomeBoolean = someBoolean
        Me.SomeString = someString
    End Sub

    Public Sub New(ByVal someInt As Integer, ByVal someBoolean As Boolean, ByVal someString As String, ByVal someOtherInt As Integer, ByVal someOtherBoolean As Boolean, ByVal someOtherString As String)
        Me.New(someInt, someBoolean, someString)
        SomeComponent.SomeOtherInt = someOtherInt
        SomeComponent.SomeOtherBoolean = someOtherBoolean
        SomeComponent.SomeOtherString = someOtherString
    End Sub

    Public Sub New(ByVal someInt As Integer, ByVal someBoolean As Boolean, ByVal someString As String, ByVal someOtherInt As Integer, ByVal someOtherBoolean As Boolean, ByVal someOtherString As String, ByVal stillAnotherInt As Integer, ByVal stillAnotherBoolean As Boolean, ByVal stillAnotherString As String)
        Me.New(someInt, someBoolean, someString, someOtherInt, someOtherBoolean, someOtherString)
        StillAnotherComponent.StillAnotherInt = stillAnotherInt
        StillAnotherComponent.StillAnotherBoolean = stillAnotherBoolean
        StillAnotherComponent.StillAnotherString = stillAnotherString
    End Sub

#End Region

#Region "IDisposable support"
    Protected Overrides Sub Finalize()
        Try
            Dispose(False)
        Finally
            MyBase.Finalize()
        End Try
    End Sub

    'inherited; override if additional cleanup needed
    Protected Overrides Sub Dispose(disposeManagedResources As [Boolean])
        ' process only if mananged and unmanaged resources have
        ' not been disposed of.
        If Not disposed Then
            Try
                'Resources not disposed
                If disposeManagedResources Then
                    ' dispose managed resources
                    StillAnotherComponent = Nothing
                End If

                disposed = True
            Finally
                ' dispose unmanaged resources
                MyBase.Dispose(disposeManagedResources)
            End Try
            'Resources already disposed
        Else
        End If
    End Sub
#End Region

#Region "IEquatable<IModel>"
    ''' <summary>
    ''' Compare property values of two specified Model objects.
    ''' </summary>
    ''' <param name="other"></param>
    ''' <returns></returns>
    Public Overrides Function Equals(other As IModelComponent) As [Boolean]
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
    Private Property _Args As String()
        Public Property Args As String()

            Get
                Return _Args
            End Get
            Set(value As String())

                _Args = value
                OnPropertyChanged("Args")
            End Set
        End Property

        Public Property SomeComponent As MVCSettingsComponent
            Get
                Return SettingsController(Of MVCSettings).Settings.SomeComponent
            End Get
            Set(value As MVCSettingsComponent)
                SettingsController(Of MVCSettings).Settings.SomeComponent = value
            'OnPropertyChanged("SomeComponent");'Not needed if fired by settings
        End Set
        End Property


    'private MVCModelComponent __StillAnotherComponent = default(MVCModelComponent);//not needed; individual properties are backed in model component
    Private _StillAnotherComponent As MVCModelComponent = Nothing
    Public Property StillAnotherComponent() As MVCModelComponent
        Get
            Return _StillAnotherComponent
        End Get
        Set

            If ModelController(Of MVCModel).DefaultHandler IsNot Nothing Then
                If _StillAnotherComponent IsNot Nothing Then
                    RemoveHandler _StillAnotherComponent.PropertyChanged, ModelController(Of MVCModel).DefaultHandler
                End If
            End If

            _StillAnotherComponent = Value

            If ModelController(Of MVCModel).DefaultHandler IsNot Nothing Then
                If _StillAnotherComponent IsNot Nothing Then
                    AddHandler _StillAnotherComponent.PropertyChanged, ModelController(Of MVCModel).DefaultHandler
                End If
            End If

            'needed because NOT backed by settings
            OnPropertyChanged("StillAnotherComponent")
        End Set
    End Property


    Public Property SomeInt As Int32
        Get
            Return SettingsController(Of MVCSettings).Settings.SomeInt
        End Get
        Set(value As Int32)
            SettingsController(Of MVCSettings).Settings.SomeInt = value
            'not needed if fired by settings
            'OnPropertyChanged("SomeInt")
        End Set
    End Property

    Public Property SomeBoolean As [Boolean]
        Get
            Return SettingsController(Of MVCSettings).Settings.SomeBoolean
        End Get
        Set(value As [Boolean])
            SettingsController(Of MVCSettings).Settings.SomeBoolean = value
            'not needed if fired by settings
            'OnPropertyChanged("SomeBoolean")
        End Set
    End Property

    Public Property SomeString As [String]
        Get
            Return SettingsController(Of MVCSettings).Settings.SomeString
        End Get
        Set(value As [String])
            SettingsController(Of MVCSettings).Settings.SomeString = value
            'not needed if fired by settings
            'OnPropertyChanged("SomeString")
        End Set
    End Property
#End Region

#Region "Methods"
#End Region
End Class
'End Namespace
