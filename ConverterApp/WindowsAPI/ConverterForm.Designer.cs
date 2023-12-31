﻿namespace WindowsAPI
{
    partial class ConverterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListOfValues = new System.Windows.Forms.ListBox();
            this.TransferFrom = new System.Windows.Forms.ListBox();
            this.TransferTo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfValues
            // 
            this.ListOfValues.FormattingEnabled = true;
            this.ListOfValues.ItemHeight = 15;
            this.ListOfValues.Location = new System.Drawing.Point(11, 35);
            this.ListOfValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfValues.Name = "ListOfValues";
            this.ListOfValues.Size = new System.Drawing.Size(236, 154);
            this.ListOfValues.TabIndex = 0;
            this.ListOfValues.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TransferFrom
            // 
            this.TransferFrom.FormattingEnabled = true;
            this.TransferFrom.ItemHeight = 15;
            this.TransferFrom.Location = new System.Drawing.Point(271, 35);
            this.TransferFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferFrom.Name = "TransferFrom";
            this.TransferFrom.Size = new System.Drawing.Size(236, 154);
            this.TransferFrom.TabIndex = 1;
            this.TransferFrom.SelectedIndexChanged += new System.EventHandler(this.TransferFrom_SelectedIndexChanged);
            // 
            // TransferTo
            // 
            this.TransferTo.FormattingEnabled = true;
            this.TransferTo.ItemHeight = 15;
            this.TransferTo.Location = new System.Drawing.Point(532, 35);
            this.TransferTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferTo.Name = "TransferTo";
            this.TransferTo.Size = new System.Drawing.Size(236, 154);
            this.TransferTo.TabIndex = 2;
            this.TransferTo.SelectedIndexChanged += new System.EventHandler(this.TranfersTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Физическая величина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Откуда переводим";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Куда переводим";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(796, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ввести значение для перевода";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(796, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(798, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1002, 299);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferTo);
            this.Controls.Add(this.TransferFrom);
            this.Controls.Add(this.ListOfValues);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConverterForm";
            this.Text = "Конвертер";
            this.Load += new System.EventHandler(this.ConverterFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListOfValues;
        private ListBox TransferFrom;
        private ListBox TransferTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private Label label5;
    }
}