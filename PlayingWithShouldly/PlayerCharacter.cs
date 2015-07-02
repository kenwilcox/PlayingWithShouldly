using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class PlayerCharacter
    {
        public List<string> Weapons;
         
        public PlayerCharacter()
        {
            CreateStartingWeapons();
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>()
            {
                "Long Bow",
                "Short Sword",
                "Small Shield"
                //"Staff of Wonder"
            };
        }
    }
}
