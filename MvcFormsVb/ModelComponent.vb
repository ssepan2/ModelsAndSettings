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

'Namespace BatchProcessDialogConsoleLibrary
''' <summary>
''' run-time model; relies on settings
''' </summary>
<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class ModelComponent
    Inherits ModelBase
#Region "Declarations"
#End Region

#Region "Constructors"
    Public Sub New()
        If SettingsController(Of Settings).Settings Is Nothing Then
            SettingsController(Of Settings).[New]()
        End If
        Debug.Assert(SettingsController(Of Settings).Settings IsNot Nothing, "SettingsController<Settings>.Settings != null")
        'SomeComponents = New BindingList(Of ModelComponent)()
    End Sub

    Public Sub New(remark_ As String, someString__3 As [String])
        Me.New()

        Remark = remark_
        SomeString = someString__3
    End Sub
#End Region

#Region "IEquatable<IModel>"
    ''' <summary>
    ''' Compare property values of two specified Model objects.
    ''' </summary>
    ''' <param name="other"></param>
    ''' <returns></returns>
    Public Overrides Function Equals(other As IModel) As [Boolean]
        Dim returnValue As [Boolean] = Nothing
        Dim otherModel As ModelComponent = Nothing

        Try
            otherModel = TryCast(other, ModelComponent)

            If Me Is otherModel Then
                returnValue = True
            Else
                If Not MyBase.Equals(other) Then
                    returnValue = False
                    'ElseIf Not Me.SomeComponents.Equals(otherModel) Then
                    '    returnValue = False
                ElseIf Me.Remark <> otherModel.Remark Then
                    returnValue = False
                ElseIf Me.NewRemark <> otherModel.NewRemark Then
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
    'Private _SomeComponents As BindingList(Of ModelComponent)
    'Public Property SomeComponents As BindingList(Of ModelComponent)
    '    Get
    '        Return _SomeComponents
    '    End Get
    '    Set(value As BindingList(Of ModelComponent))
    '        _SomeComponents = value
    '    End Set
    'End Property

    Private _SomeString As String
    Public Property SomeString As [String]
        Get
            Return _SomeString
        End Get
        Set(value As [String])
            _SomeString = value
            OnPropertyChanged("SomeString")
        End Set
    End Property

    Private _Remark As String
    Public Property Remark As String
        Get
            Return _Remark
        End Get
        Set(ByVal value As String)
            _Remark = value
            OnPropertyChanged("Remark")
        End Set
    End Property

    'Private _NewRemark As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NewRemark As String
        Get
            Return IIf(Not String.IsNullOrEmpty(Remark), Remark, "default remark") '_NewRemark
        End Get
        'Set(ByVal value As String)
        '    _NewRemark = value
        '    OnPropertyChanged("NewRemark")
        'End Set
    End Property

#End Region

#Region "Methods"
#End Region
End Class
'End Namespace
