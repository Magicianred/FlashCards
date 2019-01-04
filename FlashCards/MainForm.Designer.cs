namespace FlashCards
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstTopics = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFlashCards = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTopics
            // 
            this.lstTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.items});
            this.lstTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lstTopics.FullRowSelect = true;
            this.lstTopics.Location = new System.Drawing.Point(12, 19);
            this.lstTopics.MultiSelect = false;
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(668, 229);
            this.lstTopics.TabIndex = 0;
            this.lstTopics.UseCompatibleStateImageBehavior = false;
            this.lstTopics.View = System.Windows.Forms.View.Details;
            this.lstTopics.SelectedIndexChanged += new System.EventHandler(this.lstTopics_SelectedIndexChanged);
            this.lstTopics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTopics_MouseDoubleClick);
            // 
            // name
            // 
            this.name.Text = "Topic";
            this.name.Width = 340;
            // 
            // items
            // 
            this.items.Text = "Number of Items";
            this.items.Width = 300;
            // 
            // btnOpenFlashCards
            // 
            this.btnOpenFlashCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFlashCards.BackgroundImage")));
            this.btnOpenFlashCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFlashCards.Location = new System.Drawing.Point(555, 268);
            this.btnOpenFlashCards.Name = "btnOpenFlashCards";
            this.btnOpenFlashCards.Size = new System.Drawing.Size(125, 65);
            this.btnOpenFlashCards.TabIndex = 1;
            this.btnOpenFlashCards.UseVisualStyleBackColor = true;
            this.btnOpenFlashCards.Click += new System.EventHandler(this.btnOpenFlashCards_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRandom);
            this.groupBox1.Controls.Add(this.lstTopics);
            this.groupBox1.Controls.Add(this.btnOpenFlashCards);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flash Cards Collection";
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Location = new System.Drawing.Point(12, 283);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(298, 30);
            this.chkRandom.TabIndex = 5;
            this.chkRandom.Text = "Show Random Flash Cards";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 378);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards - Make learning easy!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTopics;
        private System.Windows.Forms.Button btnOpenFlashCards;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader items;
        private System.Windows.Forms.CheckBox chkRandom;
    }
}

