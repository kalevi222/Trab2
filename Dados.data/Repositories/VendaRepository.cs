using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;

namespace Dados.data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private DBLPJMNContext db;
        public VendaRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Venda oVenda)
        {
            db.Entry(oVenda).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Venda oVenda)
        {
            db.Entry(oVenda).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Venda oVenda)
        {
            db.Venda.Add(oVenda);
            db.SaveChanges();
        }

        public Venda? SelecionaPelaChave(int id)
        {
            return db.Venda.Find(id);
        }

        public List<Venda> SelecionarTodos()
        {
            return db.Venda.ToList();
        }
    }
}
