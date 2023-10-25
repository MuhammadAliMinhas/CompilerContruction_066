namespace Yes
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
            this.generateButton = new System.Windows.Forms.Button();
            this.generatedPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(88, 202);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(211, 48);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Weak Password? ";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // generatedPassword
            // 
            this.generatedPassword.AutoSize = true;
            this.generatedPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generatedPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedPassword.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPassword.ForeColor = System.Drawing.Color.White;
            this.generatedPassword.Location = new System.Drawing.Point(97, 101);
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.Size = new System.Drawing.Size(225, 30);
            this.generatedPassword.TabIndex = 1;
            this.generatedPassword.Text = "Password will appear here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "FA20-BCS-066 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(376, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatedPassword);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label generatedPassword;
        private System.Windows.Forms.Label label1;
    }
}

