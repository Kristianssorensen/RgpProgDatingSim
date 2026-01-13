namespace Rgp_Prog_dating_sim;

public class Gamer
{
    public void GameStart()
    {
        SetGamerStats();
        Thread.Sleep(3000);
        Convo();
        Thread.Sleep(3000);
        Spørgsmål();
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

    public void Spørgsmål()
    {
        Console.WriteLine("Du ser så godt ud iaften");
        
        Console.WriteLine(" Vælg mulighed ");
        
        List<string> Svar = new List<string>();
        Svar.Add(" 1 Fuck dig din grimme so");
        Svar.Add(" 2 Knep?");
        
        foreach (string svar in Svar)
        {
            Console.WriteLine(svar);
        }
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("IDK");
        }
        else if (input == "2")
        {
            Console.WriteLine("IDK");
        }
            
        
    }

        
    
    

