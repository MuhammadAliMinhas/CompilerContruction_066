namespace Lab_8
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.compiler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(43, 44);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(488, 106);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(43, 221);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(488, 106);
            this.outputBox.TabIndex = 1;
            // 
            // compiler
            // 
            this.compiler.Location = new System.Drawing.Point(43, 370);
            this.compiler.Name = "compiler";
            this.compiler.Size = new System.Drawing.Size(488, 50);
            this.compiler.TabIndex = 2;
            this.compiler.Text = "Compile";
            this.compiler.UseVisualStyleBackColor = true;
            this.compiler.Click += new System.EventHandler(this.compiler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compiler);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button compiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

