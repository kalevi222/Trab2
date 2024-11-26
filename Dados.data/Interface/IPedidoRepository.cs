using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IPedidoRepository
    {
        void Incluir(Pedido oPedido);
        void Alterar(Pedido oPedido);
        void Excluir(Pedido oPedido);
        Pedido? SelecionaPelaChave(int id);
        List<Pedido> SelecionarTodos();
    }
}

