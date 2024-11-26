using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Venda
{
    public int Id { get; set; }

    public double? ValorTotalVenda { get; set; }

    public double? ValorTotalUniVenda { get; set; }

    public virtual ICollection<Estoque> Estoques { get; set; } = new List<Estoque>();
}
