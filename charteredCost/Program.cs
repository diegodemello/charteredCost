using System.Globalization;

namespace charteredCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Cálculo de Custo Fretado");
            Console.WriteLine("1 - Van - 11 Pessoas");
            Console.WriteLine("2 - Ônibus - 25 Pessoas");
            Console.WriteLine("------------------------");


            int choice = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Informe o número de pontos de embarque: ");
            int pE = int.Parse(Console.ReadLine());
            double km; 
            double kmTotal = 0;

            for (int i = 1; i <= pE; i++)
            {
                Console.Write("Digite a " + i + "ª quilometragem: ");
                km = double.Parse(Console.ReadLine());
                kmTotal = kmTotal + km;
            }

            double gas = 6.10;
            double price;
            if (choice == 1)
            {
                Console.Clear();
                price = (gas/9.00) * kmTotal;
                Console.WriteLine("O custo com combustível dessa rota será de R$ " + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.Clear();
                price = (gas / 6.00) * kmTotal;
                Console.WriteLine("O custo com combustível dessa rota será de R$ " + price.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
