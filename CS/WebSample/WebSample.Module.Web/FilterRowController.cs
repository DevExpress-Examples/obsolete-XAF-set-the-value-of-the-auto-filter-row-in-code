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
using DevExpress.ExpressApp.Web.SystemModule;
using DevExpress.Web.ASPxGridView;

namespace WebSample.Module.Web {
    public partial class FilterRowController : ViewController {
        public FilterRowController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewId = "Person_ListView";
        }
        protected override void OnActivated() {
            base.OnActivated();
            IModelListViewWeb modelListViewWeb = ((IModelListViewWeb)View.Model);
            if (modelListViewWeb.FilterExpression == string.Empty)
            {
                modelListViewWeb.FilterExpression = "[Country] = 'USA'";
            }

        }
        private void changeFilterAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
            if (View.IsControlCreated) {
                ASPxGridView control = (View as ListView).Editor.Control as ASPxGridView;
                control.FilterExpression = "[Country] = 'UK'";
            }
        }
    }
}
