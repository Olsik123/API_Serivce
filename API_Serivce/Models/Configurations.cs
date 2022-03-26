using System;
using System.Collections.Generic;
using System.Text;

namespace API_Serivce.Models
{
    internal class Configurations
    {
        public int id { get; set; }
        public int adminId { get; set; }
        public string sources { get; set; }
        public string format { get; set; }
        public string type { get; set; }
        public int retention { get; set; }
        public string frequency { get; set; }
        public int packages { get; set; }
        public string alias { get; set; }
    }
}
