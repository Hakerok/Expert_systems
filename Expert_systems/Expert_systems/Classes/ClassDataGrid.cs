using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Expert_systems
{
   

    public class ClassDataGrid : ClassExpertSystems
    {
        public DataGridView DgKonstanty;
        public DataGridView DgVariables;
        internal readonly List<Expert> Experts = new List<Expert>();

        public void FirstDataGrid()
        {
            this.DgKonstanty.AutoGenerateColumns = true;
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
           

            DataGridViewColumn column1 = new DataGridViewColumn { HeaderText = @"Имя", CellTemplate = cell1 };
            DataGridViewColumn column2 = new DataGridViewColumn { HeaderText = @"Правило" , CellTemplate = cell2 };
            DataGridViewColumn column3 = new DataGridViewColumn { HeaderText = @"Родитель", CellTemplate = cell2 };
            DataGridViewColumn column4 = new DataGridViewColumn { HeaderText = @"Вес", CellTemplate = cell3 };
            DataGridViewCheckBoxColumn column5 = new DataGridViewCheckBoxColumn { HeaderText = @"Обратимость" };

            DgKonstanty.ReadOnly = true;
            DgKonstanty.AllowUserToAddRows = false;
            DgKonstanty.AllowUserToDeleteRows = false;
            DgKonstanty.Columns.Add(column1);
            DgKonstanty.Columns.Add(column2);
            DgKonstanty.Columns.Add(column3);
            DgKonstanty.Columns.Add(column4);
            DgKonstanty.Columns.Add(column5);

        }

        public void SecondDataGrid()
        {
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();

            DataGridViewColumn column1 = new DataGridViewColumn
                                              {
                                                  HeaderText = @"Правило",
                                                  ReadOnly = true,
                                                  CellTemplate = cell1
                                              };

            DataGridViewColumn column2 = new DataGridViewColumn
                                              {
                                                  HeaderText = @"Значение",
                                                  ReadOnly = false,
                                                  CellTemplate = cell2
                                              };
            DgVariables.AllowUserToAddRows = false;
            DgVariables.AllowUserToDeleteRows = false;
            DgVariables.Columns.Add(column1);
            DgVariables.Columns.Add(column2);
        }

        public void HypothesisRead(string path)
        {
            Experts.Clear();
            DgKonstanty.Rows.Clear();
            DgKonstanty.Refresh();
            DgVariables.Rows.Clear();
            DgVariables.Refresh();
            foreach (Expert temp in File.ReadAllLines(path).Select(t => t.Split(',')).Select(rS => new Expert
            {
                Name = rS[0],
                Rule = rS[1],
                Parent = rS[2],
                TheWeight = Convert.ToDouble(rS[3].Replace('.', ',')),
                Reversibility = rS[4] != "false"
            }))
            {
                Experts.Add(temp);
            }

            for (int i = 0; i < Experts.Count; i++)
            {
                DgKonstanty.Rows.Add();
                DgKonstanty.Rows[i].Cells[0].Value = Experts[i].Name;
                DgKonstanty.Rows[i].Cells[1].Value = Experts[i].Rule;
                DgKonstanty.Rows[i].Cells[2].Value = Experts[i].Parent;
                DgKonstanty.Rows[i].Cells[3].Value = Experts[i].TheWeight;
                DgKonstanty.Rows[i].Cells[4].Value = Experts[i].Reversibility;
            }
            foreach (Expert t in Experts)
            {
                var t2 = t;
                foreach (Expert t1 in Experts.Where(t1 => t2.Name == t1.Parent))
                {
                    t.Children.Add(t1);
                }
            }
            foreach (var i in Experts)
            {
                if (i.Children.Count != 0)
                {
                    continue;
                }
                int rowNumber = DgVariables.Rows.Add();
                DgVariables.Rows[rowNumber].Cells[0].Value = i.Rule;
            }
        }

    }
}
