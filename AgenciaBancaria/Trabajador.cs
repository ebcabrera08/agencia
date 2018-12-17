using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria
{
    class Trabajador
    {
        /* 
         De cada trabajador que trabaja en la agencia se conoce su nombre, número de identificación,
         * especialidad estudiada, años de experiencia, edad y sexo.
         */
        //propiedades
        private string _nombre;
        private string _noIdentificacion;
        private string _especialidad;
        private int _aExperiencia;
        private int _edad;
        private char _sexo;

        //getter and setter
      
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
       
        public string NoIdentificacion
        {
            get { return _noIdentificacion; }
            set { _noIdentificacion = value; }
        }
        
        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }       
        public int AExperiencia
        {
            get { return _aExperiencia; }
            set { _aExperiencia = value; }
        }
        
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
     

        public char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        //metodo ToString sobrecargado
        public override string ToString()
        {
            return string.Format("Nombre: " + _nombre + "No. Identificación: " + _noIdentificacion + " Especialidad: " + _especialidad + " Años Experiencia: " + _aExperiencia+" Edad: "+_edad+" Sexo: "+_sexo);

        }
    }
}
