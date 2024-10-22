
namespace Task.CSharp.HashSet_;

public class HashSetClass<T>
{
    private HashSet<T> _hashSet;
    public HashSetClass() => _hashSet = new HashSet<T>();

    public bool AddElement(T element)
    {
        return _hashSet.Add(element);
    }

    // Remove element from the HashSet
    public bool RemoveElement(T element)
    {
        return _hashSet.Remove(element);
    }

    // Check if the HashSet contains a specific element
    public bool ContainsElement(T element)
    {
        return _hashSet.Contains(element);
    }

    // Perform a union operation with another set
    public void UnionWithSet(IEnumerable<T> otherSet)
    {
        _hashSet.UnionWith(otherSet);
    }

    // Perform an intersection operation with another set
    public void IntersectWithSet(IEnumerable<T> otherSet)
    {
        _hashSet.IntersectWith(otherSet);
    }

    // Perform an except operation with another set
    public void ExceptWithSet(IEnumerable<T> otherSet)
    {
        _hashSet.ExceptWith(otherSet);
    }

    // Get the count of elements in the HashSet
    public int GetCount()
    {
        return _hashSet.Count;
    }

    // Print all elements in the HashSet
    public void PrintElements()
    {
        Console.WriteLine("Elements in HashSet:");
        foreach (var item in _hashSet)
        {
            Console.WriteLine(item);
        }
    }
}