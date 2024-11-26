using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Pedido
{
    public int Id { get; set; }

    public int FornecedorId { get; set; }

    public int? NumPedido { get; set; }

    public DateOnly? DataPedido { get; set; }

    public double? ValorTotalPedido { get; set; }

    public string? Status2 { get; set; }

    public virtual Fornecedor Fornecedor { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
