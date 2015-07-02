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
        public int HitPoints { get; private set; }
         
        public PlayerCharacter()
        {
            HitPoints = 20;
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

        public int TakeDamage(int damage)
        {
            return HitPoints -= damage;
        }

        public int TakePotion(int health)
        {
            return HitPoints += health;
        }

        public double MagicDamage(int percent)
        {
            var percentage = percent / 100.0;
            var damage = HitPoints * percentage;
            return TakeDamage((int)Math.Ceiling(damage));
        }
    }
}
