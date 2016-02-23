using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagManager.Configuration
{
    public class ServiceInitializer: IDatabaseInitializer<ManagerContext>
    {
        public void InitializeDatabase(ManagerContext context)
        {
            if (context.Database.Exists())
                context.Database.Delete();
            context.Database.Create();

            //context.Men.Add(new Man { ManID = 1, Name = "Alex" });
            //context.Men.Add(new Man { ManID = 2, Name = "Dima" });
            //context.Men.Add(new Man { ManID = 3, Name = "Aleksey" });

            context.SaveChanges();
        }
    }
}
