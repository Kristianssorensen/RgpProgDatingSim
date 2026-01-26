using System;
using System.Collections.Generic;
using System.Threading;

namespace Rgp_Prog_dating_sim;


public class Gamer
{
    private player PlayerRef;   

    public void GameStart()
    {
        SetGamerStats();
        Thread.Sleep(2000);

        SetScene();
        Thread.Sleep(2000);

        convo convo = new convo(PlayerRef); 
        convo.startconvo();
    }

    public void choosDate()
    {
        List<string> characters = new List<string>();
        Console.WriteLine("Hvem vil du på date med?");
        Console.WriteLine("Tryk 1 for Sofia");
    }

    public void SetGamerStats()
    {
        PlayerRef = new player();          
        PlayerRef.SetPlayerStats();
        PlayerRef.tjekPlayStatsLower10();
        PlayerRef.printPlayerStats();
    }

    public void SetScene()
    {
        string date = "Isabella";
        Console.WriteLine("Aftensolen falder stille mens i sætter jer ned ved bordet på restaurant Klopfer.");
        Console.WriteLine($"Du kigger {date} i øjnene");
    }
}