Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports WinSample.Module
Imports DevExpress.ExpressApp.NodeWrappers
Imports System.Net

Namespace WebSample.Module.Web
	Partial Public Class FilterRowController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewId = "Person_ListView"
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			Dim wrapper As New ASPxGridViewSettingsInfoNodeWrapper(View.Info)
			If wrapper.FilterExpression = String.Empty Then
				wrapper.FilterExpression = "[Country] = 'USA'"
			End If
		End Sub
		Private Sub changeFilterAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles changeFilterAction.Execute
			If View.IsControlCreated Then
				Dim control As ASPxGridControl = TryCast((TryCast(View, ListView)).Editor.Control, ASPxGridControl)
				control.FilterExpression = "[Country] = 'UK'"
			End If
		End Sub
	End Class
End Namespace
