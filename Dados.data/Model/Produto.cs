using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Produto
{
    public int Id { get; set; }

    public int MarcaId { get; set; }

    public int CategoriaId { get; set; }

    public string Nome { get; set; } = null!;

    public double? Preco { get; set; }

    public int CodigoBarra { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual Marca Marca { get; set; } = null!;

    public virtual ICollection<Estoque> Estoques { get; set; } = new List<Estoque>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
