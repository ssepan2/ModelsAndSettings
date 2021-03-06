﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.Serialization
Imports System.Text
'using System.Threading.Tasks;
Imports System.Xml.Serialization
Imports Ssepan.Application
Imports Ssepan.Application.MVC
Imports Ssepan.Utility

'Namespace MvcLibraryVb
''' <summary>
''' persisted settings; run-time model depends on this
''' </summary>
<TypeConverter(GetType(ExpandableObjectConverter))> _
    <Serializable> _
    Public Class MVCSettings
        Inherits SettingsBase
#Region "Declarations"
        Private Const FILE_TYPE_EXTENSION As [String] = "mvcsettings"
        Private Const FILE_TYPE_NAME As [String] = "mvcsettingsfile"
        Private Const FILE_TYPE_DESCRIPTION As [String] = "MVC Settings File"
#End Region

#Region "Constructors"
    Public Sub New()
        FileTypeExtension = FILE_TYPE_EXTENSION
        FileTypeName = FILE_TYPE_NAME
        FileTypeDescription = FILE_TYPE_DESCRIPTION
        'default
        SerializeAs = SerializationFormat.Xml
        SomeComponent = New MVCSettingsComponent()
    End Sub

    Public Sub New(someInt__1 As Int32, someBoolean__2 As [Boolean], someString__3 As [String])
        Me.New()
        SomeInt = someInt__1
        SomeBoolean = someBoolean__2
        SomeString = someString__3
    End Sub

    Public Sub New(someInt As Int32, someBoolean As [Boolean], someString As [String], someOtherInt As Int32, someOtherBoolean As [Boolean], someOtherString As [String])
        Me.New(someInt, someBoolean, someString)
        SomeComponent.SomeOtherInt = someOtherInt
        SomeComponent.SomeOtherBoolean = someOtherBoolean
        SomeComponent.SomeOtherString = someOtherString
    End Sub

    Public Sub New(someInt As Int32, someBoolean As [Boolean], someString As [String], someComponent__1 As MVCSettingsComponent)
        Me.New(someInt, someBoolean, someString)
        SomeComponent = someComponent__1
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
                    SomeComponent = Nothing
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

#Region "IEquatable<ISettingsComponent>"
        ''' <summary>
        ''' Compare property values of two specified Settings objects.
        ''' </summary>
        ''' <param name="other"></param>
        ''' <returns></returns>
        Public Overrides Function Equals(other As ISettingsComponent) As [Boolean]
        Dim returnValue As [Boolean] = Nothing
        Dim otherSettings As MVCSettings = Nothing

            Try
                otherSettings = TryCast(other, MVCSettings)

                If Me Is otherSettings Then
                    returnValue = True
                Else
                    If Not MyBase.Equals(other) Then
                        returnValue = False
                    ElseIf Not Me.SomeComponent.Equals(otherSettings) Then
                        returnValue = False
                    ElseIf Me.SomeInt <> otherSettings.SomeInt Then
                        returnValue = False
                    ElseIf Me.SomeBoolean <> otherSettings.SomeBoolean Then
                        returnValue = False
                    ElseIf Me.SomeString <> otherSettings.SomeString Then
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
        <XmlIgnore> _
        Public Overrides ReadOnly Property Dirty() As [Boolean]
            Get
                Dim returnValue As [Boolean] = Nothing

                Try
                    If MyBase.Dirty Then
                        returnValue = True
                        'else if (_SomeComponent.Equals(__SomeComponent))
                    ElseIf SomeComponent.Dirty Then
                        returnValue = True
                    ElseIf _SomeInt <> __SomeInt Then
                        returnValue = True
                    ElseIf _SomeBoolean <> __SomeBoolean Then
                        returnValue = True
                    ElseIf _SomeString <> __SomeString Then
                        returnValue = True
                    Else
                        returnValue = False
                    End If
                Catch ex As Exception
                    Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
                    Throw
                End Try

                Return returnValue
            End Get
        End Property

#Region "Persisted Properties"
    'private MVCSettingsComponent __SomeComponent = default(MVCSettingsComponent);//not needed; individual properties are backed in settings
    Private _SomeComponent As MVCSettingsComponent = Nothing
        Public Property SomeComponent As MVCSettingsComponent
            Get
                Return _SomeComponent
            End Get
            Set(value As MVCSettingsComponent)
            If SettingsController(Of MVCSettings).DefaultHandler IsNot Nothing Then
                If _SomeComponent IsNot Nothing Then
                    RemoveHandler _SomeComponent.PropertyChanged, SettingsController(Of MVCSettings).DefaultHandler
                End If
            End If

            _SomeComponent = value

            If SettingsController(Of MVCSettings).DefaultHandler IsNot Nothing Then
                If _SomeComponent IsNot Nothing Then
                    AddHandler _SomeComponent.PropertyChanged, SettingsController(Of MVCSettings).DefaultHandler
                End If
            End If

            OnPropertyChanged("SomeComponent")
        End Set
    End Property

        Private __SomeInt As Int32 = Nothing
        Private _SomeInt As Int32 = Nothing
        Public Property SomeInt As Int32
            Get
                Return _SomeInt
            End Get
            Set(value As Int32)
                _SomeInt = value
                OnPropertyChanged("SomeInt")
            End Set
        End Property

        Private __SomeBoolean As [Boolean] = Nothing
        Private _SomeBoolean As [Boolean] = Nothing
        Public Property SomeBoolean As [Boolean]
            Get
                Return _SomeBoolean
            End Get
            Set(value As [Boolean])
                _SomeBoolean = value
                OnPropertyChanged("SomeBoolean")
            End Set
        End Property

        Private __SomeString As [String] = [String].Empty
        'default(String);
        Private _SomeString As [String] = [String].Empty
        'default(String);
        Public Property SomeString As [String]
            Get
                Return _SomeString
            End Get
            Set(value As [String])
                _SomeString = value
                OnPropertyChanged("SomeString")
            End Set
        End Property
#End Region
#End Region

#Region "Methods"
        ''' <summary>
        ''' Copies property values from source working fields to detination working fields, then optionally syncs destination.
        ''' </summary>
        ''' <param name="destination"></param>
        ''' <param name="sync"></param>
        Public Overrides Sub CopyTo(destination As ISettingsComponent, sync As [Boolean])
            'ISettings
            Dim destinationSettings As MVCSettings = Nothing

            Try
                destinationSettings = TryCast(destination, MVCSettings)

                'destinationSettings.SomeComponent = this.SomeComponent;
                Me.SomeComponent.CopyTo(destinationSettings.SomeComponent, sync)

                destinationSettings.SomeInt = Me.SomeInt
                destinationSettings.SomeBoolean = Me.SomeBoolean
                destinationSettings.SomeString = Me.SomeString

                'also checks and optionally performs sync
                MyBase.CopyTo(destination, sync)
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Syncs property values by copying from working fields to reference fields.
        ''' </summary>
        Public Overrides Sub Sync()
            Try
                '__SomeComponent = ObjectHelper.Clone<MVCSettingsComponent>(_SomeComponent);
                SomeComponent.Sync()

                __SomeInt = _SomeInt
                __SomeBoolean = _SomeBoolean
                __SomeString = _SomeString

                MyBase.Sync()

                If Dirty Then
                    Throw New ApplicationException("Sync failed.")
                End If
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
                Throw
            End Try
        End Sub
#End Region
End Class
'End Namespace
