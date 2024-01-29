using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeBindingSource.Add(new Employee() { EmployeeId = "E01", EmployeeName = "Angel", EmployeeDept = "Software", Food = true, Gender = "Female" });
            employeeBindingSource.Add(new Employee() { EmployeeId = "E02", EmployeeName = "Bob", EmployeeDept = "Hardware", Food = true, Gender = "Male" });
            employeeBindingSource.Add(new Employee() { EmployeeId = "E03", EmployeeName = "Ceaser", EmployeeDept = "Mechanical", Food = false, Gender = "Male" });
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewEmployee.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you want to Delete this Employee ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employeeBindingSource.RemoveCurrent();
                }
            }

        }

        private void btnGetFoodCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < DataGridViewEmployee.Rows.Count - 1; i++)
            {
                string ischecked = (DataGridViewEmployee.Rows[i].Cells[4].Value).ToString();
                if (ischecked == "True")
                    count++;
            }
            MessageBox.Show("The Employee  Food Count is : " + count.ToString() + " .");
        }

       
    }
}
