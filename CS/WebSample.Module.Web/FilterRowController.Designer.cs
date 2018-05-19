namespace WebSample.Module.Web {
    partial class FilterRowController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.changeFilterAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // changeFilterAction
            // 
            this.changeFilterAction.Caption = "Change Filter";
            this.changeFilterAction.Id = "changeFilterAction";
            this.changeFilterAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.changeFilterAction_Execute);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction changeFilterAction;
    }
}
