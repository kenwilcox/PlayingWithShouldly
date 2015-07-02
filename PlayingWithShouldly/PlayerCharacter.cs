using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class PlayerCharacter
    {
        private string _name;
        public List<string> Weapons;
        public int HitPoints { get; private set; }
        public bool IsNoob { get; set; } 
        public string Name { get { return _name; } set { if (!string.IsNullOrEmpty(value)) _name = value; } }

        public PlayerCharacter()
        {
            HitPoints = 100;
            IsNoob = true;
            Name = GenerateName();
            CreateStartingWeapons();
        }

        private static string GenerateName()
        {
            var names = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "G'Toth'lop",
                "Boldrakteethtop"
            };

            return names[new Random().Next(0, names.Length)];
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

        public void Sleep()
        {
            var healthIncrease = new Random().Next(1, 101);
            HitPoints += healthIncrease;
        }

        // This is just for a test case
        public double AddDoubles(double a, double b)
        {
            return a + b;
        }
    }
}
