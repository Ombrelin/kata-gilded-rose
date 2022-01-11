using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemFactoryTest
{
    [Fact]
    public void Build_CheeseName_BuildsCheeseItem()
    {
        // When
        Item item = ItemFactory.BuildItem(new Item { Name = "Aged Brie" });

        // When
        Assert.IsType<CheeseItem>(item);
    }
    
    [Fact]
    public void Build_BackstageName_BuildsBackstageItem()
    {
        // When
        Item item = ItemFactory.BuildItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert" });

        // When
        Assert.IsType<BackstageItem>(item);
    }
    
    [Fact]
    public void Build_LegendaryName_BuildsLegendaryItem()
    {
        // When
        Item item = ItemFactory.BuildItem(new Item { Name = "Sulfuras, Hand of Ragnaros" });

        // When
        Assert.IsType<LegendaryItem>(item);
    }
}