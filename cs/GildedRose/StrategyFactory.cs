namespace GildedRoseKata;

public class StrategyFactory
{
    public static ItemStrategy BuildStrategy(Item item) =>
        item.Name switch
        {
            "Aged Brie" => new CheeseItemStrategy(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstageItemStrategy(),
            "Sulfuras, Hand of Ragnaros" => new LegendaryItemStrategy(),
            "Conjured item" => new ConjuredItemStrategy(),
            _ => new DefaultItemStrategy()
        };
}