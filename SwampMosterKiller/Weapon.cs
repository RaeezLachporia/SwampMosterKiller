using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    public class Weapon : Item
    {
        public Weapon(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT))
        {

        }
        private int dmg;
        public int DMG
        {
            get { return dmg}
            set { dmg value; }
        }

        private int range;
        public virtual int RANGE
        {
            get { return range
            set { range value; }
        }

        private int durability;
        public int DURABILITY
        {
            get { return durability}
            set { durability value; }
        }

        private int cost;
        public int COST
        {
            get { return cost}
            set { cost value; }
        }

        private string weapontype;
        public string WEAPONTYPE
        {
            get { return weapontype}
            set { weapontype value; }
        }
        

    }

     public class MeleeWeapon              
    {
        
        
        public enum MWType
        {
            Dagger,
            LongSword
        }

        public override Range()
        {
            return 1;
        }


          

         

}

