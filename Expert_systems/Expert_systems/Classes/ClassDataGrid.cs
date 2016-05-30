using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Expert_systems
{
    public class ClassDataGrid 
    {
           
        public void First_DataGrid(DataGridView dgKonstanty)
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

        public void Second_DataGrid(DataGridView dgVariables)
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

    }
}