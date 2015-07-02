using System;
using System.Collections.Generic;

namespace PlayingWithShouldly
{
    public class PlayerCharacter: IEquatable<PlayerCharacter>
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

        public bool Equals(PlayerCharacter other)
        {
            if (other == null) return false;
            var hs = new HashSet<string>(Weapons).SetEquals(other.Weapons);
            return Name == other.Name && HitPoints == other.HitPoints && IsNoob == other.IsNoob && hs;
        }

        public override bool Equals(object obj)
        {
            var pc = obj as PlayerCharacter;
            return pc != null && Equals(pc);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();// + HitPoints.GetHashCode();
        }

        public static bool operator ==(PlayerCharacter pc1, PlayerCharacter pc2)
        {
            if (pc1 == null || pc2 == null) return Equals(pc1, pc2);
            return pc1.Equals(pc2);
        }
        public static bool operator !=(PlayerCharacter pc1, PlayerCharacter pc2)
        {
            if (pc1 == null || pc2 == null) return !Equals(pc1, pc2);
            return !pc1.Equals(pc2);
        }
    }
}
