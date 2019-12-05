namespace Hero_Wave_Survival.Monsters.Lich
{
    partial class LAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAvatar));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbPortrait = new System.Windows.Forms.PictureBox();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pbPortrait, 0, 0);
            this.tblMain.Controls.Add(this.pbHealth, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblMain.Size = new System.Drawing.Size(200, 200);
            this.tblMain.TabIndex = 0;
            // 
            // pbPortrait
            // 
            this.pbPortrait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPortrait.Image = ((System.Drawing.Image)(resources.GetObject("pbPortrait.Image")));
            this.pbPortrait.Location = new System.Drawing.Point(3, 3);
            this.pbPortrait.Name = "pbPortrait";
            this.pbPortrait.Size = new System.Drawing.Size(194, 162);
            this.pbPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortrait.TabIndex = 0;
            this.pbPortrait.TabStop = false;
            // 
            // pbHealth
            // 
            this.pbHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHealth.Location = new System.Drawing.Point(3, 171);
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(194, 26);
            this.pbHealth.TabIndex = 1;
            // 
            // LAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "LAvatar";
            this.Size = new System.Drawing.Size(200, 200);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox pbPortrait;
        private System.Windows.Forms.ProgressBar pbHealth;
    }
}
