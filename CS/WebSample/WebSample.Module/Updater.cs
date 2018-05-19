using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using WinSample.Module;

namespace WebSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreatePerson("Sam", "USA");
            CreatePerson("John", "USA");
            CreatePerson("Keith", "UK");
            CreatePerson("Gloria", "UK");
        }
        private void CreatePerson(string name, string country) {
            Person person = ObjectSpace.FindObject<Person>(new BinaryOperator("Name", name));
            if (person == null) {
                person = ObjectSpace.CreateObject<Person>();
                person.Name = name;
                person.Country = country;
                person.Save();
            }
        }
    }
}
