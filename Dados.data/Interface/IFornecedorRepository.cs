using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Dados.data.Interface
{
    public interface IFornecedorRepository
    {
        void Incluir(Fornecedor oFornecedor);
        void Alterar(Fornecedor oFornecedor);
        void Excluir(Fornecedor oFornecedor);
        Fornecedor? SelecionaPelaChave(int id);
        List<Fornecedor> SelecionarTodos();

    }
}
