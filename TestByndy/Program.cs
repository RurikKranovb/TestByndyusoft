using System.Linq;

namespace TestByndy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var readConsole = ReadConsole();

                SumTwoMinimal twoMinimal = new SumTwoMinimal();

                var sum = twoMinimal.SumTwoMinimalMethod(readConsole);

                Console.WriteLine($"Сумма 2-ух минимальных чисел = {sum}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static IEnumerable<int>? ReadConsole()
        {
            IEnumerable<int>? value;

            Console.WriteLine("\nМассив не долже содержать символы." +
                              "\nМассив не должен быть пуст." +
                              "\nЧисла должны быть целыми." +
                              "\nМассив должен содержать более 2-ух элементов." +
                              "\nВведите массив, через пробел:");

            var read = Console.ReadLine();

            if (!string.IsNullOrEmpty(read) || read.Any(char.IsLetter) || read.Length < 2)
            {
                Console.WriteLine(
                    "\nМассив не долже содержать символы." +
                    "\nМассив не должен быть пуст." +
                    "\nЧисла должны быть целыми." +
                    "\nМассив должен содержать более 2-ух элементов.");
                ReadConsole();
            }

            value = read.Select(c => int.Parse(c.ToString())).ToArray();

            return value;
        }
    }
}
