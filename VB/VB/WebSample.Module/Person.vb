Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Data.Filtering

Namespace WinSample.Module
	<DefaultClassOptions> _
	Public Class Person
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property
		Private _Address As String
		Public Property Address() As String
			Get
				Return _Address
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Address", _Address, value)
			End Set
		End Property
		Private _Country As String
		Public Property Country() As String
			Get
				Return _Country
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Country", _Country, value)
			End Set
		End Property
	End Class
End Namespace
