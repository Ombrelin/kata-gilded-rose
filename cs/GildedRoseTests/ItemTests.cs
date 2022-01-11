using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemTests
{
    [Fact]
    public void UpdateQuality_WithClassicalItem_DecreaseSellInAndQualityByOne()
    {
        // Given
        var item = new Item { Name = "default", SellIn = 20, Quality = 10 };

        // When
        item.UpdateQualityAndSellIn();

        // Then
        Assert.Equal(19, item.SellIn);
        Assert.Equal(9, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithClassicalItemWith0QualityAndSellIn_QualityIsNotNegative()
    {
        // Given
        var item = new Item { Name = "default", SellIn = 0, Quality = 0 };

        // When
        item.UpdateQualityAndSellIn();

        // Then
        Assert.Equal(-1, item.SellIn);
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_WithNegativeSellIn_QualityIsDecreasedFaster()
    {
        // Given
        var item = new Item { Name = "default", SellIn = -5, Quality = 10 };

        // When
        item.UpdateQualityAndSellIn();

        // Then
        Assert.Equal(-6, item.SellIn);
        Assert.Equal(8, item.Quality);
    }
}