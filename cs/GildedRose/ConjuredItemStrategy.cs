namespace GildedRoseKata;

public class ConjuredItemStrategy : DefaultItemStrategy
{
    public override void UpdateQuality(Item item)
    {
        item.Quality -= 2;

        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }
}