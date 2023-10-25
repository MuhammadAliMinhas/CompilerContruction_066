using System;
using System.Collections.Generic;

class SymbolTable<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>>[] buckets;
    private int capacity;
    private int size;

    public SymbolTable(int capacity)
    {
        this.capacity = capacity;
        this.buckets = new List<KeyValuePair<TKey, TValue>>[capacity];
        this.size = 0;
    }

    private int Hash(TKey key)
    {
        return Math.Abs(key.GetHashCode()) % capacity;
    }

    public void Add(TKey key, TValue value)
    {
        int index = Hash(key);

        if (buckets[index] == null)
        {
            buckets[index] = new List<KeyValuePair<TKey, TValue>>();
        }

        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
            {
                throw new InvalidOperationException("Key already exists in the symbol table.");
            }
        }

        buckets[index].Add(new KeyValuePair<TKey, TValue>(key, value));
        size++;
    }

    public TValue Get(TKey key)
    {
        int index = Hash(key);

        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
        }

        throw new KeyNotFoundException($"Key '{key}' not found in the symbol table.");
    }

    public int Size()
    {
        return size;
    }
}

class Lab_5_Task_2
{
    static void Main(string[] args)
    {
        SymbolTable<string, int> symbolTable = new SymbolTable<string, int>(10);

        symbolTable.Add("Usama", 21);
        symbolTable.Add("Maan", 20);
        symbolTable.Add("Aladdin", 22);
        Console.WriteLine("This Task is done Using HashTables:: ");
        Console.WriteLine("Size of symbol table: " + symbolTable.Size());
        Console.WriteLine("Age of Usama is: " + symbolTable.Get("Usama"));
        Console.WriteLine("Age of Maan is: " + symbolTable.Get("Maan"));
        Console.WriteLine("Age of Aladdin is: " + symbolTable.Get("Aladdin"));

        try
        {
            Console.WriteLine("Value of w: " + symbolTable.Get("w"));
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
