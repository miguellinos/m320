namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Testen der Rechenoperationen
            int result = calculator.Addiere(5, 3);
            Console.WriteLine("Addition: " + result);

            result = calculator.Subtrahiere(10, 4);
            Console.WriteLine("Subtraktion: " + result);

            result = calculator.Multipliziere(6, 2);
            Console.WriteLine("Multiplikation: " + result);

            result = calculator.Dividiere(8, 2);
            Console.WriteLine("Division: " + result);

            // letztes Ergebnis
            int lastResult = calculator.GetLastResult();
            Console.WriteLine("Letztes Ergebnis: " + lastResult);

            var newresult = new Calculator.PerformOperation(7);
            Console.WriteLine("Ihr Resultat ist:" + result);
        }
    }
    


}