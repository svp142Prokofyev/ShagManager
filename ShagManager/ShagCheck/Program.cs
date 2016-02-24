using ShagManager;
using ShagManager.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new ServiceInitializer());

            var db = new ManagerContext();
            db.Database.Initialize(false);

            Console.WriteLine("Complete");



            Console.ReadLine();
        }
    }
}
