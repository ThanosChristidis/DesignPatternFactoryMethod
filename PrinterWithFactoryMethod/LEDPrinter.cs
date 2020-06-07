namespace PrinterWithFactoryMethod
{
    class LEDPrinter : Printer
    {
        public override decimal VoltageConsumption() => 12.73m;

        public override double Price() => 185.87d;

        public override int PrintSpeedPerHour() => 178;

        public override double MaintainancePerYear() => 68.651d;
    }


}
