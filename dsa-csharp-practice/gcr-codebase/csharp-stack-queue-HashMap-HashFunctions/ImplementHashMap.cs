using System;
using System.Collections.Generic;

public class CustomHashMap
{
    private const int InitialCapacity = 16;
    private LinkedList<KeyValuePair<int, int>>[] buckets;

    public CustomHashMap()
    {
        buckets = new LinkedList<KeyValuePair<int, int>>[InitialCapacity];
        for (int i = 0; i < InitialCapacity; i++)
        {
            buckets[i] = new LinkedList<KeyValuePair<int, int>>();
        }
    }

    public void Insert(int key, int value)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.Key == key)
            {
                bucket.Remove(node);
                bucket.AddLast(new KeyValuePair<int, int>(key, value));
                return;
            }
            node = node.Next;
        }

        bucket.AddLast(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach (var pair in bucket)
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }

        throw new KeyNotFoundException($"Key {key} not found");
    }

    public void Delete(int key)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.Key == key)
            {
                bucket.Remove(node);
                return;
            }
            node = node.Next;
        }

        throw new KeyNotFoundException($"Key {key} not found");
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key.GetHashCode()) % buckets.Length;
    }

    public void Print()
    {
        Console.WriteLine("HashMap Contents:");
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i].Count > 0)
            {
                Console.Write($"Bucket {i}: ");
                foreach (var pair in buckets[i])
                {
                    Console.Write($"({pair.Key}, {pair.Value}) ");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
    
    public static void Main(string[] args)
    {
        CustomHashMap customHashMap = new CustomHashMap();
        
        Console.WriteLine("=== Custom HashMap Demo ===");
        
        // Insert operations
        Console.WriteLine("Inserting key-value pairs...");
        customHashMap.Insert(1, 10);
        customHashMap.Insert(2, 20);
        customHashMap.Insert(3, 30);
        customHashMap.Insert(4, 40);
        customHashMap.Insert(5, 50);
        customHashMap.Insert(17, 170); // This will cause collision with key 1
        
        customHashMap.Print();

        // Get operations
        Console.WriteLine("Getting values:");
        Console.WriteLine($"Value for key 3: {customHashMap.Get(3)}");
        Console.WriteLine($"Value for key 17: {customHashMap.Get(17)}");
        Console.WriteLine();
        
        // Update operation
        Console.WriteLine("Updating key 3 with new value 300:");
        customHashMap.Insert(3, 300);
        customHashMap.Print();

        // Delete operation
        Console.WriteLine("Deleting key 2:");
        customHashMap.Delete(2);
        customHashMap.Print();
        
        // Try to get deleted key
        try
        {
            Console.WriteLine($"Trying to get deleted key 2: {customHashMap.Get(2)}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
