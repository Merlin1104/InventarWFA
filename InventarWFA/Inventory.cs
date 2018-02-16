using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarWFA
{
    class Inventory
    {
        private List<ItemBase> items = new List<ItemBase>();

        public List<ItemBase> Items
        {
            get { return items; }
        }

        public void CreateItem(int pCost, int pCount, double pWeight, string pName, int pItemType)
        {
            ItemBase item = null; //naco je toto ?
            ItemType itemType = (ItemType)pItemType; //preco pretypovavame a nezadame uz v construktore miesto int ItemType ?
            switch (itemType)
            {
                case ItemType.Armor:
                    item = new Armor(pCost, pCount, pWeight, pName, itemType);
                    break;
                case ItemType.Source:
                    item = new Source(pCost, pCount, pWeight, pName, itemType);
                    break;
                case ItemType.Weapon:
                    item = new Weapon(pCost, pCount, pWeight, pName, itemType);
                    break;
                default:
                    break;
            }// tuto sme vytvorili item a ten je kde ? V ItemBase ?

            if (item == null) return; //return co ?

            AddItem(item);
        }

        public void AddItem(ItemBase pItem)
        {
            items.Add(pItem);
        }

        public void RemoveItem(ItemBase pItem)
        {
            items.Remove(pItem);
        }

        public void RemoveItem(int pIndex)
        {
            if (pIndex < 0 || pIndex >= items.Count)
                return;

            items.RemoveAt(pIndex);
        }


    }
}
