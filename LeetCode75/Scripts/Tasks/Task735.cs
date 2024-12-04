namespace LeetCode75.Scripts;

public class Task735
{
    private static readonly Stack<int> _leftStack = new();

    public static void AsteroidCollision()
    {
        int[] testCaseOne = [5, 10, -5];
        var result = CalculateCollision(testCaseOne);

       // Console.WriteLine(result.Length);
        foreach (var res in result)
        {
         //   Console.WriteLine(res); 
        }

        int[] testCaseTwo = [8,-8];
        int[] testCaseThree = [10,2,-5];
        int[] testCaseFour = [-2,-1,1,2];
        result = CalculateCollision(testCaseFour);
      //  Console.WriteLine(result.Length);
        foreach (var res in result)
        {
            Console.WriteLine(res); 
        }
    }

    private static int[] CalculateCollision(int[] asteroids)
    {
        _leftStack.Clear();

        foreach (var asteroid in asteroids)
        {
            CompareAsteroids(asteroid);
        }

        return  _leftStack.Reverse().ToArray();
    }

    private static void CompareAsteroids(int asteroid)
    {
        if (_leftStack.Count == 0)
        {
            _leftStack.Push(asteroid);
            return;
        }

        var left = _leftStack.Pop();

        if (left > 0 && asteroid < 0)
        {
            if (left == Math.Abs(asteroid))
            {
                return;
            }

            var res = left > Math.Abs(asteroid) ? left : asteroid;
            CompareAsteroids(res);
        }
        else
        {
            _leftStack.Push(left);
            _leftStack.Push(asteroid);
        }
    }
}