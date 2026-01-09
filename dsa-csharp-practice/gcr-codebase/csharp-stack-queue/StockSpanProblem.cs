/*Stock Span Problem
Problem: For each day in a stock price array, calculate the span (number of consecutive days the price was less than or equal to the current day's price).
Hint: Use a stack to keep track of indices of prices in descending order.*/

using System;

public class StockSpanner {
    private Stack<int> prices;
    private Stack<int> spans;

    public StockSpanner() {
        prices = new Stack<int>();
        spans = new Stack<int>();
    }

    public int Next(int price) {
        int span = 1;

        while (prices.Count > 0 && prices.Peek() <= price) {
            prices.Pop();
            span += spans.Pop();
        }

        prices.Push(price);
        spans.Push(span);

        return span;
    }
    public static void Main(string[] args)
    {
        StockSpanner stockSpanner = new StockSpanner();
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        foreach (int price in prices) {
            Console.WriteLine(stockSpanner.Next(price));
        }
    }
}
