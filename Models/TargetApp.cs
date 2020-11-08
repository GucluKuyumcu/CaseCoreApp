using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCoreApp.Models
{
    public class TargetApp
    {
        [Key]
        public int id { get; set; }
        public int userid { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int interval { get; set; }
        public string mail { get; set; }
        public User User { get; set; }

    }
}
