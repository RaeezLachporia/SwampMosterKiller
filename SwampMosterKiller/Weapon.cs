using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwampMosterKiller
{
    abstract class Weapon : Item
    {
        public Weapon(weaponType _WT,int _X, int _Y, TileType _TOT,string _Sym) : base(_X, _Y, _TOT)
        {
            int X = _X;
            int y = _Y;
            
        }
        private int dmg;
        public int Dmg
        {
            get { return Dmg; }
            set { Dmg = value; }
        }

        private int range;
        public virtual int Range
        {
            get { return Range; }
            set { Range = value; }
        }

        private int durability;
        public int Durability
        {
            get { return Durability; }
            set { Durability = value; }
        }

        private int cost;
        public int Cost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public enum weaponType
        {
            Ranged,
            Melee
        }
        private  weaponType wpn;
        public int WPN
        {
            get { return WPN; }
            set { WPN = value; }
        }
        private Weapon
    }

    public class MeleeWeapon
    {
        public MeleeWeapon(Types _wpnT, int _X, int _Y, string _Sym)
        {
            _wpnT = wpnT;
            _X = X;
            _Y = Y;
            _Sym = Sym;

            Sym = "Dagger";
            Sym = "Longsword";

            MeleeWeapon mlw = new MeleeWeapon(Types.Dagger, 0, 0, "D");
            MeleeWeapon sword = new MeleeWeapon(Types.LongSword, 0, 0, "S");
            
        }
        public Types wpnT
        {
            get { return wpnT; }
            set { wpnT = value; }
        }
        private int x;
        public int X
        {
            get { return X; }
            set { X = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { Y = value; }
        }
        private string sym;
        public string Sym
        {
            get { return Sym; }
            set { Sym = value; }
        }
        public enum Types
        {
            Dagger,
            LongSword
        }

        /*public override Range()
        {

        }*/

       
    }
}
