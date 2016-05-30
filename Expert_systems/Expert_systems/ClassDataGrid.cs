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
            Column_1.HeaderText = "Имя";
            Column_1.ReadOnly = true;
            Column_1.CellTemplate = Cell_1;

            DataGridViewColumn Column_2 = new DataGridViewColumn();
            Column_2.HeaderText = "Правило";
            Column_2.ReadOnly = true;
            Column_2.CellTemplate = Cell_2;

            DataGridViewColumn Column_3 = new DataGridViewColumn();
            Column_3.HeaderText = "Родитель";
            Column_3.ReadOnly = true;
            Column_3.CellTemplate = Cell_3;


            DataGridViewCheckBoxColumn Column_4 = new DataGridViewCheckBoxColumn();
            Column_4.HeaderText = "Обратимость";
            Column_4.ReadOnly = true;

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
            Column_1.HeaderText = "Правило";
            Column_1.ReadOnly = true;
            Column_1.CellTemplate = Cell_1;
            DataGridViewColumn Column_2 = new DataGridViewColumn();
            Column_2.HeaderText = "Значение";
            Column_2.ReadOnly = false;
            Column_2.CellTemplate = Cell_2;

            dgVariables.Columns.Add(Column_1);
            dgVariables.Columns.Add(Column_2);
        }

        public void Read_Hypothesis(string path)
        {

        }

    }
}