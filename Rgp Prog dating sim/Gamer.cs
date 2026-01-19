namespace Rgp_Prog_dating_sim;
using System;
using System.Collections.Generic;
using System.Threading;  // <-- needed for Thread.Sleep

public class Gamer
{
    public void GameStart()
    {
        // SetGamerStats(); //setter dine stats (husk at aktiver igen)
        SetGamerStats();
        Thread.Sleep(2000);
        SetScene(); // setter scenen
        Thread.Sleep(2000);
        convo convo = new convo();
        convo.startconvo();
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