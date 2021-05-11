
namespace ChapeauUI
{
    partial class TableOverview
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
            this.pnlTableOverview = new System.Windows.Forms.Panel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.listViewOrderTableOverview = new System.Windows.Forms.ListView();
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItemQNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTableOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableOverview
            // 
            this.pnlTableOverview.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlTableOverview.Controls.Add(this.listViewOrderTableOverview);
            this.pnlTableOverview.Controls.Add(this.btnTable2);
            this.pnlTableOverview.Controls.Add(this.btnTable3);
            this.pnlTableOverview.Controls.Add(this.btnTable1);
            this.pnlTableOverview.Location = new System.Drawing.Point(12, 12);
            this.pnlTableOverview.Name = "pnlTableOverview";
            this.pnlTableOverview.Size = new System.Drawing.Size(525, 636);
            this.pnlTableOverview.TabIndex = 0;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(78, 83);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(75, 72);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(78, 294);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(75, 71);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(78, 190);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(75, 72);
            this.btnTable2.TabIndex = 3;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = true;
            // 
            // listViewOrderTableOverview
            // 
            this.listViewOrderTableOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItem,
            this.orderItemQNT});
            this.listViewOrderTableOverview.HideSelection = false;
            this.listViewOrderTableOverview.Location = new System.Drawing.Point(266, 24);
            this.listViewOrderTableOverview.Name = "listViewOrderTableOverview";
            this.listViewOrderTableOverview.Size = new System.Drawing.Size(234, 586);
            this.listViewOrderTableOverview.TabIndex = 4;
            this.listViewOrderTableOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOrderTableOverview.View = System.Windows.Forms.View.Details;
            // 
            // orderItem
            // 
            this.orderItem.Text = "Items";
            this.orderItem.Width = 170;
            // 
            // orderItemQNT
            // 
            this.orderItemQNT.Text = "qnt";
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(549, 660);
            this.Controls.Add(this.pnlTableOverview);
            this.Name = "TableOverview";
            this.Text = "TableOverview";
            this.pnlTableOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableOverview;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.ListView listViewOrderTableOverview;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.ColumnHeader orderItemQNT;
    }
}