using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCoreApp.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public string mail { get; set; }

        public List<TargetApp> TargetApps { get; set; }

    }
}
