namespace PrinterWithFactoryMethod
{
    partial class Program
    {
        static class PrinterMethod
        {
            public static Printer PrinterChoice(string typeofcustomer)
            {
                if (typeofcustomer == "manufacture business") return new ThreeDPrinter();

                else if (typeofcustomer == "bookshop") return new LEDPrinter();

                else if (typeofcustomer == "small business") return new InjetPrinter();

                else if (typeofcustomer == "conglomerate company") return new LaserPrinter();

                else return new SolidInkPrinter();
            }
        }


    }


}
