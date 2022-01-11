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

        // When
        item.UpdateQuality();

        // Then
        Assert.Equal(9, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithClassicalItemWith0QualityAndSellIn_QualityIsNotNegative()
    {
        // Given
        var item = new Item { Name = "default", SellIn = 0, Quality = 0 };

        // When
        item.UpdateQuality();

        // Then
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithNegativeSellIn_QualityIsDecreasedFaster()
    {
        // Given
        var item = new Item { Name = "default", SellIn = -5, Quality = 10 };

        // When
        item.UpdateQuality();

        // Then
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithCheeseItem_QualityIsIncreasedPerTwo()
    {
        // Given
        var item = new CheeseItem() { Name = "cheese", SellIn = 10, Quality = 10 };

        // When
        item.UpdateQuality();

        // Then
        Assert.Equal(11, item.Quality);
    }

}