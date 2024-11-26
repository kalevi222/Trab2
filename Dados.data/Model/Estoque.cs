using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Estoque
{
    public int Id { get; set; }

    public DateOnly Validade { get; set; }

    public int Lote { get; set; }

    public int QuantidadeAdicionada { get; set; }

    public DateOnly? DataAdicao { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
