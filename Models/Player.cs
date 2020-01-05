using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BallGameMVC.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerRassword { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
