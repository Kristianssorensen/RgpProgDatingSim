namespace Rgp_Prog_dating_sim;
using System;
using System.Collections.Generic;
using System.Threading;  // <-- needed for Thread.Sleep

public class Gamer
{
    public void GameStart()
    {
        // SetGamerStats(); //setter dine stats (husk at aktiver igen)
        SetScene(); // setter scenen
        convo convo = new convo();
        
        
        
    }
    

    
    public void Spørgsmål1()
    {
        Console.WriteLine("Du ser så godt ud iaften");
        Console.WriteLine("Vælg mulighed ");

        List<string> Svar = new List<string>();
        Svar.Add("1 Fuck dig din grimme so");
        Svar.Add("2 Knep?");

        foreach (string svar in Svar)
        {
            Console.WriteLine(svar);
        }

        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("IDK1");
            Spørgsmål2();
        }   
        if (input == "2")
        {
            Console.WriteLine("IDK2");
            Spørgsmål3();
        }   
    }

    public void Spørgsmål2()
    {
        Console.WriteLine("Spørgsmål2");
        Console.WriteLine("Vælg mulighed ");

        List<string> Svar2 = new List<string>();
        Svar2.Add("1 Fuck dig din grimme so");
        Svar2.Add("2 Knep?");

        foreach (string svar in Svar2)
        {
            Console.WriteLine(svar);
        }

        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("IDK1");
        }   
    }
    
    public void Spørgsmål3()
    {
        Console.WriteLine("Spørgsmål3");
        Console.WriteLine("Vælg mulighed ");

        List<string> Svar3 = new List<string>();
        Svar3.Add("1 svar 2");
        Svar3.Add("2 svar 2?");

        foreach (string svar in Svar3)
        {
            Console.WriteLine(svar);
        }

        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("IDK1");
            s
        }   
    }

    public void choosDate()
    {
        List<string> carectors = new List<string>();
        Console.WriteLine("hvem vil du godt på date med? tryk 1 for sofia eller fuck af med dig din taber");
        
    }
    public void SetGamerStats()
    {
        player player = new player();
        player.SetPlayerStats();
        player.tjekPlayStatsLower10(); 
        player.printPlayerStats();
    }
    public void SetScene()
    {
        string date = "Isabella";
        Console.WriteLine("Aftensolen falder stille mens i sætter jer ned ved bordet på resturant klopfer.");
        Console.WriteLine($"Du kigger {date} i øjnene");
    }
}