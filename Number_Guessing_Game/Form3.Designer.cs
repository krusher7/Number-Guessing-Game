
namespace Number_Guessing_Game
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.Inputtb = new System.Windows.Forms.TextBox();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(220, 68);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(75, 23);
            this.Menubtn.TabIndex = 14;
            this.Menubtn.Text = "Main Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // Inputtb
            // 
            this.Inputtb.Location = new System.Drawing.Point(23, 29);
            this.Inputtb.Multiline = true;
            this.Inputtb.Name = "Inputtb";
            this.Inputtb.Size = new System.Drawing.Size(146, 23);
            this.Inputtb.TabIndex = 12;
            // 
            // Enterbtn
            // 
            this.Enterbtn.Location = new System.Drawing.Point(220, 29);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(75, 23);
            this.Enterbtn.TabIndex = 11;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = true;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please choose a number between 101 to 500:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(316, 101);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Inputtb);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermediate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inputtb;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Label label1;
    }
}