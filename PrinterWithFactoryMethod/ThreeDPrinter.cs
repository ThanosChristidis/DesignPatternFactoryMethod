namespace PrinterWithFactoryMethod
{
    class ThreeDPrinter : Printer
    {
        public override decimal VoltageConsumption() => 19.908m;

        public override double Price() => 363.55d;

        public override int PrintSpeedPerHour() => 150;

        public override double MaintainancePerYear() => 154.899d;
    }


}
