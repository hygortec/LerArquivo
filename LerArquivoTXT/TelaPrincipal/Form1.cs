using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrir(String caminho)
        {
            if (File.Exists(caminho))
            {
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    tbSaida.Text += Environment.NewLine + linha;                    
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }

        }

        private void acaoBotaoBuscar(object sender, EventArgs e)
        {
            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Title = "Selecionar AFD";
            //openFileDialog.InitialDirectory = @"C:\Users\macoratti\Pictures";
            openFileDialog.Filter = "ARQUIVOS (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            DialogResult caixaDialogo = this.openFileDialog.ShowDialog();

            //MessageBox.Show(Convert.ToString(dr));
            //MessageBox.Show(openFileDialog.FileName);
            tbCaminho.Text = openFileDialog.FileName;
            
            

            abrir(openFileDialog.FileName);
        }
    }
}
