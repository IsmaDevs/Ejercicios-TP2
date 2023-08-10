using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2Lab_I
{
    class Program
    {

        static void Ejercicio1()
        {

            Console.Clear();

            int numero = 1; 

            Console.WriteLine($"La suma de los numeros del 1 al 100 son: "); 

            while (numero > 0 && numero <= 100)                                   
            {
                Console.WriteLine(numero); 

                numero++;
            } 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } 

        static void Ejercicio2()
        {
            Console.Clear();

            Console.WriteLine($"Los numeros impares del 1 al 100 son: ");  

                for (int numero = 1; numero <= 100;)                          
                {
                    Console.WriteLine($"{numero} "); 

                    numero = numero + 2; 
                } 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } 

        static void Ejercicio3()
        {
            Console.Clear();

            int num1 = 0; 
            int num2 = 0; 

            Console.Write("Ingrese el primer numero: "); 
            num1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine();
            Console.Write("Ingrese el segundo numero ahora: "); 
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"Los numeros pares que existen entre {num1} y {num2} son: "); 

            for (int i = num1; i <= num2; i++)               
            {
                if (i % 2 == 0 && i <= 100) 
                {
                    Console.Write($"{i}, ");
                } 
            } 

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio4()
        {

            Console.Clear();

            int num = -200; 

            Console.WriteLine();
            Console.WriteLine($"Los numeros multiplos de 6 desde el -200 hasta 300 son: "); 
            Console.WriteLine();
            Console.WriteLine();

            while (num >= -200 & num <= 300) 
            {
                
                if (num % 6 == 0) 
                {
                    
                    Console.WriteLine(num); 
                   
                } 

                num++; 

            } 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio5()
        {

            Console.Clear();

            int num = 0; 
            int num2 = 0;  
            string N = "No";
            string S = "Si"; 
            string respuesta; 

            while (num >= 0) 
            {

                Console.WriteLine();

                Console.Write("Ingrese un numero entero: "); 
                num = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Le gustaría seguir ingresando nuemros? (Si - No): ");
                respuesta = Console.ReadLine();

                Console.WriteLine();

                if (respuesta == S) 
                {
                    Console.WriteLine();
                    Console.WriteLine($"Suma Parcial: {num2 = num2 + num}");  
                }

                if (respuesta == N) 
                {
                    Console.WriteLine($"La suma total es: {num2 = num2 + num}"); 
                    break; 
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio6()
        {
            Console.Clear();

            int numero = 1; 
            int N = 0; 

            Console.Write("Ingrese por favor un numero mayor a 0: ");
            N = int.Parse(Console.ReadLine()); 
             
            if (N > 0) {

            for (int i = numero; i <= N; i++) 
            {

                Console.WriteLine(i); 

            } 
            
           } 

            else 
            {
                Console.WriteLine();
                Console.WriteLine("El numero debe ser mayor a 0");                                                       
            } 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio7()
        {
            Console.Clear();

            string usuario = "Lab1";
            string contraseña = "lab2023";
            string dato1;
            string dato2; 
            int Intentos = 0;

            while (Intentos <= 3) 
            {
            Console.Write("Ingrese el usuario por favor: ");
            dato1 = Console.ReadLine(); 

            Console.Write("Ahora ingrese la contraseña por favor: ");
            dato2 = Console.ReadLine(); 

                if (dato1 == usuario & dato2 == contraseña) 
                {                                           
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido profesor"); 
                   break; 

                } else  
                {
                    Console.WriteLine();
                    Console.WriteLine("Usuario o Contraseña incorrecta"); 
                    Console.WriteLine();
                }
                Intentos++; 

                if (Intentos == 3) 
                {
                    Console.WriteLine($"Demasiados intentos fallidos: {Intentos}"); 
                    break; 
                }
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio8()
        {
            int A = 5; 
            int B = 20;
            int num = 0; 

            Console.Write($"Ingrese un numero entero entre {A} y {B}: "); 
            num = int.Parse(Console.ReadLine()); 

            while (num >= 0) 
            {

                if (num >= A && num <= B)
                {                         
                    Console.WriteLine();
                    Console.WriteLine("Numero valido. ¡Bien hecho!"); 
                    break; 

                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Numero incorrecto");

                    Console.WriteLine();

                    Console.Write($"Ingrese nuevamente un numero entero entre {A} y {B}: "); 
                    num = int.Parse(Console.ReadLine()); 
                }
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio9()
        {
            int num = 0; 
            int num2 = 1; 

            Console.Write("Ingrese el numero de la tabla de multiplicar que desea ver (1 - 10): "); 
            num = int.Parse(Console.ReadLine()); 
            Console.WriteLine(); 
            

            if (num >= 1 && num <= 10) 
            {

            for (int i = num; i >= 1 & i <= 10 && num2 <= 10; num2++) 
                                                                                            
              {
                    Console.WriteLine($"{i} x {num2}: {i * num2}"); 
              }

            } else 
            {
                Console.WriteLine("Numero de Tabla de multiplicar no encontrada"); 
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio10()
        {
            Random random = new Random(); 
            int dado1 = random.Next(1, 7); 
            int dado2 = random.Next(1, 7); 
            int suma = dado1 + dado2; 

            Console.WriteLine("Resultado del lanzamiento:"); 
            Console.WriteLine("Dado 1: " + dado1); 
            Console.WriteLine("Dado 2: " + dado2); 
            Console.WriteLine("Suma: " + suma); 

            if (suma > 10) 
            {
                Console.WriteLine("¡Bien hecho jugador/a!"); 
            } 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio11()
        {

            Console.Clear();

            int[] contadorNumeros = new int[10]; 
            int contadorPares = 0; 
            int contadorImpares = 0; 
            int numero = 0; 


            while (true) 
            {
                Console.Write("Ingrese un número del 0 al 9 (N para terminar): "); 
                string entrada = Console.ReadLine();

                if (entrada.ToUpper() == "N") 
                {
                    break;
                }

                if (int.TryParse(entrada, out numero)) 
                {
                    if (numero >= 0 && numero <= 9) 
                    {
                        contadorNumeros[numero]++; 

                        if (numero % 2 == 0)
                        {
                            contadorPares++; 
                        }
                        else 
                        {
                            contadorImpares++;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Ingrese un número válido del 0 al 9."); 
                    }
                }
                else 
                {
                    Console.WriteLine("Ingrese un número válido del 0 al 9 o la letra N para terminar."); 
                }
            }

            Console.WriteLine("Cantidad de veces que se ingresó cada número:"); 
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Número " + i + ": " + contadorNumeros[i]);  
            }

            Console.WriteLine("Cantidad total de números pares: " + contadorPares); 
            Console.WriteLine("Cantidad total de números impares: " + contadorImpares); 

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio12()
        {

            Console.Clear();

            Console.Write("Ingrese un número entero mayor que 0: "); 
            int numero = int.Parse(Console.ReadLine()); 

            if (EsNumeroPrimo(numero)) 
            {
                Console.WriteLine();
                Console.WriteLine("El número ingresado es primo."); 
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("El número ingresado no es primo.");
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } 

        static bool EsNumeroPrimo(int numero) 
        {
            if (numero <= 1) 
            {
                return false; 

            }

            for (int i = 2; i <= Math.Sqrt(numero); i++) 
            {
                if (numero % i == 0) 
                {
                    return false; 

                }

            } 

            return true; 

        } 

        static void Ejercicio13()
        {

            Console.Clear();

            int votosC = 0; 
            int votosQ = 0; 
            int votosBlanco = 0;
            int totalVotos = 0; 

            while (true) 
            {
                Console.Write("Ingrese su voto (C - Candidato C, Q - Candidato Q, B - Blanco, N - Finalizar votación): "); 
                                                                                                                           
                string voto = Console.ReadLine().ToUpper(); 

                if (voto == "N") 
                {
                    break;  
                }

                switch (voto) 
                {
                    case "C": 
                        votosC++; 
                        totalVotos++; 

                        break; 

                    case "Q": 
                        votosQ++; 
                        totalVotos++; 

                        break; 

                    case "B":  
                        votosBlanco++; 
                        totalVotos++; 

                        break; 

                    default: 

                        Console.WriteLine("Voto no válido. Intente nuevamente."); 

                        break; 

                } 

            } 

            Console.WriteLine("Resultados de la votación:"); 

            Console.WriteLine("Cantidad de votos para el Candidato C: " + votosC); 
            Console.WriteLine("Cantidad de votos para el Candidato Q: " + votosQ);
            Console.WriteLine("Cantidad de votos en Blanco: " + votosBlanco); 
            Console.WriteLine("Total de votos: " + totalVotos); 

            double porcentajeC = (double)votosC / totalVotos * 100; 

            double porcentajeQ = (double)votosQ / totalVotos * 100;
                                                                    
            Console.WriteLine("Porcentaje de votos para el Candidato C: " + porcentajeC.ToString("0.00") + "%"); 

            Console.WriteLine("Porcentaje de votos para el Candidato Q: " + porcentajeQ.ToString("0.00") + "%"); 

            if (porcentajeC >= 45 && porcentajeC > porcentajeQ) 
            {                                                  
                Console.WriteLine("¡El Candidato C es el ganador!");
            }

            else if (porcentajeQ >= 45 && porcentajeQ > porcentajeC) 
            {
                Console.WriteLine("¡El Candidato Q es el ganador!");
            }
            else
            {
                Console.WriteLine("No hubo un ganador claro."); 
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        } 

        static void Main(string[] args)

        {
            // Ejercicio1(); ✔️
            // Ejercicio2(); ✔️
            // Ejercicio3(); ✔️
            // Ejercicio4(); ✔️
            // Ejercicio5(); ✔️
            // Ejercicio6(); ✔️
            // Ejercicio7(); ✔️
            // Ejercicio8(); ✔️
            // Ejercicio9(); ✔️
            // Ejercicio10(); ✔️
            // Ejercicio11(); ✔️
            // Ejercicio12(); ✔️
            // Ejercicio13(); ✔️


            Console.ReadKey();
        }
    }
}
