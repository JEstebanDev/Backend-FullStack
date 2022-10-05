using System;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria(100);
            CuentaBancaria cuenta1 = new CuentaBancaria(150);

            FormatoA formatoA = new FormatoA();
            FormatoB formatoB = new FormatoB();

            cuenta1.TranseferirMonto(cuenta, 30);
            
            Console.WriteLine(new EstadoDeCuenta(cuenta).GenerarEstadoDeCuenta(formatoA));
            Console.WriteLine(new EstadoDeCuenta(cuenta1).GenerarEstadoDeCuenta(formatoA));

            Console.WriteLine();

            Console.WriteLine(new EstadoDeCuenta(cuenta).GenerarEstadoDeCuenta(formatoB));
            Console.WriteLine(new EstadoDeCuenta(cuenta1).GenerarEstadoDeCuenta(formatoB));
            Console.ReadLine();
        }
    }
}
