namespace Impuesto_sobre_la_renta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálcula tu Impuesto Sobre la Renta");
            Console.WriteLine();


            Console.WriteLine("Ingrese su sueldo");
            double sueldoMensual = double.Parse(Console.ReadLine());

            double sueldobrutoM = sueldoMensual * 0.0591;
            double sueldonetoM = sueldoMensual - sueldobrutoM;

            double sueldonetoanual = sueldonetoM * 12;



            if (sueldonetoanual <= 416220)
            {
                Console.WriteLine();
                Console.WriteLine("N/A");
            }
            else if (sueldonetoanual <= 624329)
            {
                double excedente = sueldonetoanual - 416220;
                double isrAnual = excedente * 0.15;
                double isrMensual = isrAnual / 12;

                Console.WriteLine($"Su ISR anual es: {isrAnual}");
                Console.WriteLine($"Su ISR mensual es: {isrMensual}");
            }
            else if (sueldonetoanual <= 867123)
            {
                double excedente = sueldonetoanual - 624329;
                double isrAnual = 31216 + (excedente * 0.20);
                double isrMensual = isrAnual / 12;

                Console.WriteLine($"Su ISR anual es: {isrAnual}");
                Console.WriteLine($"Su ISR mensual es: {isrMensual}");
            }
            else
            {
                double excedente = sueldonetoanual - 867123;
                double isrAnual = 79776 + (excedente * 0.25);
                double isrMensual = isrAnual / 12;


                Console.WriteLine();
                Console.WriteLine($"Tu ISR anual es: {isrAnual}");
                Console.WriteLine($"Tu ISR mensual es: {isrMensual}");
            }
        }
    }
}
