using System;
using System.Numerics;

namespace matrices_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int vec_mat;
            int colum;
            colum = 0;  
            Console.WriteLine("EJERCICIOS VECTORES Y MATRICES\n1.Vectores.\n2.Matrices\nIngresa el valor correspondiente: ");
            vec_mat = int.Parse(Console.ReadLine());
            switch (vec_mat)
            {
                case 1:
                    int n_ejercicio;

                    do
                    {
                        Console.WriteLine("EJERCICIOS VECTORES\nOPCIONES\n1.Declarar un vector de números enteros y mostrar su contenido en la consola.\n2.Calcular la suma de todos los elementos en un vector de números reales.\n3.Encontrar el elemento más grande y el más pequeño en un vector de números\r\nenteros.\n4.Ordenar un vector de cadenas alfabéticamente.\n5.Salir\nIngresa el numero del ejercicio: ");
                        n_ejercicio = int.Parse(Console.ReadLine());

                        switch (n_ejercicio)
                        {
                            case 1:
                                int tamano;
                                Console.Write("1.Declarar un vector de números enteros y mostrar su contenido en la consola.\nIngresa el tamaño del vector: ");
                                tamano = int.Parse(Console.ReadLine());
                                //declarar vector
                                int[] numeros = new int[tamano];
                                //recorrer vector
                                for (int j = 0; j < numeros.Length; j++)
                                {
                                    Console.Write("Ingresa el valor del vector " + j + ": ");
                                    numeros[j] = int.Parse(Console.ReadLine());
                                }
                                for (int i = 0; i < numeros.Length; i++)
                                {
                                    Console.Write(numeros[i] + " ");
                                }
                                Console.WriteLine();
                                break;
                            case 2:
                                int longi;
                                float suma;
                                suma = 0;
                                Console.Write("2.Calcular la suma de todos los elementos en un vector de números reales.\nIngresa la longitud del vector: ");
                                longi = int.Parse(Console.ReadLine());
                                float[] vector = new float[longi];

                                for (int j = 0; j < vector.Length; j++)
                                {
                                    Console.Write("Ingresa el valor del vector " + j + " : ");
                                    vector[j] = float.Parse(Console.ReadLine());
                                    suma = vector[j] + suma; ;
                                }
                                Console.WriteLine("La suma de los " + vector.Length + " elementos del vector es: " + suma);

                                break;
                            case 3:
                                int longitud;
                                int mayor;

                                int menor;
                                menor = 0;
                                mayor = 0;
                                Console.Write("3.Encontrar el elemento más grande y el más pequeño en un vector de números\r\nenteros.\nIngresa el tamaño del vector: ");
                                longitud = int.Parse(Console.ReadLine());

                                //declarar vector con su tamaño
                                int[] vectorr = new int[longitud];


                                //RELLENO VECTOR
                                for (int x = 0; x < vectorr.Length; x++)
                                {


                                    Console.Write("Ingresa el valor del vector  " + x + " : ");//1

                                    vectorr[x] = int.Parse(Console.ReadLine());
                                    if (x == 0)
                                    {
                                        mayor = vectorr[x];
                                        menor = vectorr[x];
                                    }
                                    else
                                    {
                                        if (vectorr[x] < menor)
                                        {
                                            menor = vectorr[x];
                                        }
                                        if (vectorr[x] > mayor)
                                        {
                                            mayor = vectorr[x];
                                        }
                                    }
                                }
                                Console.WriteLine("El valor menor del vector es: " + menor + ".\nEl valor mayor del vector es: " + mayor);
                                break;
                            case 4:
                                int longitude;
                                Console.WriteLine("4.Ordenar un vector de cadenas alfabéticamente.\nIngresa el tamaño del vector: ");
                                //indicar tamaño del vector
                                longitude = int.Parse(Console.ReadLine());
                                // Declarar un vector de cadenas
                                string[] vectorCadenas = new string[longitude];

                                for (int a = 0; a < vectorCadenas.Length; a++)
                                {
                                    Console.Write("Ingresa el valor del vector " + a + " : ");
                                    vectorCadenas[a] = Console.ReadLine();
                                }

                                // Ordenar el vector alfabéticamente
                                Array.Sort(vectorCadenas);

                                // Mostrar el vector ordenado
                                Console.WriteLine("Vector ordenado alfabéticamente: ");
                                foreach (string cadena in vectorCadenas)
                                {
                                    Console.WriteLine(cadena);
                                }

                                break;

                        }
                    } while (n_ejercicio != 5);
                    break;
                case 2:
                    int num_ejercicio;
                    do
                    {
                        Console.WriteLine("EJERCICIOS MATRICES\n1.Declarar una matriz de enteros y mostrar su contenido en la consola.\n2.Realizar la suma de dos matrices y mostrar el resultado.\n3.Multiplicar una matriz por un escalar.\n4.Encontrar el determinante de una matriz cuadrada.\nIngresa el numero del ejercicio: ");
                        num_ejercicio = int.Parse(Console.ReadLine());

                        switch (num_ejercicio)
                        {
                            case 1:
                                int filas;
                                int columnas;
                                Console.Write("1.Declarar una matriz de enteros y mostrar su contenido en la consola.\nIngresa el numero de filas: ");
                                filas = int.Parse(Console.ReadLine());
                                Console.Write("Ingresa el numero de columnas: ");
                                columnas = int.Parse(Console.ReadLine());

                                //declarar matriz
                                int[,] nombre_matriz = new int[filas, columnas];

                                //rellenar matriz
                                for (int a = 0; a < filas; a++)
                                {
                                    for (int b = 0; b < columnas; b++)
                                    {
                                        Console.Write($"Ingresa el valor de la posicion {a},{b}: ");
                                        nombre_matriz[a, b] = int.Parse(Console.ReadLine());

                                    }
                                }
                                //mostrar contenido
                                Console.WriteLine("MATRIZ COMPLETA");
                                for (int a = 0; a < filas; a++)
                                {
                                    for (int b = 0; b < columnas; b++)
                                    {
                                        Console.Write("\t" + nombre_matriz[a, b] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                int fila;
                                int fila_2;
                                fila_2 = 0;


                                int columna;
                                int columna_2;
                                columna_2 = 0;


                                fila = 0;
                                columna = 0;



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
                                        Console.WriteLine($"Ingresa el valor de la posicion {k},{v}: ");
                                        matriz_1[k, v] = int.Parse(Console.ReadLine());
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
                                        Console.WriteLine($"Ingresa el valor de la posicion {c},{d}: ");
                                        matriz_2[c, d] = int.Parse(Console.ReadLine());
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
                                break;
                            case 3:
                                //matriz_resultante[a,b] = matriz_1[a,b]*c siendo c un numero entero
                                int fil;
                                
                                int escalar;
                               

                                Console.Write("3.Multiplicar una matriz por un escalar.\nIngresa el numero de filas de la matriz: ");
                                fil = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el numero de columnas: ");
                                colum = int.Parse(Console.ReadLine());
                                int[,] matriz_principal = new int[fil, colum];
                                int[,] matriz_resultanteee = new int[fil, colum];
                                //rellenar
                                for (int a = 0; a < fil; a++)
                                {
                                    for (int b = 0; b < colum; b++)
                                    {
                                        Console.Write($"Ingresa el valor de la posicion {a},{b}: ");
                                        matriz_principal[a, b] = int.Parse(Console.ReadLine());
                                    }
                                }
                                //mostrar matriz
                                Console.WriteLine("MATRIZ PRINCIPAL");
                                for (int a = 0; a < fil; a++)
                                {
                                    for (int b = 0; b < colum; b++)
                                    {
                                        Console.Write("\t" + matriz_principal[a, b] + " ");

                                    }
                                    Console.WriteLine();
                                }
                                //ingresar numero de escalar
                                Console.WriteLine("Ingresa el valor del escalar: ");
                                escalar = int.Parse(Console.ReadLine());
                                //multiplicar por escalar
                                for (int a = 0; a < fil; a++)
                                {
                                    for (int b = 0; b < colum; b++)
                                    {
                                        matriz_resultanteee[a, b] = matriz_principal[a, b] * escalar;

                                    }

                                }
                                //mostrar matriz resultante
                                Console.WriteLine("MATRIZ RESULTANTE");
                                for (int a = 0; a < fil; a++)
                                {
                                    for (int b = 0; b < colum; b++)
                                    {
                                        Console.Write(matriz_resultanteee[a, b]+" ");

                                    }
                                    Console.WriteLine();
                                }
                                break;
                            case 4:
                                //matriz cuadra = i=j
                                int filla;
                                int column;
                                
                                Console.WriteLine("4.Encontrar el determinante de una matriz cuadrada.\nIngresa el numero de filas: ");
                                filla = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ingresa el numero de columnas: ");
                                column = int.Parse(Console.ReadLine());

                                if(colum == filla)
                                {
                                    //rellenar matriz
                                    int[,] matriz_nueva = new int[filla, column];

                                    for (int p = 0; p < filla; p++)
                                    {
                                        for (int u = 0; u < column; u++)
                                        {
                                            Console.Write($"Ingresa el valor de la posicion {u},{p}");
                                            matriz_nueva[p, u] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    //mostrar matriz
                                    Console.WriteLine("MATRIZ PRINCIPAL");
                                    for (int p = 0; p < filla; p++)
                                    {
                                        for (int u = 0; u < column; u++)
                                        {
                                            Console.Write("\t" + matriz_nueva[p, u] + " ");
                                        }
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.Write("NO ES MATRIZ CUADRADA");
                                    break;
                                }
                                
                                break;
                        }
                    } while (num_ejercicio != 5);




                    break;
            }

        }
    }
}