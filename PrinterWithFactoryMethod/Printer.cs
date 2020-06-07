namespace PrinterWithFactoryMethod
{
    abstract class Printer
    {
        public abstract decimal VoltageConsumption();
        public abstract double Price();
        public abstract int PrintSpeedPerHour();
        public abstract double MaintainancePerYear();
    }


}
