namespace OOP_BankAPP_Inlamning._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banksystem banksystem = new Banksystem();
            bool körProgram = true;

            while (körProgram)
            {
                Console.WriteLine("\nVälkommen till bankapplikationen!");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Ta ut pengar");
                Console.WriteLine("4. Avsluta");

                Console.Write("Välj ett alternativ: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        banksystem.VisaSaldo();
                        break;
                    case "2":
                        banksystem.SättInPengar();
                        break;
                    case "3":
                        banksystem.TaUtPengar();
                        break;
                    case "4":
                        körProgram = false;
                        Console.WriteLine("Avslutar programmet...");
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        break;
                }
            }
        }
    }

}
