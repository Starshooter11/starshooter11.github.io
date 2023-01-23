
namespace Texttomeh2
{
    partial class Novel
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
            this.addNewCard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.novelName = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewCard
            // 
            this.addNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNewCard.Location = new System.Drawing.Point(841, 8);
            this.addNewCard.Margin = new System.Windows.Forms.Padding(2);
            this.addNewCard.Name = "addNewCard";
            this.addNewCard.Size = new System.Drawing.Size(111, 36);
            this.addNewCard.TabIndex = 0;
            this.addNewCard.Text = "Add New";
            this.addNewCard.UseVisualStyleBackColor = true;
            this.addNewCard.Click += new System.EventHandler(this.addNewCard_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save.Location = new System.Drawing.Point(877, 628);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 36);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.Location = new System.Drawing.Point(761, 628);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 36);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // novelName
            // 
            this.novelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.novelName.Location = new System.Drawing.Point(12, 6);
            this.novelName.Margin = new System.Windows.Forms.Padding(2);
            this.novelName.Name = "novelName";
            this.novelName.Size = new System.Drawing.Size(397, 26);
            this.novelName.TabIndex = 3;
            this.novelName.Text = "Novel Name";
            this.novelName.TextChanged += new System.EventHandler(this.novelName_TextChanged);
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genre.Location = new System.Drawing.Point(433, 9);
            this.genre.Margin = new System.Windows.Forms.Padding(2);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(269, 23);
            this.genre.TabIndex = 4;
            this.genre.Text = "Genre";
            // 
            // Novels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.novelName);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addNewCard);
            this.Name = "Novels";
            this.Text = "Novels";
            this.Load += new System.EventHandler(this.Novels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewCard;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox novelName;
        private System.Windows.Forms.TextBox genre;
    }
}