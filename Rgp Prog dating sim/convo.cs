using System;

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
            Console.WriteLine("1: I lige måde babe <3");
            Console.WriteLine("2: Okay. |:");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                akwardnes--;
                DateMood++;
                Spørgsmål1();
            }
            if (choice == 2)
            {
                akwardnes++;
                DateMood--;
                Spørgsmål1();
            }
        }

        public void Spørgsmål1()
        {
            Console.WriteLine("(Tjeneren kommer) Hvad vil I spise?");
            Console.WriteLine("1: Spaghetti kødsovs");
            Console.WriteLine("2: Krokodille Krydret med Sperm");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                DateMood++;
                Spørgsmål2();
            }
            if ( choice == 2)
            {
                akwardnes++;
                DateMood--;
                Spørgsmål3();
            }

            TjekAkwardnes();
        }

        public void Spørgsmål2()
        {
            Console.WriteLine("Ej hvor hyggeligt  ligesom Lady og Vagabonden.");
            Console.WriteLine("1: Ja, mega romantisk");
            Console.WriteLine("2: Ja nu skal du har ha den i doggy");

            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (PlayerRef.charisma >= 4)
            {
                Console.WriteLine("3 Det eneste der kunne smage bedre ville være dig (; "); // rizzy with it
            } 
            if(PlayerRef.strength >= 4)
            {
                Console.WriteLine("4 Flex dine kæmpe muller for at imponere hende");
            }
            if(PlayerRef.height >= 4)
            {
                Console.WriteLine("5 rejs dig op for at height mog hende");
            }
                


            if (choice == 1)
            {
                DateMood += 2;
                Spørgsmål4();
            }
            if (choice == 2)
            {
                akwardnes++;
                Spørgsmål5();
            }

            if (choice == 3)
            {
                akwardnes--;
                EndingGood();
            }
            
            if (choice == 4)
            {
                
                akwardnes++;
                EndingBad();
                Console.WriteLine("du ik tuf bro");
            }
            
            if (choice == 5)
            {
                
                akwardnes++;
                Spørgsmål3();
            }
            
            
            

            TjekAkwardnes();
        }

        public void Spørgsmål3()
        {
            Console.WriteLine("Hun ser lidt forvirret ud over dit valg.");
            Console.WriteLine("1: Undskyld, dårlig joke");
            Console.WriteLine("2: Hold din kæft kælling");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                akwardnes--;
                Spørgsmål6();
            }
            if  (choice == 2)
            {
                akwardnes += 2;
                DateMood--;
                Spørgsmål7();
            }

            TjekAkwardnes();
        }

        public void Spørgsmål4()
        {
            Console.WriteLine("Samtalen flyder virkelig godt nu.");
            Console.WriteLine("1: Fortæl en sød historie");
            Console.WriteLine("2: Lav en joke om negere");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                DateMood += 2;
                EndingGood();
            }
            if  (choice == 2)
            {
                akwardnes++;
                EndingNeutral();
            }
        }

        public void Spørgsmål5()
        {
            Console.WriteLine("Stemningen bliver lidt akavet.");
            Console.WriteLine("1: Skift emne");
            Console.WriteLine("2: Bitch slap hende");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                akwardnes--;
                EndingNeutral();
            }
            if (choice == 2)
            {
                akwardnes++;
                EndingBad();
            }
        }

        public void Spørgsmål6()
        {
            Console.WriteLine("Hun smiler igen.");
            Console.WriteLine("1: Foreslå dessert");
            Console.WriteLine("2: Knep?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                DateMood++;
                EndingGood();
            }
            if  (choice == 2)
            {
                EndingNeutral();
            }
        }

        public void Spørgsmål7()
        {
            Console.WriteLine("Hun virker irriteret.");
            Console.WriteLine("1: Undskyld oprigtigt");
            Console.WriteLine("2: Bliv defensiv");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                akwardnes--;
                EndingNeutral();
            }
            if  (choice == 2)
            {
                akwardnes += 2;
                EndingBad();
            }
        }

        private void EndingGood()
        {
            Console.WriteLine("Det blev en virkelig vellykket date i tager hjem til hende og Knepper!");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠘⠹⣶⣿⠷⢃⡆⠻⢈⣿⣿\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢉⣴⣿⣷⢱⢠⡘⣿⣿\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣴⣿⠿⣫⣾⢈⣸⣷⠹⣿\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣤⣶⣾⣿⣿⣿⣷⣶⣶⣬⡩⣵⣿⣿⣿⡘⢹⣿⢠⣄\n⠄⠄⠄⠄⠄⠄⠄⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣮⢻⣿⣿⣞⡄⢿⣜⣿\n⠄⠄⠄⠄⠄⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⣿⣿⣋⠄⠙⠉⠛\n⠄⠄⠄⠄⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣷⠇⠄⠄⠄⠄\n⠄⠄⠄⠄⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠄⣿⡄⠄⠄⠄⠄\n⡀⠄⠄⢠⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠄⠄⠘⠇⠄⠄⠄⠄\n⣶⣾⣿⣷⡹⣿⣿⣿⣎⢿⣿⣿⣿⣿⣿⣿⣿⡿⠿⣛⣵⣿⣷⣶⣤⡀⠄⠄⠄⠄\n⣿⣿⣿⣿⣿⣮⣿⡿⠿⣛⣢⢩⣭⣭⣭⣭⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⠄⠄⠄⠄\n⣿⣿⣿⠿⣫⣾⣿⣿⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠄⠄⠄⠄\n⠿⢟⣭⣾⣿⣿⣿⣿⣿⣿⣿⣮⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠄⠄⠄⠄\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢛⣁⣀⣀⣀⣀⣀");
            Environment.Exit(0);
        }

        private void EndingNeutral()
        {
            Console.WriteLine("Det var en okay date.");
            Console.WriteLine("Måske ses I igen.");
            Environment.Exit(0);
        }

        private void EndingBad()
        {
            Console.WriteLine("Stemningen er helt Væk");
            Console.WriteLine("I går hver til sit og du gooner alene derhjemme.");
            Console.WriteLine("⡠⠖⠚⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠒⠢⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡤⠞⠁⢀⣠⣴⣶⣶⣶⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⣴⣶⣶⣶⣤⣀⡀⠉⠲⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⠁⠀⠀⠘⠉⠁⠀⠀⠉⠛⢾⣍⡛⢷⠀⠀⠀⠀⠀⠀⠀⢰⡾⢋⣵⠾⠋⠉⠀⠀⠈⠙⠂⠀⠀⠑⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⢀⡔⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⠾⡇⠀⠀⠀⠀⠀⠀⡿⠾⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⣄⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⢀⠎⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀⠀⢀⡤⠖⠉⠁⠀⠀⠀⠉⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⠋⠁⠀⠀⠀⠈⠙⠢⣄⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⢠⠋⠀⠀⠀⠀⠀⠀⣠⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⡜⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⡎⠀⠀⠀⠀⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⠀⠀⠀⠀⠀⠀⠀⢠⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⡄⠀⠀⠀⠀⠀⠈⡆⠀⠀⠀⠀\n⠀⠀⠀⠀⠸⠀⠀⠀⠀⠀⠀⢰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠀⠀⠀⠀⠀⠀⠀⠸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⡀⠀⠀⠀⠀⠀⠸⡀⠀⠀⠀\n⠀⠀⠀⢀⡇⠀⠀⠀⠀⠀⠀⡇⠀⠀⣀⠤⠔⢒⣂⣀⣀⣒⠲⢤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⢒⣊⣀⣀⣒⠒⠤⢄⠀⠀⠀⢇⠀⠀⠀⠀⠀⠀⣇⠀⠀⠀\n⠀⠀⠀⡸⠀⠀⠀⠀⠀⠀⠸⢀⢔⣨⣴⣿⣿⣿⣿⣿⣿⣿⣿⣷⣝⡄⠀⠀⠀⠀⠀⠀⠀⠀⣔⣵⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣐⢄⡸⠀⠀⠀⠀⠀⠀⢸⡀⠀⠀\n⠀⠀⡔⠁⠀⠀⠀⠀⠀⠀⠀⣵⡿⠛⢹⣿⣿⣿⣿⣿⣿⣿⠉⣻⠻⡏⠀⠀⠀⠀⠀⠀⠀⠈⣸⠋⢸⣿⣿⣿⣿⣿⣿⣿⠉⣻⠿⣷⣅⠀⠀⠀⠀⠀⠀⠀⠑⣄⠀\n⠀⡞⠀⠀⠀⠀⠀⠀⠀⠠⡾⡏⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⡟⠃⠀⣧⠀⠀⠀⠀⠀⠀⠀⢰⡇⠀⠈⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠈⣽⡆⠀⠀⠀⠀⠀⠀⠀⠘⡄\n⢸⠁⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⡀⠀⠀⠘⠐⠿⠿⠿⠟⠋⠀⣀⣴⠇⠀⠀⠀⠀⠀⠀⠀⠘⢳⣄⡀⠙⠐⠿⠿⠿⠟⠋⠀⠀⠀⣰⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⢱\n⠸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⢶⣶⣲⣶⣒⣲⣶⠾⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⠶⣶⣖⣲⣒⣲⣶⡾⠿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸\n⠀⠀⠀⠀⠀⠰⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡄⠀⠀⠀⠀⢀\n⢰⠀⠀⠀⠀⠀⠈⢷⣶⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠴⣾⡟⠀⠀⠀⠀⠀⢸\n⠸⡀⠀⠀⠀⠀⠀⠈⢿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠏⠀⠀⠀⠀⠀⠀⣸\n⠀⢣⠀⠀⠀⠀⠀⠀⠈⢻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⠋⠀⠀⠀⠀⠀⠀⢀⠇\n⠀⠈⢆⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣶⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⣴⣾⣿⡿⠃⠀⠀⠀⠀⠀⠀⢀⡞⠀\n⠀⠀⠘⢆⠀⠀⠀⠀⠀⠀⠀⠙⢿⣷⣍⣻⠛⠻⢷⣶⣖⣒⣤⣤⣤⣤⣤⣤⣴⣤⣤⣴⣶⣤⣤⣤⣤⣤⣒⣾⢷⠿⠛⠛⣏⠕⣿⠟⠀⠀⠀⠀⠀⠀⠀⢀⡜⠀⠀\n⠀⠀⠀⠈⢆⠀⠀⠀⠀⠀⠀⠀⠀⠻⡿⣿⣦⣀⠀⡇⠀⠀⠀⢸⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⢸⢀⣠⣾⣿⣶⡋⠀⠀⠀⠀⠀⠀⠀⢀⠎⠀⠀⠀\n⠀⠀⠀⠀⠈⠳⡀⠀⠀⠀⠀⠀⠀⠀⢹⠈⢻⣿⣿⣷⡤⢄⡀⢸⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⢸⡀⣀⡤⢴⣿⣿⣿⣿⠏⡏⡇⠀⠀⠀⠀⠀⠀⡴⠋⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠈⢦⡀⠀⠀⠀⠀⠀⣟⠀⠈⠙⣿⣿⠉⠀⠈⠉⠁⠐⠒⠒⠒⠚⠒⠒⠒⠒⡆⡞⠉⠀⠀⢸⣿⠿⢋⡼⠀⠙⠃⠀⠀⠀⠀⢠⠞⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠙⢦⡀⠀⠀⠀⢸⠀⢀⡀⠈⠻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⡇⠀⠀⠀⡸⠃⢠⢻⠡⠀⠀⠀⠀⠀⣠⠔⠁⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠲⣄⠀⠀⡇⢸⡏⠲⣄⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⢀⡇⣄⡾⣾⠇⠀⠀⢀⡠⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠢⡇⢸⡇⠀⢸⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡼⣸⠈⡼⡟⣀⠤⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⢸⠑⠒⠼⢦⣸⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣡⠤⢳⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢱⠀⡇⠀⠀⠀⢸⢉⡳⡀⢀⣴⡄⠀⠀⠀⠀⣀⠀⠀⣠⡾⠁⠀⠀⠀⡏⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠮⠶⠃⠀⠀⠀⠸⢸⠘⢽⠢⣉⠀⠀⠀⢀⠞⢀⠙⣯⠜⠁⠀⠀⠀⠀⠷⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣶⠇⠀⠁⠒⠭⠄⢶⡿⠦⠴⠊⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⠄⠒⠒⠒⠒⠀⠀⠀⠀⠀⠁⠀⠤⠤⠤⠤⠤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⢴⠒⠒⠀⠀⠉⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠁⠀⠒⠲⢤⡄⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠓⠒⠒⠦⠤⠶⠶⠶⠶⠶⣶⠒⠒⠒⠒⠒⠒⠂⠀⠤⠤⠖⠒⠚⠛⠛⠒⠒⠛⠛⠦⠤⠔⠒⠒⠒⠉⠉⠀⠀⠀⠀");
            Environment.Exit(0);
        }
    }
}
