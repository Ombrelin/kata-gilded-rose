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
            foreach (var item in Items)
            {
                var strategy = StrategyFactory.BuildStrategy(item);
                strategy.UpdateQuality(item);
                strategy.UpdateSellIn(item);
            }

        }
    }
}
