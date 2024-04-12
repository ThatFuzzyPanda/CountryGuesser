using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagToCountryMatchGame.Model
{
    internal class GameParams
    {
       public int? CorrectGuess {  get; set; }
        public int? IncorrectGuess { get; set; }

        public string Gamemode { get; set; }
    }
}
