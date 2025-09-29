namespace Task_Performance_Thread_Priority_Navarro_04
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
            this.ThreadStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreadStatus
            // 
            this.ThreadStatus.AutoSize = true;
            this.ThreadStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ThreadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(106)))));
            this.ThreadStatus.Location = new System.Drawing.Point(86, 9);
            this.ThreadStatus.Name = "ThreadStatus";
            this.ThreadStatus.Size = new System.Drawing.Size(197, 31);
            this.ThreadStatus.TabIndex = 0;
            this.ThreadStatus.Text = "-Thread Starts-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(134, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThreadStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThreadStatus;
        private System.Windows.Forms.Button button1;
    }
}

