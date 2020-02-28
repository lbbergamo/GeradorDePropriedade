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

        static string getEset(string nome)
        {
            string propriedade = "private String " + nome;
            string set = "public void set" + nome + "(string _" + nome + ") { " + nome + " = _" + nome + "; }";
            string get = "public String get" + nome + "() { return " + nome + ";}";
            // public void setB(string _b) { b = _b; }
            // public String getB() { return b; }
            //private String b;
            return propriedade + "\n" + set + "\n" + get;
        }

        public static void geradorTxt(string nome)
        {
            StreamWriter x;
          
            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = @"C:\\Users\\Public\\arq01.txt";

            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoNome);
            //Console.ReadKey();
            x.Write(getEset(nome));
            x.Close();
        }
    }
}
