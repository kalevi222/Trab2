using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface ICategoriaRepository
    {
        void Incluir(Categoria oCategoria);
        void Alterar(Categoria oCategoria);
        void Excluir(Categoria oCategoria);
        Categoria? SelecionaPelaChave(int id);
        List<Categoria> SelecionarTodos();
    }
}
