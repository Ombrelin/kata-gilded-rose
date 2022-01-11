﻿// Do not touch this file
namespace GildedRoseKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void UpdateQualityAndSellIn()
        {
            SellIn --;
            if (Quality > 0)
            {
                if (SellIn >= 0)
                {
                    Quality--;
                }
                else
                {
                    Quality -= 2;
                }
            }
        }
    }
}
