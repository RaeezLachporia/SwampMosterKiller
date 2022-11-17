using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
     class Shop
    {

        Weapon[] wpn = new Weapon[3];
        Random rndwpn = new Random();
        Character player;
        MeleeWeapon Dagger = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0, "D");
        public Shop(Character _Player, Weapon[] _wpn)
        {
            int number;
            player = _Player;
            for (int i = 0; i < wpn.Length; i++)
            {
                wpn[i] = RandomWeapon();
            }
        }
        private Weapon RandomWeapon()
        {
            if (rndwpn.Next() == 1)
            {
                MeleeWeapon Dagger = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0, "D");

            }
            if (rndwpn.Next() == 2)
            {
                MeleeWeapon LongSword = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0, "LS");
            }
            if (rndwpn.Next() == 3)
            {
                RangedWeapon Rifle = new RangedWeapon(RangedWeapon.weaponType.Rifle, 0, 0, "R");
            }
            else
            {
                RangedWeapon LongBow = new RangedWeapon(RangedWeapon.weaponType.Rifle, 0, 0, "LB");
            }
        }
    }
}
