namespace LeetCode75.Scripts;

public class Task2336
{
}

public class SmallestInfiniteSet
{
    private int _currentSmallestElement = 1;
    private HashSet<int> _removed = new();

    public SmallestInfiniteSet()
    {
        _currentSmallestElement = 1;
        _removed = new();
    }

    public int PopSmallest()
    {
        _removed.Add(_currentSmallestElement);
        var result = _currentSmallestElement;
        FindSmallest();
        return result;
    }

    public void AddBack(int num)
    {
        _removed.Remove(num);
        if (_currentSmallestElement > num)
        {
            _currentSmallestElement = num;
        }
    }

    private void FindSmallest()
    {
        _currentSmallestElement++;
        while (_removed.Contains(_currentSmallestElement))
        {
            _currentSmallestElement++;
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */