using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class TelaImportarArquivo : Form
    {
        public TelaImportarArquivo()
        {
            InitializeComponent();
            //Banco b = new Banco();
           // b.conectaBanco("localhost\\sqlexpress","banco_dados","SGA","G3st0r");
        }

        private void abrir(String caminho)
        {
            if (File.Exists(caminho))
            {
                tbCaminho.Text = caminho;
                int quantidadeLinhas = contaLinhas(caminho);
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                string conteudo = "";             
                progressBar1.Visible = true;

                
                
                progressBar1.Value = 0;
                progressBar1.Maximum = quantidadeLinhas;

                int linhaAtual = 0;
                while (linha != null)
                {
                    progressBar1.Value = linhaAtual;
                    //tbSaida.Text +=  + linha;   
                    conteudo += linha + Environment.NewLine;                 
                    linha = leitor.ReadLine();
                    linhaAtual++;
                }
                tbSaida.Text = conteudo;
                MessageBox.Show("Importação efetuada com sucesso!!!");
                progressBar1.Visible = false;                
                leitor.Close();
                entrada.Close();
            }

        }
        private int contaLinhas(String caminho)
        {
            int cont = 0;
            if (File.Exists(caminho))
            {
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                

                while (linha != null)
                {                   
                    cont++;
                    linha = leitor.ReadLine();
                }                
                leitor.Close();
                entrada.Close();
            }
            return cont;            
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
            //numLinhas(openFileDialog.FileName);
        }

        private void tbCaminho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
