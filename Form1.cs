using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace GeradorDePropriedade
{
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e) //btn Salvar
        {
            tbListaComposto.Enabled = false;
            string nome = tbListaComposto.Text;
            string[] separado = nome.Split('\n');
            string texto = gerador.lista(separado);
            ErroBLL.validaDados(separado);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                gerador.geradorTxt(texto);
                MessageBox.Show("Arquivo Gerado na Pasta -> C:\\Users\\Public\\arq01.txt ", "Funcionando");
            }
        }
        private void Button1_Click(object sender, EventArgs e) //btn Copiar
        {
            tbListaComposto.Enabled = false;
            string nome = tbListaComposto.Text;
            string[] separado = nome.Split('\n');
            string texto = gerador.lista(separado);

            ErroBLL.validaDados(separado);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                Clipboard.SetText(texto);
                MessageBox.Show("Utilize o Ctrl+V", "Funcionando");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbListaComposto.Enabled = true;
            tbListaComposto.Clear();
        }

        private void TbListaComposto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTeste1_Click(object sender, EventArgs e)
        {


        }
    }
}
