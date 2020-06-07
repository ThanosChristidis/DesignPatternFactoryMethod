using System;


namespace PrinterWithFactoryMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {

            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("\tWelcome user to my online shop! I will help you to choose the most suitable printer depending on your profession");
                Console.WriteLine("\t So please tell me, what is your profession");
                Console.WriteLine("\t If you work in manufacture business, type 'manufacture business' ");
                Console.WriteLine("\t Else if you work in bookshop, type 'bookshop' ");
                Console.WriteLine("\t Else if you work in small business, type 'small business' ");
                Console.WriteLine("\t Or else if you work in conglomerate company, type 'conglomerate company' ");
                Console.Write("\t Otherwise type your profession: ");
                string occupation = Console.ReadLine();
                var printer = PrinterMethod.PrinterChoice(occupation);

                Console.WriteLine($"\tThe suitable printer for your {occupation} is {printer.GetType().Name}");

                do
                {
                    Console.WriteLine("\tDo you want to continue? -YES or NO?");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("\tInvalid choice, please say YES or NO");
                    }

                } while (UserChoice != "YES" && UserChoice != "NO");

            } while (UserChoice == "YES");

            Console.WriteLine("\tThank you for your preference to my shop!");
            Console.Read();
        }
    }

}
