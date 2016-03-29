using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MessageBox.Show(openFileDialog.FileName);
        }
    }
}
