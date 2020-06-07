namespace PrinterWithFactoryMethod
{
    class SolidInkPrinter : Printer
    {
        public override decimal VoltageConsumption() => 11.21m;

        public override double Price() => 72.83d;

        public override int PrintSpeedPerHour() => 95;

        public override double MaintainancePerYear() => 52.846d;
    }


}
