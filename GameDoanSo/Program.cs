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
            while (true)
            {
                Random random = new Random();
                int secretNumber = random.Next(1, 101);
                //Console.WriteLine($"So bi mat la: {secretNumber}");
                int guess;
                bool isCorrect = false;
                int dem = 0;
                while (!isCorrect)
                {
                    Console.Write("Nhap so cua ban: ");
                    if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Vui lòng nhập số!");
                        Console.ResetColor();
                        continue;
                    }
                    if (guess < 1 || guess > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("So ban nhap khong hop le. Vui long nhap so tu 1 den 100.");
                        Console.ResetColor();
                        continue;
                    }
                    dem++;
                    if (guess < secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("So ban nho hon so bi mat.");
                        Console.ResetColor();
                    }
                    else if (guess > secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("So ban lon hon so bi mat.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Chuc mung! Ban da doan dung so bi mat.");
                        Console.ResetColor();
                        Console.WriteLine($"So lan da doan: {dem}");
                        isCorrect = true;
                    }
                }
                string choice;
                while (true)
                {
                    Console.WriteLine("Ban co muon choi lai khong? (Y/N): ");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "Y" || choice == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap Y hoac N.");
                    }
                }
                if (choice == "N")
                {
                    Console.WriteLine("Cam on ban da choi!");
                    break;
                }
                Console.Clear();
            }
           
        }
    }
}
