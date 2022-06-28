
namespace ArhitecturaNeuronala
{
    partial class HiddenLayersNeurons
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
            this.textBox_globalInputValue = new System.Windows.Forms.TextBox();
            this.textBox_activValue = new System.Windows.Forms.TextBox();
            this.textBox_outputValue = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global Input Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activation Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Value";
            // 
            // textBox_globalInputValue
            // 
            this.textBox_globalInputValue.Location = new System.Drawing.Point(196, 12);
            this.textBox_globalInputValue.Name = "textBox_globalInputValue";
            this.textBox_globalInputValue.ReadOnly = true;
            this.textBox_globalInputValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_globalInputValue.TabIndex = 3;
            // 
            // textBox_activValue
            // 
            this.textBox_activValue.Location = new System.Drawing.Point(196, 55);
            this.textBox_activValue.Name = "textBox_activValue";
            this.textBox_activValue.ReadOnly = true;
            this.textBox_activValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_activValue.TabIndex = 4;
            // 
            // textBox_outputValue
            // 
            this.textBox_outputValue.Location = new System.Drawing.Point(196, 100);
            this.textBox_outputValue.Name = "textBox_outputValue";
            this.textBox_outputValue.ReadOnly = true;
            this.textBox_outputValue.Size = new System.Drawing.Size(175, 27);
            this.textBox_outputValue.TabIndex = 5;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(143, 151);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(94, 29);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(107, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "_____________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(126, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "__________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(143, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "_______";
            // 
            // HiddenLayersNeurons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 201);
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
            this.Name = "HiddenLayersNeurons";
            this.Text = "h1N1 Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_globalInputValue;
        private System.Windows.Forms.TextBox textBox_activValue;
        private System.Windows.Forms.TextBox textBox_outputValue;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}