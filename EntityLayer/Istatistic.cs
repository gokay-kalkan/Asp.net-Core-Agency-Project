using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Istatistic
    {
        public int Id { get; set; }
        public string CompletedClass { get; set; }
        public string ProjectClass { get; set; }
        public string CustomersClass { get; set; }
        public int Completed { get; set; }
        public int Projects { get; set; }
        public int Customers { get; set; }
    }
}
