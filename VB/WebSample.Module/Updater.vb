Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports WinSample.Module

Namespace WebSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			CreatePerson("Sam", "USA")
			CreatePerson("John", "USA")
			CreatePerson("Keith", "UK")
			CreatePerson("Gloria", "UK")
		End Sub
		Private Sub CreatePerson(ByVal name As String, ByVal country As String)
			Dim person As Person = Session.FindObject(Of Person)(New BinaryOperator("Name", name))
			If person Is Nothing Then
				person = New Person(Session)
				person.Name = name
				person.Country = country
				person.Save()
			End If
		End Sub
	End Class
End Namespace
