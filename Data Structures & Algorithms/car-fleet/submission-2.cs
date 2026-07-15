public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        List<(int position, int speed)> cars = new();

        for(int i = 0; i < position.Length; i++)
        {
            cars.Add((position[i], speed[i]));
        }

        cars.Sort((a, b) => b.position.CompareTo(a.position));

        Stack<double> stack = new Stack<double>();

        foreach (var car in cars)
        {
            double time = (double)(target - car.position) / car.speed;
            if (stack.Count == 0 || time > stack.Peek())
            {
                stack.Push(time);   
            }
        }
        return stack.Count;
    }
}
