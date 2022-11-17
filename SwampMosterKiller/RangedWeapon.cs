using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller 
{
    internal class RangedWeapon : Weapon
    {
        public RangedWeapon(weaponType _WT, int _X, int _Y, TileType _TOT, string _Sym) : base(_WT, _X, _Y, _TOT, _Sym)
        {
            String WeaponType = _Sym;
            WeaponType = "Rifle";
            WeaponType = "Longbow";
            RangedWeapon RRWPN = new RangedWeapon(weaponType.Rifle,0,0,TOT,"R");
            RangedWeapon RBWPN = new RangedWeapon(weaponType.Longbow, 0, 0, TOT, "LB");


            RRWPN.Durability = 3;
            RRWPN.Range = 3;
            RRWPN.Dmg = 5;
            RRWPN.Cost = 7;

            RBWPN.Durability = 4;
            RBWPN.Range = 2;
            RBWPN.Dmg = 4;
            RBWPN.Cost = 6;
        }
        public enum weaponType
        {
            Rifle,
            Longbow
        }
    }
}
