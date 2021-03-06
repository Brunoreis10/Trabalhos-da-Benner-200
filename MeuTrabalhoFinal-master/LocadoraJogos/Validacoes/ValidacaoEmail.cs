﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Validacoes
{
    public class ValidacaoEmail
    {
        public bool ValidarEmail(string strEmail)
        {
            if (strEmail == null)
            {
                return false;
            }
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}