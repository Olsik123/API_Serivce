using System;
using System.Collections.Generic;
using System.Text;

namespace API_Serivce.Models
{
    public class Stations
    {
        public int id { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public string alias { get; set; }
        public bool verified { get; set; }
    }
}
