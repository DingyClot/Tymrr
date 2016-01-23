namespace Tymrr
{
    partial class Tymrr
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
            this.Task1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Task1.FlatAppearance.BorderSize = 0;
            this.Task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task1.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task1.ForeColor = System.Drawing.Color.Black;
            this.Task1.Location = new System.Drawing.Point(13, 13);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(533, 310);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "+";
            this.Task1.UseVisualStyleBackColor = false;
            this.Task1.Resize += new System.EventHandler(this.Task1_Resize);
            // 
            // Tymrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(558, 335);
            this.Controls.Add(this.Task1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Tymrr";
            this.Text = "Tymrr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1;
    }
}