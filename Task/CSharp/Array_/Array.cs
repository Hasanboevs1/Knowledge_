using System;

namespace Task.CSharp.Array_;

public class ArrayClass
{
    private int[] _array;

    // Constructor to initialize the array
    public ArrayClass(int[] initialArray) => _array = initialArray;

    // Method to print all elements in the array
    public void PrintArray()
    {
        Console.WriteLine("Array elements:");
        foreach (var element in _array)
        {
            Console.WriteLine(element);
        }
    }

    // Method to sort the array
    public void SortArray()
    {
        Array.Sort(_array);
        Console.WriteLine("Array sorted.");
    }

    // Method to reverse the array
    public void ReverseArray()
    {
        Array.Reverse(_array);
        Console.WriteLine("Array reversed.");
    }

    // Method to find the index of an element
    public int FindElementIndex(int element)
    {
        int index = Array.IndexOf(_array, element);
        return index >= 0 ? index : -1;
    }

    // Method to resize the array
    public void ResizeArray(int newSize)
    {
        Array.Resize(ref _array, newSize);
        Console.WriteLine($"Array resized to {newSize} elements.");
    }

    // Method to add an element at the end (if resized)
    public void AddElementAtEnd(int element)
    {
        int currentSize = _array.Length;
        ResizeArray(currentSize + 1);
        _array[currentSize] = element;
        Console.WriteLine($"Element {element} added at the end.");
    }

    // Method to get the number of elements in the array
    public int GetArrayLength()
    {
        return _array.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Initialize the ArrayClass with some data
        int[] initialArray = { 10, 5, 20, 15 };
        ArrayClass arrayClass = new ArrayClass(initialArray);

        // Print the array
        arrayClass.PrintArray();

        // Sort the array and print it
        arrayClass.SortArray();
        arrayClass.PrintArray();

        // Reverse the array and print it
        arrayClass.ReverseArray();
        arrayClass.PrintArray();

        // Find the index of an element
        int elementToFind = 15;
        int index = arrayClass.FindElementIndex(elementToFind);
        if (index != -1)
        {
            Console.WriteLine($"Element {elementToFind} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Element {elementToFind} not found in the array.");
        }

        // Resize the array and add a new element
        arrayClass.AddElementAtEnd(25);
        arrayClass.PrintArray();

        // Print the current size of the array
        Console.WriteLine($"Array length: {arrayClass.GetArrayLength()}");
    }
}
