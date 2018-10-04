using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LocadoraJogos.Models;

namespace LocadoraJogos.DAO
{
    public class DescontoDAO
    {
        public void Adiciona(Desconto desconto)
        {
            using (var context = new LojaContext())
            {
                context.Descontos.Add(desconto);
                context.SaveChanges();
            }
        }

        public IList<Desconto> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Descontos.ToList();
            }
        }

        public void Atualiza(Desconto desconto)
        {
            using (var contexto = new LojaContext())
            {
                contexto.Descontos.Update(desconto);
                contexto.SaveChanges();
            }
        }
        public Desconto BuscaPorId(int id)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Descontos.Find(id);
            }
        }

        public Desconto BuscaPorCodigo(string codigo)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Descontos.FirstOrDefault(d => d.CodigoDoDesconto == codigo);
            }
        }
    }
}