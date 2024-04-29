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

namespace listadecontatos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private contato[] contatos = new contato[1];

        private void Escrever(contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
            }

            escreverEmArquivo.Close();
        }

        private void Ler()



        

    

        {
            StreamReader lerarquivo = new StreamReader("contatos.txt");
            contatos = new contato[Convert.ToInt32(lerarquivo.ReadLine())];


            for (int x = 0;x < contatos.Length; x++)
            {
                contatos[x] = new contato();
                contatos[x].Nome = lerarquivo.ReadLine();
                contatos[x].Sobrenome = lerarquivo.ReadLine();
                contatos[x].Telefone = lerarquivo.ReadLine();

            }

        }

        private void Exibir()
        {
            ListadeContatos.Items.Clear();

            for (int x = 0; x < contatos.Length; x++)
            {
                ListadeContatos.Items.Add(contatos[x].ToString());
            }
        }

        private void LimparFormulario()
        {
            TextBoxNome.Text = string.Empty;
            TextBoxSobrenome.Text = string.Empty;
            TextBoxTelefone.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contato contato = new contato();
            contato.Nome = TextBoxSobrenome.Text;
            contato.Nome = TextBoxNome.Text;   
            contato.Nome = TextBoxTelefone.Text;

                //ListadeContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            LimparFormulario();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }
    }
}
