using Com.Sys.OAFrame.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Sys.OAFrame.Model
{
    public class TestContext : DbContext
    {
        public TestContext():base("name=DemoEntities")
        {

        }

        public DbSet<Test> Testes { get; set; }
    }
}
