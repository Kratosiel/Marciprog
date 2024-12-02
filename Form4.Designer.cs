namespace Marcihelp
{
    partial class Form4
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
            szuroTextBox = new TextBox();
            ugyfelekListBox = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rendelesekLsitBox = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            rendelesekComboBox = new ComboBox();
            cimEgybenDTO1BindingSource = new BindingSource(components);
            label5 = new Label();
            kedvezmenyTextBox = new TextBox();
            label6 = new Label();
            statuszComboBox = new ComboBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            mennyisegTextBox = new TextBox();
            hozzaadButton = new Button();
            torolButton = new Button();
            label8 = new Label();
            termekekListBox = new ListBox();
            termekBindingSource = new BindingSource(components);
            ujrendelesButton = new Button();
            label9 = new Label();
            mentesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTO1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // szuroTextBox
            // 
            szuroTextBox.Location = new Point(29, 25);
            szuroTextBox.Name = "szuroTextBox";
            szuroTextBox.Size = new Size(193, 23);
            szuroTextBox.TabIndex = 0;
            szuroTextBox.TextChanged += szuroTextBox_TextChanged;
            // 
            // ugyfelekListBox
            // 
            ugyfelekListBox.DataSource = ugyfelBindingSource;
            ugyfelekListBox.DisplayMember = "Nev";
            ugyfelekListBox.FormattingEnabled = true;
            ugyfelekListBox.ItemHeight = 15;
            ugyfelekListBox.Location = new Point(29, 85);
            ugyfelekListBox.Name = "ugyfelekListBox";
            ugyfelekListBox.Size = new Size(193, 469);
            ugyfelekListBox.TabIndex = 1;
            ugyfelekListBox.ValueMember = "UgyfelID";
            ugyfelekListBox.SelectedIndexChanged += ugyfelekListBox_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 67);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Rendelések";
            // 
            // rendelesekLsitBox
            // 
            rendelesekLsitBox.DataSource = rendelesBindingSource;
            rendelesekLsitBox.DisplayMember = "RendelesDatum";
            rendelesekLsitBox.FormattingEnabled = true;
            rendelesekLsitBox.ItemHeight = 15;
            rendelesekLsitBox.Location = new Point(229, 85);
            rendelesekLsitBox.Name = "rendelesekLsitBox";
            rendelesekLsitBox.Size = new Size(199, 469);
            rendelesekLsitBox.TabIndex = 5;
            rendelesekLsitBox.ValueMember = "RendelesId";
            rendelesekLsitBox.SelectedIndexChanged += rendelesekLsitBox_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // rendelesekComboBox
            // 
            rendelesekComboBox.DataBindings.Add(new Binding("SelectedValue", rendelesBindingSource, "SzallitasiCimId", true, DataSourceUpdateMode.OnPropertyChanged));
            rendelesekComboBox.DataSource = cimEgybenDTO1BindingSource;
            rendelesekComboBox.DisplayMember = "CimEgyben";
            rendelesekComboBox.FormattingEnabled = true;
            rendelesekComboBox.Location = new Point(451, 85);
            rendelesekComboBox.Name = "rendelesekComboBox";
            rendelesekComboBox.Size = new Size(410, 23);
            rendelesekComboBox.TabIndex = 7;
            rendelesekComboBox.ValueMember = "CimId";
            // 
            // cimEgybenDTO1BindingSource
            // 
            cimEgybenDTO1BindingSource.DataSource = typeof(Models.CimEgybenDTO1);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 67);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 8;
            label5.Text = "Rendelés címe";
            // 
            // kedvezmenyTextBox
            // 
            kedvezmenyTextBox.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Kedvezmeny", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00%"));
            kedvezmenyTextBox.Location = new Point(867, 85);
            kedvezmenyTextBox.Name = "kedvezmenyTextBox";
            kedvezmenyTextBox.Size = new Size(100, 23);
            kedvezmenyTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(867, 67);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 10;
            label6.Text = "Kedvezmény";
            // 
            // statuszComboBox
            // 
            statuszComboBox.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            statuszComboBox.FormattingEnabled = true;
            statuszComboBox.Items.AddRange(new object[] { "Feldolgozás alatt", "Szállítás", "Kiszállítva", "Törölve" });
            statuszComboBox.Location = new Point(973, 85);
            statuszComboBox.Name = "statuszComboBox";
            statuszComboBox.Size = new Size(131, 23);
            statuszComboBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(973, 67);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Státusz";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(714, 428);
            dataGridView1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1188, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 14;
            label4.Text = "Mennyiség";
            // 
            // mennyisegTextBox
            // 
            mennyisegTextBox.Location = new Point(1188, 183);
            mennyisegTextBox.Name = "mennyisegTextBox";
            mennyisegTextBox.Size = new Size(100, 23);
            mennyisegTextBox.TabIndex = 15;
            // 
            // hozzaadButton
            // 
            hozzaadButton.Location = new Point(1188, 243);
            hozzaadButton.Name = "hozzaadButton";
            hozzaadButton.Size = new Size(100, 47);
            hozzaadButton.TabIndex = 16;
            hozzaadButton.Text = "Tétel hozzáadása";
            hozzaadButton.UseVisualStyleBackColor = true;
            hozzaadButton.Click += hozzaadButton_Click;
            // 
            // torolButton
            // 
            torolButton.Location = new Point(1188, 306);
            torolButton.Name = "torolButton";
            torolButton.Size = new Size(100, 52);
            torolButton.TabIndex = 17;
            torolButton.Text = "Tétel törlése";
            torolButton.UseVisualStyleBackColor = true;
            torolButton.Click += torolButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1368, 67);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 18;
            label8.Text = "Termékek";
            // 
            // termekekListBox
            // 
            termekekListBox.DataSource = termekBindingSource;
            termekekListBox.DisplayMember = "Nev";
            termekekListBox.FormattingEnabled = true;
            termekekListBox.ItemHeight = 15;
            termekekListBox.Location = new Point(1368, 101);
            termekekListBox.Name = "termekekListBox";
            termekekListBox.Size = new Size(227, 454);
            termekekListBox.TabIndex = 19;
            termekekListBox.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // ujrendelesButton
            // 
            ujrendelesButton.Location = new Point(229, 572);
            ujrendelesButton.Name = "ujrendelesButton";
            ujrendelesButton.Size = new Size(199, 23);
            ujrendelesButton.TabIndex = 20;
            ujrendelesButton.Text = "Új rendelés";
            ujrendelesButton.UseVisualStyleBackColor = true;
            ujrendelesButton.Click += ujrendelesButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(451, 580);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 21;
            label9.Text = "A rendelés teljes értéke:";
            // 
            // mentesButton
            // 
            mentesButton.Location = new Point(1050, 570);
            mentesButton.Name = "mentesButton";
            mentesButton.Size = new Size(115, 35);
            mentesButton.TabIndex = 22;
            mentesButton.Text = "Mentés";
            mentesButton.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1723, 633);
            Controls.Add(mentesButton);
            Controls.Add(label9);
            Controls.Add(ujrendelesButton);
            Controls.Add(termekekListBox);
            Controls.Add(label8);
            Controls.Add(torolButton);
            Controls.Add(hozzaadButton);
            Controls.Add(mennyisegTextBox);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(statuszComboBox);
            Controls.Add(label6);
            Controls.Add(kedvezmenyTextBox);
            Controls.Add(label5);
            Controls.Add(rendelesekComboBox);
            Controls.Add(rendelesekLsitBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ugyfelekListBox);
            Controls.Add(szuroTextBox);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTO1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox szuroTextBox;
        private ListBox ugyfelekListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox rendelesekLsitBox;
        private ComboBox rendelesekComboBox;
        private Label label5;
        private TextBox kedvezmenyTextBox;
        private Label label6;
        private ComboBox statuszComboBox;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox mennyisegTextBox;
        private Button hozzaadButton;
        private Button torolButton;
        private Label label8;
        private ListBox termekekListBox;
        private Button ujrendelesButton;
        private Label label9;
        private Button mentesButton;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource cimEgybenDTO1BindingSource;
        private BindingSource rendelesBindingSource;
    }
}