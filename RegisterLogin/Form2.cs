﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RegisterLogin
{
    
    public partial class Form2 : Form
    {
        public class Usuario
        {

            public String user;
            public String email;
            public String pswd;

            //Console.WriteLine(todosUsuarios[0].nombre);

        }

        public static List<Usuario> todosUsuarios = new List<Usuario>();

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AsterTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AsterTextBoxUser.Text == "" || AsterTextBoxEmail.Text == "" || AsterTextBoxPswd1.Text == "" || AsterTextBoxPswd2.Text == "")
            {
                MessageBox.Show("Se necesitan rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (AsterTextBoxPswd1.Text != AsterTextBoxPswd2.Text)
                {
                    MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Usuario a = new Usuario();

                    a.user = AsterTextBoxUser.Text;
                    a.email = AsterTextBoxEmail.Text;
                    a.pswd = AsterTextBoxPswd1.Text;

                    todosUsuarios.Add(a);

                    Console.WriteLine(todosUsuarios[0].user);
                    Console.WriteLine(todosUsuarios[0].email);
                    Console.WriteLine(todosUsuarios[0].pswd);

                    MessageBox.Show("Registro concedido con éxito", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AsterTextBoxUser.Text = "";
                    AsterTextBoxEmail.Text = "";
                    AsterTextBoxPswd1.Text = "";
                    AsterTextBoxPswd2.Text = "";
                    this.Dispose();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
            
        }

        private void AsterTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsterTextBoxUser.Text = "";
            AsterTextBoxEmail.Text = "";
            AsterTextBoxPswd1.Text = "";
            AsterTextBoxPswd2.Text = "";

            Console.WriteLine(todosUsuarios[0].user);
            Console.WriteLine(todosUsuarios[0].email);
            Console.WriteLine(todosUsuarios[0].pswd);

            this.Dispose();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
