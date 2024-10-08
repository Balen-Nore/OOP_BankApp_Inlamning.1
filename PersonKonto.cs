namespace OOP_BankAPP_Inlamning._1
{
    public class Personkonto : Bankkonto
    {
        public Personkonto(int kontonummer, string kontoinnehavareNamn, double startSaldo)
            : base(kontonummer, kontoinnehavareNamn, startSaldo)
        {
        }

        public override void SättInPengar(double belopp)
        {
            base.SättInPengar(belopp);
            Console.WriteLine("Personkonto insättning gjord.");
        }
    }

}
