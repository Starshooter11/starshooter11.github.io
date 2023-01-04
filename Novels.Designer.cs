
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
            this.novelName = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.addCard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // novelName
            // 
            this.novelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.novelName.Location = new System.Drawing.Point(12, 12);
            this.novelName.Name = "novelName";
            this.novelName.Size = new System.Drawing.Size(196, 26);
            this.novelName.TabIndex = 0;
            this.novelName.Text = "Novel Name";
            this.novelName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(236, 12);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(192, 20);
            this.genre.TabIndex = 1;
            this.genre.Text = "Genre";
            // 
            // addCard
            // 
            this.addCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addCard.Location = new System.Drawing.Point(684, 6);
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(104, 28);
            this.addCard.TabIndex = 2;
            this.addCard.Text = "Add New";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(698, 412);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 32);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(603, 412);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 32);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Novels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.novelName);
            this.Name = "Novels";
            this.Text = "Novelcs";
            this.Load += new System.EventHandler(this.Novelcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox novelName;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button addCard;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
    }
}