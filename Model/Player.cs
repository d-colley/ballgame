using System.ComponentModel.DataAnnotations;

namespace BallGame.Model
{
    public class Player
    {
        [Key]
        public string PlayerID { get; set; }
        public string PlayerName { get; set; }

        public string PlayerRassword { get; set; }
    }
}