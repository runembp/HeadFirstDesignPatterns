using System.Collections;

namespace AdapterPattern.Iterators;

public class ArraylistIterator(List<string> list) : IEnumerator<string>
{
    public bool MoveNext()
    {
        var indexOfCurrent = list.FindIndex(x => x == Current);
        var isNextNullOrWhitespace = !string.IsNullOrWhiteSpace(list[indexOfCurrent++]);

        return isNextNullOrWhitespace;
    }

    public void Reset()
    {
        var thing = list.First();
    }

    public string Current { get; }

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        list.Clear();
    }
}