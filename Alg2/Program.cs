// See https://aka.ms/new-console-template for more information
namespace alg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int escolha;
            do
            {
                Console.WriteLine("[1] Adicionar Remédio [2] Listar Remédios [3] Remover Remédio [4] Entrada Estoque [5] Saída Estoque [0] Sair");
                 escolha = int.Parse(Console.ReadLine());
                
                if (escolha == 1)
                {
                    Console.Write("Nome do remédio: ");
                    string nome = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Categoria(tipo de medicamento)");
                    string categoria = Console.ReadLine();
                    Console.Write("Quantidade de miligramas");
                    double miligramas = double.Parse(Console.ReadLine());
                    Console.Write("Quantidade de Comprimidos");
                    int comprimidos = int.Parse(Console.ReadLine());
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Estoque inicial: ");
                    int estoqueInicial = int.Parse(Console.ReadLine());

                    Remedio novoRemedio = new Remedio(nome, preco, marca, categoria, miligramas, comprimidos, estoqueInicial);
                    estoque.Adicionar(novoRemedio);
                }
                else if (escolha == 2)
                {
                    estoque.Listar();
                }
                else if (escolha == 3)
                {
                    Console.Write("Posição do remédio a ser removido: ");
                    int posRemover = int.Parse(Console.ReadLine());
                    estoque.Remover(posRemover);
                }
                else if (escolha == 4)
                {
                    Console.Write("Posição do remédio para entrada de estoque: ");
                    int posEntrada = int.Parse(Console.ReadLine());
                    Console.Write("Quantidade de entrada: ");
                    int qtdEntrada = int.Parse(Console.ReadLine());
                    estoque.EntradaEstoque(posEntrada, qtdEntrada);
                }
                else if (escolha == 5)
                {
                    Console.Write("Posição do remédio para saída de estoque: ");
                    int posSaida = int.Parse(Console.ReadLine());
                    Console.Write("Quantidade de saída: ");
                    int qtdSaida = int.Parse(Console.ReadLine());
                    estoque.SaidaEstoque(posSaida, qtdSaida);
                }
                else if (escolha == 0)
                {
                    Console.WriteLine("Saindo do programa....");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

            }
            while (escolha != 0);
        }
    }
}    
