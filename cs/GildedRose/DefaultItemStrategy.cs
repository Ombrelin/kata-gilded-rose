namespace GildedRoseKata;

public class DefaultItemStrategy : ItemStrategy
{
    public virtual void UpdateQuality(Item item)
    {
        if (item.Quality > 0)
        {
            if (item.SellIn >= 0)
            {
                item.Quality -= 1;
            }
            else
            {
                item.Quality -= 2;
            }
        }

        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }

    public virtual void UpdateSellIn(Item item)
    {
        item.SellIn -= 1;
    }
}