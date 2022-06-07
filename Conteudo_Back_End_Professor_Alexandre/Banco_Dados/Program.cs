/*NetEmpresta possui ao redor de 200.000 filmes (filmes, documentários, animes, ..), cujo empréstimo deve ser controlado.

Cada filme/documentario/anime possui um número. 
Para cada filme, é necessário saber seu título e sua categoria (comédia, drama, aventura, ...).
Cada filme recebe um identificador próprio. 

Os clientes podem desejar encontrar os filmes estrelados pelo seu ator predileto. 
Por isso, é necessário manter a informação dos atores que estrelam em cada filme. 
Nem todo filme possui estrelas. Para cada ator os clientes às vezes desejam saber o nome real,
bem como a data de nascimento.

A NetEmpresa possui muitos clientes cadastrados. 
Somente clientes cadastrados podem alugar filmes. 
Para cada cliente é necessário saber seu pré-nome e seu sobrenome, seu telefone e seu endereço. 
Além disso, cada cliente recebe um número de associado.
Finalmente, desejamos saber que filmes cada cliente tem alugados. 
Um cliente pode ter vários empréstimos em um instante no tempo. 

Nota: são mantidos registros históricos de aluguéis.

A partir desse relato construa:
-modelo lógico

Indicando entidades, atributos, relacionamentos, cardinalidades*/



/// <summary>
/// Codigo Categoria chave primaria
/// </summary>
class Categoria
{
    public int CodCategoaria { get; set; } 
    public string Descricao { get; set; }
    public bool Ativo { get; set; }

    public Categoria( int codcategoria, string descricao, bool ativo)
    {
        this.CodCategoaria = codcategoria;
        this.Descricao = descricao;
        this.Ativo = ativo;
    }
    
}


/// <summary>
/// Codigo do Ator chave primaria
/// </summary>
class Ator
{
    
    public int CodAtor { get; set; }  
    public string Apelido { get; set; }
    public string Nome { get; set; }
    public DateTime Datanascimento { get; set; }
    public bool Ativo { get; set; }


    public Ator( int codator, string apelido, string nome, DateTime datanascimento, bool ativo)
    {
        this.CodAtor = codator;
        this.Apelido = apelido;
        this.Nome = nome;
        this.Datanascimento = datanascimento;
        this.Ativo = ativo;

    }
}


/// <summary>
/// Codigo do filme  Chave primaria
/// </summary>
class Filme
{
    public int CodFilme { get; set; } 
    public string titulo { get; set; }

    /// <summary>
    /// relacionamento Filme 1 n  -------  1 nCategoria  ==> pode ser chave estrangeira
    /// </summary>
    public Categoria categoria { get; set; }  

    /// <summary>
    /// referência ator para saber se estar ativo  ==> pode ser chave estrangeira
    /// </summary>
    public Ator ator { get; set; }

    public Filme( int codfilme, string titulo, Categoria categoria, Ator ator)
    {
        this.CodFilme = codfilme;
        this.titulo = titulo;
        this.categoria = categoria;
        this.ator = ator;
    }
}



/// <summary>
/// Codigo do cliente chave primaria
/// </summary>
class Cliente
{
    public int CdCliente { get; set; }  
    public string prenome { get; set; }
    public string sobrenome { get; set; }
    public int telefone { get; set; }
    public string endereco { get; set; }
    public bool Ativo { get; set; }

    public Cliente(int codcliente, string prenome, string sobrenome, int telefone, string genero, bool ativo)
    {
        this.CdCliente = codcliente;
        this.prenome = prenome;
        this.sobrenome = sobrenome;
        this.telefone = telefone;
        this.endereco = endereco;
        this.Ativo = ativo;

    }
}


/// <summary>
/// Cliente, Filme, data, hora => formam a chave primaria
/// codigo do filme referência filme
/// codigo do Cliente referência Cliente
/// </summary>
class Aluguel
{
    /// <summary>
    ///para que seja feito um emprestimo de filme é necessario ter uma lista com 1 ou mais filmes
    /// </summary>
    public Filme Filme { get; set; }
    /// <summary>
    ///  para um aluguel ser atribuido a um cliente será necessario o cliente estar cadastrado
    /// </summary>
    public Cliente Cliente { get; set; }
    public DateTime data { get; set; }
    public DateTime hora { get; set; }


    public Aluguel( Filme filme, Cliente cliente, DateTime data, DateTime hora)
    {
        this.Filme = filme;
        this.Cliente = cliente;
        this.data = data;
        this.hora = hora;


    }
}