using System;

namespace practicando
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            do{

            } while (resp == "s" || resp == "s");

            int valor1 = 0; // Aca se almacena el primer valor ingresado
            int valor2 = 0; // Aca se almacena el segundo valor ingresado
            int R = 0; // Aca se  almacena el resultado de la operacion

            // Aca salen los mensajes para elegir que operacion hacer
            Console.WriteLine("Presione el simbolo para realizar la operacion:");

            Console.WriteLine("+ para sumar");
            Console.WriteLine("- para restar");
            Console.WriteLine("* para multiplicar");
            Console.WriteLine("/ para dividir");

            Console.WriteLine("Elija una opción"); 
            resp = Console.ReadLine();  // Aca guardo la operacion que desea hacer
            string eleccion = Convert.ToString(resp); // Se hace la convercion de caracter

            // Aca van los mensajes para ingresar los datos

            Console.WriteLine("Ingrese el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            switch (eleccion)
                {
                    case "+": //Simbolo que se seleciona del menu este indica la operacion.
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-": //Simbolo que se seleciona del menu este indica la operacion.
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*": //Simbolo que se seleciona del menu este indica la operacion.
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/": //Simbolo que se seleciona del menu este indica la operacion.
                        Console.WriteLine("El resultado de la division es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                }
                Console.WriteLine("Desea continuar? s/n "); // S para hacerlo nuevamente y N para salir
                resp = Console.ReadLine();
                
                while (resp == "s" || resp == "s" );
            }
            
        }
    }

