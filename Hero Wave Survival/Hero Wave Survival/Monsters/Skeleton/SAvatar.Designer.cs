namespace Hero_Wave_Survival.Monsters.Skeleton
{
    partial class SAvatar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAvatar));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.prbHealth = new System.Windows.Forms.ProgressBar();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pbAvatar, 0, 0);
            this.tblMain.Controls.Add(this.prbHealth, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblMain.Size = new System.Drawing.Size(200, 200);
            this.tblMain.TabIndex = 0;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(3, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(194, 162);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // prbHealth
            // 
            this.prbHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbHealth.Location = new System.Drawing.Point(3, 171);
            this.prbHealth.Name = "prbHealth";
            this.prbHealth.Size = new System.Drawing.Size(194, 26);
            this.prbHealth.TabIndex = 1;
            // 
            // SAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "SAvatar";
            this.Size = new System.Drawing.Size(200, 200);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.ProgressBar prbHealth;
    }
}
