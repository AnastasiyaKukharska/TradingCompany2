namespace WF
{
    partial class Basket
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.basketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new WF.projectDataSet();
            this.basketTableAdapter = new WF.projectDataSetTableAdapters.BasketTableAdapter();
            this.buy = new System.Windows.Forms.Button();
            this.shipment = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.basketIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.basketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // basketIDDataGridViewTextBoxColumn
            // 
            this.basketIDDataGridViewTextBoxColumn.DataPropertyName = "BasketID";
            this.basketIDDataGridViewTextBoxColumn.HeaderText = "BasketID";
            this.basketIDDataGridViewTextBoxColumn.Name = "basketIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataMember = "Basket";
            this.basketBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basketTableAdapter
            // 
            this.basketTableAdapter.ClearBeforeFill = true;
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buy.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.Location = new System.Drawing.Point(26, 25);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(136, 47);
            this.buy.TabIndex = 1;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = false;
            // 
            // shipment
            // 
            this.shipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.shipment.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipment.Location = new System.Drawing.Point(271, 25);
            this.shipment.Name = "shipment";
            this.shipment.Size = new System.Drawing.Size(204, 47);
            this.shipment.TabIndex = 2;
            this.shipment.Text = "Order shipping";
            this.shipment.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.add.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(591, 25);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(184, 47);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(621, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "book";
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(816, 25);
            this.fillByToolStrip1.TabIndex = 7;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.shipment);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Basket";
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private projectDataSetTableAdapters.BasketTableAdapter basketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn basketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button shipment;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
    }
}