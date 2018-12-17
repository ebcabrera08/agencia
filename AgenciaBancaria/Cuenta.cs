using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria
{
    /*
      Para cada cuenta se sabe su número único, el nombre del propietario, el tipo de cuenta (A, B o C), 
     * la fecha de apertura y la cantidad que deposita el cliente al abrir la cuenta
     */
    class Cuenta
    {
        //propiedades
        private string _numeroCuenta;
        private string _nombrePropietario;
        private char _tipoCuenta;
        private string _fechaCreada;
        private double _cantidadDepositada;

        //getter and setter
        public string NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }
        
        public string NombrePropietario
        {
            get { return _nombrePropietario; }
            set { _nombrePropietario = value; }
        }       

        public char TipoCuenta
        {
            get { return _tipoCuenta; }
            set { _tipoCuenta = value; }
        }        
        public string FechaCreada
        {
            get { return _fechaCreada; }
            set { _fechaCreada = value; }
        }     

        public double CantidadDepositada
        {
            get { return _cantidadDepositada; }
            set { _cantidadDepositada = value; }
        }
       
    }
}
