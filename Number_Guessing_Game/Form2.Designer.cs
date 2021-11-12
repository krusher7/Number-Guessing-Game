
namespace Number_Guessing_Game
{
    partial class Form2
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
            this.Menubtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.Inputtb = new System.Windows.Forms.TextBox();
            this.Textlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(212, 75);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(75, 23);
            this.Menubtn.TabIndex = 14;
            this.Menubtn.Text = "Main Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // Enterbtn
            // 
            this.Enterbtn.Location = new System.Drawing.Point(212, 33);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(75, 23);
            this.Enterbtn.TabIndex = 12;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = true;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Inputtb
            // 
            this.Inputtb.Location = new System.Drawing.Point(15, 33);
            this.Inputtb.Multiline = true;
            this.Inputtb.Name = "Inputtb";
            this.Inputtb.Size = new System.Drawing.Size(146, 23);
            this.Inputtb.TabIndex = 11;
            // 
            // Textlbl
            // 
            this.Textlbl.AutoSize = true;
            this.Textlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textlbl.Location = new System.Drawing.Point(12, 9);
            this.Textlbl.Name = "Textlbl";
            this.Textlbl.Size = new System.Drawing.Size(275, 16);
            this.Textlbl.TabIndex = 10;
            this.Textlbl.Text = "Please choose a number between 1 and 100:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(316, 101);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.Inputtb);
            this.Controls.Add(this.Textlbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.TextBox Inputtb;
        private System.Windows.Forms.Label Textlbl;
    }
}