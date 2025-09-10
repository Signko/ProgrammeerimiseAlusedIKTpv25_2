namespace VisualStudioTourHelloWorld
{
    internal class Program
    {
        static string AReallyCoolFunction()
        {
            /* 
             väga sekreetne funktsioon.
            töötab hästi minu arvutis aga kui sul ei tööta siis unluck
             */
            string VeryImportantPassword = "qwerty"; // väga oluline NDA stuff. donˇt share
            return VeryImportantPassword;
        }

        static void Main(string[] args)
        {
            /* int foo = 5;
            int bar = 6;

            Console.WriteLine(foo + bar);

            Console.WriteLine("Hello, World!");
            

            string SomethingVeryImportant = AReallyCoolFunction();
            Console.WriteLine(SomethingVeryImportant);

            int VeryImportantNumber = 5;
            float AnotherVeryImportantNumber = 5.2f;
            double YetAnotherVeryImportantNumber = 1.4;

            float esimene_tulemus = VeryImportantNumber + AnotherVeryImportantNumber;
            double tulemus = VeryImportantNumber + AnotherVeryImportantNumber + YetAnotherVeryImportantNumber;

            Console.WriteLine(esimene_tulemus);
            Console.WriteLine(tulemus);


            Console.WriteLine("Palun sisetage teie nimi: ");
            string yourname = Console.ReadLine();
            Console.WriteLine("Tere, " + yourname);
            */


            /*
            Console.WriteLine("sisestage numbri palun aitah");
            int teine_depends = int.Parse(Console.ReadLine());
            switch (teine_depends)
            {
                default:
                    Console.WriteLine("default case");
                    return;
                case 1:
                    Console.WriteLine("case 1");
                    return;
                case 69:
                    Console.WriteLine("nice");
                    return;
            }*/


            Console.WriteLine("Tere. Sisestage esimene number pls");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nüüd sisestage teine number");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Noh aga mis me teeme?");
            Console.WriteLine("1. liitmine (+)");
            Console.WriteLine("2. jagamine (/)");
            Console.WriteLine("3. korrutamine (*)");
            Console.WriteLine("4. lahutamine (-)");
            
            Console.WriteLine("Palun sisestage oma valik (1,2,3 või 4): ");
            int valik = int.Parse(Console.ReadLine());

            int tulemus = 0;
            
            if (valik == 1) { 
                tulemus = arv1 + arv2;
            }
            else if (valik == 2) {
                tulemus = arv1 / arv2;
            }
            else if (valik == 3) {
                tulemus = arv1 * arv2;
            }
            else if (valik == 4) {
                tulemus = arv1 - arv2;
            }
            else {
                throw new Exception("Vale valik. Proovige uuesti.");
            }



            Console.WriteLine("Tulemus: " + tulemus);
        }
    }
}
