using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCoreApp.Models
{
    public class Log
    {
        [Key]
        public int id { get; set; }
        public int targetid { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
    }
}
