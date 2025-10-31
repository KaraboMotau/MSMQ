namespace MSMQ
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textNumbers = new System.Windows.Forms.TextBox();
            this.textRead = new System.Windows.Forms.TextBox();
            this.textPrint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumer";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(76, 69);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(231, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(457, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textNumbers
            // 
            this.textNumbers.Location = new System.Drawing.Point(76, 98);
            this.textNumbers.Name = "textNumbers";
            this.textNumbers.Size = new System.Drawing.Size(100, 20);
            this.textNumbers.TabIndex = 11;
            // 
            // textRead
            // 
            this.textRead.Location = new System.Drawing.Point(457, 98);
            this.textRead.Name = "textRead";
            this.textRead.Size = new System.Drawing.Size(100, 20);
            this.textRead.TabIndex = 12;
            // 
            // textPrint
            // 
            this.textPrint.Location = new System.Drawing.Point(457, 259);
            this.textPrint.Name = "textPrint";
            this.textPrint.Size = new System.Drawing.Size(100, 20);
            this.textPrint.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPrint);
            this.Controls.Add(this.textRead);
            this.Controls.Add(this.textNumbers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textNumbers;
        private System.Windows.Forms.TextBox textRead;
        private System.Windows.Forms.TextBox textPrint;
    }
}

