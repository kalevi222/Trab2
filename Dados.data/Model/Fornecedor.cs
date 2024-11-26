using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Fornecedor
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Contato { get; set; }

    public string? Endereco { get; set; }

    public string Cnpj { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
