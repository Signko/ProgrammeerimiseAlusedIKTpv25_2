namespace VisualStudioTourHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere. Sisestage esimene number pls");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nüüd sisestage teine number");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Noh aga mis me teeme?");
            Console.WriteLine("1. liitmine (+)");
            Console.WriteLine("2. jagamine (/)");
            Console.WriteLine("3. korrutamine (*)");
            Console.WriteLine("4. lahutamine (-)");
            Console.WriteLine("5. Astendamine (^)");
            
            Console.WriteLine("Palun sisestage oma valik (1,2,3 või 4): ");
            int valik = int.Parse(Console.ReadLine());

            double tulemus = 0;
            
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
            else if (valik == 5) {
                tulemus = Math.Pow(arv1, arv2);
            }
            else {
                throw new Exception("Vale valik. Proovige uuesti.");
            }



            Console.WriteLine("Tulemus: " + tulemus);
        }
    }
}
