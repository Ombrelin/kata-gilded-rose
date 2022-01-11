// Do not touch this file
namespace GildedRoseKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void UpdateQuality()
        {
            if (Quality > 0)
            {
                if (SellIn >= 0)
                {
                    Quality -= 1;
                }
                else
                {
                    Quality -= 2;
                }
            }
        }

        public void UpdateSellIn()
        {
            SellIn -= 1;
        }
    }
}
