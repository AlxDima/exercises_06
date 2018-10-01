using System;

namespace GameModel
{
    public class Hero
    {
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int HitPoints { get; set; }

        public Weapon MainHandWeapon { get; set; }

        public bool IsAlive()
        {
            return HitPoints > 0;
        }

        public int Attack()
        {
            if (IsAlive())
            {
                if (MainHandWeapon == null)
                {
                    return Strength / 2;
                }
                return (MainHandWeapon.Attack * Strength) / 2;
            }
            else
            {
                return 0;
            }
            

            
        }

        public void Defend(Hero opponent)
        {
            if (opponent == null)
            {
                throw new ArgumentNullException();
            }
            HitPoints -= (opponent.Attack() - Defence);
            if (HitPoints < 0)
            {
                HitPoints = 0;
            }
        }
    }
}
