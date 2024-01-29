namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewEmployee = new System.Windows.Forms.DataGridView();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewComboBoxColumn();
            employeeDeptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Food = new DataGridViewCheckBoxColumn();
            Delete = new DataGridViewButtonColumn();
            employeeBindingSource = new BindingSource(components);
            btnGetFoodCount = new Button();
            employeeBindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewEmployee
            // 
            DataGridViewEmployee.AutoGenerateColumns = false;
            DataGridViewEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEmployee.Columns.AddRange(new DataGridViewColumn[] { employeeIdDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn, Gender, employeeDeptDataGridViewTextBoxColumn, Food, Delete });
            DataGridViewEmployee.DataSource = employeeBindingSource;
            DataGridViewEmployee.Location = new Point(39, 120);
            DataGridViewEmployee.Margin = new Padding(3, 2, 3, 2);
            DataGridViewEmployee.Name = "DataGridViewEmployee";
            DataGridViewEmployee.RowHeadersWidth = 51;
            DataGridViewEmployee.Size = new Size(907, 287);
            DataGridViewEmployee.TabIndex = 0;
            DataGridViewEmployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Gender.HeaderText = "Gender";
            Gender.Items.AddRange(new object[] { "Male", "Female" });
            Gender.Name = "Gender";
            Gender.Width = 150;
            // 
            // employeeDeptDataGridViewTextBoxColumn
            // 
            employeeDeptDataGridViewTextBoxColumn.DataPropertyName = "EmployeeDept";
            employeeDeptDataGridViewTextBoxColumn.HeaderText = "EmployeeDept";
            employeeDeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeDeptDataGridViewTextBoxColumn.Name = "employeeDeptDataGridViewTextBoxColumn";
            employeeDeptDataGridViewTextBoxColumn.Width = 150;
            // 
            // Food
            // 
            Food.DataPropertyName = "Food";
            Food.FalseValue = "False";
            Food.HeaderText = "Food";
            Food.Name = "Food";
            Food.ToolTipText = "Yes/No";
            Food.TrueValue = "True";
            Food.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // btnGetFoodCount
            // 
            btnGetFoodCount.BackColor = SystemColors.GradientInactiveCaption;
            btnGetFoodCount.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetFoodCount.Location = new Point(402, 429);
            btnGetFoodCount.Name = "btnGetFoodCount";
            btnGetFoodCount.Size = new Size(193, 39);
            btnGetFoodCount.TabIndex = 1;
            btnGetFoodCount.Text = "Food Count";
            btnGetFoodCount.UseVisualStyleBackColor = false;
            btnGetFoodCount.Click += btnGetFoodCount_Click;
            // 
            // employeeBindingSource1
            // 
            employeeBindingSource1.DataSource = typeof(Employee);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(DataGridViewEmployee);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGetFoodCount);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 495);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(283, 53);
            label2.Name = "label2";
            label2.Size = new Size(428, 35);
            label2.TabIndex = 3;
            label2.Text = "DataGridView - Employee";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 521);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewEmployee;
        private BindingSource employeeBindingSource;
        private Button btnGetFoodCount;
        private BindingSource employeeBindingSource1;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Gender;
        private DataGridViewTextBoxColumn employeeDeptDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Food;
        private DataGridViewButtonColumn Delete;
        private Panel panel1;
        private Label label2;
    }
}
