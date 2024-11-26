using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Marca
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
