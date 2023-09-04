using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace M320_HA
{
    internal class Mymath
    {
        //ggT
        static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        //kgV
        static int Calc_kgV(int a, int b)
        {
            
            return (a * b) / Calc_ggT(a, b);
        }
        static int Readint()
        {
            int zahl;
            int zahl2;
            while(true)
            {
                Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
                if (int.TryParse(Console.ReadLine(), out zahl) && zahl > 0)
                {
                    return zahl;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
                Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
                if (int.TryParse(Console.ReadLine(), out zahl2) && zahl2 > 0)
                {
                    return zahl;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
                Console.WriteLine("Der ggT von " + zahl, " und " + zahl2, " ist " + Calc_ggT);
                return 0;
            }
            
        }

        static void ShowResult(int result_1, int result_2, int num1, int num2)
        {
            Console.WriteLine($"ggT von {num1} und {num2} ist {result_1}");
            Console.WriteLine($"kgV von {num1} und {num2} ist {result_2}");
        }
        static void Main(string[] args)
        {
            

        }
        //ggT rekursiv berechnen
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return Calc_ggT_r(b, a % b);
        }
        // 1. arithmethischer Wert
        public static double CalculateMean(int[] numbers)
        {
            return numbers.Average();
        }
        // 2. kleinster Wert
        public static int MinValue(int[] numbers)
        {
            return numbers.Min();
        }
        // 3. grösster Wert
        public static int MaxValue(int[] numbers)
        {
            return numbers.Max();
        }

        // Eingabe von Zahlen in ein Array
        public static int[] ReadNumbersArray(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Bitte geben Sie die {i + 1}. Zahl ein: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }

        // Funktion zum Vertauschen von dem Variableninhalten
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Funktion, die den Inhalt eines übergebenen Arrays umkehrt 
        public static void ReverseArray<T>(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                T temp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = temp;

            }
        }

    }


}

