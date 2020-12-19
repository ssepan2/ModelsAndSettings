Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Ssepan.Application

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("MvcFormsVb")> 
<Assembly: AssemblyDescription("Reference implementation of MVC, Winforms")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Free Software Foundation, Inc.")>
<Assembly: AssemblyProduct("MVCForms")>
<Assembly: AssemblyCopyright("Copyright (C) 1989, 1991 Free Software Foundation, Inc.  " & vbLf & "59 Temple Place - Suite 330, Boston, MA  02111-1307, USA")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("995313c0-e6b8-4fd1-ae86-5e92b11f8db1")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("0.3")>


#Region " Helper class to get information for the About form. "
''' <summary>
''' This class uses the System.Reflection.Assembly class to
''' access assembly meta-data
''' This class is ! a normal feature of AssemblyInfo.cs
''' </summary>
Public Class AssemblyInfo
	Inherits AssemblyInfoBase
	' Used by Helper Functions to access information from Assembly Attributes
	Public Sub New()
        MyBase.myType = GetType(MVCView)
	End Sub
End Class
#End Region
