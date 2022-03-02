using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("............................");
            Console.WriteLine(".-------SALUD PRIMERO------.\n............................\n");
            Console.WriteLine("Por favor ingrese la opción que desea realizar \n 1.Consultar historial cliníco del paciente \n 2.Registrar nuevo paciente. \n 3.Salir");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("++++++++++++++++++++++++++++++++\n");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Bienevenio a los historiales clinicos \n por favor ingrese su contraseña");
                    int pasword = Convert.ToInt32(Console.ReadLine());
                    if (pasword == 123)
                    {
                        Console.WriteLine("********************************");
                        Console.WriteLine("*Contraseña correcta bienvenido*\n********************************");
                        Console.WriteLine("Que acción desea realizar \n 1.Revisar expediente \n 2. Consultar calendario de consulta. \n 3. salir ");
                        Console.WriteLine("----------------------------------------------");
                        int accion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------------------------\n");
                        switch (accion)
                        {
                            case 1:
                                Console.WriteLine("Bienvenido a la consulta de historiales clinicos \n");
                                break;
                            case 2:
                                Console.WriteLine("Aquí tiene sus proximas consultas");
                                break;
                            case 3:
                                Console.WriteLine("Hasta pronto\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("LA CONTRASEÑA ES INCORRECTA ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Escriba los datos del paciente");
                    break;
                case 3:
                    Console.WriteLine("}}}}}}}}}}}}}}}}}}}}Gracias por su preferencia {{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{");
                    break;

            }
            Console.ReadKey();
        }
    }
}