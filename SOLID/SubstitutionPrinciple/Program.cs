using System;
using System.Collections.Generic;

namespace SubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(100);
            CuentaBancaria cuenta2 = new CuentaBancaria(150);
            cuenta2.TranseferirMonto(cuenta1, 30);
            IList<IEstadoDeCuenta> estadosDeCuenta = new List<IEstadoDeCuenta>
            {
                new FormatoADeEstadoDeCuenta(cuenta1),
                new FormatoADeEstadoDeCuenta(cuenta2),
                new FormatoBDeEstadoDeCuenta(cuenta1),
                new FormatoBDeEstadoDeCuenta(cuenta2)
            };
            Imprimir imp= new Imprimir();
            imp.Print(estadosDeCuenta);
            Console.ReadLine();
        }
    }
}
