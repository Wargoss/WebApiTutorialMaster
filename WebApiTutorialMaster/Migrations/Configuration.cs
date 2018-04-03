namespace WebApiTutorialMaster.Migrations
{

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiTutorialMaster.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiTutorialMaster.Models.WebApiTutorialMasterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiTutorialMaster.Models.WebApiTutorialMasterContext context)
        {

            context.Contacts.AddOrUpdate(p => p.Name,

          new Models.Contact

          {

              ContactId = 1,

              Name = "Jessica Diaz",

              Address = "Ctra. Valencia km 7",

              City = "Madrid",

              State = "Spain",

              Zip = "28555",

              Email = "jdiaz@etsisi.upm.es",

          },

          new Contact

          {

              ContactId = 2,

              Name = "Jennifer Perez",

              Address = "Ctra. Valencia km 7",

              City = "Madrid",

              State = "Spain",

              Zip = "28555",

              Email = "jperez@etsisi.upm.es",

          },

          new Contact

          {

              ContactId = 1,

              Name = "Agustin Yague",

              Address = "Ctra. Valencia km 7",

              City = "Madrid",

              State = "Spain",

              Zip = "28555",

              Email = "ayague@etsisi.upm.es",

          }



);

        }

    }

}