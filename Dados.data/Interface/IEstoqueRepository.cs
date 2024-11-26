using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IEstoqueRepository
    {
        void Incluir(Estoque oEstoque);
        void Alterar(Estoque oEstoque);
        void Excluir(Estoque oEstoque);
        Estoque? SelecionaPelaChave(int id);
        List<Estoque> SelecionarTodos();

    }
}
