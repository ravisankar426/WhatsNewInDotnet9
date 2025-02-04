
// Aggregate By
var sales = new List<Sale>
        {
            new ("North",100m ),
            new ("South", 150m ),
            new ("North", 200m ),
            new ("East", 50m ),
            new ("South", 100m )
        };

var totalSalesByRegion = sales.AggregateBy(
    keySelector: sale => sale.Region, // key
    seed: 0m, // seed value for the accumulator of each group
    func: (acc, sale) => acc + sale.Amount //accumulator function
);

foreach (var (region, totalAmount) in totalSalesByRegion)
{
    Console.WriteLine($"Region: {region}, Total Sales: {totalAmount}");
}



// CountBy method
var words = new[] { "apple", "banana", "apple", "cherry", "banana", "apple" };
var wordCounts = words.CountBy(word => word);
foreach (var (word, count) in wordCounts)
{
    Console.WriteLine($"{word}: {count}");
}

// Index method
var fruits = new[] { "apple", "banana", "cherry" };
foreach (var (index, fruit) in fruits.Index())
{
    Console.WriteLine($"Index {index}: {fruit}");
}







record Sale(string Region, decimal Amount);