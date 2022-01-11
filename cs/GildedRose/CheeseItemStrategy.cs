namespace GildedRoseKata;

public class CheeseItemStrategy : DefaultItemStrategy
{
    public override void UpdateQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += item.SellIn switch
            {
                <= 0 => 2,
                _ => 1
            };

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}