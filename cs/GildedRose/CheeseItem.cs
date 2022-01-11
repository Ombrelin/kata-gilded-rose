namespace GildedRoseKata;

public class CheeseItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality += SellIn switch
            {
                <= 0 => 2,
                _ => 1
            };

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}