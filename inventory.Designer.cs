namespace EasyAdmin.gym_management_system
{
    partial class inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.txt_item_search = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_itemSeller_delete = new System.Windows.Forms.TextBox();
            this.txt_itemQuantity_delete = new System.Windows.Forms.TextBox();
            this.txt_itemName_delete = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_clear_item = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit_InventoryForm = new System.Windows.Forms.Button();
            this.txt_itemPrice_delete = new System.Windows.Forms.TextBox();
            this.txt_itemDate_delete = new System.Windows.Forms.TextBox();
            this.txt_itemCategory_delete = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_ItemSearch_delete = new System.Windows.Forms.Button();
            this.btn_item_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
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
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 622);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 169);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(186, 20);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 114);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(166, 39);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Inventory";
            // 
            // dgv_inventory
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_inventory.Location = new System.Drawing.Point(244, 117);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.RowHeadersWidth = 51;
            this.dgv_inventory.RowTemplate.Height = 24;
            this.dgv_inventory.Size = new System.Drawing.Size(1138, 243);
            this.dgv_inventory.TabIndex = 2;
            // 
            // txt_item_search
            // 
            this.txt_item_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_item_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_search.ForeColor = System.Drawing.Color.White;
            this.txt_item_search.Location = new System.Drawing.Point(498, 49);
            this.txt_item_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_item_search.Multiline = true;
            this.txt_item_search.Name = "txt_item_search";
            this.txt_item_search.Size = new System.Drawing.Size(222, 46);
            this.txt_item_search.TabIndex = 53;
            this.txt_item_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_item_search_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(250, 61);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(201, 23);
            this.bunifuCustomLabel3.TabIndex = 52;
            this.bunifuCustomLabel3.Text = "Enter item ID/Name";
            // 
            // txt_itemSeller_delete
            // 
            this.txt_itemSeller_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemSeller_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemSeller_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemSeller_delete.Location = new System.Drawing.Point(413, 571);
            this.txt_itemSeller_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemSeller_delete.Multiline = true;
            this.txt_itemSeller_delete.Name = "txt_itemSeller_delete";
            this.txt_itemSeller_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemSeller_delete.TabIndex = 63;
            // 
            // txt_itemQuantity_delete
            // 
            this.txt_itemQuantity_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemQuantity_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemQuantity_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemQuantity_delete.Location = new System.Drawing.Point(413, 509);
            this.txt_itemQuantity_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemQuantity_delete.Multiline = true;
            this.txt_itemQuantity_delete.Name = "txt_itemQuantity_delete";
            this.txt_itemQuantity_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemQuantity_delete.TabIndex = 62;
            // 
            // txt_itemName_delete
            // 
            this.txt_itemName_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemName_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemName_delete.Location = new System.Drawing.Point(413, 447);
            this.txt_itemName_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemName_delete.Multiline = true;
            this.txt_itemName_delete.Name = "txt_itemName_delete";
            this.txt_itemName_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemName_delete.TabIndex = 61;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(275, 509);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(105, 23);
            this.bunifuCustomLabel6.TabIndex = 60;
            this.bunifuCustomLabel6.Text = "Quantity :";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(265, 392);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(120, 23);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "Category : ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(300, 452);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(79, 23);
            this.bunifuCustomLabel4.TabIndex = 58;
            this.bunifuCustomLabel4.Text = "name :";
            // 
            // btn_clear_item
            // 
            this.btn_clear_item.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_clear_item.AutoSize = true;
            this.btn_clear_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_clear_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear_item.BorderRadius = 0;
            this.btn_clear_item.ButtonText = "Clear";
            this.btn_clear_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_item.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear_item.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear_item.Iconimage = null;
            this.btn_clear_item.Iconimage_right = null;
            this.btn_clear_item.Iconimage_right_Selected = null;
            this.btn_clear_item.Iconimage_Selected = null;
            this.btn_clear_item.IconMarginLeft = 0;
            this.btn_clear_item.IconMarginRight = 0;
            this.btn_clear_item.IconRightVisible = true;
            this.btn_clear_item.IconRightZoom = 0D;
            this.btn_clear_item.IconVisible = true;
            this.btn_clear_item.IconZoom = 50D;
            this.btn_clear_item.IsTab = false;
            this.btn_clear_item.Location = new System.Drawing.Point(1273, 545);
            this.btn_clear_item.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btn_clear_item.Name = "btn_clear_item";
            this.btn_clear_item.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_clear_item.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_clear_item.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear_item.selected = false;
            this.btn_clear_item.Size = new System.Drawing.Size(104, 59);
            this.btn_clear_item.TabIndex = 65;
            this.btn_clear_item.Text = "Clear";
            this.btn_clear_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear_item.Textcolor = System.Drawing.Color.White;
            this.btn_clear_item.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_item.Click += new System.EventHandler(this.btn_clear_item_Click);
            // 
            // btn_exit_InventoryForm
            // 
            this.btn_exit_InventoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit_InventoryForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_exit_InventoryForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit_InventoryForm.Image")));
            this.btn_exit_InventoryForm.Location = new System.Drawing.Point(1337, 0);
            this.btn_exit_InventoryForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit_InventoryForm.Name = "btn_exit_InventoryForm";
            this.btn_exit_InventoryForm.Size = new System.Drawing.Size(55, 45);
            this.btn_exit_InventoryForm.TabIndex = 67;
            this.btn_exit_InventoryForm.UseVisualStyleBackColor = true;
            this.btn_exit_InventoryForm.Click += new System.EventHandler(this.btn_exit_newmemberForm_Click);
            // 
            // txt_itemPrice_delete
            // 
            this.txt_itemPrice_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemPrice_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemPrice_delete.Location = new System.Drawing.Point(880, 455);
            this.txt_itemPrice_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemPrice_delete.Multiline = true;
            this.txt_itemPrice_delete.Name = "txt_itemPrice_delete";
            this.txt_itemPrice_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemPrice_delete.TabIndex = 73;
            // 
            // txt_itemDate_delete
            // 
            this.txt_itemDate_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemDate_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemDate_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemDate_delete.Location = new System.Drawing.Point(880, 392);
            this.txt_itemDate_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemDate_delete.Multiline = true;
            this.txt_itemDate_delete.Name = "txt_itemDate_delete";
            this.txt_itemDate_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemDate_delete.TabIndex = 72;
            // 
            // txt_itemCategory_delete
            // 
            this.txt_itemCategory_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.txt_itemCategory_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemCategory_delete.ForeColor = System.Drawing.Color.White;
            this.txt_itemCategory_delete.Location = new System.Drawing.Point(413, 392);
            this.txt_itemCategory_delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemCategory_delete.Multiline = true;
            this.txt_itemCategory_delete.Name = "txt_itemCategory_delete";
            this.txt_itemCategory_delete.Size = new System.Drawing.Size(236, 32);
            this.txt_itemCategory_delete.TabIndex = 71;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(790, 452);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 23);
            this.bunifuCustomLabel2.TabIndex = 70;
            this.bunifuCustomLabel2.Text = "Price :";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(300, 571);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel7.TabIndex = 69;
            this.bunifuCustomLabel7.Text = "Seller : ";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(684, 401);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(176, 23);
            this.bunifuCustomLabel8.TabIndex = 68;
            this.bunifuCustomLabel8.Text = "Date Purchased :";
            // 
            // btn_ItemSearch_delete
            // 
            this.btn_ItemSearch_delete.BackColor = System.Drawing.Color.Green;
            this.btn_ItemSearch_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ItemSearch_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ItemSearch_delete.ForeColor = System.Drawing.Color.White;
            this.btn_ItemSearch_delete.Location = new System.Drawing.Point(751, 61);
            this.btn_ItemSearch_delete.Name = "btn_ItemSearch_delete";
            this.btn_ItemSearch_delete.Size = new System.Drawing.Size(143, 34);
            this.btn_ItemSearch_delete.TabIndex = 89;
            this.btn_ItemSearch_delete.Text = "Search";
            this.btn_ItemSearch_delete.UseVisualStyleBackColor = false;
            this.btn_ItemSearch_delete.Click += new System.EventHandler(this.btn_ItemSearch_delete_Click);
            // 
            // btn_item_Delete
            // 
            this.btn_item_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_item_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_item_Delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_item_Delete.Location = new System.Drawing.Point(917, 61);
            this.btn_item_Delete.Name = "btn_item_Delete";
            this.btn_item_Delete.Size = new System.Drawing.Size(143, 34);
            this.btn_item_Delete.TabIndex = 88;
            this.btn_item_Delete.Text = "Delete";
            this.btn_item_Delete.UseVisualStyleBackColor = false;
            this.btn_item_Delete.Click += new System.EventHandler(this.btn_item_Delete_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1394, 622);
            this.Controls.Add(this.btn_ItemSearch_delete);
            this.Controls.Add(this.btn_item_Delete);
            this.Controls.Add(this.txt_itemPrice_delete);
            this.Controls.Add(this.txt_itemDate_delete);
            this.Controls.Add(this.txt_itemCategory_delete);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.btn_exit_InventoryForm);
            this.Controls.Add(this.btn_clear_item);
            this.Controls.Add(this.txt_itemSeller_delete);
            this.Controls.Add(this.txt_itemQuantity_delete);
            this.Controls.Add(this.txt_itemName_delete);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txt_item_search);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.dgv_inventory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventory";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inventory_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inventory_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txt_item_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txt_itemSeller_delete;
        private System.Windows.Forms.TextBox txt_itemQuantity_delete;
        private System.Windows.Forms.TextBox txt_itemName_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear_item;
        private System.Windows.Forms.Button btn_exit_InventoryForm;
        private System.Windows.Forms.TextBox txt_itemPrice_delete;
        private System.Windows.Forms.TextBox txt_itemDate_delete;
        private System.Windows.Forms.TextBox txt_itemCategory_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Button btn_ItemSearch_delete;
        private System.Windows.Forms.Button btn_item_Delete;
    }
}