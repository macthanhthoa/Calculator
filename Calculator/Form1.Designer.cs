namespace Calculator
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
            this.Cong = new System.Windows.Forms.Button();
            this.So1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.So2 = new System.Windows.Forms.Label();
            this.So3 = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Tru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cong
            // 
            this.Cong.Location = new System.Drawing.Point(322, 216);
            this.Cong.Name = "Cong";
            this.Cong.Size = new System.Drawing.Size(75, 46);
            this.Cong.TabIndex = 0;
            this.Cong.Text = "+";
            this.Cong.UseVisualStyleBackColor = true;
            this.Cong.Click += new System.EventHandler(this.Cong_Click);
            // 
            // So1
            // 
            this.So1.AutoSize = true;
            this.So1.Location = new System.Drawing.Point(99, 62);
            this.So1.Name = "So1";
            this.So1.Size = new System.Drawing.Size(51, 24);
            this.So1.TabIndex = 1;
            this.So1.Text = "Số A";
            this.So1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 29);
            this.textBox1.TabIndex = 2;
            // 
            // So2
            // 
            this.So2.AutoSize = true;
            this.So2.Location = new System.Drawing.Point(99, 120);
            this.So2.Name = "So2";
            this.So2.Size = new System.Drawing.Size(50, 24);
            this.So2.TabIndex = 3;
            this.So2.Text = "Số B";
            // 
            // So3
            // 
            this.So3.AutoSize = true;
            this.So3.Location = new System.Drawing.Point(99, 173);
            this.So3.Name = "So3";
            this.So3.Size = new System.Drawing.Size(51, 24);
            this.So3.TabIndex = 3;
            this.So3.Text = "Số C";
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Location = new System.Drawing.Point(180, 25);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(89, 24);
            this.TT.TabIndex = 3;
            this.TT.Text = "Tính toán";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 29);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 29);
            this.textBox3.TabIndex = 2;
            // 
            // Tru
            // 
            this.Tru.Location = new System.Drawing.Point(222, 216);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(75, 46);
            this.Tru.TabIndex = 4;
            this.Tru.Text = "-";
            this.Tru.UseVisualStyleBackColor = true;
            this.Tru.Click += new System.EventHandler(this.Tru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 482);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.So3);
            this.Controls.Add(this.So2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.So1);
            this.Controls.Add(this.Cong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tinhtoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cong;
        private System.Windows.Forms.Label So1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label So2;
        private System.Windows.Forms.Label So3;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Tru;
    }
}

