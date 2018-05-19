Imports Microsoft.VisualBasic
Imports System
Namespace WebSample.Module.Web
	Partial Public Class FilterRowController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.changeFilterAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' changeFilterAction
			' 
			Me.changeFilterAction.Caption = "Change Filter"
			Me.changeFilterAction.Id = "changeFilterAction"
'			Me.changeFilterAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.changeFilterAction_Execute);

		End Sub

		#End Region

		Private WithEvents changeFilterAction As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
