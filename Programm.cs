class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs(x) < 1)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += Math.Pow(x, 2*i + 1) / (2 * i + 1);
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Oшибка! |x| < 1");
        }
    }
}
