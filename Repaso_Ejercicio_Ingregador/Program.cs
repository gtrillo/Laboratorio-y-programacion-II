using System;
using Repaso_Entidades;
namespace Repaso_Ejercicio_Ingregador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gonzalo Trillo";//Cambiar por SU apellido y SU nombre
            Cliente mauri = new Cliente(eTipoCLiente.PoliticoCorrupto,
            "Mauri");
            Cliente fariña = new Cliente(eTipoCLiente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCLiente.JugadorDeFutbol,
            "Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro",
            eTipoCLiente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678,
            50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);
            ParaisoFiscal panamaPappers = eParaisoFiscales.Panama;
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}
