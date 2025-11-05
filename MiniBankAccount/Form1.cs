using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankAccount
{
    public partial class Form1 : Form
    {
        List<BankAccount> AllAcount = new List<BankAccount>();
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            BankAccount bankAccount = new BankAccount(textBox1.Text);

            AllAcount.Add(bankAccount);

            RefreshGrid();
            MessageBox.Show("Account Create Successfuly");
        }
        public void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AllAcount;
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankAccount SelectAccout = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;
            SelectAccout.balance += numericUpDown1.Value;
            RefreshGrid();
            numericUpDown1.Value = 0;


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            BankAccount SelectAccout = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;
            decimal withdrawAmount = numericUpDown1.Value;

            if(SelectAccout.balance < withdrawAmount)
            {
                MessageBox.Show("Insufient Balance");
                return;
            }

            SelectAccout.balance -= numericUpDown1.Value;
            RefreshGrid();
            numericUpDown1.Value = 0;
        }
    }
}
