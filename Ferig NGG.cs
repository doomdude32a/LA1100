namespace Stay_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;



            int Spielen = Convert.ToInt32(1);





            while (Spielen == 1)
            {




                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                          Zufallszahl Spiel                                 ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                int Zahl = Convert.ToInt32(new Random().Next(1, 100));
                Console.WriteLine("Geben sie ein Zahl ein");
                Console.Write("Zahl 1:");
                int eingabe = 0;
                bool check = false;
                int ana = Convert.ToInt32(0);

                while (eingabe != Zahl)
                {
                    ana++;
                    while (check == false)
                    {
                        try
                        {
                            eingabe = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.WriteLine("Geben sie bitte nur Zahlen ein");
                            check = false;
                        }
                    }
                    check = false;



                    if (eingabe > Zahl)
                    {

                        Console.WriteLine("Die Zufalszahl ist keiner als " + eingabe);

                    }
                    else
                    {

                        Console.WriteLine("Der Zufalszahl ist grösser als " + eingabe);

                    };
                    Console.WriteLine("Zahl {0}: ", ana);
                    if (eingabe == Zahl)
                    {
                        Console.WriteLine("Bravo, du hast es geschaft!!!"); Console.WriteLine("Du hast {0} mal versucht", ana);
                        Console.WriteLine("Willst du nochmal spielen?");
                    }

                }
                

                
               
                string erneut = Console.ReadLine();
                if (erneut == "ja")
                {
                    Spielen = Convert.ToInt32(1);
                }
                if (erneut == "nein")
                {
                    Spielen = Convert.ToInt32(0);
                }







            }
        }
    }
}