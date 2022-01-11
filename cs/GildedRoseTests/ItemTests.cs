using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemTests
{
    [Fact]
    public void UpdateQuality_WithClassicalItem_DecreaseQualityByOne()
    {
        // Given
        var item = new Item { Name = "default", SellIn = 20, Quality = 10 };
        var strategy = new DefaultItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(9, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithClassicalItemWith0QualityAndSellIn_QualityIsNotNegative()
    {
        // Given
        var item = new Item { Name = "default", SellIn = 0, Quality = 0 };
        var strategy = new DefaultItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithNegativeSellIn_QualityIsDecreasedFaster()
    {
        // Given
        var item = new Item { Name = "default", SellIn = -5, Quality = 10 };
        var strategy = new DefaultItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithCheeseItem_QualityIsIncreasedPerTwo()
    {
        // Given
        var item = new Item() { Name = "cheese", SellIn = 10, Quality = 10 };
        var strategy = new CheeseItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithBackstageItemAnd12SellIn_QualityIncreasedPerOne()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = 12, Quality = 10 };
        var strategy = new CheeseItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithBackstageItemAnd8SellIn_QualityIncreasedPerTwo()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = 8, Quality = 10 };
        var strategy = new BackstageItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(12, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithBackstageItemAnd4SellIn_QualityIncreasedPerThree()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = 4, Quality = 10 };
        var strategy = new BackstageItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(13, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithBackstageItemAnd4SellInAndHighQuality_QualityIs50()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = 4, Quality = 48 };
        var strategy = new BackstageItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(50, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithBackstageItemAndNegativeSellIn_QualityDropsTo0()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = -1, Quality = 10 };
        var strategy = new BackstageItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithLegendaryItemAndNegativeSellIn_QualityDoesNotChange()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = -1, Quality = 80 };
        var strategy = new LegendaryItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(80, item.Quality);
    }

    [Fact]
    public void UpdateSellIn_WithLegendaryItem_SellInDoesNotChange()
    {
        // Given
        var item = new Item() { Name = "backstage", SellIn = -1, Quality = 80 };
        var strategy = new LegendaryItemStrategy();

        // When
        strategy.UpdateQuality(item);

        // Then
        Assert.Equal(-1, item.SellIn);
    }

}