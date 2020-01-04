using System.ComponentModel.DataAnnotations;

namespace BallGame.Model
{
    public class Environ
    {
        [Key]
        public string EnvID { get; set; }
        public string EnvName { get; set; }

        public string EnvLocation { get; set; }
        public string EnvTurfType { get; set; }
    }
}