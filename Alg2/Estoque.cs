namespace alg2
{
    class Estoque
    {
        Remedio[] remedios = new Remedio[0];

        public void Adicionar(Remedio novoRemedio)
        {
            Remedio[] novoVetor = new Remedio[remedios.Length + 1];

            for (int pos = 0; pos < remedios.Length; pos++)
            {
                novoVetor[pos] = remedios[pos];
            }
            novoVetor[novoVetor.Length - 1] = novoRemedio;

            remedios = novoVetor;
        }

        public void Listar()
        {
            Console.WriteLine("\n\n==== LISTA DE REMEDIOS ===\n");

            for (int pos = 0; pos < remedios.Length; pos++)
            {
                Remedio item = remedios[pos];
                Console.WriteLine($"{pos + 1}#  {item.Nome} - {item.Marca} - {item.Miligramas}mg - {item.Comprimidos}cpsl - Tipo: {item.Categoria} , R$ {item.Preco} ({item.Estoque})");
            }
        }

        public void Remover(int posRemover)
        {
            Remedio[] novoVetor = new Remedio[remedios.Length - 1];
            for (int pos = 0; pos < novoVetor.Length; pos++)
            {
                if (pos >= posRemover)
                {
                    novoVetor[pos] = remedios[pos + 1];
                }
                else
                {
                    novoVetor[pos] = remedios[pos];
                }
            }
            remedios = novoVetor;
        }

        public void EntradaEstoque(int posicao, int qtd)
        {
            if (posicao >= 1 && posicao <= remedios.Length)
            {
                remedios[posicao - 1].Estoque += qtd;
                Console.WriteLine($"{remedios[posicao - 1].Nome}. Novo estoque: {remedios[posicao - 1].Estoque}");
            }
            else
            {
                Console.WriteLine("Posição inválida. Nenhuma entrada de estoque realizada.");
            }
        }

        public void SaidaEstoque(int posicao, int qtd)
        {
            if (posicao >= 1 && posicao <= remedios.Length)
            {
                if (remedios[posicao - 1].Estoque >= qtd)
                {
                    remedios[posicao - 1].Estoque -= qtd;
                    Console.WriteLine($"Saída de estoque realizada para {remedios[posicao - 1].Nome}. Novo estoque: {remedios[posicao - 1].Estoque}");
                }
                else
                {
                    Console.WriteLine("Quantidade solicitada maior que o estoque disponível");
                }
            }
            else
            {
                Console.WriteLine("Posição inválida. Nenhuma saída de estoque realizada.");
            }
        }
    }
}






