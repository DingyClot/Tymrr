namespace Tymrr.WinForms
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskTime = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTime
            // 
            this.taskTime.BackColor = System.Drawing.Color.Transparent;
            this.grid.SetColumnSpan(this.taskTime, 2);
            this.taskTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTime.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTime.Location = new System.Drawing.Point(0, 249);
            this.taskTime.Margin = new System.Windows.Forms.Padding(0);
            this.taskTime.Name = "taskTime";
            this.taskTime.Size = new System.Drawing.Size(317, 64);
            this.taskTime.TabIndex = 2;
            this.taskTime.Text = "00:00:00";
            this.taskTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskTime.Visible = false;
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.Transparent;
            this.grid.SetColumnSpan(this.taskName, 2);
            this.taskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskName.Font = new System.Drawing.Font("Segoe UI Light", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(3, 62);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(311, 187);
            this.taskName.TabIndex = 3;
            this.taskName.Text = "F1";
            this.taskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taskName.UseCompatibleTextRendering = true;
            this.taskName.Click += new System.EventHandler(this.taskName_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(253, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 62);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "✗";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.grid.Controls.Add(this.closeButton, 1, 0);
            this.grid.Controls.Add(this.taskName, 0, 1);
            this.grid.Controls.Add(this.taskTime, 0, 2);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.Name = "tableLayoutPanel1";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.Size = new System.Drawing.Size(317, 313);
            this.grid.TabIndex = 5;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(317, 313);
            this.Resize += new System.EventHandler(this.Task_Resize);
            this.grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskTime;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel grid;
    }
}
