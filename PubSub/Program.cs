using System;

namespace PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            bool quit = false;
            Satelite selectedSatelite = null;

            Satelite sputnik1 = new Satelite("Sputnik1");
            Satelite iss = new Satelite("International Space Station");

            Planet earth = new Planet("Earth");
            Planet mars = new Planet("Mars");

            mars.Radar.Subscribe(sputnik1);
            mars.Radar.Subscribe(iss);

            Console.WriteLine("Interplanetary Broadcasting System (IBS) status: ONLINE");
            Console.WriteLine("=======================================================");
            
            while (selectedSatelite == null)
            {
                Console.WriteLine("Please choose a satelite to broadcast your message.");
                Console.WriteLine("1 - " + sputnik1.Name);
                Console.WriteLine("2 - " + iss.Name);

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        selectedSatelite = sputnik1;
                        break;

                    case "2":
                        selectedSatelite = iss;
                        break;

                    default:
                        Console.WriteLine("Satelite not found. Please choose a valid satelite.");
                        break;
                }

            }

            
            while (!quit)
            {
                Console.WriteLine("Enter your message to broadcast OR enter q to quit:");
                message = Console.ReadLine();

                if (message.ToLower() == "q")
                {
                    quit = true;
                    Console.WriteLine("Interplanetary Broadcasting System (IBS) shutting down...");
                    Console.WriteLine("Interplanetary Broadcasting System (IBS) status: OFFLINE");
                }
                else
                {
                    earth.Radar.SendMessage(selectedSatelite, message);
                }
            }

            mars.Radar.Unsubcribe(sputnik1);
            mars.Radar.Unsubcribe(iss);
        }
    }
}
