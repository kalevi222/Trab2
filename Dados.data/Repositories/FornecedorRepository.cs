using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;

namespace Dados.data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private DBLPJMNContext db;
        public FornecedorRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Fornecedor oFornecedor)
        {
            db.Entry(oFornecedor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Fornecedor oFornecedor)
        {
            db.Entry(oFornecedor).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Fornecedor oFornecedor)
        {
            db.Fornecedors.Add(oFornecedor);
            db.SaveChanges();
        }

        public Fornecedor? SelecionaPelaChave(int id)
        {
            return db.Fornecedors.Find (id);
        }

        public List<Fornecedor> SelecionarTodos()
        {
            return db.Fornecedors.ToList();
        }
    }
}
