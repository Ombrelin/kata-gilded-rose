namespace GildedRoseKata;

public class CheeseItem : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }
}