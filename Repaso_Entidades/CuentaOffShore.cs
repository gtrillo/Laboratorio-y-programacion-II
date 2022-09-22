﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Entidades
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño
        {
            get { return this._dueño; }
        }

        public int NumeroCuenta
        {
            get { return this._numeroCuenta; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }


        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        }


        public CuentaOffShore(string nombre,eTipoCLiente tipo, int numero, double saldoInicial):this(new Cliente (tipo, nombre), numero, saldoInicial)
        {
           
        }
        
        public static explicit operator int (CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }
       
        public static bool operator == (CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;

            if(cos1.Dueño == cos2.Dueño && cos1._numeroCuenta == cos2._numeroCuenta)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
    }
}
