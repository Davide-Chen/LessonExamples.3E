public class Program
{
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella classe 3E");

        int costoSpedizioneSingoloPacco = 5; //dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = 2;
        
        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è: {costoTotale}");
    }
}
