using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;
namespace Dados.data.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private DBLPJMNContext db;
        public MarcaRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Marca oMarca)
        {
            db.Entry(oMarca).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Marca oMarca)
        {
            db.Entry(oMarca).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Marca oMarca)
        {
            db.Marcas.Add(oMarca);
            db.SaveChanges();
        }

        public Marca SelecionaPelaChave(int id)
        {
            return db.Marcas.Find(id);
        }

        public List<Marca> SelecionarTodos()
        {
            return db.Marcas.ToList();
        }
    }
}
