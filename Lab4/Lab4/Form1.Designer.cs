namespace Lab4
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
            this.YammanKate = new System.Windows.Forms.Button();
            this.tfInput = new System.Windows.Forms.TextBox();
            this.tfTokens = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // YammanKate
            // 
            this.YammanKate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.YammanKate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YammanKate.Location = new System.Drawing.Point(12, 344);
            this.YammanKate.Name = "YammanKate";
            this.YammanKate.Size = new System.Drawing.Size(415, 73);
            this.YammanKate.TabIndex = 0;
            this.YammanKate.Text = "Analyze";
            this.YammanKate.UseVisualStyleBackColor = false;
            this.YammanKate.Click += new System.EventHandler(this.YammanKate_Click);
            // 
            // tfInput
            // 
            this.tfInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tfInput.Location = new System.Drawing.Point(12, 12);
            this.tfInput.Multiline = true;
            this.tfInput.Name = "tfInput";
            this.tfInput.Size = new System.Drawing.Size(415, 101);
            this.tfInput.TabIndex = 1;
            // 
            // tfTokens
            // 
            this.tfTokens.Location = new System.Drawing.Point(12, 119);
            this.tfTokens.Name = "tfTokens";
            this.tfTokens.Size = new System.Drawing.Size(415, 219);
            this.tfTokens.TabIndex = 6;
            this.tfTokens.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 429);
            this.Controls.Add(this.tfTokens);
            this.Controls.Add(this.tfInput);
            this.Controls.Add(this.YammanKate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YammanKate;
        private System.Windows.Forms.TextBox tfInput;
        private System.Windows.Forms.RichTextBox tfTokens;
    }
}

