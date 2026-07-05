namespace GameDoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Game đoán số";
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("GAME DOAN SO");
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("Doan so tu 1 den 100");
            Console.WriteLine("Nhan Enter de bat dau!");
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            Console.WriteLine($"So bi mat la: {secretNumber}");
            Console.ReadLine(); 
        }
    }
}
