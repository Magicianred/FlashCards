namespace FlashCards
{
    partial class FlashCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashCardForm));
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.lnkGoogleTranslate = new System.Windows.Forms.LinkLabel();
            this.btnGo = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rdoAnswer4 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCharacter
            // 
            this.txtCharacter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacter.Location = new System.Drawing.Point(12, 12);
            this.txtCharacter.Multiline = true;
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.ReadOnly = true;
            this.txtCharacter.Size = new System.Drawing.Size(607, 216);
            this.txtCharacter.TabIndex = 0;
            this.txtCharacter.TabStop = false;
            // 
            // lnkGoogleTranslate
            // 
            this.lnkGoogleTranslate.AutoSize = true;
            this.lnkGoogleTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGoogleTranslate.Location = new System.Drawing.Point(19, 345);
            this.lnkGoogleTranslate.Name = "lnkGoogleTranslate";
            this.lnkGoogleTranslate.Size = new System.Drawing.Size(118, 17);
            this.lnkGoogleTranslate.TabIndex = 6;
            this.lnkGoogleTranslate.TabStop = true;
            this.lnkGoogleTranslate.Text = "Google Translate";
            this.lnkGoogleTranslate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoogleTranslate_LinkClicked);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(533, 336);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(96, 35);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip1,
            this.toolStrip2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStrip4});
            this.statusBar.Location = new System.Drawing.Point(0, 375);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(642, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusBar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel3.Text = "       Your Progress: ";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Test Time: ";
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(59, 17);
            this.toolStrip4.Text = "Duration: ";
            // 
            // rdoAnswer4
            // 
            this.rdoAnswer4.AutoSize = true;
            this.rdoAnswer4.Location = new System.Drawing.Point(358, 307);
            this.rdoAnswer4.Name = "rdoAnswer4";
            this.rdoAnswer4.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer4.TabIndex = 4;
            this.rdoAnswer4.TabStop = true;
            this.rdoAnswer4.Tag = "D";
            this.rdoAnswer4.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer3
            // 
            this.rdoAnswer3.AutoSize = true;
            this.rdoAnswer3.Location = new System.Drawing.Point(358, 281);
            this.rdoAnswer3.Name = "rdoAnswer3";
            this.rdoAnswer3.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer3.TabIndex = 3;
            this.rdoAnswer3.TabStop = true;
            this.rdoAnswer3.Tag = "C";
            this.rdoAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer2
            // 
            this.rdoAnswer2.AutoSize = true;
            this.rdoAnswer2.Location = new System.Drawing.Point(26, 307);
            this.rdoAnswer2.Name = "rdoAnswer2";
            this.rdoAnswer2.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer2.TabIndex = 2;
            this.rdoAnswer2.TabStop = true;
            this.rdoAnswer2.Tag = "B";
            this.rdoAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer1
            // 
            this.rdoAnswer1.AutoSize = true;
            this.rdoAnswer1.Location = new System.Drawing.Point(26, 281);
            this.rdoAnswer1.Name = "rdoAnswer1";
            this.rdoAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer1.TabIndex = 1;
            this.rdoAnswer1.TabStop = true;
            this.rdoAnswer1.Tag = "A";
            this.rdoAnswer1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select right answer:";
            // 
            // FlashCardForm
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 397);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoAnswer4);
            this.Controls.Add(this.lnkGoogleTranslate);
            this.Controls.Add(this.rdoAnswer3);
            this.Controls.Add(this.rdoAnswer2);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.rdoAnswer1);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card";
            this.Load += new System.EventHandler(this.FlashForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip4;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.LinkLabel lnkGoogleTranslate;
        private System.Windows.Forms.RadioButton rdoAnswer4;
        private System.Windows.Forms.RadioButton rdoAnswer3;
        private System.Windows.Forms.RadioButton rdoAnswer2;
        private System.Windows.Forms.RadioButton rdoAnswer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
    }
}