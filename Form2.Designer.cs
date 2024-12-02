namespace Marcihelp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            listBox1 = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            rendelesBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            cimBindingSource = new BindingSource(components);
            cimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hazszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            varosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iranyitoszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orszagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(1174, 494);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.DataSource = ugyfelBindingSource;
            listBox1.DisplayMember = "Nev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(57, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 409);
            listBox1.TabIndex = 1;
            listBox1.ValueMember = "UgyfelID";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cimIdDataGridViewTextBoxColumn, utcaDataGridViewTextBoxColumn, hazszamDataGridViewTextBoxColumn, varosDataGridViewTextBoxColumn, iranyitoszamDataGridViewTextBoxColumn, orszagDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn, ugyfelDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cimBindingSource;
            dataGridView1.Location = new Point(407, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 289);
            dataGridView1.TabIndex = 3;
            // 
            // cimBindingSource
            // 
            cimBindingSource.DataSource = typeof(Models.Cim);
            // 
            // cimIdDataGridViewTextBoxColumn
            // 
            cimIdDataGridViewTextBoxColumn.DataPropertyName = "CimId";
            cimIdDataGridViewTextBoxColumn.HeaderText = "CimId";
            cimIdDataGridViewTextBoxColumn.Name = "cimIdDataGridViewTextBoxColumn";
            // 
            // utcaDataGridViewTextBoxColumn
            // 
            utcaDataGridViewTextBoxColumn.DataPropertyName = "Utca";
            utcaDataGridViewTextBoxColumn.HeaderText = "Utca";
            utcaDataGridViewTextBoxColumn.Name = "utcaDataGridViewTextBoxColumn";
            // 
            // hazszamDataGridViewTextBoxColumn
            // 
            hazszamDataGridViewTextBoxColumn.DataPropertyName = "Hazszam";
            hazszamDataGridViewTextBoxColumn.HeaderText = "Hazszam";
            hazszamDataGridViewTextBoxColumn.Name = "hazszamDataGridViewTextBoxColumn";
            // 
            // varosDataGridViewTextBoxColumn
            // 
            varosDataGridViewTextBoxColumn.DataPropertyName = "Varos";
            varosDataGridViewTextBoxColumn.HeaderText = "Varos";
            varosDataGridViewTextBoxColumn.Name = "varosDataGridViewTextBoxColumn";
            // 
            // iranyitoszamDataGridViewTextBoxColumn
            // 
            iranyitoszamDataGridViewTextBoxColumn.DataPropertyName = "Iranyitoszam";
            iranyitoszamDataGridViewTextBoxColumn.HeaderText = "Iranyitoszam";
            iranyitoszamDataGridViewTextBoxColumn.Name = "iranyitoszamDataGridViewTextBoxColumn";
            // 
            // orszagDataGridViewTextBoxColumn
            // 
            orszagDataGridViewTextBoxColumn.DataPropertyName = "Orszag";
            orszagDataGridViewTextBoxColumn.HeaderText = "Orszag";
            orszagDataGridViewTextBoxColumn.Name = "orszagDataGridViewTextBoxColumn";
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            // 
            // ugyfelDataGridViewTextBoxColumn
            // 
            ugyfelDataGridViewTextBoxColumn.DataPropertyName = "Ugyfel";
            ugyfelDataGridViewTextBoxColumn.HeaderText = "Ugyfel";
            ugyfelDataGridViewTextBoxColumn.Name = "ugyfelDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 529);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource rendelesBindingSource;
        private BindingSource ugyfelBindingSource;
        private DataGridViewTextBoxColumn cimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn utcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hazszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iranyitoszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orszagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelDataGridViewTextBoxColumn;
        private BindingSource cimBindingSource;
    }
}