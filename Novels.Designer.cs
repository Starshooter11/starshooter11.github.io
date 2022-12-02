
namespace Texttomeh2
{
    partial class Novels
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
            this.addNewCard.Location = new System.Drawing.Point(1261, 12);
            this.addNewCard.Name = "addNewCard";
            this.addNewCard.Size = new System.Drawing.Size(167, 55);
            this.addNewCard.TabIndex = 0;
            this.addNewCard.Text = "Add New";
            this.addNewCard.UseVisualStyleBackColor = true;
            this.addNewCard.Click += new System.EventHandler(this.addNewCard_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save.Location = new System.Drawing.Point(1261, 800);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(167, 55);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.Location = new System.Drawing.Point(1088, 800);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 55);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // novelName
            // 
            this.novelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.novelName.Location = new System.Drawing.Point(18, 10);
            this.novelName.Name = "novelName";
            this.novelName.Size = new System.Drawing.Size(593, 35);
            this.novelName.TabIndex = 3;
            this.novelName.Text = "Novel Name";
            this.novelName.TextChanged += new System.EventHandler(this.novelName_TextChanged);
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genre.Location = new System.Drawing.Point(651, 25);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(402, 30);
            this.genre.TabIndex = 4;
            this.genre.Text = "Genre";
            // 
            // Novels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 867);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.novelName);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addNewCard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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