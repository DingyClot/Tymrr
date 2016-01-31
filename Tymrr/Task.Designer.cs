﻿namespace Tymrr
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
            this.SuspendLayout();
            // 
            // taskTime
            // 
            this.taskTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taskTime.BackColor = System.Drawing.Color.Transparent;
            this.taskTime.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTime.Location = new System.Drawing.Point(3, 73);
            this.taskTime.Name = "taskTime";
            this.taskTime.Size = new System.Drawing.Size(114, 30);
            this.taskTime.TabIndex = 2;
            this.taskTime.Text = "00:00:00";
            this.taskTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskName
            // 
            this.taskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.taskName.BackColor = System.Drawing.Color.Transparent;
            this.taskName.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(3, 35);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(114, 23);
            this.taskName.TabIndex = 3;
            this.taskName.Text = "This Task";
            this.taskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(97, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "✗";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.taskTime);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(120, 120);
            this.Resize += new System.EventHandler(this.Task_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskTime;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Button closeButton;
    }
}