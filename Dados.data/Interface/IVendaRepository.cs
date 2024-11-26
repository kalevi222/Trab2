using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IVendaRepository
    {
        void Incluir(Venda oVenda);
        void Alterar(Venda oVenda);
        void Excluir(Venda oVenda);
        Venda? SelecionaPelaChave(int id);
        List<Venda> SelecionarTodos();
    }
}

