namespace LeetCode75.Scripts;

public class Task649
{
    private static Queue<char> _senats;

    public static void Dota2Senate()
    {
        var result = PredictPartyVictory("DDRRR");
        Console.WriteLine(result);
    }

    private static string PredictPartyVictory(string senate)
    {
        if (senate.Length == 1 )
        {
            return senate.Equals("D") ? "Dire" : "Radiant";
        }
        
        _senats = new Queue<char>();
    
        foreach (var character in senate)
        {
            _senats.Enqueue(character);
        }
    
        var cancellationToken = new CancellationTokenSource();
    
      //  while (!cancellationToken.IsCancellationRequested)
       // {
            if (CompareNeighbours(out var predictPartyVictory)) return predictPartyVictory;
       // }
    
        return "";
    }
    
    private static bool CompareNeighbours(out string predictPartyVictory)
    {
        if (!_senats.Contains('D'))
        {
            {
                predictPartyVictory = "Radiant";
                return true;
            }
        }
        else if (!_senats.Contains('R'))
        {
            {
                predictPartyVictory = "Dire";
                return true;
            }
        }

        var leftSenator = _senats.Dequeue();
        var rightSenator = _senats.Peek();
    
        if (leftSenator.Equals(rightSenator))
        {
            _senats.Enqueue(leftSenator);
            CompareNeighbours(out predictPartyVictory);
        }
        else
        {
            _senats.Dequeue();
            _senats.Enqueue(leftSenator);
        }

        CompareNeighbours(out predictPartyVictory);
        return true;
    }
}