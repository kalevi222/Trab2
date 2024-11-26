using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace Dados.data.Interface
{
    public interface IUsuarioRepository
    {
        void Incluir(Usuario oUsuario);
        void Alterar(Usuario oUsuario);
        void Excluir(Usuario oUsuario);
        Usuario? SelecionaPelaChave(int id);
        List<Usuario> SelecionarTodos();
    }
}

