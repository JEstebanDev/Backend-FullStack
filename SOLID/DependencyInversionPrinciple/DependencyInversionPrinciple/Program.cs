using DependencyInversionPrinciple.Cuentas;
using DependencyInversionPrinciple.Estados;
using DependencyInversionPrinciple.Interfaces;
using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Imprimir(IList<IEstadoDeCuentaConPie> estadosDeCuenta)
        {
            foreach (IEstadoDeCuentaConPie estadoDeCuenta in estadosDeCuenta)
            {
                Console.WriteLine(estadoDeCuenta.GenerarEncabezado());
                Console.WriteLine(estadoDeCuenta.GenerarContenido());
                Console.WriteLine(estadoDeCuenta.GenerarPie());
                Console.WriteLine();
            }
        }
        static void Imprimir(IList<IEstadoDeCuenta> estadosDeCuenta)
        {
            foreach (IEstadoDeCuenta estadoDeCuenta in estadosDeCuenta)
            {
                Console.WriteLine(estadoDeCuenta.GenerarEncabezado());
                Console.WriteLine(estadoDeCuenta.GenerarContenido());
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ICuentaConMantenimiento cuenta1 = new CuentaCorriente(100);
            ICuentaBancaria cuenta2 = new CuentaAhorro(150);
            IList<IEstadoDeCuentaConPie> estadosDeCuentaConPie = new List<IEstadoDeCuentaConPie>
            {
                new FormatoADeEstadoDeCuenta(cuenta1),
                new FormatoADeEstadoDeCuenta(cuenta2)
            };
            IList<IEstadoDeCuenta> estadosDeCuentaSinPie = new List<IEstadoDeCuenta>
            {
                new FormatoBDeEstadoDeCuenta(cuenta1),
                new FormatoBDeEstadoDeCuenta(cuenta2)
            };
            Imprimir(estadosDeCuentaConPie);
            Imprimir(estadosDeCuentaSinPie);
            cuenta1.IncrementarIntereses();
            cuenta1.CalcularMatenimiento();
            cuenta2.IncrementarIntereses();
            Transferencia transferencia = new Transferencia(cuenta1, cuenta2, 30, new MoneyGram());
            transferencia.Tranferir();
            Imprimir(estadosDeCuentaConPie);
            Imprimir(estadosDeCuentaSinPie);
            Console.ReadLine();
        }
    }
}

