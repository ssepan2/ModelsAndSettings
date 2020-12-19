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
            If SettingsController(Of MVCSettings).Settings Is Nothing Then
                SettingsController(Of MVCSettings).[New]()
            End If
            Debug.Assert(SettingsController(Of MVCSettings).Settings IsNot Nothing, "SettingsController<MVCSettings>.Settings != null")
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
        ''' <param name="other"></param>
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
                'TODO:update handlers?
                UpdateHandlers()
                'for completeness; will rely on internal notifications
                OnPropertyChanged("SomeComponent")
            End Set
        End Property

        Public Property SomeInt As Int32
            Get
                Return SettingsController(Of MVCSettings).Settings.SomeInt
            End Get
            Set(value As Int32)
                SettingsController(Of MVCSettings).Settings.SomeInt = value
                OnPropertyChanged("SomeInt")
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
                OnPropertyChanged("SomeString")
            End Set
        End Property
#End Region

#Region "Methods"

        ''' <summary>
        ''' Update child components (used as properties) to use the passed handler.
        ''' Note: for every child component, copy to child and then let child copy to its children
        ''' </summary>
        Public Overrides Sub UpdateHandlers()
            'copy handlers from this object to child conponent
            ObjectHelper.CopyEvents(Of ModelBase, SettingsComponentBase)(Me, Me.SomeComponent, "PropertyChanged")

            'allow child component to copy handlers from itself to it's child conponent (if child component does not implement, this still calls empty method in base).
            Me.SomeComponent.UpdateHandlers()
        End Sub
#End Region
    End Class
'End Namespace
