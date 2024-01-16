class Remedio{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string Marca { get; set; }
    public string Categoria { get; set; }
    public double Miligramas { get; set; }
    public int Comprimidos { get; set; }

    public Remedio(string nome, double preco, string marca, string categoria, double miligramas, int comprimidos, int estoqueInicial){
    //this para atribuir valor   
    this.Nome = nome;
    this.Preco = preco;
    this.Estoque = estoqueInicial;
    this.Marca = marca;
    this.Categoria = categoria;
    this.Miligramas = miligramas;
    this.Comprimidos = comprimidos;

    }
}

