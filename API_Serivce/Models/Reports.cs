using System;
using System.Collections.Generic;
using System.Text;

namespace API_Serivce.Models
{
    public class Reports
    {
        public int id { get; set; }
        public int assignmentId { get; set; }
        public string date { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
}
