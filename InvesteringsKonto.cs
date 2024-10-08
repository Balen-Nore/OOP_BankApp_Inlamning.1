namespace OOP_BankAPP_Inlamning._1
{
    public class Investeringskonto : Bankkonto
    {
        public Investeringskonto(int kontonummer, string kontoinnehavareNamn, double startSaldo)
            : base(kontonummer, kontoinnehavareNamn, startSaldo)
        {
        }

        public override void TaUtPengar(double belopp)
        {
            base.TaUtPengar(belopp);
            Console.WriteLine("Uttag från investeringskonto gjord.");
        }
    }

}
