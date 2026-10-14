using BlaisePascal.LessonExample.ExampleVehicle.Domain;
using System;
using System.Collections.Generic;
using System.Text;
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

        try
        {
            Vehicle vehicle1 = new Vehicle("AA 000AA", 1, 50, 75);
            Console.WriteLine(vehicle1.LicensePlate);
            Console.WriteLine(vehicle1.OdometerKm);
            Console.WriteLine(vehicle1.DailyRate);
            Console.WriteLine(vehicle1.FuelLevelPercentage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }

        try
        {
            //Vehicle vehicle2 = new Vehicle(); //non esiste un costruttore senza parametri definito nella classe, quindi non è possibile creare un oggetto Vehicle senza passare almeno la targa come parametro
            Vehicle vehicle = new Vehicle("abc");
            string license = vehicle.LicensePlate;
            Console.WriteLine(license);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}