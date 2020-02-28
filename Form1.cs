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
            string nomeDaPropriedade = tbNome.Text;
            gerador.geradorTxt(nomeDaPropriedade);
            tbNome.Enabled = false;
            MessageBox.Show("Arquivo Gerado na Pasta -> C:\\Users\\Public\\arq01.txt ","Funcionando");
        }

        private void Button1_Click(object sender, EventArgs e) //btn Copiar
        {
            string nomeDaPropriedade = tbNome.Text;
            string teste = gerador.getEset(nomeDaPropriedade);
            Clipboard.SetText(teste);
            tbNome.Enabled = false;
            MessageBox.Show("Utilize o Ctrl+V" , "Funcionando");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbNome.Enabled = true;
            tbNome.Clear();
        }
    }
}
