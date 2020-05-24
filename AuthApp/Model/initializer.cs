using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AuthApp.Model
{
    class Initializer:DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.Add(new User { Login = "admin", Password = "pikachu" });
            context.SaveChanges();
        }
    }
}
