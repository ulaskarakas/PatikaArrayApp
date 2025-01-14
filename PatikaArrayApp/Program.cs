public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Lütfen {i+1}. sayıyı yazınız: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array'in elemanları:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = 99;

        //Array.Reverse(numbers);
        Sorting(numbers);

        Console.WriteLine("Büyükten küçüğe array'in elemanları: ");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }

    static void Sorting(int[] array)
    {
        int n = array.Length;

        // Tüm elemanları karşılaştır
        for (int i = 0; i < n - 1; i++)
        {
            // Son sıralanmış elemanları dikkate alma
            for (int j = 0; j < n - i - 1; j++)
            {
                // Sıralı değilse yer değiştir
                if (array[j] > array[j + 1])
                {
                    // Swap
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

}