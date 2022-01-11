using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        /*
         /!\ Do not change code above this line /!\
         */

        public void UpdateQuality()
        {
            var newItems = new List<Item>();
            foreach (var item in Items.Select(ItemFactory.BuildItem))
            {
                item.UpdateQuality();
                item.UpdateSellIn();
                newItems.Add(item);
            }

            Items = new List<Item>(newItems.ToList());
        }
    }
}
