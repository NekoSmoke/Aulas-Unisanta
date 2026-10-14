using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        #region variaveis globais
        int Contador = 1, Seleciona = 0;
        Double comprimento, angulo, angulorad, tempo;
        #endregion
        public Form1()
        {
            

            InitializeComponent();
        }

        private void Tmr_DataHora_Tick(object sender, EventArgs e)
        {
            Lbl_DataHora.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Seleciona = 0;
            Contador = 1;
            Btn_Calcular.Enabled = false;
            Btn_Limpar.Enabled = false;
            Txt_Comprimento.Visible = false;
            Txt_Angulo.Visible = false;
            Txt_Tempo.Visible = false;
        }

        private void Tmr_Animacao_Tick(object sender, EventArgs e)
        {
            Contador = Contador % 16 + 1;

            Pbx_Pendulo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pend" + Convert.ToString(Contador) + ".bmp");
        }
        #region Fechar Programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair?","Fechar aplicativo",MessageBoxButtons.YesNo,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button2) ==DialogResult.No)
                e.Cancel = true;            
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmar?","Limpar Dados",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {
                Seleciona = 0;
                Contador = 0;
                Rbt_Periodo.Checked = false;
                Rbt_Deslocamento.Checked = false;

                Txt_Comprimento.Clear();
                Txt_Angulo.Clear();
                Txt_Tempo.Clear();

                Txt_Comprimento.Visible = false;
                Txt_Angulo.Visible = false;
                Txt_Tempo.Visible = false;

                Lbx_Ensaio.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
