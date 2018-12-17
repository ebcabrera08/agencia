using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria
{
    class Agencia
    {
        //propiedades
        private string _nombre;       
        private string _direccion;
        List<Cuenta> cuenta;       
        List<Trabajador> trabajador;

      
        //constructor
        public Agencia() {
            _nombre = "";
            _direccion = "";
            cuenta = new List<Cuenta>();
            trabajador = new List<Trabajador>();
        }

        //getter and setter
       
          public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public override string ToString()
        {
            return string.Format("Nombre: "+_nombre+" Direccion: "+_direccion);
        }
        internal List<Trabajador> Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }
        internal List<Cuenta> Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
    }
}
