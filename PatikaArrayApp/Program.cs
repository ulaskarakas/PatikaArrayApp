public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Please enter {i + 1}. number: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid value! Please enter a number: ");
            }
        }

        Console.WriteLine("Elements of array:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Array.Resize(ref numbers, numbers.Length + 1);

        Console.Write("Enter the number you want to add to array: ");
        while (!int.TryParse(Console.ReadLine(), out numbers[numbers.Length - 1]))
        {
            Console.Write("Invalid value! Please enter a number: ");
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("Elements of array from largest to smallest: ");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }

}