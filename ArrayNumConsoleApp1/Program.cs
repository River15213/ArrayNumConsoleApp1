namespace ArrayNumConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите количество строк в массиве: ");
            int inputLine = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int inputColumn = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________________________");
            int sumOne = 0;
            int sumTwo = 0;

            int[,] arrayNumOne = new int[inputLine, inputColumn];
            int[,] arrayNumTwo = new int[inputLine, inputColumn];


            for (int i = 0; i < inputLine; i++)
            {
                for (int j = 0; j < inputColumn; j++)
                {
                    arrayNumOne[i, j] = random.Next(10);
                    Console.Write($"{arrayNumOne[i, j]} ");
                    sumOne = sumOne + arrayNumOne[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Сумма первого массива = {sumOne}");
            Console.WriteLine("----------------------");


            for (int i = 0; i < inputLine; i++)
            {
                for (int j = 0; j < inputColumn; j++)
                {
                    arrayNumTwo[i, j] = random.Next(10);
                    Console.Write($"{arrayNumTwo[i, j]} ");
                    sumTwo = sumTwo + arrayNumTwo[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Сумма второго массива = {sumTwo}");
            Console.WriteLine("----------------------");


            for (int i = 0; i < inputLine; i++)
            {
                for (int j = 0; j < inputColumn; j++)
                {
                    var arraySum = arrayNumOne[i, j] + arrayNumTwo[i, j];
                    Console.Write($"{arraySum} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Сумма третьего массива = {sumTwo + sumOne}");
            Console.WriteLine("----------------------");

        }
    }
}
