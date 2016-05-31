using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;

namespace Expert_systems
{
    public partial class Form1 : Form
    {
        
        readonly ClassDataGrid classDg = new ClassDataGrid();
        ClassExpertSystems classEs;
        public Form1()
        {
           InitializeComponent();
          
        }
        
        private void Hypothesis1Click(object sender, EventArgs e)
        {
          
            try
            {
              string path = Environment.CurrentDirectory + @"\Hypothesis_1.dataES";
              classDg.HypothesisRead(path);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
           
            
        }

        private void Hypothesis2Click(object sender, EventArgs e)
        {
            try
            {
               string path = Environment.CurrentDirectory + @"\Hypothesis_2.dataES";
               classDg.HypothesisRead(path);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void CalculateClick(object sender, EventArgs e)
        {
           
        }

        private void ExitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Вы действительно хотите выйти?", @"Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1Load(object sender, EventArgs e)
        {
            classDg.DgKonstanty = dgKonstanty;
            classDg.DgVariables = dgVariables;
            classDg.FirstDataGrid();
            classDg.SecondDataGrid();
        }
    }
}

 