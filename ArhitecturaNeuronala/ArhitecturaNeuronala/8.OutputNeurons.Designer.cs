
namespace ArhitecturaNeuronala
{
    partial class OutputNeurons
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.textBox_outputValue = new System.Windows.Forms.TextBox();
            this.textBox_activValue = new System.Windows.Forms.TextBox();
            this.textBox_globalInputValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(140, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "_______";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(123, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "__________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(104, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "_____________";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(140, 158);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(94, 29);
            this.button_Ok.TabIndex = 21;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // textBox_outputValue
            // 
            this.textBox_outputValue.Location = new System.Drawing.Point(193, 107);
            this.textBox_outputValue.Name = "textBox_outputValue";
            this.textBox_outputValue.ReadOnly = true;
            this.textBox_outputValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_outputValue.TabIndex = 20;
            // 
            // textBox_activValue
            // 
            this.textBox_activValue.Location = new System.Drawing.Point(193, 62);
            this.textBox_activValue.Name = "textBox_activValue";
            this.textBox_activValue.ReadOnly = true;
            this.textBox_activValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_activValue.TabIndex = 19;
            // 
            // textBox_globalInputValue
            // 
            this.textBox_globalInputValue.Location = new System.Drawing.Point(193, 19);
            this.textBox_globalInputValue.Name = "textBox_globalInputValue";
            this.textBox_globalInputValue.ReadOnly = true;
            this.textBox_globalInputValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_globalInputValue.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Output Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Activation Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Global Input Value";
            // 
            // OutputNeurons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 202);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.textBox_outputValue);
            this.Controls.Add(this.textBox_activValue);
            this.Controls.Add(this.textBox_globalInputValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OutputNeurons";
            this.Text = "oN1 Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox_outputValue;
        private System.Windows.Forms.TextBox textBox_activValue;
        private System.Windows.Forms.TextBox textBox_globalInputValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}