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

        public void ÖverförPengar()
        {
            Bankkonto frånKonto = VäljKonto("Välj konto att överföra från:");
            Bankkonto tillKonto = VäljKonto("Välj konto att överföra till:");
            if (frånKonto != null && tillKonto != null)
            {
                double belopp = LäsGiltigtBelopp("Ange belopp att överföra: ");
                frånKonto.ÖverförPengar(belopp, tillKonto);
            }
        }

        private Bankkonto VäljKonto(string meddelande = "Välj konto:")
        {
            Console.WriteLine(meddelande);
            Console.WriteLine("1. Personkonto");
            Console.WriteLine("2. Sparkonto");
            Console.WriteLine("3. Investeringskonto");

            return Console.ReadLine() switch
            {
                "1" => _personkonto,
                "2" => _sparkonto,
                "3" => _investeringskonto,
                _ => throw new InvalidOperationException("Ogiltigt val.")
            };
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
