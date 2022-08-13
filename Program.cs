using System;

namespace semana_3_proyecto_de_menu_con_estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Proyecto de menu sobre las estructuras");
            System.Console.WriteLine("Primer programa usando estructuras en modoconsola");
            System.Console.WriteLine("Presione cualquier tecla para continuar");

            System.Console.ReadKey();

            int repetir;

            do
            {
                Console.Clear();
                menu_interno();

                System.Console.WriteLine("Ingrese 1 para continuar el menu ");
                System.Console.WriteLine("ingrese 2 para salir del menu");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

                
             
        }

        private static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1- Ejemplo If");
            System.Console.WriteLine("2- Ejemplo Switch");
            System.Console.WriteLine("3- Ejemplo For");
            System.Console.WriteLine("4- Ejemplo While");
            System.Console.WriteLine("5- Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:

                    Programa_if();
                    break;

                case 2:

                    Programa_switch();
                    break;

                case 3:

                    programa_for();
                    break;

                case 4:

                    progama_while();
                    break;

                case 5:

                    programa_dowhile();
                    break;

               
              
                        


            }

        }
    }
}
