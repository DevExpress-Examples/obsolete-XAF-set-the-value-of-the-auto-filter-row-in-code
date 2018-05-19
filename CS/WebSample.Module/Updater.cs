using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using WinSample.Module;

namespace WebSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreatePerson("Sam", "USA");
            CreatePerson("John", "USA");
            CreatePerson("Keith", "UK");
            CreatePerson("Gloria", "UK");
        }
        private void CreatePerson(string name, string country) {
            Person person = Session.FindObject<Person>(new BinaryOperator("Name", name));
            if (person == null) {
                person = new Person(Session);
                person.Name = name;
                person.Country = country;
                person.Save();
            }
        }
    }
}
