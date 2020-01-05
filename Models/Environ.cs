using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BallGameMVC.Models
{
    public class Environ
    {
        [Key]
        public int EnvID { get; set; }
        public string EnvName { get; set; }

        public string EnvLocation { get; set; }
        public string EnvTurfType { get; set; }
        public DateTime EnvRegistrationDate { get; set; }

    }
}
