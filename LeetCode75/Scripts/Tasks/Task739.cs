namespace LeetCode75.Scripts;

public class Task739
{
    public Task739()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        var result = DailyTemperatures(temperatures);
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }

    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        var tempTrack = new Stack<int>();

        for (var i = temperatures.Length - 1; i >= 0; i--)
        {
            while (tempTrack.Count > 0 && temperatures[tempTrack.Peek()] <= temperatures[i])
            {
                tempTrack.Pop();
            }

            answer[i] = tempTrack.Count > 0 ? tempTrack.Peek() - i : 0;
            tempTrack.Push(i);
        }

        return answer;
    }
}