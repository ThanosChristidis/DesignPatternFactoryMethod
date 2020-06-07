namespace PrinterWithFactoryMethod
{
    class LaserPrinter : Printer
    {
        public override decimal VoltageConsumption() => 13.83m;

        public override double Price() => 97.76d;

        public override int PrintSpeedPerHour() => 90;

        public override double MaintainancePerYear() => 60.833d;
    }


}
