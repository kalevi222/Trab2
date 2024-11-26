using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;
namespace Dados.data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private DBLPJMNContext db;
        public CategoriaRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Categoria oCategoria)
        {
            db.Entry(oCategoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Categoria oCategoria)
        {
            db.Entry(oCategoria).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Categoria oCategoria)
        {
            db.Categoria.Add(oCategoria);
            db.SaveChanges();
        }

        public Categoria? SelecionaPelaChave(int id)
        {
            return db.Categoria.Find(id);
        }

        public List<Categoria> SelecionarTodos()
        {
            return db.Categoria.ToList();
        }
    }
}
