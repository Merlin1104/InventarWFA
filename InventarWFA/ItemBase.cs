using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarWFA
{
    public enum ItemType
    {
        None = 0,
        Weapon = 1,
        Armor = 2,
        Source = 3
    }


    public abstract class ItemBase
    {
        protected int cost;
        protected int count;
        protected double weight;
        protected string name;
        protected ItemType itemType;

        public ItemBase(int pCost, int pCount, double pWeight, string pName, ItemType pItemtype)
        {
            cost = pCost;
            count = pCount;
            weight = pWeight;
            name = pName;
            itemType = pItemtype;
        }

        public abstract string DescribeItem();
    }

    
}
