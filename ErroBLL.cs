using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePropriedade
{
    class ErroBLL
    {
        public static void validaDados(string[] nome)
        {
            Erro.setErro(false);
            for (int i = 0; i < nome.Length; i++)
            {
                string teste1 = nome[i];
                for (int x = 0; x < teste1.Length; x++)
                {
                    char var = teste1[x];
                    if (var.Equals(' '))
                    {
                        Erro.setErro(true);
                        Erro.setErro("Contem Espaço em branco ou nulo");
                    }
                }
   
            }
        }
    }
}
