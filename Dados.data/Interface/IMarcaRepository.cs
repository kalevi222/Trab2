using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IMarcaRepository
    {
        void Incluir(Marca oMarca);
        void Alterar(Marca oMarca);
        void Excluir (Marca oMarca);
        Marca? SelecionaPelaChave (int id);
        List<Marca> SelecionarTodos();
    }
}
