//crear dos  matrices, mostrarlas, sumar con for anidado y mostrar la suma de las matrices
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace suma_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            suma_matrices();
        }
        public static void menu()
        {
            int opcion;
            Console.WriteLine("" +
                "MENU DE OPCIONES\n" +
                "1). Suma matrices\n" +
                "2). Salir\n" );
            
        }
        public static void suma_matrices()
        {
            int opcion;
            do
            {
                Random numero = new Random();
                menu();

                Console.WriteLine("Ingresa una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                int fila;
                int fila_2;
                
                int columna;
                int columna_2;

                //crear matriz 1
                Console.WriteLine("MATRIZ 1");
                Console.Write("2.Realizar la suma de dos matrices y mostrar el resultado.\nIngresael numero de filas: ");
                fila = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el numero de columnas: ");
                columna = int.Parse(Console.ReadLine());

                int[,] matriz_1 = new int[fila, columna];

                //rellenar valores matriz 1
                for (int k = 0; k < fila; k++)
                {
                    for (int v = 0; v < columna; v++)
                    {

                        /*Console.WriteLine($"Ingresa el valor de la posicion {k},{v}: ");
                        matriz_1[k, v] = int.Parse(Console.ReadLine());*/
                        matriz_1[k, v]= numero.Next(0, 10);

                    }
                }
                Console.WriteLine("MATRIZ RESULTANTE 1");
                for (int k = 0; k < fila; k++)
                {
                    for (int v = 0; v < columna; v++)
                    {
                        Console.Write("\t" + matriz_1[k, v] + " ");
                    }
                    Console.WriteLine();
                }

                //crear matriz 2
                Console.WriteLine("MATRIZ 2");
                Console.Write("Ingresael numero de filas: ");
                fila_2 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el numero de columnas: ");
                columna_2 = int.Parse(Console.ReadLine());

                int[,] matriz_2 = new int[fila_2, columna_2];

                //rellenar valores matriz 2
                for (int c = 0; c < fila_2; c++)
                {
                    for (int d = 0; d < columna_2; d++)
                    {
                        /*Console.WriteLine($"Ingresa el valor de la posicion {c},{d}: ");
                        matriz_2[c, d] = int.Parse(Console.ReadLine());*/
                        matriz_2[c, d] = numero.Next(0, 10);
                    }
                }
                //mostrar matriz 2
                Console.WriteLine("MATRIZ RESULTANTE 2");
                for (int c = 0; c < fila_2; c++)
                {
                    for (int d = 0; d < columna_2; d++)
                    {
                        Console.Write("\t" + matriz_2[c, d] + " ");
                    }
                    Console.WriteLine();
                }
                if (fila != fila_2 || columna != columna_2)
                {
                    Console.WriteLine("PARA HACER LA SUMA ES NECESARIO QUE AMBAS FILAS Y AMBAS COLUMNAS SEAN IGUALES");
                }
                else
                {
                    //suma_matrices
                    int[,] matriz_resultantee = new int[fila, columna];
                    for (int c = 0; c < fila_2; c++)
                    {
                        for (int d = 0; d < columna_2; d++)
                        {
                            matriz_resultantee[c, d] = matriz_1[c, d] + matriz_2[c, d];
                        }
                    }
                    Console.WriteLine("SUMA MATRIZ");
                    for (int c = 0; c < fila_2; c++)
                    {
                        for (int d = 0; d < columna_2; d++)
                        {
                            Console.Write(matriz_resultantee[c, d] + " ");
                        }
                        Console.WriteLine();
                    }
                }

            } while (opcion == 1);
                
                        
            }
                

            
        }
}


    

    
        
        
            
    