using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria
{




    class Program
    {




        static void Main(string[] args)
        {
            
            //variables
            var menu = new Menu();
            List<Cuenta> cuenta = new List<Cuenta>();
            List<Trabajador> trabajador = new List<Trabajador>();
            Agencia agencia = new Agencia();
            string opcion = "";


            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("  ****BIENVENIDO(A) AL SISTEMA DE GESTION BANCARIA***  ");
                Console.WriteLine("Marque [0] para registrar los datos de la agencia, ");
                Console.WriteLine("Marque [1] para registrar una cuenta, ");
                Console.WriteLine("Marque [2] para registrar trabajador, ");
                Console.WriteLine("Marque [3] para listar todos los datos, ");
                Console.WriteLine("Marque [4] determinar cantidad de cuentas por tipo, ");
                Console.WriteLine("Marque [5] para obtener la cuenta de tipo A que menos saldo tenga, ");
                Console.WriteLine("Marque [6] para mostrar los datos de las cuentas de tipo B menor de un valor");
                Console.WriteLine("Marque [8] para dado un valor, (especialidad  y años de experiencia) obtener trabajadores");
                Console.WriteLine("Marque [9] para eliminar cuenta");
                Console.WriteLine("Marque [10] para eliminar trabajador");
                Console.WriteLine("Marque [11] para eliminar Agencia");
                Console.WriteLine("Marque [12] Obtener lista ordenada de Cuentas");

                Console.WriteLine("Marque [13] para terminar");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("  ****REGISTRAR/ACTUALIZAR AGENCIA BANCARIA*****  ");
                        Console.WriteLine("Entre nombre de la Agencia ");
                        agencia.Nombre = Console.ReadLine();
                        Console.WriteLine("Entre direccion de la Agencia ");
                        agencia.Direccion = Console.ReadLine();
                        Console.WriteLine("\n----------------------------------------------------");
                        Console.WriteLine("  ****AGENCIA CREADA**** ");
                        Console.WriteLine("  ****MARQUE UNA TECLA PARA IR AL MENU**** ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "1":
                        Cuenta cuentaAux = new Cuenta();
                        Console.Clear();
                        Console.WriteLine("  ****REGISTRAR CUENTA BANCARIA*****  ");
                        if (agencia.Nombre == "")
                        {// validar que la cuenta este creada.
                            Console.WriteLine("  ****DEBE REGISTRAR PRIMERO LA AGENCIA BANCARIA *****  ");
                            break;
                        }
                        //creacion de la cuenta
                        try
                        {
                            Console.WriteLine("Entre numero de la cuenta ");
                            cuentaAux.NumeroCuenta = Console.ReadLine();
                            Console.WriteLine("Entre Nombre del propietario ");
                            cuentaAux.NombrePropietario = Console.ReadLine();
                            Console.WriteLine("Entre tipo de cuenta (A)-(B)-(C) ");
                            cuentaAux.TipoCuenta = Convert.ToChar(Console.ReadLine());//convertir de string a char 
                            Console.WriteLine("Entre cantidad depositada ");
                            cuentaAux.CantidadDepositada = Convert.ToDouble(Console.ReadLine());//convertir a double
                            agencia.Cuenta.Add(cuentaAux);//agregar cuenta a la lista
                            //ordenando la lista
                            agencia.Cuenta=agencia.Cuenta.OrderByDescending(cu => cu.CantidadDepositada).ToList();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Error de formato, intente de nuevo ");
                            break;
                        }

                        Console.WriteLine("\n----------------------------------------------------");
                        Console.WriteLine("  ****CUENTA CREADA**** ");
                        Console.WriteLine("  ****MARQUE UNA TECLA PARA IR AL MENU**** ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Trabajador auxTrabaja = new Trabajador();
                        Console.Clear();
                        Console.WriteLine("  ****REGISTRAR TRABAJADOR*****  ");
                        if (agencia.Nombre == null)
                        {// validar que la cuenta este creada.
                            Console.WriteLine("  ****DEBE REGISTRAR PRIMERO LA AGENCIA BANCARIA *****  ");
                            break;
                        }
                        //creacion de la cuenta
                        try
                        {
                            Console.WriteLine("Entre nombre del trabajador ");
                            auxTrabaja.Nombre = Console.ReadLine();
                            Console.WriteLine("Entre No. identificacion del trabajador ");
                            auxTrabaja.NoIdentificacion = Console.ReadLine();
                            Console.WriteLine("Entre especialidad del trabajador");
                            auxTrabaja.Especialidad = Console.ReadLine();
                            Console.WriteLine("Entre sexo del trabajador");
                            auxTrabaja.Sexo = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Entre edad del trabajador");
                            auxTrabaja.Edad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Entre años de experiencia del trabajador");
                            auxTrabaja.AExperiencia = Convert.ToInt32(Console.ReadLine());
                            agencia.Trabajador.Add(auxTrabaja);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Error de formato, intente de nuevo ");
                            break;
                        }
                       
                        Console.WriteLine("\n----------------------------------------------------");
                        Console.WriteLine("  ****TRABAJADOR AGREGADO**** ");
                        Console.WriteLine("  ****MARQUE UNA TECLA PARA IR AL MENU**** ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("  ****DATOS GENERALES****  ");
                        if (agencia.Nombre == null||agencia.Trabajador.Count<1||agencia.Cuenta.Count<1)
                        {// validar que la cuenta este creada.
                            Console.WriteLine("  ****FALTAN ELEMENTOS POR REGISTRAR *****  ");
                            break;
                        }
                        Console.WriteLine("  ****AGENCIA *****  ");
                        Console.WriteLine("NOMBRE: "+agencia.Nombre+"  DIRECCION: "+agencia.Direccion+".");
                        Console.WriteLine("\n  ****CUENTAS *****  ");
                        for (int i = 0; i < agencia.Cuenta.Count;i++ )
                            Console.WriteLine("No.: " + agencia.Cuenta[i].NumeroCuenta + " PROPIETARIO: " + agencia.Cuenta[i].NombrePropietario + " TIPO: " + agencia.Cuenta[i].TipoCuenta + " FECHA: " + agencia.Cuenta[i].FechaCreada + " MONTO: " + agencia.Cuenta[i].CantidadDepositada + ".");
                        
                            Console.WriteLine("\n  ****TRABAJADORES *****  ");
                        for (int i = 0; i < agencia.Trabajador.Count;i++ )
                            Console.WriteLine("NOMBRE.: " + agencia.Trabajador[i].Nombre + " ESPECIALIDAD: " + agencia.Trabajador[i].Especialidad + " NO. ID.: " + agencia.Trabajador[i].NoIdentificacion + " EXPERIENCIA: " + agencia.Trabajador[i].AExperiencia + " EDAD: " + agencia.Trabajador[i].Edad + " SEXO: " + agencia.Trabajador[i].Sexo);
                                
                            break;
                    case "4":
                            int a=0, b=0, c=0;//CONTADORES TEMPORALES
                            for (int i = 0; i < agencia.Cuenta.Count; i++)
                            {
                                if (agencia.Cuenta[i].TipoCuenta == 'A' || agencia.Cuenta[i].TipoCuenta == 'a')
                                    a++;
                                if (agencia.Cuenta[i].TipoCuenta == 'B' || agencia.Cuenta[i].TipoCuenta == 'b')
                                    b++;
                                if (agencia.Cuenta[i].TipoCuenta == 'C' || agencia.Cuenta[i].TipoCuenta == 'c')
                                    c++;                           
                            }
                        Console.WriteLine("Existen \n " + a + " de tipo (A).\n " + b + " de tipo (B). \n " + c + " de tipo (C)");
                        Console.WriteLine("\n----------------------------------------------------");                  
                        Console.WriteLine("  ****MARQUE UNA TECLA PARA IR AL MENU**** ");
                        Console.ReadKey();
                        Console.Clear();

                            break;
                     case "5":
                            if (agencia.Cuenta.Count < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("  ****No existen cuentas creadas**** ");
                                break;
                            }
                            Cuenta cuentaAux2 = new Cuenta();
                            cuentaAux2.CantidadDepositada = 0;
                            foreach (Cuenta cuent in agencia.Cuenta)
                            {
                                if (cuentaAux2.CantidadDepositada > 0 && (cuent.TipoCuenta == 'A' || cuent.TipoCuenta == 'a'))
                                {
                                    cuentaAux2 = cuent.CantidadDepositada < cuentaAux2.CantidadDepositada ? cuent : cuentaAux2;
                                }
                                else
                                  if (cuent.TipoCuenta == 'A' || cuent.TipoCuenta == 'a')
                                            cuentaAux2 = cuent;
                            }//end for
                            if (cuentaAux2 != null)
                            {
                                Console.WriteLine("Cuenta (A) de menos saldo: No. {0} Propietario: {1}", cuentaAux2.NumeroCuenta, cuentaAux2.NombrePropietario);
                                break;
                            }
                            else { 
                            Console.WriteLine("NO EXISTEN CUENTAS EN ESTA CATEGORIA");
                                break;
                            }
                     case "6":
                            if (agencia.Cuenta.Count <= 0)// si no hay cuentas
                            {
                                Console.Clear();
                                Console.WriteLine("******No existen cuenta creadas******");
                                break;

                            }
                        //variables
                            List<Cuenta> aux = new List<Cuenta>();
                        double valor;
                         Console.Clear();

                        Console.WriteLine("  ****SALDO INFERIOR A UN VALOR*****  ");                        
                        try
                        {
                            Console.WriteLine("Entre el valor: ");
                            valor =Convert.ToDouble(Console.ReadLine());
                            foreach (Cuenta cuent in agencia.Cuenta)
                            {
                                if (cuent.CantidadDepositada < valor)
                                    aux.Add(cuent);
                            }

                            if (aux.Count > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Cuentas  menores de {0}", valor);
                                foreach (Cuenta cuAux in aux) {
                                    Console.WriteLine("Cuenta: No. {0}, Propietario: {1}, Saldo: {2}", cuAux.NumeroCuenta,cuAux.NombrePropietario,cuAux.CantidadDepositada);
                                    break;
                                }
                            }
                            else {
                                Console.Clear();
                                Console.WriteLine("No existen valores menores a {0}",valor);
                                break;
                            
                            }
                            break;
                        }catch(Exception e){

                            Console.WriteLine("Formato de valor incorrecto");
                            break;
                        }
                    case "8":
                        //Dado un valor, (especialidad estudiada y años de experiencia) obtener trabajadores
                         List<int> posiciones = new List<int>();
                        var espec = "";
                        var annosE = "";

                        Console.WriteLine("  ****BUSCAR TRABAJADOR*****  ");
                        Console.WriteLine("Entre especialidad del trabajador:");
                        espec= Console.ReadLine();
                        Console.WriteLine("Entre años de experiencia del trabajador:");
                        annosE = Console.ReadLine();
                        
                        for (int i = 0; i < agencia.Trabajador.Count; i++) {
                            if (agencia.Trabajador[i].Especialidad == espec && agencia.Trabajador[i].AExperiencia == Convert.ToInt32(annosE))
                            {
                                posiciones.Add(i);
                            }
                         }
                        if (posiciones.Count < 1)
                            Console.WriteLine("No se enontraron trabajadores para estos valores");
                        else { 
                           foreach(int pos1 in posiciones)
                               Console.WriteLine(agencia.Trabajador[pos1]);
                        }
                            break;
                    case "9":
                        //para eliminar una cuenta dado su número
                        if (agencia.Cuenta.Count <= 0)
                        {
                            Console.WriteLine("!!!NO EXISTEN CUENTAS!!!");
                            break;
                        }
                        
                        var cuentaNo = "";
                        Cuenta pos = new Cuenta();
                        Console.WriteLine("****ELIMINAR CUENTA");
                        Console.WriteLine("Entre el numero de la cuenta o escriba X para cancelar..");
                        cuentaNo = Console.ReadLine();
                        if (cuentaNo.ToUpper() == "X")
                            break;
                      
                        for (int i = 0; i < agencia.Cuenta.Count; i++)
                        {
                            if (agencia.Cuenta[i].NumeroCuenta == cuentaNo)
                                pos = agencia.Cuenta[i];
                        }
                        if (pos.NumeroCuenta != null)
                        {
                            agencia.Cuenta.Remove(pos);
                            Console.WriteLine("**** Cuenta eliminada correctamente ***** ");
                        }
                        else
                            Console.WriteLine("Lo siento no se encuentró la cuenta: ");

                            break;
                    case "10":
                        //para eliminar un trabajador de la agencia bancaria
                            if (agencia.Trabajador.Count <= 0)
                            {
                                Console.WriteLine("!!!NO EXISTEN TRABAJADORES!!");
                                break;
                            }
                         var IdentNo = "";
                        Trabajador posT = new Trabajador();
                        Console.WriteLine("****ELIMINAR TRABAJADOR");
                        Console.WriteLine("Entre el numero de Identificación del trabajador o escriba X para cancelar..");
                        IdentNo = Console.ReadLine();
                        if (IdentNo.ToUpper() == "X")
                            break;
                      
                        for (int i = 0; i < agencia.Trabajador.Count; i++)
                        {
                            if (agencia.Trabajador[i].NoIdentificacion == IdentNo)
                                posT = agencia.Trabajador[i];
                        }
                        if (posT.NoIdentificacion != null)
                        {
                            agencia.Trabajador.Remove(posT);
                            Console.WriteLine("**** Trabajador eliminado correctamente ***** ");
                        }
                        else
                            Console.WriteLine("Lo siento no se encuentró el trabajador: ");
                            break;

                    case "11":
                            //para eliminar la agencia bancaria
                            var elimA = "";
                            if (agencia.Nombre=="")
                            {
                                Console.WriteLine("!!!NO EXISTE CUENTA AUN!!");
                                break;
                            }
                            Console.WriteLine("Está a punto de eliminar la AGENCIA");
                            Console.WriteLine("Se elimininarán todos los datos");
                            Console.WriteLine("Marque (1) para continuar y otra tecla para cancelar..");
                            elimA = Console.ReadLine();
                            if (elimA == "1")
                            {
                                agencia = null;
                                agencia = new Agencia();
                               }

                            break;
                    case "":
                            Console.Clear();
                            break;
                    default:

                        break;

                }
            } while (opcion != "13");

            Console.ReadKey();
        }
    }
       
}
