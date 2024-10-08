namespace OOP_BankAPP_Inlamning._1
{
    public class Bankkonto
    {
        public int Kontonummer { get; }
        public string KontoinnehavareNamn { get; }
        public double Saldo { get; protected set; }

        // Konstruktor
        public Bankkonto(int kontonummer, string kontoinnehavareNamn, double startSaldo)
        {
            Kontonummer = kontonummer;
            KontoinnehavareNamn = kontoinnehavareNamn;
            Saldo = startSaldo;
        }

        // Insättning
        public virtual void SättInPengar(double belopp)
        {
            if (belopp <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
                return;
            }
            Saldo += belopp;
            Console.WriteLine($"Insättning av {belopp} gjordes. Ny saldo: {Saldo}.");
        }

        // Uttag
        public virtual void TaUtPengar(double belopp)
        {
            if (belopp <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
                return;
            }
            if (belopp > Saldo)
            {
                Console.WriteLine("Otillräckligt saldo.");
                return;
            }
            Saldo -= belopp;
            Console.WriteLine($"Uttag av {belopp} gjordes. Ny saldo: {Saldo}.");
        }

        // Visa saldo
        public void VisaSaldo()
        {
            Console.WriteLine($"Saldo för konto {Kontonummer} ({KontoinnehavareNamn}): {Saldo}.");
        }
    }

}
