namespace Hero_Wave_Survival.GameScreens
{
    partial class StoreFront
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
            this.tbStoreLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblHPDesc = new System.Windows.Forms.Label();
            this.btnBuyHP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnExitShop = new System.Windows.Forms.Button();
            this.lblGold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStoreLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStoreLayout
            // 
            this.tbStoreLayout.ColumnCount = 2;
            this.tbStoreLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbStoreLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbStoreLayout.Controls.Add(this.label1, 0, 0);
            this.tbStoreLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tbStoreLayout.Controls.Add(this.btnBuyHP, 1, 1);
            this.tbStoreLayout.Controls.Add(this.btnExitShop, 1, 2);
            this.tbStoreLayout.Controls.Add(this.lblGold, 1, 0);
            this.tbStoreLayout.Location = new System.Drawing.Point(13, 13);
            this.tbStoreLayout.Name = "tbStoreLayout";
            this.tbStoreLayout.RowCount = 3;
            this.tbStoreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbStoreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbStoreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbStoreLayout.Size = new System.Drawing.Size(259, 336);
            this.tbStoreLayout.TabIndex = 0;
            // 
            // lblHPDesc
            // 
            this.lblHPDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHPDesc.Location = new System.Drawing.Point(3, 0);
            this.lblHPDesc.Name = "lblHPDesc";
            this.lblHPDesc.Size = new System.Drawing.Size(117, 52);
            this.lblHPDesc.TabIndex = 0;
            this.lblHPDesc.Text = "Test";
            this.lblHPDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuyHP
            // 
            this.btnBuyHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuyHP.Location = new System.Drawing.Point(132, 155);
            this.btnBuyHP.Name = "btnBuyHP";
            this.btnBuyHP.Size = new System.Drawing.Size(124, 23);
            this.btnBuyHP.TabIndex = 1;
            this.btnBuyHP.Text = "Buy HP Pot";
            this.btnBuyHP.UseVisualStyleBackColor = true;
            this.btnBuyHP.Click += new System.EventHandler(this.BtnBuyHP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblStock, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHPDesc, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 105);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStock.Location = new System.Drawing.Point(3, 52);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(117, 53);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Test";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitShop
            // 
            this.btnExitShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitShop.Location = new System.Drawing.Point(132, 310);
            this.btnExitShop.Name = "btnExitShop";
            this.btnExitShop.Size = new System.Drawing.Size(124, 23);
            this.btnExitShop.TabIndex = 3;
            this.btnExitShop.Text = "Leave Shop";
            this.btnExitShop.UseVisualStyleBackColor = true;
            this.btnExitShop.Click += new System.EventHandler(this.BtnExitShop_Click);
            // 
            // lblGold
            // 
            this.lblGold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(132, 49);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(28, 13);
            this.lblGold.TabIndex = 4;
            this.lblGold.Text = "Test";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gold:";
            // 
            // StoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tbStoreLayout);
            this.Name = "StoreFront";
            this.Text = "StoreFront";
            this.tbStoreLayout.ResumeLayout(false);
            this.tbStoreLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbStoreLayout;
        private System.Windows.Forms.Label lblHPDesc;
        private System.Windows.Forms.Button btnBuyHP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitShop;
        private System.Windows.Forms.Label lblGold;
    }
}