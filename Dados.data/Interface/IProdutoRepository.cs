using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IProdutoRepository
    {
        void Incluir(Produto oProduto);
        void Alterar(Produto oProduto);
        void Excluir(Produto oProduto);
        Produto? SelecionaPelaChave(int id);
        List<Produto> SelecionarTodos();
    }
}

