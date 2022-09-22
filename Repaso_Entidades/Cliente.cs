using System;
using System.Text;
namespace Repaso_Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCLiente _tipoDeCliente;


        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCLiente.SinTipo;
        }

        public Cliente(eTipoCLiente tipo) : this()
        {
            this._tipoDeCliente = tipo;
        }

        public Cliente(eTipoCLiente tipo, string nombre) : this(tipo)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            this._aliasParaIncognito = new Random().Next(1000, 9000).ToString();
        }

        public string GetAlias
        {
            get
            {
                if (this._aliasParaIncognito == "Sin alias")
                {
                    CrearAlias();
                    return this._aliasParaIncognito;
                }
                else
                {
                    return this._aliasParaIncognito;
                }
            }

        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre: {this._nombre}");
            sb.AppendLine($"Alias: {this.GetAlias}");
            sb.AppendLine($"Tipo de cliente: {this._tipoDeCliente}");
            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }

    }
}
