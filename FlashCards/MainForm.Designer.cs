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
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.btnEditTopic = new System.Windows.Forms.Button();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTopics
            // 
            this.lstTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.items});
            this.lstTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lstTopics.FullRowSelect = true;
            this.lstTopics.Location = new System.Drawing.Point(12, 12);
            this.lstTopics.MultiSelect = false;
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(682, 339);
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
            this.items.Text = "Number of Cards";
            this.items.Width = 300;
            // 
            // btnOpenFlashCards
            // 
            this.btnOpenFlashCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFlashCards.BackgroundImage")));
            this.btnOpenFlashCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFlashCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFlashCards.Location = new System.Drawing.Point(470, 368);
            this.btnOpenFlashCards.Name = "btnOpenFlashCards";
            this.btnOpenFlashCards.Size = new System.Drawing.Size(224, 53);
            this.btnOpenFlashCards.TabIndex = 1;
            this.btnOpenFlashCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFlashCards.UseVisualStyleBackColor = true;
            this.btnOpenFlashCards.Click += new System.EventHandler(this.btnOpenFlashCards_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Location = new System.Drawing.Point(12, 436);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(298, 30);
            this.chkRandom.TabIndex = 5;
            this.chkRandom.Text = "Show Random Flash Cards";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // btnEditTopic
            // 
            this.btnEditTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTopic.Location = new System.Drawing.Point(314, 368);
            this.btnEditTopic.Name = "btnEditTopic";
            this.btnEditTopic.Size = new System.Drawing.Size(136, 53);
            this.btnEditTopic.TabIndex = 6;
            this.btnEditTopic.Text = "Edit Topic";
            this.btnEditTopic.UseVisualStyleBackColor = true;
            this.btnEditTopic.Click += new System.EventHandler(this.btnEditTopic_Click);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopic.Location = new System.Drawing.Point(12, 368);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(136, 53);
            this.btnAddTopic.TabIndex = 7;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTopic.Location = new System.Drawing.Point(163, 368);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(136, 53);
            this.btnDeleteTopic.TabIndex = 8;
            this.btnDeleteTopic.Text = "Delete Topic";
            this.btnDeleteTopic.UseVisualStyleBackColor = true;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 478);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.btnOpenFlashCards);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.lstTopics);
            this.Controls.Add(this.btnEditTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards - Make learning easy!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTopics;
        private System.Windows.Forms.Button btnOpenFlashCards;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader items;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Button btnEditTopic;
        private System.Windows.Forms.Button btnDeleteTopic;
        private System.Windows.Forms.Button btnAddTopic;
    }
}

