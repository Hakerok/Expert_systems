using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert_systems
{
    public partial class Form1 : Form
    {
        ClassDataGrid class_dg = new ClassDataGrid();
        ClassExpertSystems class_es = new ClassExpertSystems();
        public Form1()
        {
           InitializeComponent();
           class_dg.dgKonstanty = dgKonstanty;
           class_dg.dgVariables = dgVariables;
           class_dg.First_DataGrid();
           class_dg.Second_DataGrid();
        }
        
        private void Hypothesis_1_Click(object sender, EventArgs e)
        {
            dgKonstanty.Rows.Clear();
            dgKonstanty.Refresh();
            dgVariables.Rows.Clear();
            dgVariables.Refresh();
            string path = Environment.CurrentDirectory + @"\Gipoteza1.dataES";
            class_dg.Read_Hypothesis(path);
        }

        private void Hypothesis_2_Click(object sender, EventArgs e)
        {
            dgKonstanty.Rows.Clear();
            dgKonstanty.Refresh();
            dgVariables.Rows.Clear();
            dgVariables.Refresh();
            string path = Environment.CurrentDirectory + @"\Gipoteza2.dataES";
            class_dg.Read_Hypothesis(path);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}

 