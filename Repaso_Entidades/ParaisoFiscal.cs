using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisoFiscales _lugar;
        static int _cantidadCuentas;
        static DateTime fechaInicioActividades;
        static ParaisoFiscal()
        {
            _cantidadCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            _listadoCuentas=new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisoFiscales lugar):this()
        {
            this._lugar = lugar;
        }
        public void MostrarParaiso()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"fecha de inicio de actividad: {fechaInicioActividades}");
            stringBuilder.AppendLine($"locacion: {this._lugar}");
            stringBuilder.AppendLine($"cantidad de cuentitas: {_cantidadCuentas}");
            stringBuilder.AppendLine("**********************LISTADO DE CUENTAS*******************************");
            foreach (CuentaOffShore c in _listadoCuentas)
            {
                stringBuilder.AppendLine($"dueño: {Cliente.RetornarDatos(c.Dueño)}");
                stringBuilder.AppendLine($"Numero de cuenta : {c.Saldo}");
                stringBuilder.AppendLine($"Saldo: {c.Saldo}");
            }
            Console.WriteLine(stringBuilder);
        }
        public static implicit operator ParaisoFiscal(eParaisoFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }
        public static ParaisoFiscal operator + (ParaisoFiscal f, CuentaOffShore cos)
        {
            if (f != cos)
            {
                f._listadoCuentas.Add(cos);
                Console.WriteLine("Se agrego la cuenta al paraiso");
                _cantidadCuentas++;
            }
            else
            {
                foreach (var item in f._listadoCuentas)
                {
                    item.Saldo+=cos.Saldo;
                }
            }
            return f;
        }
        public static ParaisoFiscal operator -(ParaisoFiscal f, CuentaOffShore cos)
        {
            if (f==cos)
            {
                f._listadoCuentas.Remove(cos);
                _cantidadCuentas--;
                Console.WriteLine("Se quito la cuenta del paraiso");
            }
            Console.WriteLine("no se quito la cuenta del paraiso porque no existe");
            return f;
        }
        public static bool operator == (ParaisoFiscal f, CuentaOffShore cos)
        {
            bool retorno = false;
            foreach (var item in f._listadoCuentas)
            {
                if (item==cos)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(ParaisoFiscal f, CuentaOffShore cos)
        {
            return !(f == cos);
        }

    }
}
