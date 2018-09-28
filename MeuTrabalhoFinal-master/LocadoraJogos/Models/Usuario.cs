using LocadoraJogos.DAO;
using LocadoraJogos.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataDeNascimento { get; set; }
        public bool Adminstrador { get; set; }

        public bool ValidaCadastro()
        {
            return new ValidacaoNome().ValidaNome(Nome);
        }

        
    }
}