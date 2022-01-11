using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemFactoryTest
{
    [Fact]
    public void Build_CheeseName_BuildsCheeseItem()
    {
        // When
        var item = StrategyFactory.BuildStrategy(new Item { Name = "Aged Brie" });

        // When
        Assert.IsType<CheeseItemStrategy>(item);
    }
    
    [Fact]
    public void Build_BackstageName_BuildsBackstageItem()
    {
        // When
        var item = StrategyFactory.BuildStrategy(new Item { Name = "Backstage passes to a TAFKAL80ETC concert" });

        // When
        Assert.IsType<BackstageItemStrategy>(item);
    }
    
    [Fact]
    public void Build_LegendaryName_BuildsLegendaryItem()
    {
        // When
        var item = StrategyFactory.BuildStrategy(new Item { Name = "Sulfuras, Hand of Ragnaros" });

        // When
        Assert.IsType<LegendaryItemStrategy>(item);
    }

    [Fact]
    public void Build_ConjuredName_BuildsConjuredItem()
    {
        // When
        var item = StrategyFactory.BuildStrategy(new Item { Name = "Conjured item" });

        // When
        Assert.IsType<ConjuredItemStrategy>(item);
    }
}