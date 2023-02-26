internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com quantidade de figuras ");
        int qtd = int.Parse(Console.ReadLine());

        for(int i = 1; i <= qtd; i++)
        {
            Console.WriteLine("figura " + i) ;
            Console.WriteLine("retangulo ou circulo:(r/c) ?");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Cor (black,blue,red):");
            string opcor = Console.ReadLine();

            if (op == 'r')
            {
                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine());

            }

           

            }

        Console.WriteLine("Areas: ");

    }
    }
