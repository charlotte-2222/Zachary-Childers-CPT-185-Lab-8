namespace Zachary_Childers_CPT_185_Lab_8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlDsk = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconExpand = new FontAwesome.Sharp.IconPictureBox();
            this.iconMin = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChild = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.PictureBox();
            this.btnTime = new FontAwesome.Sharp.IconButton();
            this.btnMorse = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDsk.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsk
            // 
            this.pnlDsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.pnlDsk.Controls.Add(this.panel2);
            this.pnlDsk.Controls.Add(this.panelTitleBar);
            this.pnlDsk.Controls.Add(this.pictureBox1);
            this.pnlDsk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDsk.Location = new System.Drawing.Point(220, 0);
            this.pnlDsk.Name = "pnlDsk";
            this.pnlDsk.Size = new System.Drawing.Size(964, 631);
            this.pnlDsk.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 9);
            this.panel2.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelTitleBar.Controls.Add(this.iconExpand);
            this.panelTitleBar.Controls.Add(this.iconMin);
            this.panelTitleBar.Controls.Add(this.iconExit);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconExpand
            // 
            this.iconExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconExpand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExpand.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconExpand.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExpand.Location = new System.Drawing.Point(891, 3);
            this.iconExpand.Name = "iconExpand";
            this.iconExpand.Size = new System.Drawing.Size(34, 32);
            this.iconExpand.TabIndex = 7;
            this.iconExpand.TabStop = false;
            this.toolTip1.SetToolTip(this.iconExpand, "Maximize Window");
            this.iconExpand.Click += new System.EventHandler(this.iconExpand_Click);
            // 
            // iconMin
            // 
            this.iconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMin.Location = new System.Drawing.Point(851, 3);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(34, 32);
            this.iconMin.TabIndex = 6;
            this.iconMin.TabStop = false;
            this.toolTip1.SetToolTip(this.iconMin, "Minimize to TaskBar");
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.Location = new System.Drawing.Point(929, 3);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(34, 32);
            this.iconExit.TabIndex = 5;
            this.iconExit.TabStop = false;
            this.toolTip1.SetToolTip(this.iconExit, "Exit Application");
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 35;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 35);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChild
            // 
            this.lblTitleChild.AutoSize = true;
            this.lblTitleChild.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChild.ForeColor = System.Drawing.Color.White;
            this.lblTitleChild.Location = new System.Drawing.Point(66, 35);
            this.lblTitleChild.Name = "lblTitleChild";
            this.lblTitleChild.Size = new System.Drawing.Size(50, 20);
            this.lblTitleChild.TabIndex = 1;
            this.lblTitleChild.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logoBtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // logoBtn
            // 
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(30, 12);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(153, 122);
            this.logoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBtn.TabIndex = 0;
            this.logoBtn.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTime.FlatAppearance.BorderSize = 0;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.Color.White;
            this.btnTime.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnTime.IconColor = System.Drawing.Color.White;
            this.btnTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTime.IconSize = 45;
            this.btnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTime.Location = new System.Drawing.Point(0, 190);
            this.btnTime.Name = "btnTime";
            this.btnTime.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTime.Rotation = 0D;
            this.btnTime.Size = new System.Drawing.Size(220, 50);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "Clock";
            this.btnTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnTime, "Digital Clock");
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnMorse
            // 
            this.btnMorse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMorse.FlatAppearance.BorderSize = 0;
            this.btnMorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMorse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorse.ForeColor = System.Drawing.Color.White;
            this.btnMorse.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnMorse.IconColor = System.Drawing.Color.White;
            this.btnMorse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMorse.IconSize = 45;
            this.btnMorse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMorse.Location = new System.Drawing.Point(0, 140);
            this.btnMorse.Name = "btnMorse";
            this.btnMorse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMorse.Rotation = 0D;
            this.btnMorse.Size = new System.Drawing.Size(220, 50);
            this.btnMorse.TabIndex = 0;
            this.btnMorse.Text = "Translator";
            this.btnMorse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnMorse, "Translate all your Desires....");
            this.btnMorse.UseVisualStyleBackColor = true;
            this.btnMorse.Click += new System.EventHandler(this.btnMorse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 230);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Click to join Zach\'s Discord Server!");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panelMenu.Controls.Add(this.btnTime);
            this.panelMenu.Controls.Add(this.btnMorse);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.pnlDsk);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlDsk.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDsk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconExpand;
        private FontAwesome.Sharp.IconPictureBox iconMin;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoBtn;
        private FontAwesome.Sharp.IconButton btnTime;
        private FontAwesome.Sharp.IconButton btnMorse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

