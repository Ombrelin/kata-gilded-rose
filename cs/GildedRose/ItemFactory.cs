namespace GildedRoseKata;

public class ItemFactory
{
    public static Item BuildItem(Item item) =>
        item.Name switch
        {
            "Aged Brie" => new CheeseItem { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
            "Backstage passes to a TAFKAL80ETC concert" => new BackstageItem { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
            "Sulfuras, Hand of Ragnaros" => new LegendaryItem() { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
            _ => new Item() { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality }
        };
}