using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarWFA
{
    class Armor : ItemBase
    {
        public Armor(int pCost, int pCount, double pWeight, string pName, ItemType pItemType) : base(pCost, pCount, pWeight, pName, pItemType)
        {

        }
        public override string DescribeItem()
        {
            string s = null;
            s = name + " | Weight: " + weight + " | Type: " + itemType;
            return s;
        }
    }
}
