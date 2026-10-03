using BlaisePascal.LessonExample.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        
        /*
        Console.WriteLine("Inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente} nella classe 3E");

        Console.WriteLine("INserisci il tipo di spedizione");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("INserisci il numero di pacchi");
        int numeroPacchiComprati = int.Parse( Console.ReadLine() );

        int costoSpedizioneSingoloPacco = 5; //dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        
        
        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è: {costoTotale}");
        */

        Vehicle vehicle = new Vehicle("abc");
        //vehicle.LicensePlate = "abc";
        string license = vehicle.LicensePlate;

        Console.WriteLine(vehicle);
        Console.WriteLine(license);

    }
}
