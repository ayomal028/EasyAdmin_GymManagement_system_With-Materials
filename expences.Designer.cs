namespace EasyAdmin.gym_management_system
{
    partial class expences
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expences));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_exit_expencesForm = new System.Windows.Forms.Button();
            this.dgv_expences = new System.Windows.Forms.DataGridView();
            this.btn_expencesSearch = new System.Windows.Forms.Button();
            this.btn_expence_Add = new System.Windows.Forms.Button();
            this.txt_expence_search = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_expence_delete = new System.Windows.Forms.Button();
            this.btn_expence_update = new System.Windows.Forms.Button();
            this.btn_expence_clear = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpdown_expences = new System.Windows.Forms.ComboBox();
            this.txt_expences_amount = new System.Windows.Forms.TextBox();
            this.dtp_expences = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_expences_description = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expences)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 609);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 120);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(186, 20);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 77);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(172, 39);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Expences";
            // 
            // btn_exit_expencesForm
            // 
            this.btn_exit_expencesForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit_expencesForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_exit_expencesForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit_expencesForm.Image")));
            this.btn_exit_expencesForm.Location = new System.Drawing.Point(1162, 0);
            this.btn_exit_expencesForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit_expencesForm.Name = "btn_exit_expencesForm";
            this.btn_exit_expencesForm.Size = new System.Drawing.Size(55, 45);
            this.btn_exit_expencesForm.TabIndex = 67;
            this.btn_exit_expencesForm.UseVisualStyleBackColor = true;
            this.btn_exit_expencesForm.Click += new System.EventHandler(this.btn_exit_expencesForm_Click);
            // 
            // dgv_expences
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_expences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_expences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_expences.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_expences.Location = new System.Drawing.Point(227, 394);
            this.dgv_expences.Name = "dgv_expences";
            this.dgv_expences.RowHeadersWidth = 51;
            this.dgv_expences.RowTemplate.Height = 24;
            this.dgv_expences.Size = new System.Drawing.Size(827, 204);
            this.dgv_expences.TabIndex = 68;
            // 
            // btn_expencesSearch
            // 
            this.btn_expencesSearch.BackColor = System.Drawing.Color.Green;
            this.btn_expencesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expencesSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expencesSearch.ForeColor = System.Drawing.Color.White;
            this.btn_expencesSearch.Location = new System.Drawing.Point(677, 29);
            this.btn_expencesSearch.Name = "btn_expencesSearch";
            this.btn_expencesSearch.Size = new System.Drawing.Size(143, 34);
            this.btn_expencesSearch.TabIndex = 93;
            this.btn_expencesSearch.Text = "Search";
            this.btn_expencesSearch.UseVisualStyleBackColor = false;
            this.btn_expencesSearch.Click += new System.EventHandler(this.btn_expencesSearch_Click);
            // 
            // btn_expence_Add
            // 
            this.btn_expence_Add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_expence_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expence_Add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expence_Add.ForeColor = System.Drawing.Color.White;
            this.btn_expence_Add.Location = new System.Drawing.Point(227, 337);
            this.btn_expence_Add.Name = "btn_expence_Add";
            this.btn_expence_Add.Size = new System.Drawing.Size(143, 38);
            this.btn_expence_Add.TabIndex = 92;
            this.btn_expence_Add.Text = "ADD";
            this.btn_expence_Add.UseVisualStyleBackColor = false;
            this.btn_expence_Add.Click += new System.EventHandler(this.btn_expence_Add_Click);
            // 
            // txt_expence_search
            // 
            this.txt_expence_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_expence_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expence_search.ForeColor = System.Drawing.Color.White;
            this.txt_expence_search.Location = new System.Drawing.Point(433, 29);
            this.txt_expence_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_expence_search.Multiline = true;
            this.txt_expence_search.Name = "txt_expence_search";
            this.txt_expence_search.Size = new System.Drawing.Size(222, 31);
            this.txt_expence_search.TabIndex = 91;
            this.txt_expence_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_expence_search_KeyDown);
            this.txt_expence_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expence_search_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(324, 37);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(101, 23);
            this.bunifuCustomLabel3.TabIndex = 90;
            this.bunifuCustomLabel3.Text = "Enter ID : ";
            // 
            // btn_expence_delete
            // 
            this.btn_expence_delete.BackColor = System.Drawing.Color.Brown;
            this.btn_expence_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expence_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expence_delete.ForeColor = System.Drawing.Color.White;
            this.btn_expence_delete.Location = new System.Drawing.Point(596, 337);
            this.btn_expence_delete.Name = "btn_expence_delete";
            this.btn_expence_delete.Size = new System.Drawing.Size(143, 38);
            this.btn_expence_delete.TabIndex = 94;
            this.btn_expence_delete.Text = "Delete";
            this.btn_expence_delete.UseVisualStyleBackColor = false;
            this.btn_expence_delete.Click += new System.EventHandler(this.btn_expence_delete_Click);
            // 
            // btn_expence_update
            // 
            this.btn_expence_update.BackColor = System.Drawing.Color.Orange;
            this.btn_expence_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expence_update.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expence_update.ForeColor = System.Drawing.Color.White;
            this.btn_expence_update.Location = new System.Drawing.Point(410, 337);
            this.btn_expence_update.Name = "btn_expence_update";
            this.btn_expence_update.Size = new System.Drawing.Size(143, 38);
            this.btn_expence_update.TabIndex = 95;
            this.btn_expence_update.Text = "Update";
            this.btn_expence_update.UseVisualStyleBackColor = false;
            this.btn_expence_update.Click += new System.EventHandler(this.btn_expence_update_Click);
            // 
            // btn_expence_clear
            // 
            this.btn_expence_clear.BackColor = System.Drawing.Color.Coral;
            this.btn_expence_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expence_clear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expence_clear.ForeColor = System.Drawing.Color.White;
            this.btn_expence_clear.Location = new System.Drawing.Point(962, 337);
            this.btn_expence_clear.Name = "btn_expence_clear";
            this.btn_expence_clear.Size = new System.Drawing.Size(92, 38);
            this.btn_expence_clear.TabIndex = 96;
            this.btn_expence_clear.Text = "clear";
            this.btn_expence_clear.UseVisualStyleBackColor = false;
            this.btn_expence_clear.Click += new System.EventHandler(this.btn_expence_clear_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(262, 117);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 23);
            this.bunifuCustomLabel1.TabIndex = 97;
            this.bunifuCustomLabel1.Text = "Expence type : ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(705, 120);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(137, 23);
            this.bunifuCustomLabel4.TabIndex = 98;
            this.bunifuCustomLabel4.Text = "Description : ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(277, 184);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(148, 23);
            this.bunifuCustomLabel5.TabIndex = 99;
            this.bunifuCustomLabel5.Text = "Amount(Lkr) : ";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // dpdown_expences
            // 
            this.dpdown_expences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.dpdown_expences.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpdown_expences.ForeColor = System.Drawing.Color.White;
            this.dpdown_expences.FormattingEnabled = true;
            this.dpdown_expences.Items.AddRange(new object[] {
            "Machine Maintenance",
            "building maintenance",
            "Monthly Electricity bill",
            "water bill",
            "suppliment purchasing"});
            this.dpdown_expences.Location = new System.Drawing.Point(433, 117);
            this.dpdown_expences.Name = "dpdown_expences";
            this.dpdown_expences.Size = new System.Drawing.Size(217, 27);
            this.dpdown_expences.TabIndex = 100;
            // 
            // txt_expences_amount
            // 
            this.txt_expences_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_expences_amount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expences_amount.ForeColor = System.Drawing.Color.White;
            this.txt_expences_amount.Location = new System.Drawing.Point(433, 184);
            this.txt_expences_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_expences_amount.Multiline = true;
            this.txt_expences_amount.Name = "txt_expences_amount";
            this.txt_expences_amount.Size = new System.Drawing.Size(217, 31);
            this.txt_expences_amount.TabIndex = 101;
            this.txt_expences_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_expences_amount_KeyDown);
            // 
            // dtp_expences
            // 
            this.dtp_expences.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_expences.CustomFormat = "yyyy-MM-dd";
            this.dtp_expences.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expences.Location = new System.Drawing.Point(433, 257);
            this.dtp_expences.Name = "dtp_expences";
            this.dtp_expences.Size = new System.Drawing.Size(217, 22);
            this.dtp_expences.TabIndex = 102;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(242, 256);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(184, 23);
            this.bunifuCustomLabel6.TabIndex = 103;
            this.bunifuCustomLabel6.Text = "Date Scheduled : ";
            // 
            // txt_expences_description
            // 
            this.txt_expences_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_expences_description.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expences_description.ForeColor = System.Drawing.Color.White;
            this.txt_expences_description.Location = new System.Drawing.Point(849, 117);
            this.txt_expences_description.Name = "txt_expences_description";
            this.txt_expences_description.Size = new System.Drawing.Size(338, 162);
            this.txt_expences_description.TabIndex = 104;
            this.txt_expences_description.Text = "";
            // 
            // expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1224, 609);
            this.Controls.Add(this.txt_expences_description);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.dtp_expences);
            this.Controls.Add(this.txt_expences_amount);
            this.Controls.Add(this.dpdown_expences);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_expence_clear);
            this.Controls.Add(this.btn_expence_update);
            this.Controls.Add(this.btn_expence_delete);
            this.Controls.Add(this.btn_expencesSearch);
            this.Controls.Add(this.btn_expence_Add);
            this.Controls.Add(this.txt_expence_search);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.dgv_expences);
            this.Controls.Add(this.btn_exit_expencesForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "expences";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expences";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expences_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.expences_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView dgv_expences;
        private System.Windows.Forms.Button btn_exit_expencesForm;
        private System.Windows.Forms.TextBox txt_expences_amount;
        private System.Windows.Forms.ComboBox dpdown_expences;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btn_expence_clear;
        private System.Windows.Forms.Button btn_expence_update;
        private System.Windows.Forms.Button btn_expence_delete;
        private System.Windows.Forms.Button btn_expencesSearch;
        private System.Windows.Forms.Button btn_expence_Add;
        private System.Windows.Forms.TextBox txt_expence_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.RichTextBox txt_expences_description;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DateTimePicker dtp_expences;
    }
}