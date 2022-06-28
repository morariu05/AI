
namespace ArhitecturaNeuronala
{
    partial class Generalinformation
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Input = new System.Windows.Forms.NumericUpDown();
            this.numeric_Output = new System.Windows.Forms.NumericUpDown();
            this.numeric_Hidden = new System.Windows.Forms.NumericUpDown();
            this.numericHiddenL1 = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHiddenL1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Neurons in the Input Layer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Neurons in the Output Layer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Neurons in the Hidden Layer 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Hidden Layers (1 - 3)";
            // 
            // numeric_Input
            // 
            this.numeric_Input.Location = new System.Drawing.Point(335, 26);
            this.numeric_Input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Input.Name = "numeric_Input";
            this.numeric_Input.Size = new System.Drawing.Size(80, 27);
            this.numeric_Input.TabIndex = 5;
            this.numeric_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_Output
            // 
            this.numeric_Output.Location = new System.Drawing.Point(335, 71);
            this.numeric_Output.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Output.Name = "numeric_Output";
            this.numeric_Output.Size = new System.Drawing.Size(80, 27);
            this.numeric_Output.TabIndex = 6;
            this.numeric_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Output.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_Hidden
            // 
            this.numeric_Hidden.Location = new System.Drawing.Point(335, 117);
            this.numeric_Hidden.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_Hidden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Hidden.Name = "numeric_Hidden";
            this.numeric_Hidden.Size = new System.Drawing.Size(80, 27);
            this.numeric_Hidden.TabIndex = 7;
            this.numeric_Hidden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Hidden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Hidden.ValueChanged += new System.EventHandler(this.numeric_Hidden_ValueChanged);
            // 
            // numericHiddenL1
            // 
            this.numericHiddenL1.Location = new System.Drawing.Point(332, 31);
            this.numericHiddenL1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHiddenL1.Name = "numericHiddenL1";
            this.numericHiddenL1.Size = new System.Drawing.Size(80, 27);
            this.numericHiddenL1.TabIndex = 8;
            this.numericHiddenL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericHiddenL1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.numericHiddenL1);
            this.panel.Location = new System.Drawing.Point(3, 183);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(429, 171);
            this.panel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(270, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "_________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(276, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(234, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "_______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hidden Layers";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(176, 369);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Generalinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.numeric_Hidden);
            this.Controls.Add(this.numeric_Output);
            this.Controls.Add(this.numeric_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Generalinformation";
            this.Text = "General Information";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHiddenL1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_Input;
        private System.Windows.Forms.NumericUpDown numeric_Output;
        private System.Windows.Forms.NumericUpDown numeric_Hidden;
        private System.Windows.Forms.NumericUpDown numericHiddenL1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Save;
    }
}