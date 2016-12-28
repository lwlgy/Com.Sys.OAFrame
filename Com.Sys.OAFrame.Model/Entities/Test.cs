using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Sys.OAFrame.Model.Entities
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Remark { get; set; }
    }
}
