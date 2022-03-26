using System;
using System.Collections.Generic;
using System.Text;

namespace API_Serivce.Models
{
    internal class Destinations
    {
        public int id { get; set; }
        public int configurationId { get; set; }
        public string place { get; set; }
        public string path { get; set; }
        public string FTPurl { get; set; }
    }
}
