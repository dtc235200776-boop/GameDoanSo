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
            int guess;
            bool isCorrect = false;
            while(!isCorrect)
            {
                Console.Write("Nhap so cua ban: ");
                guess = int.Parse(Console.ReadLine());
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so tu 1 den 100.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("So ban nho hon so bi mat.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("So ban lon hon so bi mat.");
                }
                else
                {
                    Console.WriteLine("Chuc mung! Ban da doan dung so bi mat.");
                    isCorrect = true;
                }
            }
            Console.ReadLine(); 
        }
    }
}
