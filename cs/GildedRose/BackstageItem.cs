namespace GildedRoseKata;

public class BackstageItem : Item
{
    public override void UpdateQuality()
    {
        if (SellIn <= 0)
        {
            Quality = 0;
        } else
        {
            Quality += SellIn switch
            {
                <= 5 => 3,
                <= 10 => 2,
                _ => 1
            };

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}