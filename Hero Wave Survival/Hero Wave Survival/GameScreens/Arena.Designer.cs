namespace Hero_Wave_Survival.GameScreens
{
    partial class Arena
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
            this.tbArena = new System.Windows.Forms.TableLayoutPanel();
            this.tbEnem = new System.Windows.Forms.TableLayoutPanel();
            this.tbArena.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbArena
            // 
            this.tbArena.ColumnCount = 1;
            this.tbArena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbArena.Controls.Add(this.tbEnem, 0, 0);
            this.tbArena.Location = new System.Drawing.Point(12, 12);
            this.tbArena.Name = "tbArena";
            this.tbArena.RowCount = 2;
            this.tbArena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbArena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbArena.Size = new System.Drawing.Size(860, 537);
            this.tbArena.TabIndex = 0;
            // 
            // tbEnem
            // 
            this.tbEnem.ColumnCount = 3;
            this.tbEnem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbEnem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbEnem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbEnem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEnem.Location = new System.Drawing.Point(3, 3);
            this.tbEnem.Name = "tbEnem";
            this.tbEnem.RowCount = 2;
            this.tbEnem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbEnem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbEnem.Size = new System.Drawing.Size(854, 316);
            this.tbEnem.TabIndex = 0;
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tbArena);
            this.Name = "Arena";
            this.Text = "Arena";
            this.tbArena.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbArena;
        private System.Windows.Forms.TableLayoutPanel tbEnem;
    }
}