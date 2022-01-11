namespace GildedRoseKata;

public class BackstageItemStrategy : DefaultItemStrategy
{
    public override void UpdateQuality(Item item)
    {
        if (item.SellIn <= 0)
        {
            item.Quality = 0;
        } else
        {
            item.Quality += item.SellIn switch
            {
                <= 5 => 3,
                <= 10 => 2,
                _ => 1
            };

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}