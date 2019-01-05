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
            this.grpCharacter = new System.Windows.Forms.GroupBox();
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
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoAnswer4 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer1 = new System.Windows.Forms.RadioButton();
            this.grpCharacter.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCharacter
            // 
            this.grpCharacter.Controls.Add(this.txtCharacter);
            this.grpCharacter.Controls.Add(this.lnkGoogleTranslate);
            this.grpCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCharacter.Location = new System.Drawing.Point(11, 1);
            this.grpCharacter.Name = "grpCharacter";
            this.grpCharacter.Size = new System.Drawing.Size(644, 249);
            this.grpCharacter.TabIndex = 2;
            this.grpCharacter.TabStop = false;
            this.grpCharacter.Text = "Flash Card";
            // 
            // txtCharacter
            // 
            this.txtCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacter.Location = new System.Drawing.Point(11, 21);
            this.txtCharacter.Multiline = true;
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.ReadOnly = true;
            this.txtCharacter.Size = new System.Drawing.Size(607, 216);
            this.txtCharacter.TabIndex = 1;
            // 
            // lnkGoogleTranslate
            // 
            this.lnkGoogleTranslate.AutoSize = true;
            this.lnkGoogleTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGoogleTranslate.Location = new System.Drawing.Point(500, 0);
            this.lnkGoogleTranslate.Name = "lnkGoogleTranslate";
            this.lnkGoogleTranslate.Size = new System.Drawing.Size(118, 17);
            this.lnkGoogleTranslate.TabIndex = 5;
            this.lnkGoogleTranslate.TabStop = true;
            this.lnkGoogleTranslate.Text = "Google Translate";
            this.lnkGoogleTranslate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoogleTranslate_LinkClicked);
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(559, 353);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(96, 35);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
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
            this.statusBar.Location = new System.Drawing.Point(0, 391);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(671, 22);
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
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.txtAnswer4);
            this.grpAnswers.Controls.Add(this.txtAnswer3);
            this.grpAnswers.Controls.Add(this.txtAnswer2);
            this.grpAnswers.Controls.Add(this.txtAnswer1);
            this.grpAnswers.Controls.Add(this.label4);
            this.grpAnswers.Controls.Add(this.label3);
            this.grpAnswers.Controls.Add(this.label2);
            this.grpAnswers.Controls.Add(this.label1);
            this.grpAnswers.Controls.Add(this.rdoAnswer4);
            this.grpAnswers.Controls.Add(this.rdoAnswer3);
            this.grpAnswers.Controls.Add(this.rdoAnswer2);
            this.grpAnswers.Controls.Add(this.rdoAnswer1);
            this.grpAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpAnswers.Location = new System.Drawing.Point(12, 245);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(643, 102);
            this.grpAnswers.TabIndex = 6;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Select the right answer:";
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer4.Location = new System.Drawing.Point(385, 59);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.ReadOnly = true;
            this.txtAnswer4.Size = new System.Drawing.Size(232, 16);
            this.txtAnswer4.TabIndex = 11;
            this.txtAnswer4.Text = "this is a sample text";
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer3.Location = new System.Drawing.Point(385, 29);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.ReadOnly = true;
            this.txtAnswer3.Size = new System.Drawing.Size(232, 16);
            this.txtAnswer3.TabIndex = 10;
            this.txtAnswer3.Text = "this is a sample text";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer2.Location = new System.Drawing.Point(53, 66);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ReadOnly = true;
            this.txtAnswer2.Size = new System.Drawing.Size(232, 16);
            this.txtAnswer2.TabIndex = 9;
            this.txtAnswer2.Text = "this is a sample text";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer1.Location = new System.Drawing.Point(53, 34);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.ReadOnly = true;
            this.txtAnswer1.Size = new System.Drawing.Size(232, 16);
            this.txtAnswer1.TabIndex = 8;
            this.txtAnswer1.Text = "this is a sample text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "&D)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "&C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&B)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&A)";
            // 
            // rdoAnswer4
            // 
            this.rdoAnswer4.AutoSize = true;
            this.rdoAnswer4.Location = new System.Drawing.Point(365, 62);
            this.rdoAnswer4.Name = "rdoAnswer4";
            this.rdoAnswer4.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer4.TabIndex = 7;
            this.rdoAnswer4.TabStop = true;
            this.rdoAnswer4.Tag = "D";
            this.rdoAnswer4.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer3
            // 
            this.rdoAnswer3.AutoSize = true;
            this.rdoAnswer3.Location = new System.Drawing.Point(365, 31);
            this.rdoAnswer3.Name = "rdoAnswer3";
            this.rdoAnswer3.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer3.TabIndex = 5;
            this.rdoAnswer3.TabStop = true;
            this.rdoAnswer3.Tag = "C";
            this.rdoAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer2
            // 
            this.rdoAnswer2.AutoSize = true;
            this.rdoAnswer2.Location = new System.Drawing.Point(33, 66);
            this.rdoAnswer2.Name = "rdoAnswer2";
            this.rdoAnswer2.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer2.TabIndex = 3;
            this.rdoAnswer2.TabStop = true;
            this.rdoAnswer2.Tag = "B";
            this.rdoAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer1
            // 
            this.rdoAnswer1.AutoSize = true;
            this.rdoAnswer1.Location = new System.Drawing.Point(33, 35);
            this.rdoAnswer1.Name = "rdoAnswer1";
            this.rdoAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rdoAnswer1.TabIndex = 1;
            this.rdoAnswer1.TabStop = true;
            this.rdoAnswer1.Tag = "A";
            this.rdoAnswer1.UseVisualStyleBackColor = true;
            // 
            // FlashCardForm
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 413);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.grpCharacter);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card";
            this.Load += new System.EventHandler(this.FlashForm_Load);
            this.grpCharacter.ResumeLayout(false);
            this.grpCharacter.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.grpAnswers.ResumeLayout(false);
            this.grpAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCharacter;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip4;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.LinkLabel lnkGoogleTranslate;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.RadioButton rdoAnswer4;
        private System.Windows.Forms.RadioButton rdoAnswer3;
        private System.Windows.Forms.RadioButton rdoAnswer2;
        private System.Windows.Forms.RadioButton rdoAnswer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
    }
}