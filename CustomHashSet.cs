using System.Collections.Generic;
public class CustomHashSet<T>
{
    private readonly Dictionary<int, T> _items = new Dictionary<int, T>();

    public bool Add(T item)
    {
        var hashCode = item.GetHashCode();
        if (!_items.ContainsKey(hashCode) && !_items.ContainsValue(item))
        {
            _items.Add(hashCode, item);
            return true;
        }

        return false;
    }

    public bool Contains(T item)
    {
        var hashCode = item.GetHashCode();
        if (!!_items.ContainsKey(hashCode) && !!_items.ContainsValue(item))
            return true;

        return false;
    }
}