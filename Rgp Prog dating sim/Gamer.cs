namespace Rgp_Prog_dating_sim;

public class Gamer
{
    public void GameStart()
    {
        SetGamerStats();
        Convo();
    }

    public void Convo()
    {
        SetScene();
        
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

