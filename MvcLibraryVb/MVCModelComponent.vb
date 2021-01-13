Imports System
'using System.Collections.Generic;
Imports System.ComponentModel
Imports System.Diagnostics
'using System.Linq;
'using System.Xml.Serialization;
Imports System.Reflection
'using System.Runtime.Serialization;
'using System.Text;
Imports Ssepan.Application
Imports Ssepan.Utility

'Namespace MVCLibrary
''' <summary>
''' component of non-persisted properties; 
''' run-time model depends on this;
''' does NOT rely on settings
''' </summary>
<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class MVCModelComponent
		Inherits ModelComponentBase
		#Region "Declarations"
		#End Region

		#Region "Constructors"
		Public Sub New()
		End Sub

		Public Sub New(stillAnotherInt As Int32, stillAnotherBoolean As [Boolean], stillAnotherString As [String])
			Me.New()
			Me.StillAnotherInt = stillAnotherInt
			Me.StillAnotherBoolean = stillAnotherBoolean
			Me.StillAnotherString = stillAnotherString
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

#Region "IEquatable<IModelComponent>"
		''' <summary>
		''' Compare property values of two specified Settings objects.
		''' </summary>
		''' <param name="other"></param>
		''' <returns></returns>
		Public Overrides Function Equals(other As IModelComponent) As [Boolean]
			Dim returnValue As [Boolean] = Nothing
			Dim otherModel As MVCModelComponent = Nothing

			Try
				otherModel = TryCast(other, MVCModelComponent)

				If Me Is otherModel Then
					returnValue = True
				Else
					If Not MyBase.Equals(other) Then
						returnValue = False
					ElseIf Me.StillAnotherInt <> otherModel.StillAnotherInt Then
						returnValue = False
					ElseIf Me.StillAnotherBoolean <> otherModel.StillAnotherBoolean Then
						returnValue = False
					ElseIf Me.StillAnotherString <> otherModel.StillAnotherString Then
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

#Region "Non-Persisted Properties"
		Private _StillAnotherInt As Int32 = Nothing
		Public Property StillAnotherInt() As Int32
			Get
				Return _StillAnotherInt
			End Get
			Set
				_StillAnotherInt = value
				OnPropertyChanged("StillAnotherInt")
			End Set
		End Property

		Private _StillAnotherBoolean As [Boolean] = Nothing
		Public Property StillAnotherBoolean() As [Boolean]
			Get
				Return _StillAnotherBoolean
			End Get
			Set
				_StillAnotherBoolean = value
				OnPropertyChanged("StillAnotherBoolean")
			End Set
		End Property

		Private _StillAnotherString As [String] = [String].Empty
		'default(String);
		Public Property StillAnotherString() As [String]
			Get
				Return _StillAnotherString
			End Get
			Set
				_StillAnotherString = value
				OnPropertyChanged("StillAnotherString")
			End Set
		End Property
		#End Region
		#End Region

	End Class
'End Namespace
