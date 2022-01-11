namespace GildedRoseKata;

public interface ItemStrategy
{
    void UpdateQuality(Item item);
    void UpdateSellIn(Item item);
}