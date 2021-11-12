
namespace Number_Guessing_Game
{
    partial class Form1
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
            this.Difficultcb = new System.Windows.Forms.CheckBox();
            this.Intermediatecb = new System.Windows.Forms.CheckBox();
            this.Easycb = new System.Windows.Forms.CheckBox();
            this.wlclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Difficultcb
            // 
            this.Difficultcb.AutoSize = true;
            this.Difficultcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficultcb.Location = new System.Drawing.Point(248, 78);
            this.Difficultcb.Name = "Difficultcb";
            this.Difficultcb.Size = new System.Drawing.Size(66, 19);
            this.Difficultcb.TabIndex = 8;
            this.Difficultcb.Text = "Difficult";
            this.Difficultcb.UseVisualStyleBackColor = true;
            this.Difficultcb.CheckedChanged += new System.EventHandler(this.Difficultcb_CheckedChanged);
            // 
            // Intermediatecb
            // 
            this.Intermediatecb.AutoSize = true;
            this.Intermediatecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intermediatecb.Location = new System.Drawing.Point(113, 78);
            this.Intermediatecb.Name = "Intermediatecb";
            this.Intermediatecb.Size = new System.Drawing.Size(95, 19);
            this.Intermediatecb.TabIndex = 7;
            this.Intermediatecb.Text = "Intermediate";
            this.Intermediatecb.UseVisualStyleBackColor = true;
            this.Intermediatecb.CheckedChanged += new System.EventHandler(this.Intermediatecb_CheckedChanged);
            // 
            // Easycb
            // 
            this.Easycb.AutoSize = true;
            this.Easycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easycb.Location = new System.Drawing.Point(22, 78);
            this.Easycb.Name = "Easycb";
            this.Easycb.Size = new System.Drawing.Size(52, 19);
            this.Easycb.TabIndex = 6;
            this.Easycb.Text = "Easy";
            this.Easycb.UseVisualStyleBackColor = true;
            this.Easycb.CheckedChanged += new System.EventHandler(this.Easycb_CheckedChanged);
            // 
            // wlclbl
            // 
            this.wlclbl.AutoSize = true;
            this.wlclbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlclbl.Location = new System.Drawing.Point(32, 20);
            this.wlclbl.Name = "wlclbl";
            this.wlclbl.Size = new System.Drawing.Size(259, 32);
            this.wlclbl.TabIndex = 5;
            this.wlclbl.Text = "Welcome to the number guessing game.\r\nPlease choose a difficulty below:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(316, 101);
            this.Controls.Add(this.Difficultcb);
            this.Controls.Add(this.Intermediatecb);
            this.Controls.Add(this.Easycb);
            this.Controls.Add(this.wlclbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Difficultcb;
        private System.Windows.Forms.CheckBox Intermediatecb;
        private System.Windows.Forms.CheckBox Easycb;
        private System.Windows.Forms.Label wlclbl;
    }
}