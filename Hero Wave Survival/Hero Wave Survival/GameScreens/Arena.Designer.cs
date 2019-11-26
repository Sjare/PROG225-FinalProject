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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNextWave = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbArena.SuspendLayout();
            this.tbEnem.SuspendLayout();
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
            this.tbEnem.Controls.Add(this.btnStart, 1, 0);
            this.tbEnem.Controls.Add(this.btnNextWave, 0, 0);
            this.tbEnem.Controls.Add(this.btnStore, 1, 1);
            this.tbEnem.Controls.Add(this.btnClose, 2, 0);
            this.tbEnem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEnem.Location = new System.Drawing.Point(3, 3);
            this.tbEnem.Name = "tbEnem";
            this.tbEnem.RowCount = 2;
            this.tbEnem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbEnem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbEnem.Size = new System.Drawing.Size(854, 316);
            this.tbEnem.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnStart.Location = new System.Drawing.Point(287, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnNextWave
            // 
            this.btnNextWave.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNextWave.Location = new System.Drawing.Point(3, 3);
            this.btnNextWave.Name = "btnNextWave";
            this.btnNextWave.Size = new System.Drawing.Size(278, 23);
            this.btnNextWave.TabIndex = 1;
            this.btnNextWave.Text = "Next Wave";
            this.btnNextWave.UseVisualStyleBackColor = true;
            this.btnNextWave.Visible = false;
            this.btnNextWave.Click += new System.EventHandler(this.BtnNextWave_Click);
            // 
            // btnStore
            // 
            this.btnStore.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnStore.Location = new System.Drawing.Point(287, 161);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(278, 23);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "Go To Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Visible = false;
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClose.Location = new System.Drawing.Point(571, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(278, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.tbEnem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbArena;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.TableLayoutPanel tbEnem;
        public System.Windows.Forms.Button btnNextWave;
        public System.Windows.Forms.Button btnStore;
        public System.Windows.Forms.Button btnClose;
    }
}