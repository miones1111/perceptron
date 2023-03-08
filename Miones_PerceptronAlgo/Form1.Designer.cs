namespace Miones_PerceptronAlgo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input1_txt = new System.Windows.Forms.TextBox();
            this.input2_txt = new System.Windows.Forms.TextBox();
            this.ouput_txt = new System.Windows.Forms.Label();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "A simple Perceptron for\r\n\"AND\" Gate\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter x1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter x2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result (y):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // input1_txt
            // 
            this.input1_txt.Location = new System.Drawing.Point(147, 177);
            this.input1_txt.Name = "input1_txt";
            this.input1_txt.Size = new System.Drawing.Size(100, 22);
            this.input1_txt.TabIndex = 4;
            // 
            // input2_txt
            // 
            this.input2_txt.Location = new System.Drawing.Point(147, 238);
            this.input2_txt.Name = "input2_txt";
            this.input2_txt.Size = new System.Drawing.Size(100, 22);
            this.input2_txt.TabIndex = 5;
            // 
            // ouput_txt
            // 
            this.ouput_txt.AutoSize = true;
            this.ouput_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ouput_txt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouput_txt.Location = new System.Drawing.Point(161, 296);
            this.ouput_txt.Name = "ouput_txt";
            this.ouput_txt.Size = new System.Drawing.Size(59, 33);
            this.ouput_txt.TabIndex = 6;
            this.ouput_txt.Text = "Ans";
            // 
            // btn_test
            // 
            this.btn_test.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test.Location = new System.Drawing.Point(294, 231);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(101, 38);
            this.btn_test.TabIndex = 8;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_train
            // 
            this.btn_train.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_train.Location = new System.Drawing.Point(294, 168);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(101, 38);
            this.btn_train.TabIndex = 9;
            this.btn_train.Text = "Train";
            this.btn_train.UseVisualStyleBackColor = true;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 418);
            this.Controls.Add(this.btn_train);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.ouput_txt);
            this.Controls.Add(this.input2_txt);
            this.Controls.Add(this.input1_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input1_txt;
        private System.Windows.Forms.TextBox input2_txt;
        private System.Windows.Forms.Label ouput_txt;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_train;
    }
}

