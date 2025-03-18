namespace ClassificacaoDeTrianguloConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o valor do lado X: ");
                int LadoX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor do lado Y: ");
                int LadoY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor do lado Z: ");
                int LadoZ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("______________________________________________________");
                Console.WriteLine("Valores informados: ");
                Console.WriteLine("Lado X: " + LadoX);
                Console.WriteLine("Lado Y: " + LadoY);
                Console.WriteLine("Lado Z: " + LadoZ);
                Console.WriteLine("______________________________________________________");

                bool medidasTriangulosValidas =
                    LadoX + LadoY > LadoZ &&
                    LadoX + LadoZ > LadoY &&
                    LadoY + LadoZ > LadoX;

                if (medidasTriangulosValidas == true)
                    Console.WriteLine("Os valores informados formam um triângulo.");
                else
                    Console.WriteLine("Os valores informados não formam um triângulo.");

                Console.WriteLine("______________________________________________________");
                Console.Write("Deseja continuar ? (S / N) : ");
                string opcaoContinuar = Console.ReadLine() !.ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
