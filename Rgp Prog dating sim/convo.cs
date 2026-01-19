namespace Rgp_Prog_dating_sim;

public class convo
{
    public int akwardnes; //a meter for the akwardnes of the conversation and dertermens what you can and cant do
    public int DateMood; // a meter of how good the mood of the carettor your are dateing are
    public int playerMood; //a meter og the mood of the player

    void startconvo()
    {
        Console.WriteLine("Du ser godt ud i aften skat!");
        Console.WriteLine("tast 1 for ... ");
        Console.WriteLine("tast 2 for ... ");
        if (Convert.ToInt32(Console.ReadLine()) == 1)
        {
            Console.WriteLine("Svar 1");
            
        }

    }

}