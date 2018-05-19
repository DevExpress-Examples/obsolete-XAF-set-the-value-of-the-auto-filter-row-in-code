using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Data.Filtering;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class Person : BaseObject {
        public Person(Session session) : base(session) { }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        private string _Address;
        public string Address {
            get { return _Address; }
            set { SetPropertyValue("Address", ref _Address, value); }
        }
        private string _Country;
        public string Country {
            get { return _Country; }
            set { SetPropertyValue("Country", ref _Country, value); }
        }
    }
}
