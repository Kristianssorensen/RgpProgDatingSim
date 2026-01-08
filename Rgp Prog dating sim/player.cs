using System;
namespace Rgp_Prog_dating_sim;

public class player
{
    public int height;
    public int charisma;
    public int strength;
    
    public void SetPlayerStats()
    {
        Console.WriteLine("Du skal sette dine stats. Højde, Charizzma, styrke. Skriv en værdig mellem 1-5, summen af dine stas må højest være 10");
        Console.WriteLine("Sæt højde: ");
        height = Convert.ToInt32(Console.ReadLine());
        if (height > 5 || height < 1)
        {
            Console.WriteLine("hvæm tror du du er det må højest være 5 din bums! du er du på højde med mathias");
            height = 1;
        }
        Console.WriteLine("Sæt Charizzma: ");
        charisma = Convert.ToInt32(Console.ReadLine());
        if (charisma > 5 || charisma < 1)
        {
            Console.WriteLine("hvæm tror du du er det må højest være 5 din bums! du har nu silases rizz!");
            charisma = 1;
        }
        Console.WriteLine("Sæt styrke: ");
        strength = Convert.ToInt32(Console.ReadLine());
        if (strength > 5 || strength < 1)
        {
            Console.WriteLine("hvæm tror du du er det må højest være 5 din bums! du knækker som den tændstik du er!");
            strength= 1;
        }
    }

    public void tjekPlaystatsLower10()
    {
        if (height + charisma + strength > 10)
        {
            Console.WriteLine("Din fucking bums summen måtte højets være 10, prøv igen din nød.");
            SetPlayerStats();
            tjekPlaystatsLower10();
        }
        else
        {
            return;
        }
    }
    
    /* test af github
    

}