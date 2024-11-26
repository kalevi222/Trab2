using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Interface;
using Dados.data.Model;

namespace Dados.data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DBLPJMNContext db;
        public UsuarioRepository(DBLPJMNContext context)
        {
            db = context;
        }
        public void Alterar(Usuario oUsuario)
        {
            db.Entry(oUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Usuario oUsuario)
        {
            db.Entry(oUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Usuario oUsuario)
        {
            db.Usuarios.Add(oUsuario);
            db.SaveChanges();
        }

        public Usuario? SelecionaPelaChave(int id)
        {
            return db.Usuarios.Find(id);
        }

        public List<Usuario> SelecionarTodos()
        {
            return db.Usuarios.ToList();
        }
    }
}
