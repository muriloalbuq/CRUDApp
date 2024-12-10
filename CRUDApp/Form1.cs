using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lojasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lojasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRUDAppDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cRUDAppDBDataSet.Lojas'. Você pode movê-la ou removê-la conforme necessário.
            this.lojasTableAdapter.Fill(this.cRUDAppDBDataSet.Lojas);

        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lojaCodigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void lojaCodigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cdMunicipioLabel_Click(object sender, EventArgs e)
        {

        }

        private void cdMunicipioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cPF_CNPJLabel_Click(object sender, EventArgs e)
        {

        }

        private void cPF_CNPJTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paisLabel_Click(object sender, EventArgs e)
        {

        }

        private void paisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cEPLabel_Click(object sender, EventArgs e)
        {

        }

        private void cEPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homePageLabel_Click(object sender, EventArgs e)
        {

        }

        private void homePageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void municipioLabel_Click(object sender, EventArgs e)
        {

        }

        private void municipioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dDDLabel_Click(object sender, EventArgs e)
        {

        }

        private void dDDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fisicaJuridicaLabel_Click(object sender, EventArgs e)
        {

        }

        private void fisicaJuridicaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoEnderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoEnderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataAberturaLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataAberturaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
