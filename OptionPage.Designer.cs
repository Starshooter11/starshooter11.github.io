
namespace Texttomeh2
{
    partial class OptionPage 
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
            this.charButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plotButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.charButton.Location = new System.Drawing.Point(18, 21);
            this.charButton.Name = "charButton";
            this.charButton.Size = new System.Drawing.Size(175, 46);
            this.charButton.TabIndex = 0;
            this.charButton.Text = "Create Character";
            this.charButton.UseVisualStyleBackColor = true;
            this.charButton.Click += new System.EventHandler(this.charButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Location";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.plotButton.Location = new System.Drawing.Point(199, 21);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(175, 46);
            this.plotButton.TabIndex = 2;
            this.plotButton.Text = "Create Event";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "New Novel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 141);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.charButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button charButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button button4;
    }
}