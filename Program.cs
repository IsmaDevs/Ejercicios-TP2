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

            int numero = 1; //declaramos la variable con un tipo de dato entero y le asignamos el valor de 1.

            Console.WriteLine($"La suma de los numeros del 1 al 100 son: "); // Le indicamos por pantalla cuales son los numeros del 1 al 100

            while (numero > 0 && numero <= 100) // Realizamos un clico While en el cual si "numero" es mayor a 0 y menor o igual a 100 que 
                                                  // nos muestre los numeros que se van sumando con el contador "numero++;" hasta llegar a 100.   
            {
                Console.WriteLine(numero); // Le mostramos por la pantalla de la consola los numeros del 1 al 100.

                numero++; // Aquí se van sumando los numeros, variable rol contador.

            } // fin del while

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } //fin de la función.

        static void Ejercicio2()
        {
            Console.Clear();

            Console.WriteLine($"Los numeros impares del 1 al 100 son: "); //Realizamos un Console.Write para mostrar o indicar en pantalla los numeros impares. 

                for (int numero = 1; numero <= 100;) //Colocamos un for en el cual declaramos una variable de tipo entero y con un valor de 1.
                                                     // En el mismo for también colocamos de que la variable "numero" tiene que ser menor o igual a 100. 
                {
                    Console.WriteLine($"{numero} "); // Mostrara los numeros impares del 1 al 100, al ser impares sera hasta 99.

                    numero = numero + 2; //ponemos un contador para que se vayan sumando los numeros de a dos para que resulte ser un numero impar ya que el valor inicial es 1. 

                } // fin del for

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } //fin de la función

        static void Ejercicio3()
        {
            Console.Clear();

            int num1 = 0; //Declaramos la primera variable como "num1" de tipo entero y con un valor inical de 0. 
            int num2 = 0; //Aquí declaramos la segunda variable como "num2" y con el mismo tipo y valor inicial que la primera variable.

            Console.Write("Ingrese el primer numero: "); //Aquí le indicamos por pantalla que debe ingresar un numero
            num1 = int.Parse(Console.ReadLine()); // Tomamos el valor del numero ingresado por el usuario

            Console.WriteLine();
            Console.Write("Ingrese el segundo numero ahora: "); //Mismo procedimiento, indicamos que ingrese ahora un segundo numero.
            num2 = int.Parse(Console.ReadLine()); // Tomamos el valor del segundo numero ingresado por la persona.

            Console.WriteLine();
            Console.Write($"Los numeros pares que existen entre {num1} y {num2} son: "); // Aquí mostramos el mensaje por pantalla del resultado final...

            for (int i = num1; i <= num2; i++) // Realizamos un for en el cual la variable num1 se le asignara a la variable " i ".
                                               // La variable i pasara por una verificación de que si es menor o igual a num2 entonces se ira sumando: i++ (Rol contador).
            {
                if (i % 2 == 0 && i <= 100) // Colocamos un if en el cual i sea multiplo de 2 con un resto de 0 y también le asignamos un rango
                                            // en el cual debe ser i menor o igual a 100, por lo tanto la suma maxima de numeros sera 100.
                {
                    Console.Write($"{i}, "); // Por ultimo, imprimimos los numeros pares de los valores ingresados por el usuario.

                } // fin del if

            } // fin del ciclo while

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio4()
        {

            Console.Clear();

            int num = -200; // Declaramos la variable num con un valor de -200 y tipo de dato entero.

            Console.WriteLine();
            Console.WriteLine($"Los numeros multiplos de 6 desde el -200 hasta 300 son: "); // Aquí se indicara en pantalla cuales son los numeros multiplos de 6 desde -200 al 300
            Console.WriteLine();
            Console.WriteLine();

            while (num >= -200 & num <= 300) // Realizamos un ciclo while en el cual num tiene que ser mayor o igual a -200 y menor a 300
                                             // Esto se lo hace para que tenga un rango limite, ya que si no colocamos esto el programa seguira sumando numeros infinitamnete.
            {
                
                if (num % 6 == 0) // Hacemos un if en el cual si el num es multiplo de 6 y de un resto de 0 se iran mostrando los numeros multiplos.
                {
                    
                    Console.WriteLine(num); //Aquí se imprimen los numeros multiplos de 6.
                   
                } // Fin del if

                num++; // Por ultimo, se realiza una variable con rol contador para que se vayan sumando los numeros hasta el 300

            } // Fin del cichlo while

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio5()
        {

            Console.Clear();

            int num = 0; // Declaramos una variable de tipo entero con un valor de 0 llamada num
            int num2 = 0;  // Ahora declaramos otra variable de nombre num2 de tipo de dato entero y un valor de 0
            string N = "No"; // Ahora declaramos variables de tipo string llamada N con un valor de "No".
            string S = "Si"; // y aquí lo mismo, una variable de tipo string llamada S con un valor de "Si"
            string rep; // Por ultimo, una variable de tipo string sin un valor definido ya que sera una variable que tomara datos del usuario.


            while (num >= 0) // Hacemos un ciclo while si num es mayor o igual a 0, se entrara al ciclo
            {

                Console.WriteLine();

                Console.Write("Ingrese un numero entero: "); // Le indicamos al usuario que ingrese un numero entero
                num = int.Parse(Console.ReadLine()); // Aquí la variable num tomara el dato del usuario.

                Console.WriteLine();

                Console.Write("Le gustaría seguir ingresando nuemros? (Si - No): "); // Le enviamos un mensaje preguntando si desea seguir ingresando numeros
                rep = Console.ReadLine(); // la variable rep registrara la repuesta del usuario

                Console.WriteLine();

                if (rep == S) // Hacemos un if, si la variable rep es igual a S le enviara un mensaje por la consola.
                {
                    Console.WriteLine();
                    Console.WriteLine($"Suma Parcial: {num2 = num2 + num}");  // Aquí le mostramos el mensaje de la Suma parcial de los numeros ingreados por él.
                }

                if (rep == N) // Si la rep es igual a N, cortara el ciclo y enviara un mensaje.
                {


                    Console.WriteLine($"La suma total es: {num2 = num2 + num}"); // Le enviamos el mensaje de la Suma total de los numeros ingresados por el usuario.

                    break; // Hacemos un break para romper el ciclo en el caso que la repuesta del usuario haya sido No
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio6()
        {
            Console.Clear();

            int numero = 1; // Declaramos la variable numero con valor 1 y tipo de dato entero.
            int N = 0; // Declaramos otra variable con un valor predeterminado que es 0 y el tipo de dato entero

            Console.Write("Ingrese por favor un numero mayor a 0: "); // Aquí le indicamos al usuario que debe ingresar un numero
            N = int.Parse(Console.ReadLine()); // El programa tomara el valor o numero ingresado por el usuario
             
            if (N > 0) { // Hacemos un if para verificar si el numero es mayor a 0

            for (int i = numero; i <= N; i++) // Si el numero es mayor a 0, entrara por un for en el cual contara del 1 al numero ingresado por el usuario.
            {

                Console.WriteLine(i); // Mostrara por pantalla los numeros del 1 al N

            } // fin del for
            
           } // fin del if

            else // Hacemos un else en caso que el numero que haya ingreado no haya sido mayor a 0.
            {
                Console.WriteLine();
                Console.WriteLine("El numero debe ser mayor a 0"); // Aquí mostrara un mensaje por pantalla que le indica al usuario que el numero debe ser mayor a 0
                                                                   // para que se pueda ejecutar el programa.
            } // Fin de else

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio7()
        {
            Console.Clear();

            string usuario = "Lab1"; // Declaramos una variable de nombre "usuario" con un tipo de dato string y que tenga un valor el cual es "Lab1"
            string contraseña = "lab2023"; // Declaramos una segunda variable con un tipo de dato string y que su valor sea "lab2023"
            string dato1; // Aquí declaramos la variable dato1 como tipo entero, sera una variable que almacenara datos del usuario
            string dato2; // Esta es otra variable igual a dato1.
            int Intentos = 0; // Declaramos una variable llamada "Intentos" con tipo de dato entero y con un valor inicial de 0.

            while (Intentos <= 3) // Hacemos un ciclo while en el cual se entrara si los intentos son menor o igual a 3
            {
            Console.Write("Ingrese el usuario por favor: "); // Le pedimos al usuario que ingrese el usuario.
            dato1 = Console.ReadLine(); // La variable dato1 almacenara lo que escribio el usuario.

            Console.Write("Ahora ingrese la contraseña por favor: "); // Ahora le indicamos que ingrese su contraseña
            dato2 = Console.ReadLine(); // y la variable dato2 almacenara también lo que haya escrito el usuario.

                if (dato1 == usuario & dato2 == contraseña) // Hacemos un if en el cual si dato1 es igual a usuario y dato2 igual a contraseña
                {                                           // entonces enviara un mensaje.
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido profesor"); // Aquí le enviamos un mensaje de "Bienvenido profesor"
                   break; // Hacemos un break para romper el ciclo en el caso de que los datos ingresados sean correctos

                } else  // Hacemos un else, si los datos no fueron los correctos le enviaremos un mensaje.
                {
                    Console.WriteLine();
                    Console.WriteLine("Usuario o Contraseña incorrecta"); // Le enviamos un mensaje diciendo que el usuario o contraseña fueron incorrectos
                    Console.WriteLine();
                }
                Intentos++; // Hacemos que la variable Intentos tenga un rol contador para que vaya contando los intentos fallidos del usuario.

                if (Intentos == 3) // Si los intentos fallidos del usuario llegan a 3 se le enviara un mensaje.
                {
                    Console.WriteLine($"Demasiados intentos fallidos: {Intentos}"); // Le enviamos un mensaje diciendo que fueron demasiados intentos fallidos
                                                                                    // y le mostramos la cantidad (el numero) de intentos.

                    break; // Ponemos un break para cuando los intentos lleguen a ser igual a 3
                }
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio8()
        {
            int A = 5; // Declaramos la variable de tipo de dato entero con un valor de 5 que sera el numero minimo en el programa
            int B = 20; // Aquí también declaramos una variable de tipo de dato entero con un valor de 20 que este numero sera el máximo en el programa
            int num = 0; // Declaramos una variable de tipo entero con un valor de 0, ya que esta variable almacenara datos ingresados por el usuario.

            Console.Write($"Ingrese un numero entero entre {A} y {B}: "); // Le indicamos al usuario que ingrese un numero entero entre las variables A (5) y B (20).
            num = int.Parse(Console.ReadLine()); // En esta parte almacenara el numero ingresado por el usuario en la variable num.

            while (num >= 0) // Hacemos un ciclo en el cual se entrara si el numero es mayor o igual a 0 ya que no puede ser un numero negativo en el programa.
            {

                if (num >= A && num <= B) // Hacemos un if en el que si el numero es mayor o igual a A (5) y menor o igual a B (20) se enviara un mensaje
                {                         // de que el numero es valido.  
                    Console.WriteLine();
                    Console.WriteLine("Numero valido. ¡Bien hecho!"); // Enviamos/Mostramos el mensaje al usuario de que el numero que ingreso es valido.
                    break; // Hacemos un break para cuando el numero sea valido rompa el ciclo.

                } else // Realizamos un else en el caso que el numero ingresado no este entre las variables A y B
                {
                    Console.WriteLine();
                    Console.WriteLine("Numero incorrecto"); // Le mostramos por pantalla al usuario que el numero que ingreso es incorrecto.

                    Console.WriteLine();

                    Console.Write($"Ingrese nuevamente un numero entero entre {A} y {B}: "); // Le pedimos que ingrese nuevamente un numero entre A (5) y B (20)
                    num = int.Parse(Console.ReadLine()); // Almacenara la variable num el nuevo numero ingresado por el usuario.
                }
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio9()
        {
            int num = 0; // Declaramos la variable de tipo entero y con un valor de 0.
            int num2 = 1; // Declaramos otra variable de tipo de dato entero y con un valor de 1.

            Console.Write("Ingrese el numero de la tabla de multiplicar que desea ver (1 - 10): ");  // Le indicamos al usuario que ingrese un numero entre el 1 y el 10.
            num = int.Parse(Console.ReadLine()); // La variable num almacenara el dato o numero ingresado por el usuario.
            Console.WriteLine(); 
            

            if (num >= 1 && num <= 10) // Si la variable num tiene un numero que sea mayor o igual a 1 y menor o igual a 10 entrara al ciclo for.
            {

            

            for (int i = num; i >= 1 & i <= 10 && num2 <= 10; num2++) // ciclo for: declaramos que la variable i tome el dato de num.
                                                                      // Si i es mayor o igual a 1 y menor o igual a 10 enviara un mensaje.
                                                                      // También colocamos que num2 tiene que ser menor o igual a 10 y la variable tendra un rol contador.
                {

                    Console.WriteLine($"{i} x {num2}: {i * num2}"); // Este mensaje le mostrara al usuario 10 veces, ya que num2 no puede ser mayor a 10
                                                                    // y se realiza una multiplicación entre el numero ingresado por el usuario hasta el numero 10
                                                                    // para que pueda ver también los resultados de la tabla del numero que ingreso.
               
                    
              }

            } else // Hacemos un else en el caso que el numero que ingreso es menor a 1 o mayor a 10
            {
                Console.WriteLine("Numero de Tabla de multiplicar no encontrada"); // Le indicamos por pantalla que el numero que ingreso es incorrecto.
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        }

        static void Ejercicio10()
        {
            Random random = new Random(); // Colocamos una clase Random para generar los numeros enteros aleatorios del 1 al 7
            int dado1 = random.Next(1, 7); // Declaramos la variable dado1 con un valor de numeros enteros del 1 al 7
            int dado2 = random.Next(1, 7); // También Declaramos la variable dado2 con un valor de numeros enteros del 1 al 7
            int suma = dado1 + dado2; // Aquí declaramos la variable suma con un tipo de dato entero que su valor sera la suma de dado1 con dado2

            Console.WriteLine("Resultado del lanzamiento:"); // Le indicamos por la consola al usuario los resultados de los numeros de dado1 y dado2 y la suma que da de ambos
            Console.WriteLine("Dado 1: " + dado1); // Mostramos el numero que salio de manera aleatorio en dado1
            Console.WriteLine("Dado 2: " + dado2); // y aquí mostramos el numero aleatorio que salio de dado2
            Console.WriteLine("Suma: " + suma); // Le mostramos la suma de los numeros que salieron de dado1 y dado2.

            if (suma > 10) // Hacemos un if en el caso que si la suma es mayor a 10, el programa enviara un mensaje.
            {
                Console.WriteLine("¡Bien hecho jugador/a!"); // Le enviamos un mensaje por consola diciendo "¡Bien hecho jugador/a"

            } // fin del if

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio11()
        {

            Console.Clear();

            int[] contadorNumeros = new int[10]; // Declaramos una variable de tipo entero llamada contadorNumeros y que su valor sea un tipo de entero de 10
            int contadorPares = 0; // Declaramos una variable de tipo entero con un nombre de contadorPares con un valor inicial de 0
            int contadorImpares = 0; // Declaramos también una variable de tipo entero con un nombre de contadorImpares con un valor de 0
            int numero = 0; // También declaramos otra variable llamada numero de tipo entero con un valor de 0


            while (true) // Hacemos un ciclo while
            {
                Console.Write("Ingrese un número del 0 al 9 (N para terminar): "); // Le indicamos por la pantalla de la consola que debe ingresar un numero el usuario.
                string entrada = Console.ReadLine(); // Declaramos una variable llamada entrada con tipo de dato string que esta variable almacenara los datos del usuario.

                if (entrada.ToUpper() == "N") // Hacemos un if, si entrada es igual a N, el ciclo se rompera.
                {
                    break;
                }

                if (int.TryParse(entrada, out numero)) // Si la variable entrada es un numero entrara en otro if
                {
                    if (numero >= 0 && numero <= 9) // En este if se verificara si el numero ingreado es mayor o igual a 0 y menor igual a 9 
                    {
                        contadorNumeros[numero]++; // Utilizamos una variable contador para contar los numeros en la variable contadorNumeros

                        if (numero % 2 == 0) // Si el numero es multiplo de 2, se lo contara en la variable contadorPares
                        {
                            contadorPares++; // Aquí usamos la variable contadorPares en el caso que el numero sea multiplo de 2
                        }
                        else // Si el numero no es multiplo de 2 se almacenara en la variable de rol contador llamada contadorImpares
                        {
                            contadorImpares++; // Aquí usamos la variable contadorImpares por si el numero no es multiplo de 2
                        }
                    }
                    else // else del segundo if. En este else si el numero es menor a 0 o mayor a 9 se enviara un mensaje por consola
                    {
                        Console.WriteLine("Ingrese un número válido del 0 al 9."); // Aquí enviamos el mensaje diciendo que el numero ingresado no es valido.
                    }
                }
                else // Else del primer if. En este else se lo utiliza en el caso que el usuario ingrese un dato que no sea entero y se le envia un mensaje.
                {
                    Console.WriteLine("Ingrese un número válido del 0 al 9 o la letra N para terminar."); // Le indicamos por consola que debe ingresar un numero valido.
                }
            }

            Console.WriteLine("Cantidad de veces que se ingresó cada número:"); // Cuando se corte el ciclo le indicamos por pantalla de la consola  los numeros ingreados
            for (int i = 0; i < 10; i++) // Hacemos un for en donde se declara la variable i con un valor de 0 y tipo de dato entero y si i es menor a 10.
                                         // por ultimo la variable i tomara un rol de variable contador.
            {
                Console.WriteLine("Número " + i + ": " + contadorNumeros[i]);  //Aquí mostramos por pantalla los numeros de i (1 al 9) y las veces que se ingresaron los numeros
            }

            Console.WriteLine("Cantidad total de números pares: " + contadorPares); // Mostramos por consola la cantidad total de los numeros pares ingresados.
            Console.WriteLine("Cantidad total de números impares: " + contadorImpares); // y aquí también mostramos por consola la cantidad total de numeros impares ingreados.

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");
        }

        static void Ejercicio12()
        {

            Console.Clear();

            Console.Write("Ingrese un número entero mayor que 0: "); // Le indicamos por pantalla al usuario que debe ingresar un numero entero mayor a 0.
            int numero = int.Parse(Console.ReadLine()); // Declaramos la variable numero con un tipo de dato entero y su valor sera el dato que ingrese el usuario.

            if (EsNumeroPrimo(numero)) // Hacemos un if que se entrara en el caso que el numero ingresado sea primo
            {
                Console.WriteLine();
                Console.WriteLine("El número ingresado es primo."); // Le enviamos un mensaje diciendo que el numero que ingreso es primo.
            }
            else // hacemos un else, si el numero no lo es.
            {
                Console.WriteLine();
                Console.WriteLine("El número ingresado no es primo."); // Mostramos por consola al usuario que el numero no es primo
            }

            Console.WriteLine();
            Console.WriteLine("El programa ha finalizado, Presione cualquier tecla para salir...");

        } // fin del if

        static bool EsNumeroPrimo(int numero) // Hacemos una funcion bool llamada EsNumeroPrimo con un parametro de la variable numero de tipo de dato entero.
        {
            if (numero <= 1) // Hacemos un if en el caso que si el numero es menor o igual a 1
            {
                return false; // retornara un valor de falso

            } // fin del if

            for (int i = 2; i <= Math.Sqrt(numero); i++) // hacemos un for en donde la variable i de tipo de dato entero tomara un valor de 2 
                                                         // y si i es menor o igual a numero. También i sera una variable de rol contador.
            {
                if (numero % i == 0) // Hacemos un if en donde verificamos si numero es divisible por i y termine dando un resultado igual a 0
                {
                    return false; // en el caso que sea igual a 0, retornara un valor falso.

                } // fin del if

            } // fin del for

            return true; // retornara un valor verdadero a la función.

        } // fin de la función

        static void Ejercicio13()
        {

            Console.Clear();

            int votosC = 0; // Declaramos la variable votosC con un tipo de entero de valor 0
            int votosQ = 0; // Declaramos otra variable llamada votosQ con un tipo de dato entero y con un valor de 0
            int votosBlanco = 0; // Declaramos una tercera variable llamada votosBlanco con tipo de dato entero y un valor de 0
            int totalVotos = 0; // Declaramos una ultima variable con un tipo de dato entero llamada totalVotos y con un valor de 0.

            while (true) // Hacemos un ciclo while
            {
                Console.Write("Ingrese su voto (C - Candidato C, Q - Candidato Q, B - Blanco, N - Finalizar votación): "); // Le indicamos por pantalla al usuario
                                                                                                                           // que debe ingresar su voto a los candidatos propuestos.

                string voto = Console.ReadLine().ToUpper(); // Declaramos la variable voto con un tipo de dato string y esta almacenara la repuesta del usuario

                if (voto == "N") // Hacemos un if en el caso que la variable voto sea igual a N
                {
                    break;  // Cortamos/Rompemos el ciclo si voto es igual a N
                }

                switch (voto) // Hacemos un switch con la variable voto
                {
                    case "C": // Colocamos el primer caso si el dato ingresado es "C".
                        votosC++; // La variable votosC tomara un rol de contador si es un dato ingresado por el usuario
                        totalVotos++; // y la variable totalVotos también tomara el rol de contador si lo ingresado por el usuario es "C"

                        break; // break del caso "C".

                    case "Q": // Colocamos un segundo caso si el dato ingresado es "Q".
                        votosQ++; // La variable votosQ tomara el rol de contador
                        totalVotos++; // y la variable totalVotos también tomara un rol contador si el dato ingresado por el usuario es Q.

                        break; // break del caso "Q".

                    case "B": // Colocamos un ultimo caso si el dato ingresado por el usuario es "B". 
                        votosBlanco++; // la variable votosBlanco tomara el rol de contador
                        totalVotos++; // y la variable totalVotos también tendra el rol contador si el dato ingresado es B.

                        break; // break del caso "B".

                    default: // Hacemos un default si el dato ingresado por el usuario no es el correcto.

                        Console.WriteLine("Voto no válido. Intente nuevamente."); // Le indicamos por pantalla que el dato ingresado no es valido

                        break; // break del default.

                } // fin del switch

            } // fin del while

            Console.WriteLine("Resultados de la votación:"); // Mostramos por la pantalla de la consola los resultados de la votación

            Console.WriteLine("Cantidad de votos para el Candidato C: " + votosC); // Mostramos la cantidad de veces que se ingreso el dato "C"
            Console.WriteLine("Cantidad de votos para el Candidato Q: " + votosQ); // Mostramos la cantidad de veces que se ingreso el dato "Q"
            Console.WriteLine("Cantidad de votos en Blanco: " + votosBlanco); // y también mstramos la cantidad de veces que se ingreso el dato "B"
            Console.WriteLine("Total de votos: " + totalVotos); // Le mostramos al usuario el total de los datos ingresados.

            double porcentajeC = (double)votosC / totalVotos * 100; // declaramos una variable llamada porcentajeC con un tipo de dato real que tomara el valor de votosC
                                                                    // y este valor se lo multiplica por 100.

            double porcentajeQ = (double)votosQ / totalVotos * 100; // declaramos otra variable llamada porcentajeQ con un tipo de dato real que tomara el valor de votosQ
                                                                    // y el valor se lo multiplicara también por 100

            Console.WriteLine("Porcentaje de votos para el Candidato C: " + porcentajeC.ToString("0.00") + "%"); // le mostramos por pantalla al usuario el porcentaje de los votos
                                                                                                                 // de la variable porcentajeC que la convertimos a string

            Console.WriteLine("Porcentaje de votos para el Candidato Q: " + porcentajeQ.ToString("0.00") + "%"); // también le mostramos el porcentaje de votos de la variable
                                                                                                                 // porcentajeQ que la convertimos también a tipo de dato string.

            if (porcentajeC >= 45 && porcentajeC > porcentajeQ) // Hacemos un if en el caso que si porcentajeC es mayor o igual a 45 y porcentajeC sea mayor al porcentajeQ
            {                                                   // se envie por un mensaje por pantalla

                Console.WriteLine("¡El Candidato C es el ganador!"); // Le indicamos por pantalla al usuario que el candidato C es el ganador de la votación.

            }

            else if (porcentajeQ >= 45 && porcentajeQ > porcentajeC) // Hacemos un else if si el porcentajeQ es mayor o igual a 45 y mayor a porcentajeC
            {
                Console.WriteLine("¡El Candidato Q es el ganador!"); // Si los datos son correctos al else if se envia un mensaje diciendo que el candidato Q es el ganador.
            }
            else // hacemos por ultimo un else, en el caso que los datos no hayan sido mayores a lo indicado
            {
                Console.WriteLine("No hubo un ganador claro."); // y mostramos por pantalla que no hubo un ganador en especifico.
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
