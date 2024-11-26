using System;
using System.Collections.Generic;

namespace Dados.data.Model;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool PermissaoProduto { get; set; }

    public bool PermissaoCategoria { get; set; }

    public bool PermissaoAdiRemProduto { get; set; }

    public bool PermissaoAdm { get; set; }

    public bool PermissaoCadastroUsuario { get; set; }

    public bool PermissaoFornecedor { get; set; }

    public bool PermissaoMarca { get; set; }

    public bool PermissaoGerirVenda { get; set; }

    public bool PermissaoGerirPedido { get; set; }
}
