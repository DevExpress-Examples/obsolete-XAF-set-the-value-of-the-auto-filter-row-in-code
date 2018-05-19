using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using WinSample.Module;
using DevExpress.ExpressApp.NodeWrappers;
using System.Net;

namespace WebSample.Module.Web {
    public partial class FilterRowController : ViewController {
        public FilterRowController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewId = "Person_ListView";
        }
        protected override void OnActivated() {
            base.OnActivated();
            ASPxGridViewSettingsInfoNodeWrapper wrapper = new ASPxGridViewSettingsInfoNodeWrapper(View.Info);
            if (wrapper.FilterExpression == string.Empty) {
                wrapper.FilterExpression = "[Country] = 'USA'";
            }
        }
        private void changeFilterAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
            if (View.IsControlCreated) {
                ASPxGridControl control = (View as ListView).Editor.Control as ASPxGridControl;
                control.FilterExpression = "[Country] = 'UK'";
            }
        }
    }
}
