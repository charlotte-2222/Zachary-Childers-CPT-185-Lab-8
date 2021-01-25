namespace Zachary_Childers_CPT_185_Lab_8.Forms
{
    partial class morse
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            this.btnClr = new FontAwesome.Sharp.IconButton();
            this.btnMorse = new FontAwesome.Sharp.IconButton();
            this.iconExt = new FontAwesome.Sharp.IconButton();
            this.txtMorseOut = new System.Windows.Forms.RichTextBox();
            this.txtMorseInput = new System.Windows.Forms.TextBox();
            this.lblSaid = new System.Windows.Forms.Label();
            this.txtSaid = new System.Windows.Forms.RichTextBox();
            this.playBtn = new FontAwesome.Sharp.IconButton();
            this.btnToBinary = new FontAwesome.Sharp.IconButton();
            this.txtBinOut = new System.Windows.Forms.RichTextBox();
            this.lblMorse = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTest = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopy.IconColor = System.Drawing.Color.White;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.IconSize = 30;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.Location = new System.Drawing.Point(0, 100);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCopy.Rotation = 0D;
            this.btnCopy.Size = new System.Drawing.Size(158, 50);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnCopy, "Copy Translation to Clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClr
            // 
            this.btnClr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClr.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            this.btnClr.IconColor = System.Drawing.Color.White;
            this.btnClr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClr.IconSize = 30;
            this.btnClr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClr.Location = new System.Drawing.Point(0, 50);
            this.btnClr.Name = "btnClr";
            this.btnClr.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClr.Rotation = 0D;
            this.btnClr.Size = new System.Drawing.Size(158, 50);
            this.btnClr.TabIndex = 1;
            this.btnClr.Text = "&Delete All";
            this.btnClr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnClr, "Delete All Records");
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnMorse
            // 
            this.btnMorse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMorse.FlatAppearance.BorderSize = 0;
            this.btnMorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMorse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorse.ForeColor = System.Drawing.Color.White;
            this.btnMorse.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnMorse.IconColor = System.Drawing.Color.White;
            this.btnMorse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMorse.IconSize = 30;
            this.btnMorse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMorse.Location = new System.Drawing.Point(0, 0);
            this.btnMorse.Name = "btnMorse";
            this.btnMorse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMorse.Rotation = 0D;
            this.btnMorse.Size = new System.Drawing.Size(158, 50);
            this.btnMorse.TabIndex = 0;
            this.btnMorse.Text = "&Translate";
            this.btnMorse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnMorse, "Translate String");
            this.btnMorse.UseVisualStyleBackColor = false;
            this.btnMorse.Click += new System.EventHandler(this.btnMorse_Click);
            // 
            // iconExt
            // 
            this.iconExt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconExt.FlatAppearance.BorderSize = 0;
            this.iconExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExt.ForeColor = System.Drawing.Color.White;
            this.iconExt.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconExt.IconColor = System.Drawing.Color.White;
            this.iconExt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExt.IconSize = 30;
            this.iconExt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconExt.Location = new System.Drawing.Point(0, 150);
            this.iconExt.Name = "iconExt";
            this.iconExt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconExt.Rotation = 0D;
            this.iconExt.Size = new System.Drawing.Size(158, 50);
            this.iconExt.TabIndex = 3;
            this.iconExt.Text = "&Exit";
            this.iconExt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.iconExt, "Exit to home");
            this.iconExt.UseVisualStyleBackColor = true;
            this.iconExt.Click += new System.EventHandler(this.iconExt_Click);
            // 
            // txtMorseOut
            // 
            this.txtMorseOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMorseOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtMorseOut.Font = new System.Drawing.Font("Segoe UI Semibold", 14.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseOut.ForeColor = System.Drawing.Color.White;
            this.txtMorseOut.Location = new System.Drawing.Point(16, 15);
            this.txtMorseOut.Name = "txtMorseOut";
            this.txtMorseOut.ReadOnly = true;
            this.txtMorseOut.Size = new System.Drawing.Size(276, 365);
            this.txtMorseOut.TabIndex = 2;
            this.txtMorseOut.Text = "";
            this.toolTip1.SetToolTip(this.txtMorseOut, "Morse Output");
            // 
            // txtMorseInput
            // 
            this.txtMorseInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMorseInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtMorseInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorseInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseInput.ForeColor = System.Drawing.Color.White;
            this.txtMorseInput.Location = new System.Drawing.Point(287, 27);
            this.txtMorseInput.Name = "txtMorseInput";
            this.txtMorseInput.Size = new System.Drawing.Size(326, 25);
            this.txtMorseInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMorseInput, "Input AplhaNumeric text to translate");
            // 
            // lblSaid
            // 
            this.lblSaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaid.AutoSize = true;
            this.lblSaid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaid.ForeColor = System.Drawing.Color.White;
            this.lblSaid.Location = new System.Drawing.Point(3, 2);
            this.lblSaid.Name = "lblSaid";
            this.lblSaid.Size = new System.Drawing.Size(72, 20);
            this.lblSaid.TabIndex = 30;
            this.lblSaid.Text = "You Said:";
            this.toolTip1.SetToolTip(this.lblSaid, "Whatever the user said");
            this.lblSaid.Visible = false;
            // 
            // txtSaid
            // 
            this.txtSaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtSaid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaid.ForeColor = System.Drawing.Color.White;
            this.txtSaid.Location = new System.Drawing.Point(17, 25);
            this.txtSaid.Name = "txtSaid";
            this.txtSaid.ReadOnly = true;
            this.txtSaid.Size = new System.Drawing.Size(129, 153);
            this.txtSaid.TabIndex = 30;
            this.txtSaid.Text = "";
            this.toolTip1.SetToolTip(this.txtSaid, "Morse Output");
            this.txtSaid.Visible = false;
            // 
            // playBtn
            // 
            this.playBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playBtn.IconColor = System.Drawing.Color.White;
            this.playBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.playBtn.IconSize = 30;
            this.playBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playBtn.Location = new System.Drawing.Point(790, 0);
            this.playBtn.Name = "playBtn";
            this.playBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.playBtn.Rotation = 0D;
            this.playBtn.Size = new System.Drawing.Size(158, 76);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "&Playback Morse";
            this.playBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.playBtn, "Play Back Morse Code in Real Time");
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // btnToBinary
            // 
            this.btnToBinary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToBinary.FlatAppearance.BorderSize = 0;
            this.btnToBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBinary.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnToBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBinary.ForeColor = System.Drawing.Color.White;
            this.btnToBinary.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.btnToBinary.IconColor = System.Drawing.Color.White;
            this.btnToBinary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToBinary.IconSize = 30;
            this.btnToBinary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToBinary.Location = new System.Drawing.Point(0, 200);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnToBinary.Rotation = 0D;
            this.btnToBinary.Size = new System.Drawing.Size(158, 50);
            this.btnToBinary.TabIndex = 14;
            this.btnToBinary.Text = "&Binary";
            this.btnToBinary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnToBinary, "Translate to Base 10");
            this.btnToBinary.UseVisualStyleBackColor = false;
            this.btnToBinary.Click += new System.EventHandler(this.btnToBinary_Click);
            // 
            // txtBinOut
            // 
            this.txtBinOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBinOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtBinOut.Font = new System.Drawing.Font("Segoe UI Semibold", 13.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinOut.ForeColor = System.Drawing.Color.White;
            this.txtBinOut.Location = new System.Drawing.Point(311, 15);
            this.txtBinOut.Name = "txtBinOut";
            this.txtBinOut.ReadOnly = true;
            this.txtBinOut.Size = new System.Drawing.Size(276, 365);
            this.txtBinOut.TabIndex = 3;
            this.txtBinOut.Text = "";
            this.toolTip1.SetToolTip(this.txtBinOut, "Binary Output");
            // 
            // lblMorse
            // 
            this.lblMorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMorse.AutoSize = true;
            this.lblMorse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorse.ForeColor = System.Drawing.Color.White;
            this.lblMorse.Location = new System.Drawing.Point(152, 32);
            this.lblMorse.Name = "lblMorse";
            this.lblMorse.Size = new System.Drawing.Size(124, 20);
            this.lblMorse.TabIndex = 29;
            this.lblMorse.Text = "Text to Translate:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBinOut);
            this.panel3.Controls.Add(this.txtMorseOut);
            this.panel3.Location = new System.Drawing.Point(125, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 400);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.lblSaid);
            this.panel2.Controls.Add(this.txtSaid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 181);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btnToBinary);
            this.panel1.Controls.Add(this.iconExt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnClr);
            this.panel1.Controls.Add(this.btnMorse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(790, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 432);
            this.panel1.TabIndex = 28;
            // 
            // panelTest
            // 
            this.panelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelTest.Controls.Add(this.playBtn);
            this.panelTest.Controls.Add(this.txtMorseInput);
            this.panelTest.Controls.Add(this.lblMorse);
            this.panelTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTest.Location = new System.Drawing.Point(0, 0);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(948, 76);
            this.panelTest.TabIndex = 27;
            // 
            // morse
            // 
            this.AcceptButton = this.btnMorse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.CancelButton = this.iconExt;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTest);
            this.Name = "morse";
            this.Text = "0";
            this.Load += new System.EventHandler(this.morse_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnCopy;
        private FontAwesome.Sharp.IconButton btnClr;
        private FontAwesome.Sharp.IconButton btnMorse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTest;
        private FontAwesome.Sharp.IconButton iconExt;
        private System.Windows.Forms.TextBox txtMorseInput;
        private System.Windows.Forms.Label lblMorse;
        private System.Windows.Forms.RichTextBox txtMorseOut;
        private System.Windows.Forms.RichTextBox txtSaid;
        private System.Windows.Forms.Label lblSaid;
        private FontAwesome.Sharp.IconButton playBtn;
        private FontAwesome.Sharp.IconButton btnToBinary;
        private System.Windows.Forms.RichTextBox txtBinOut;
    }
}