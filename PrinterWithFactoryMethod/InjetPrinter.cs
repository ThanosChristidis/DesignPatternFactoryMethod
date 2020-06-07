namespace PrinterWithFactoryMethod
{
    class InjetPrinter : Printer
    {
        public override decimal VoltageConsumption() => 16.67m;

        public override double Price() => 119.32d;

        public override int PrintSpeedPerHour() => 78;

        public override double MaintainancePerYear() => 42.93d;
    }


}
