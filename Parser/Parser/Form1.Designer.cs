namespace Parser
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.parse = new System.Windows.Forms.Button();
            this.ouput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputBox.Location = new System.Drawing.Point(34, 52);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(251, 90);
            this.inputBox.TabIndex = 0;
            // 
            // parse
            // 
            this.parse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parse.Location = new System.Drawing.Point(34, 183);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(251, 78);
            this.parse.TabIndex = 1;
            this.parse.Text = "Parse ";
            this.parse.UseVisualStyleBackColor = false;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // ouput
            // 
            this.ouput.AutoSize = true;
            this.ouput.BackColor = System.Drawing.Color.Gray;
            this.ouput.Location = new System.Drawing.Point(34, 164);
            this.ouput.Name = "ouput";
            this.ouput.Size = new System.Drawing.Size(39, 13);
            this.ouput.TabIndex = 2;
            this.ouput.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(317, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ouput);
            this.Controls.Add(this.parse);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.Label ouput;
        private System.Windows.Forms.Label label2;
    }
}

