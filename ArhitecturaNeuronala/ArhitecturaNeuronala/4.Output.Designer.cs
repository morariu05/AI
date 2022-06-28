
namespace ArhitecturaNeuronala
{
    partial class Output
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
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Output = new System.Windows.Forms.ComboBox();
            this.g_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.a_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.teta_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fct_activare_comboBox = new System.Windows.Forms.ComboBox();
            this.fct_intrare_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.g_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teta_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(131, 210);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 25;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Output
            // 
            this.comboBox_Output.FormattingEnabled = true;
            this.comboBox_Output.Items.AddRange(new object[] {
            "Real",
            "Binar"});
            this.comboBox_Output.Location = new System.Drawing.Point(189, 159);
            this.comboBox_Output.Name = "comboBox_Output";
            this.comboBox_Output.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Output.TabIndex = 24;
            // 
            // g_numericUpDown
            // 
            this.g_numericUpDown.DecimalPlaces = 2;
            this.g_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.g_numericUpDown.Location = new System.Drawing.Point(275, 109);
            this.g_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.g_numericUpDown.Name = "g_numericUpDown";
            this.g_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.g_numericUpDown.TabIndex = 23;
            this.g_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.g_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // a_numericUpDown
            // 
            this.a_numericUpDown.DecimalPlaces = 2;
            this.a_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.a_numericUpDown.Location = new System.Drawing.Point(155, 109);
            this.a_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.a_numericUpDown.Name = "a_numericUpDown";
            this.a_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.a_numericUpDown.TabIndex = 22;
            this.a_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // teta_numericUpDown
            // 
            this.teta_numericUpDown.DecimalPlaces = 2;
            this.teta_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.teta_numericUpDown.Location = new System.Drawing.Point(38, 109);
            this.teta_numericUpDown.Name = "teta_numericUpDown";
            this.teta_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.teta_numericUpDown.TabIndex = 21;
            this.teta_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fct_activare_comboBox
            // 
            this.fct_activare_comboBox.FormattingEnabled = true;
            this.fct_activare_comboBox.Items.AddRange(new object[] {
            "Treaptă",
            "Sigmoidală",
            "Semn",
            "Tangenta Hiperbolică",
            "Liniară"});
            this.fct_activare_comboBox.Location = new System.Drawing.Point(189, 64);
            this.fct_activare_comboBox.Name = "fct_activare_comboBox";
            this.fct_activare_comboBox.Size = new System.Drawing.Size(151, 28);
            this.fct_activare_comboBox.TabIndex = 20;
            // 
            // fct_intrare_comboBox
            // 
            this.fct_intrare_comboBox.FormattingEnabled = true;
            this.fct_intrare_comboBox.Items.AddRange(new object[] {
            "Suma",
            "Produs",
            "Maxim",
            "Minim"});
            this.fct_intrare_comboBox.Location = new System.Drawing.Point(189, 19);
            this.fct_intrare_comboBox.Name = "fct_intrare_comboBox";
            this.fct_intrare_comboBox.Size = new System.Drawing.Size(151, 28);
            this.fct_intrare_comboBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Output Function";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(131, 109);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(17, 20);
            this.a_label.TabIndex = 17;
            this.a_label.Text = "a";
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.Location = new System.Drawing.Point(251, 109);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(18, 20);
            this.g_label.TabIndex = 16;
            this.g_label.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "θ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Activation Function";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input Function";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(114, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(144, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "______";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(125, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "_________";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 249);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Output);
            this.Controls.Add(this.g_numericUpDown);
            this.Controls.Add(this.a_numericUpDown);
            this.Controls.Add(this.teta_numericUpDown);
            this.Controls.Add(this.fct_activare_comboBox);
            this.Controls.Add(this.fct_intrare_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.a_label);
            this.Controls.Add(this.g_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "Output";
            this.Text = "Output";
            ((System.ComponentModel.ISupportInitialize)(this.g_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teta_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_Output;
        private System.Windows.Forms.NumericUpDown g_numericUpDown;
        private System.Windows.Forms.NumericUpDown a_numericUpDown;
        private System.Windows.Forms.NumericUpDown teta_numericUpDown;
        private System.Windows.Forms.ComboBox fct_activare_comboBox;
        private System.Windows.Forms.ComboBox fct_intrare_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}