using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeradorDePropriedade
{
    class gerador
    {
        public static string getEset(string nome)
        {
            string propriedade = "private String " + nome + ";";
            string set = "public void set" + nome + "(string _" + nome + ") { " + nome + " = _" + nome + "; }";
            string get = "public String get" + nome + "() { return " + nome + ";}";

            return propriedade + "\n" + set + "\n" + get;
        }

        public static void geradorTxt(string nome)
        {
            StreamWriter x;

            string CaminhoNome = @"C:\\Users\\Public\\arq01.txt";

            x = File.CreateText(CaminhoNome);

            x.Write(nome);
            x.Close();
            System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Public");
        }

        public static string lista(string[] nomes)
        {
            string codigoCompleto = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                codigoCompleto += getEset(nomes[i]) + "\n\n";
            }
            return codigoCompleto;
        }
    }
}
