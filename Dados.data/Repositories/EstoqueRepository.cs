using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;
namespace Dados.data.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private DBLPJMNContext db;
        public EstoqueRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Estoque oEstoque)
        {
            db.Entry(oEstoque).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Estoque oEstoque)
        {
            db.Entry(oEstoque).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Estoque oEstoque)
        {
            db.Estoques.Add(oEstoque);
            db.SaveChanges();
        }

        public Estoque SelecionaPelaChave(int id)
        {
            return db.Estoques.Find(id);
        }

        public List<Estoque> SelecionarTodos()
        {
            return db.Estoques.ToList();
        }
    }
}
