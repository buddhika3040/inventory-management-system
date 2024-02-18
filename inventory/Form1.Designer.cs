namespace inventory
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.skutextBox4 = new System.Windows.Forms.TextBox();
            this.catagorycomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTROY MANAGEMENT SYSYTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(22, 144);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(310, 22);
            this.priceBox.TabIndex = 1;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(1, 219);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(1060, 398);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "new";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.White;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(379, 172);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(313, 41);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.White;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(729, 172);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(313, 41);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(379, 144);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(310, 22);
            this.descriptionBox.TabIndex = 6;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(729, 144);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(310, 22);
            this.QuantityBox.TabIndex = 7;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(379, 97);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(310, 22);
            this.nametextBox.TabIndex = 9;
            // 
            // skutextBox4
            // 
            this.skutextBox4.Location = new System.Drawing.Point(22, 97);
            this.skutextBox4.Name = "skutextBox4";
            this.skutextBox4.Size = new System.Drawing.Size(310, 22);
            this.skutextBox4.TabIndex = 10;
            this.skutextBox4.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // catagorycomboBox
            // 
            this.catagorycomboBox.FormattingEnabled = true;
            this.catagorycomboBox.Items.AddRange(new object[] {
            "Automotive",
            "Haradware",
            "Grocery",
            "Pharmacy"});
            this.catagorycomboBox.Location = new System.Drawing.Point(729, 95);
            this.catagorycomboBox.Name = "catagorycomboBox";
            this.catagorycomboBox.Size = new System.Drawing.Size(310, 24);
            this.catagorycomboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "sku:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "catagory:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "name:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "description:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "price:";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1063, 620);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catagorycomboBox);
            this.Controls.Add(this.skutextBox4);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox skutextBox4;
        private System.Windows.Forms.ComboBox catagorycomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

