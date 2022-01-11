namespace GildedRoseKata;

public class ItemFactory
{
    public static Item BuildItem(Item item) =>
        item.Name switch
        {
            "Aged Brie" => new CheeseItem {Name = item.Name, Quality = item.Quality},
            "Backstage passes to a TAFKAL80ETC concert" => new BackstageItem {Name = item.Name, Quality = item.Quality},
            "Sulfuras, Hand of Ragnaros" => new LegendayItem {Name = item.Name, Quality = item.Quality}
            _ => item
        };
}