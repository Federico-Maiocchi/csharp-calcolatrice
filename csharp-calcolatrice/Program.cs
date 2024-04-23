namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testate tutti i metodi della vostra classe di helper(con un esempio per ogni casistica).
            int a = 5;
            int b = 10;

            Console.WriteLine($"Somma di due numeri interi: {CalcoliHelper.SumInt(a, b)}");
            Console.WriteLine($"Differenza tra due numeri interi: {CalcoliHelper.SubInt(a, b)}");
            Console.WriteLine($"Moltiplicazione di due numeri interi: {CalcoliHelper.MultiplicationInt(a, b)}");
            Console.WriteLine($"Valore assoluto di un numero intero: {CalcoliHelper.AbsoluteValueInt(a)}");
            Console.WriteLine($"Minimo tra due numeri interi: {CalcoliHelper.MinimumInt(a, b)}");
            Console.WriteLine($"Massimo tra due numeri interi: {CalcoliHelper.MaximunInt(a, b)}");

            double c = 2.4;
            double d = 12.64;

            Console.WriteLine($"Somma di due numeri double: {CalcoliHelper.SumDouble(c, d)}");
            Console.WriteLine($"Differenza tra due numeri double: {CalcoliHelper.SubDouble(c, d)}");
            Console.WriteLine($"Moltiplicazione di due numeri double: {CalcoliHelper.MultiplicationDouble(c, d)}");
            Console.WriteLine($"Valore assoluto di un numero double: {CalcoliHelper.AbsoluteValueDouble(c)}");
            Console.WriteLine($"Minimo tra due numeri double: {CalcoliHelper.MiniumDouble(c, d)}");
            Console.WriteLine($"Massimo tra due numeri double: {CalcoliHelper.MaximunDouble(c, d)}");


        }
    }
}
