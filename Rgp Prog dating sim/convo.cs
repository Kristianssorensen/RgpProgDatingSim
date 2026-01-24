using System;
using System.Collections.Generic;

namespace Rgp_Prog_dating_sim
{

    public class convo
    {
        private player PlayerRef;
        
        public int akwardnes = 4;
        public int DateMood = 5;

        public convo(player p) 
        {
            PlayerRef = p;
        }
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
                Spørgsmål1();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                TjekAkwardnes();
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål1();
            }
        }
        public void Spørgsmål1()
        {
            Console.WriteLine("(tjeneren kommer hen til bordet) Hvad kunne i tænke jer at spise");
            Console.WriteLine("Tast 1 for Spaghetti kødsovs");
            Console.WriteLine("tast 2 for Krokodille krydret med spermet fra en ged");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Spaghetti kødsovs");
                DateMood++;
                Spørgsmål2();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Krokodille krydret med spermet fra en ged");
                akwardnes++;
                DateMood--;
                Spørgsmål3();
            }
            TjekAkwardnes();
        }

        public void Spørgsmål2()
        {
            Console.WriteLine("Ej totalt hyggeligt ligesom i lady og vagabonden");
            Console.WriteLine("1 Ja nu mangler vi bare kysset");
            Console.WriteLine("2 Ja så bug dig ned og lad os tage den doggystyle");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("1 Ja nu mangler vi bare kysset");
                akwardnes--;
                DateMood++;
                Spørgsmål4();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Ja så bug dig ned og lad os tage den doggystyle");
                akwardnes++;
                DateMood--;
                Spørgsmål5();
            }
            TjekAkwardnes();
        }
        public void Spørgsmål3()
        {
            Console.WriteLine("Ej hvor var det mærkeligt sagt skat du simpelhen for meget");
            Console.WriteLine("1 Det må du virkelig undskylde skal nok opføre mig ordentligt");
            Console.WriteLine("2 Jeg gør hvad jeg vil");
            if (PlayerRef.strength > 3)
            {
                Console.WriteLine("Kast krokodillen efter hende");
                Environment.Exit(0);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("");
                akwardnes = 3;
                Spørgsmål6();
            }
            else if (choice == 2)
            {
                Console.WriteLine("");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål7();
            }
            TjekAkwardnes();
        }

        public void Spørgsmål4()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                Spørgsmål8();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål9();
            }
            TjekAkwardnes();
        }

        public void Spørgsmål5()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                Spørgsmål10();

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål11();
            }
            TjekAkwardnes();
        }

        public void Spørgsmål6()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                Spørgsmål12();

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål13();

            }
            TjekAkwardnes();
        }

        public void Spørgsmål7()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
                Spørgsmål14();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
                Spørgsmål15();
            }
            TjekAkwardnes();
        }

        public void Spørgsmål8()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");


            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål9()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål10()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål11()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål12()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål13()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;

            }
            TjekAkwardnes();
        }

        public void Spørgsmål14()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
            }
            TjekAkwardnes();
        }

        public void Spørgsmål15()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Iligemåde babe <3");
                akwardnes = 3;

            }
            else if (choice == 2)
            {
                Console.WriteLine("Okay. |: ");
                akwardnes = 5;
                DateMood = 3;
            }
            TjekAkwardnes();
        }

    }

}

