using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.DAO
{
    public class UsuarioDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new LojaContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public void Remove(Usuario usuario)
        {
            using (var contexto = new LojaContext())
            {
                contexto.Usuarios.Remove(usuario);
                contexto.SaveChanges();
            }
        }


        public void Atualiza(Usuario usuario)
        {
            using (var contexto = new LojaContext())
            {
                contexto.Usuarios.Update(usuario);
                contexto.SaveChanges();
            }
        }
        public Usuario BuscaPorId(int id)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }

        public bool BuscaPorNome(string nome)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.Where(u => u.Nome == nome).FirstOrDefault() != null;
            }
        }
    }
}
