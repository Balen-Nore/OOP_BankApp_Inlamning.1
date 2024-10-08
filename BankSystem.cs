namespace OOP_BankAPP_Inlamning._1
{
    public class Banksystem
    {
        private readonly Personkonto _personkonto;
        private readonly Sparkonto _sparkonto;
        private readonly Investeringskonto _investeringskonto;

        public Banksystem()
        {
            string användarNamn = "Balen";
            _personkonto = new Personkonto(1, användarNamn, 1000);
            _sparkonto = new Sparkonto(2, användarNamn, 5000);
            _investeringskonto = new Investeringskonto(3, användarNamn, 10000);
        }

        public void VisaSaldo()
        {
            Bankkonto valtKonto = VäljKonto();
            valtKonto?.VisaSaldo();
        }

        public void SättInPengar()
        {
            Bankkonto valtKonto = VäljKonto();
            if (valtKonto != null)
            {
                double belopp = LäsGiltigtBelopp("Ange belopp att sätta in: ");
                valtKonto.SättInPengar(belopp);
            }
        }

        public void TaUtPengar()
        {
            Bankkonto valtKonto = VäljKonto();
            if (valtKonto != null)
            {
                double belopp = LäsGiltigtBelopp("Ange belopp att ta ut: ");
                valtKonto.TaUtPengar(belopp);
            }
        }

        private Bankkonto VäljKonto()
        {
            Console.WriteLine("Välj konto:");
            Console.WriteLine("1. Personkonto");
            Console.WriteLine("2. Sparkonto");
            Console.WriteLine("3. Investeringskonto");

            switch (Console.ReadLine())
            {
                case "1":
                    return _personkonto;
                case "2":
                    return _sparkonto;
                case "3":
                    return _investeringskonto;
                default:
                    Console.WriteLine("Felaktigt val.");
                    return null;
            }
        }

        private double LäsGiltigtBelopp(string meddelande)
        {
            double belopp;
            Console.Write(meddelande);
            while (!double.TryParse(Console.ReadLine(), out belopp) || belopp <= 0)
            {
                Console.WriteLine("Ogiltigt belopp. Försök igen.");
                Console.Write(meddelande);
            }
            return belopp;
        }
    }

}
