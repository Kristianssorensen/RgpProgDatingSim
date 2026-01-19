using System;
using System.Collections.Generic;

namespace Rgp_Prog_dating_sim
{
    
    public class convo
    {
        public int akwardnes = 4;
        public int DateMood = 5;
       
        public void TjekAkwardnes()
        {
            if (akwardnes <= 0)
            {
                Console.WriteLine("Stemningen er helt død... daten er slut.");
                Environment.Exit(0);
            }
        }
    
        public void startconvo()
        {
            Console.WriteLine("Du ser godt ud i aften skat!");
            Console.WriteLine("tast 1 for Iligemåde babe <3 ");
            Console.WriteLine("tast 2 for Okay. |: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                TjekAkwardnes();
                Spørgsmål2();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                TjekAkwardnes();
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål3();
            }
        }
        
        public void Spørgsmål2()
        {
            Console.WriteLine("(tjeneren kommer hen til bordet) Hvad kunne i tænke jer at spise");
            Console.WriteLine("Tast 1 for Spaghetti kødsovs");
            Console.WriteLine("tast 2 for Krokodille krydret med spermet fra en ged");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Spaghetti kødsovs");
                DateMood+;
                Spørgsmål4();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Krokodille krydret med spermet fra en ged");
                akwardnes++;
                DateMood--;
                Spørgsmål5();
            }
        }
    
       
    
        public void Spørgsmål3()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                Spørgsmål2();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål3();
            }
        }