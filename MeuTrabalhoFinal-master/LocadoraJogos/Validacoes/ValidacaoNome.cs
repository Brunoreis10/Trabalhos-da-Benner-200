using LocadoraJogos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Validacoes
{
    public class ValidacaoNome
    {
        public bool ValidaNome(string nome)
        {
            if (nome == null)
            {
                return false;
            }

            if (nome.Length < 5 || nome.Length > 50)
            {
                return false;
            }

            UsuarioDAO dao = new UsuarioDAO();
            if (dao.BuscaPorNome(nome))
            {
                return false;
            }

            return true;
        }
    }
}