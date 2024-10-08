namespace OOP_BankAPP_Inlamning._1
{
    public class Sparkonto : Bankkonto
    {
        public Sparkonto(int kontonummer, string kontoinnehavareNamn, double startSaldo)
            : base(kontonummer, kontoinnehavareNamn, startSaldo)
        {
        }

        public override void TaUtPengar(double belopp)
        {
            base.TaUtPengar(belopp);
            Console.WriteLine("Uttag från sparkonto gjord.");
        }
    }

}
