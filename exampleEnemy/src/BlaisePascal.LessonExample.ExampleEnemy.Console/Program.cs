using BlaisePascal.LessonExample.ExampleEnemy.Domain;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        Enemy enemy = new Enemy("Goblin", 100, 25);

        Console.WriteLine(enemy);

        Console.WriteLine($"Il nemico è vivo? {enemy.IsAlive()}");

        enemy.TakeDamage(30);

        Console.WriteLine(enemy);

        Console.WriteLine($"Il nemico è vivo? {enemy.IsAlive()}");

        Player player = new Player("Mario");

        player.AddExperience(150);

        Console.WriteLine($"Esperienza e livello dopo l'aggiunta: livello:{player.Level} e esperienza:{player.Experience}");

        player.AddGold(50);
        Console.WriteLine($"Oro del giocatore: {player.Gold}");

        player.TakeDamage(30);
        Console.WriteLine($"HP del giocatore dopo averne perso 30: {player.Health}");

        player.Heal(20);
        Console.WriteLine($"HP del giocatore dopo essersi curato di 20: {player.Health}");

        player.TakeDamage(100);
        Console.WriteLine($"Il giocatore è vivo? {player.IsAlive}");

        player.ResetHealth();

        player.ResetExperience();
        Console.WriteLine($"I punti HP e l'esperienza dopo il reset: HP: {player.Health} e EXP: {player.Experience}");
    }
}