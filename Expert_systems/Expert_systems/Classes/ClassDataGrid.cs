using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Expert_systems
{
    public class ClassDataGrid 
    {
      public List<ClassExpertModel> EMList = new List<ClassExpertModel>();
      public DataGridView dgKonstanty = new DataGridView();
      public DataGridView dgVariables = new DataGridView();
      
        public void First_DataGrid()
        {
            dgKonstanty.AutoGenerateColumns = true;
            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_4 = new DataGridViewTextBoxCell();

            DataGridViewColumn Column_1 = new DataGridViewColumn();
            DataGridViewColumn Column_2 = new DataGridViewColumn();
            DataGridViewColumn Column_3 = new DataGridViewColumn();
            DataGridViewCheckBoxColumn Column_4 = new DataGridViewCheckBoxColumn();

            Column_1.HeaderText = "Имя";
            Column_2.HeaderText = "Правило";
            Column_3.HeaderText = "Родитель";
            Column_4.HeaderText = "Обратимость";
            Column_1.CellTemplate = Cell_1;
            Column_2.CellTemplate = Cell_2;
            Column_3.CellTemplate = Cell_3;

            dgKonstanty.ReadOnly = true;
            dgKonstanty.AllowUserToAddRows = true;
            dgKonstanty.AllowUserToDeleteRows = true;
            dgKonstanty.Columns.Add(Column_1);
            dgKonstanty.Columns.Add(Column_2);
            dgKonstanty.Columns.Add(Column_3);
            dgKonstanty.Columns.Add(Column_4);

        }

        public void Second_DataGrid()
        {
            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();

            DataGridViewColumn Column_1 = new DataGridViewColumn();
            DataGridViewColumn Column_2 = new DataGridViewColumn();

            Column_1.HeaderText = "Правило";
            Column_2.HeaderText = "Значение";
            Column_1.ReadOnly = true;
            Column_2.ReadOnly = false;
            Column_1.CellTemplate = Cell_1;          
            Column_2.CellTemplate = Cell_2;

            dgVariables.AllowUserToAddRows = true;
            dgVariables.AllowUserToDeleteRows = true;
            dgVariables.Columns.Add(Column_1);
            dgVariables.Columns.Add(Column_2);
        }

        public void Read_Hypothesis(string path)
        {
            string[] ruleStrings = File.ReadAllLines(path);
            for (int i = 0; i < ruleStrings.Length; i++)
            {
                string[] rS = new string[5];
                rS = ruleStrings[i].Split(',');
                ClassExpertModel temp = new ClassExpertModel();
                temp.Name = rS[0];
                temp.Rule = rS[1];
                temp.Parent = rS[2];
                temp.Weight = Convert.ToDouble(rS[3].Replace('.', ','));
                if (rS[4] == "false")
                {
                    temp.Obratimost = false;
                }
                else
                {
                    temp.Obratimost = true;
                }
                EMList.Add(temp);
            }

            for (int i = 0; i < EMList.Count; i++)
            {
                dgKonstanty.Rows.Add();
                dgKonstanty.Rows[i].Cells[0].Value = EMList[i].Name;
                dgKonstanty.Rows[i].Cells[1].Value = EMList[i].Rule;
                dgKonstanty.Rows[i].Cells[2].Value = EMList[i].Parent;
                dgKonstanty.Rows[i].Cells[3].Value = EMList[i].Weight;
                dgKonstanty.Rows[i].Cells[4].Value = EMList[i].Obratimost;
            }
            for (int i = 0; i < EMList.Count; i++)
            {
                for (int j = 0; j < EMList.Count; j++)
                {
                    if (EMList[i].Name == EMList[j].Parent)
                    {
                        EMList[i].children.Add(EMList[j]);
                    }
                }
            }
            foreach (var z in EMList)
            {
                if (z.children.Count == 0)
                {
                    int rowNumber = dgVariables.Rows.Add();
                    dgVariables.Rows[rowNumber].Cells[0].Value = z.Rule;
                }
            }
        }

    }
}