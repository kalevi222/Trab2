using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;
using Dados.data.Interface;
using Dados.data.Model;

namespace Dados.data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private DBLPJMNContext db;
        public PedidoRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Pedido oPedido)
        {
            db.Entry(oPedido).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Pedido oPedido)
        {
            db.Entry(oPedido).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Pedido oPedido)
        {
            db.Pedidos.Add(oPedido);
            db.SaveChanges();
        }

        public Pedido? SelecionaPelaChave(int id)
        {
            return db.Pedidos.Find(id);
        }

        public List<Pedido> SelecionarTodos()
        {
            return db.Pedidos.ToList();
        }
    }
}
