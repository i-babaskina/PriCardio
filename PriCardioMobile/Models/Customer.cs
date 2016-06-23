using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriCardioMobile.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Pulse { get; set; }
        public int DIA { get; set; }
        public int SYS { get; set; }
    }
}
