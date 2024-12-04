namespace LeetCode75.Scripts;


public class Task649_2
{
    private Queue<char> _senats;
    private Queue<char> _checkedSenators;
    private Queue<char> _votedSenators;

    public Task649_2()
    {
        var result = PredictPartyVictory("RDD");
        Console.WriteLine(result);
    }

    private string PredictPartyVictory(string senate)
    {
        if (senate.Length == 1)
        {
            return senate.Equals("D") ? "Dire" : "Radiant";
        }

        _senats = new Queue<char>();
        _checkedSenators = new Queue<char>();
        _votedSenators = new Queue<char>();

        foreach (var character in senate)
        {
            _senats.Enqueue(character);
        }

        _checkedSenators.Enqueue(_senats.Dequeue());

        
        return CompareNeighbours();
    }

    private string CompareNeighbours()
    {
        string result;
        if (CheckStringForWinner(out result))
        {
            return result;
        }

        if (_senats.Count < 1)
        {
            CheckStringForWinner(out result);
            return result;
        }

        var previousSenator = _checkedSenators.Count < 1 ? _senats.Dequeue() : _checkedSenators.Dequeue();
        if (_senats.Count < 1 && _checkedSenators.Count < 1)
        {
            _checkedSenators.Enqueue(previousSenator);
            CheckStringForWinner(out result);
            return result;
        }

        var nextSenator = _senats.Dequeue();


        if (previousSenator.Equals(nextSenator))
        {
            _checkedSenators.Enqueue(previousSenator);
            _checkedSenators.Enqueue(nextSenator);
        }
        else
        {
            _senats.Enqueue(previousSenator);
        }

        result = CompareNeighbours();

        return result;
    }

    private bool CheckStringForWinner(out string result)
    {
        if (!_checkedSenators.Contains('D') && _senats.Count < 1)
        {
            {
                result = "Radiant";
                return true;
            }
        }

        if (!_checkedSenators.Contains('R') && _senats.Count < 1)
        {
            {
                result = "Dire";
                return true;
            }
        }

        result = "";
        return false;
    }
}