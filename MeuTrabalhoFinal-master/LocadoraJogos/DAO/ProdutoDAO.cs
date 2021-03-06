﻿using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.DAO
{
    public class ProdutosDAO
    {
        public void Adiciona(Produto produto)
        {
            using (var context = new LojaContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public IList<Produto> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Produtos.Include("Categoria").ToList();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Produtos.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
            }
        }

        public int BuscaQuantidade(int id)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Produtos.Find(id).Quantidade;
            }
        }
    }
}

 