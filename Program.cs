using System;

namespace ClassDemoIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string ugedag = "mandag";

/*
            if (ugedag == "søndag")
            System.Console.WriteLine("Jubii søndag"); // sætning

            if (ugedag == "søndag")
            {
                System.Console.WriteLine("Jubii søndag"); // sætning
                // flere sætninger
            }

            if (ugedag != "søndag")
            {
                System.Console.WriteLine("ØV"); // sætning
                // flere sætninger
            }
            

            if (ugedag == "søndag")
            {
                // SANDT
                System.Console.WriteLine("Jubii søndag"); // sætning
                // flere sætninger
            }
            else{
                // FALSK
                System.Console.WriteLine("ØV"); // sætning
                // flere sætninger
            }

            bool solenSkinner = true;

            if (ugedag == "søndag")
            {
                if (solenSkinner) 
                // SANDT
                System.Console.WriteLine("Jubii onkel giver is "); // sætning
                // flere sætninger
            }


            if (ugedag == "søndag" && solenSkinner)
            {
                // SANDT
                System.Console.WriteLine("Jubii onkel giver is "); // sætning
                // flere sætninger
            }

            switch(ugedag){
                case "søndag": System.Console.WriteLine("Jubii søndag");
                                break;
                case "lørdag":  System.Console.WriteLine("Så skal vi i byen");
                                break;
                default : System.Console.WriteLine("Kedelig hverdag");
                            break;
                }
            

            for(int i = 0; i <10; i++){
                System.Console.WriteLine(i);
            }

            for (int i = 5; i>= 0 ; i--){
                System.Console.WriteLine("tæller baglæns " + i);
            }
            

            int i = 0;
            while (i < 10){
                System.Console.WriteLine(i);

                i++;
            }
            

            string str = "";
            while (str != "stop"){
                System.Console.WriteLine(str);

                str = Console.ReadLine();
            }
*/
            for(string str = ""; str != "stop"; str = Console.ReadLine()){
                System.Console.WriteLine(str);

            }


             


            Console.WriteLine("Hello World!");
        }
    }
}
