using System;

namespace T8_JLDRL_1247723
{
    class Program
    {
        static void Main(string[] args)
        {
           
        inicio:
            Console.Clear();
            Titulo();

            Console.WriteLine("A. Sumatoria consecutivo");
            Console.WriteLine("B. Mostrar tabla de multiplicar");
            Console.WriteLine("C. Número perfecto");
            Console.WriteLine("S. Salir del programa");
            Console.WriteLine("Elige una de las opciones");
            bool convertido = char.TryParse(Console.ReadLine(), out char op);
            if (convertido == true && (op=='A' || op=='B' || op=='C'|| op=='S'))
            {
                goto programa;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
                Console.Clear();
                goto inicio;
            }

        programa:
            switch (op)
            {
                case 'A':
                reinicio1:
                    int i = 1;
                    int suma = 0;
                    Console.Clear();
                    Titulo();
                    Console.WriteLine("A. Sumatoria consecutivo");
                    Console.WriteLine("Ingrese el número en el que finaliza la sumatoria");
                    bool n = int.TryParse(Console.ReadLine(), out int num);
                    Console.ReadKey();
                    Console.WriteLine();
                    if (n == true)
                    {
                        do
                        {
                            suma = i + suma;
                            Console.WriteLine(i);
                            i++;
                        } while (i <= num); Console.WriteLine("La suma es: "+suma);

                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                        goto reinicio1;
                    }
                    goto inicio;
                case 'B':
                reinicio2:
                    Console.Clear(); 
                    Titulo();
                    Console.WriteLine("B. Mostrar tabla de multiplicar");
                    Console.WriteLine("Ingrese el número de la tabla de multiplicar: ");
                    n = int.TryParse(Console.ReadLine(), out int n1);
                    Console.ReadKey();
                    Console.WriteLine();
                    if (n == true && n1>0)
                    {
                        for(int j = 0; j <= n1; j++)
                        {
                            int mul = j * n1;
                            Console.WriteLine(j +"*" + n1+"="+mul);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                        goto reinicio2;
                    }
                    goto inicio;
                case 'C':
                    reinicio3:
                    int k = 1;
                    int suma2 = 0;
                    Console.Clear();
                    Titulo();
                    Console.WriteLine("C. Número perfecto");
                    Console.WriteLine("Ingrese un número mayor a 0: ");
                    n = int.TryParse(Console.ReadLine(), out int n2);
                    if (n == true && n2 >0)
                    {
                        do {
                            if (k == n2)
                            {
                                break;
                            }
                            else if (n2 % k == 0)
                            {
                                suma2 += k;
                                Console.WriteLine(k);
                            }
                            k++;

                        } while (k <=28);                        
                        Console.WriteLine(suma2);
                        if (suma2 == n2)
                        {
                            Console.WriteLine("Es un número perfecto");
                        }
                        else
                        {
                            Console.WriteLine("No es un número perfecto");

                        }

                        Console.ReadKey();    
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                        goto reinicio3;
                    }
                    goto inicio;
                case 'S':
                    Environment.Exit(0);
                    Console.Clear();
                    break;
            }
            static void Titulo()
            {
                Console.WriteLine("LABORATORIO 8");
                Console.WriteLine();
            }
        }
    }
}
