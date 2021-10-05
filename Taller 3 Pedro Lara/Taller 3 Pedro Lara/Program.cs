using System;

namespace Taller_3_Pedro_Lara
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1(6, 13);
            Punto1(50, 10);
            Console.WriteLine("");
            int[] datos = { 3, 7, 90, 23, 6, 17, 53, 1, 15, 12 };
            Punto2(datos);
            Console.WriteLine("");
            Console.WriteLine("");
            Punto3(4.5, 5);
            Punto3(3.8, 4.4);
            Punto3(3, 3.7);
            Punto3(2, 1);
            Console.WriteLine("");
            Punto4(2000);
            Punto4(2045);
            Console.WriteLine("");
            Punto5(26);
            Punto5(89);
        }
        static void Punto1(int a, int b)
        {
            double Div;
            Div = a % b;
            if (Div == 0)
            {
                Console.WriteLine("El numero " + a + " es multiplo de " + b);
            }
            else
            {
                Console.WriteLine("El numero " + a + " no es multiplo de " + b);
            }


        }
        static void Punto2(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write(datos[i] + " ");
            }

            Console.WriteLine(" ");

            int Div;
            int CP = 0;
            int CI = 0;
            for (int v = 0; v < (datos.Length); v++)
            {
                Div = datos[v] % 2;
                if (Div == 0)
                {
                    CP++;
                }
                else
                {
                    CI++;
                }
            }

            int Aux = 0;
            int Aux1 = 0;
            int[] Pares = new int[CP];
            int[] Impares = new int[CI];

            for (int v = 0; v < (datos.Length); v++)
            {
                Div = datos[v] % 2;
                if (Div == 0)
                {
                    Pares[Aux++] = datos[v];
                }
                else
                {
                    Impares[Aux1++] = datos[v];
                }
            }

            Aux = 0;
            for (int z = 1; z < Pares.Length; z++)
            {
                for (int v = 0; v < (Pares.Length - z); v++)
                {
                    if (Pares[v] > Pares[v + 1])
                    {
                        Aux = Pares[v];
                        Pares[v] = Pares[v + 1];
                        Pares[v + 1] = Aux;

                    }

                }
            }

            Aux = 0;
            for (int z = 1; z < Impares.Length; z++)
            {
                for (int v = 0; v < (Impares.Length - z); v++)
                {
                    if (Impares[v] > Impares[v + 1])
                    {
                        Aux = Impares[v];
                        Impares[v] = Impares[v + 1];
                        Impares[v + 1] = Aux;

                    }

                }
            }

            Console.Write("lista de numeros pares: ");
            for (int i = 0; i < Pares.Length; i++)
            {
                Console.Write(Pares[i] + " ");
            }

            Console.WriteLine(" ");

            Console.Write("lista de numeros Impares: ");
            for (int i = 0; i < Impares.Length; i++)
            {
                Console.Write(Impares[i] + " ");
            }
        }
        static void Punto3(double NotaT, double NotaP)
        {
            double NotaF;
            NotaF = (NotaP * 0.45) + (NotaT * 0.55);

            if (NotaF > 4.5)
            {
                Console.WriteLine("la nota " + NotaF + " es excelente");
            }
            else if (NotaF >= 3.8)
            {
                Console.WriteLine("la nota " + NotaF + " es sobresaliente");
            }
            else if (NotaF >= 3)
            {
                Console.WriteLine("la nota " + NotaF + " es aceptable");
            }
            else
            {
                Console.WriteLine("la nota " + NotaF + " es insuficiente");
            }

        }
        static void Punto4(double Num)
        {
            double Mod;
            double Div;

            Mod = Num % 100;
            Div = Num / 100;
            int Div1 = Convert.ToInt32(Math.Floor(Div));

            if (Mod == 0)
            {
                Console.WriteLine("el año " + Num + " es el siglo " + Div);
            }
            else
            {
                Console.WriteLine("el año " + Num + " es el siglo " + (Div1 + 1));
            }
        }
        static void Punto5(int Num)
        {
            int Suma;
            int Mod;
            double Div;

            Mod = Num % 10;
            Div = Num / 10;
            int Div1 = Convert.ToInt32(Math.Floor(Div));
            Suma = Div1 + Mod;

            Console.WriteLine("la suma de los digitos de " + Num + " es " + Suma);
        }
    }
}
        
    

