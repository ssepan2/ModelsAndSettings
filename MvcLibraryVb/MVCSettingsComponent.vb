Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Runtime.Serialization
Imports System.Text
Imports Ssepan.Application
Imports Ssepan.Utility

Namespace MvcLibraryVb
    ''' <summary>
    ''' component of persisted settings; run-time model depends on this
    ''' </summary>
    <TypeConverter(GetType(ExpandableObjectConverter))> _
    <Serializable> _
    Public Class MVCSettingsComponent
        Inherits SettingsComponentBase
#Region "Declarations"
#End Region

#Region "Constructors"
        Public Sub New()
        End Sub

        Public Sub New(someOtherInt__1 As Int32, someOtherBoolean__2 As [Boolean], someOtherString__3 As [String])
            Me.New()
            SomeOtherInt = someOtherInt__1
            SomeOtherBoolean = someOtherBoolean__2
            SomeOtherString = someOtherString__3
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
                    ' dispose managed resources
                    If disposeManagedResources Then
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
            Dim otherModel As MVCSettingsComponent = Nothing

            Try
                otherModel = TryCast(other, MVCSettingsComponent)

                If Me Is otherModel Then
                    returnValue = True
                Else
                    If Not MyBase.Equals(other) Then
                        returnValue = False
                    ElseIf Me.SomeOtherInt <> otherModel.SomeOtherInt Then
                        returnValue = False
                    ElseIf Me.SomeOtherBoolean <> otherModel.SomeOtherBoolean Then
                        returnValue = False
                    ElseIf Me.SomeOtherString <> otherModel.SomeOtherString Then
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
                    ElseIf _SomeOtherInt <> __SomeOtherInt Then
                        returnValue = True
                    ElseIf _SomeOtherBoolean <> __SomeOtherBoolean Then
                        returnValue = True
                    ElseIf _SomeOtherString <> __SomeOtherString Then
                        returnValue = True
                    Else
                        returnValue = False
                    End If
                Catch ex As Exception
                    Log.Write(ex, MethodBase.GetCurrentMethod, EventLogEntryType.[Error])
                    Throw
                End Try

                Return returnValue
            End Get
        End Property

#Region "Persisted Properties"
        Private __SomeOtherInt As Int32 = Nothing
        Private _SomeOtherInt As Int32 = Nothing
        Public Property SomeOtherInt As Int32
            Get
                Return _SomeOtherInt
            End Get
            Set(value As Int32)
                _SomeOtherInt = value
                OnPropertyChanged("SomeOtherInt")
            End Set
        End Property

        Private __SomeOtherBoolean As [Boolean] = Nothing
        Private _SomeOtherBoolean As [Boolean] = Nothing
        Public Property SomeOtherBoolean As [Boolean]
            Get
                Return _SomeOtherBoolean
            End Get
            Set(value As [Boolean])
                _SomeOtherBoolean = value
                OnPropertyChanged("SomeOtherBoolean")
            End Set
        End Property

        Private __SomeOtherString As [String] = [String].Empty
        'default(String);
        Private _SomeOtherString As [String] = [String].Empty
        'default(String);
        Public Property SomeOtherString As [String]
            Get
                Return _SomeOtherString
            End Get
            Set(value As [String])
                _SomeOtherString = value
                OnPropertyChanged("SomeOtherString")
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
            Dim destinationSettings As MVCSettingsComponent = Nothing

            Try
                destinationSettings = TryCast(destination, MVCSettingsComponent)

                destinationSettings.SomeOtherInt = Me.SomeOtherInt
                destinationSettings.SomeOtherBoolean = Me.SomeOtherBoolean
                destinationSettings.SomeOtherString = Me.SomeOtherString

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
                __SomeOtherInt = _SomeOtherInt
                __SomeOtherBoolean = _SomeOtherBoolean
                __SomeOtherString = _SomeOtherString

                MyBase.Sync()

                If Dirty Then
                    Throw New ApplicationException("Sync failed.")
                End If
            Catch ex As Exception
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.[Error])
                Throw
            End Try
        End Sub

        '''' <summary>
        '''' Update child components (used as properties) to use the passed handler.
        '''' </summary>
        '''' <param name="defaultHandler"></param>
        'public override void UpdateHandlers()
        '{
        '    ObjectHelper.CopyEvents<SettingsBase, SettingsComponentBase>(this, this._SomeSubComponent, "PropertyChanged");
        '}
#End Region
    End Class
End Namespace
