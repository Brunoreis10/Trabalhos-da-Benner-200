using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Validacoes
{
    public class ValidacaoSenha
    {
        public bool VerificaSenhaForte(string senha)
        {
            if (senha.Length < 6 || senha.Length > 12)
                return false;
            if (!senha.Any(c => char.IsDigit(c)))
                return false;
            if (!senha.Any(c => char.IsUpper(c)))
                return false;
            if (!senha.Any(c => char.IsLower(c)))
                return false;
            if (!senha.Any(c => char.IsSymbol(c)))
                return false;

            var contadorRepetido = 0;
            var ultimoCaracter = '\0';
            foreach (var c in senha) 
    {
                if (c == ultimoCaracter)
                    contadorRepetido++;
                else
                    contadorRepetido = 0;
                if (contadorRepetido == 2)
                    return false;
                ultimoCaracter = c;
            }
            return true;
        }
    }
}