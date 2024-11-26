using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;
namespace Dados.data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DBLPJMNContext db;
        public ProdutoRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Produto oProduto)
        {
            db.Entry(oProduto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Produto oProduto)
        {
            db.Entry(oProduto).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Produto oProduto)
        {
            db.Produtos.Add(oProduto);
            db.SaveChanges();
        }

        public Produto? SelecionaPelaChave(int id)
        {
            return db.Produtos.Find(id);
        }

        public List<Produto> SelecionarTodos()
        {
            return db.Produtos.ToList();
        }
    }
}
