using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLogin
{

    public partial class Form1 : Form
    {
        //public class Usuario
        //{

        //    public String user;
        //    public String email;
        //    public String pswd;

        //    //Console.WriteLine(todosUsuarios[0].nombre);

        //}
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email1 = textBox1.Text;
            string pasword = textBox2.Text;
            Form2.Usuario usuarioEncontrado = Form2.todosUsuarios.FirstOrDefault(u => u.email == email1 && u.pswd == pasword);

            if (usuarioEncontrado != null)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                // Los datos no coinciden con ningún usuario en la lista
                MessageBox.Show("Los datos no coinciden con ningún usuario en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (textBox1.Text == "correo" && textBox2.Text == "contraseña")
            //{
            //    Form f3 = new Form3();
            //    f3.ShowDialog();
            //}
            //else if(textBox1.Text != "correo" || textBox2.Text != "contraseña")
            //{
            //    MessageBox.Show("El correo y/o la contraseña no son correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
