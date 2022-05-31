using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {/* 
     acessar url https://grupolhasa.com.br/portal/acessar
     acessar sistema
     email: keidi@grupolhasa.com.br
     senha: 123456
     https://grupolhasa.com.br/cadastro/proposta_operacional/index

     
        */
        public Form1()
        {
            InitializeComponent();
        }


        ChromeDriver drv;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pesquisarCidade.Text == "")
            {
                MessageBox.Show("Você precisa informar uma cidade");
                return;
            }

            drv = new ChromeDriver();   

            string url = txtSite.Text + "/search?q=temperatura+" + pesquisarCidade.Text;
            drv.Navigate().GoToUrl(url);
            Thread.Sleep(1000);

            string temp = drv.FindElement(By.Id("wob_tm")).Text;
            string hora = drv.FindElement(By.ClassName("wob_dts")).Text;
            
            MessageBox.Show("A temperatura é",temp +  "e a hora é" + hora);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
