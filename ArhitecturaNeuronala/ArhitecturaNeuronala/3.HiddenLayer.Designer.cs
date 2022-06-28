
namespace ArhitecturaNeuronala
{
    partial class HiddenLayers
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
            this.fct_intrare_textBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fct_intrare_comboBox = new System.Windows.Forms.ComboBox();
            this.fct_activare_comboBox = new System.Windows.Forms.ComboBox();
            this.teta_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.a_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.g_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Output = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teta_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fct_intrare_textBox
            // 
            this.fct_intrare_textBox.AutoSize = true;
            this.fct_intrare_textBox.Location = new System.Drawing.Point(12, 20);
            this.fct_intrare_textBox.Name = "fct_intrare_textBox";
            this.fct_intrare_textBox.Size = new System.Drawing.Size(103, 20);
            this.fct_intrare_textBox.TabIndex = 0;
            this.fct_intrare_textBox.Text = "Input Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activation Function";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "θ";
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.Location = new System.Drawing.Point(251, 110);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(18, 20);
            this.g_label.TabIndex = 3;
            this.g_label.Text = "g";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(131, 110);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(17, 20);
            this.a_label.TabIndex = 4;
            this.a_label.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Output Function";
            // 
            // fct_intrare_comboBox
            // 
            this.fct_intrare_comboBox.FormattingEnabled = true;
            this.fct_intrare_comboBox.Items.AddRange(new object[] {
            "Suma",
            "Produs",
            "Maxim",
            "Minim"});
            this.fct_intrare_comboBox.Location = new System.Drawing.Point(189, 20);
            this.fct_intrare_comboBox.Name = "fct_intrare_comboBox";
            this.fct_intrare_comboBox.Size = new System.Drawing.Size(151, 28);
            this.fct_intrare_comboBox.TabIndex = 6;
            this.fct_intrare_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_Input_SelectedIndexChanged);
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
            this.fct_activare_comboBox.Location = new System.Drawing.Point(189, 65);
            this.fct_activare_comboBox.Name = "fct_activare_comboBox";
            this.fct_activare_comboBox.Size = new System.Drawing.Size(151, 28);
            this.fct_activare_comboBox.TabIndex = 7;
            this.fct_activare_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_Activation_SelectedIndexChanged);
            // 
            // teta_numericUpDown
            // 
            this.teta_numericUpDown.DecimalPlaces = 2;
            this.teta_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.teta_numericUpDown.Location = new System.Drawing.Point(38, 110);
            this.teta_numericUpDown.Name = "teta_numericUpDown";
            this.teta_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.teta_numericUpDown.TabIndex = 8;
            this.teta_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_numericUpDown
            // 
            this.a_numericUpDown.DecimalPlaces = 2;
            this.a_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.a_numericUpDown.Location = new System.Drawing.Point(155, 110);
            this.a_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.a_numericUpDown.Name = "a_numericUpDown";
            this.a_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.a_numericUpDown.TabIndex = 9;
            this.a_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // g_numericUpDown
            // 
            this.g_numericUpDown.DecimalPlaces = 2;
            this.g_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.g_numericUpDown.Location = new System.Drawing.Point(275, 110);
            this.g_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.g_numericUpDown.Name = "g_numericUpDown";
            this.g_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.g_numericUpDown.TabIndex = 10;
            this.g_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.g_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Output
            // 
            this.comboBox_Output.FormattingEnabled = true;
            this.comboBox_Output.Items.AddRange(new object[] {
            "Real",
            "Binar"});
            this.comboBox_Output.Location = new System.Drawing.Point(189, 160);
            this.comboBox_Output.Name = "comboBox_Output";
            this.comboBox_Output.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Output.TabIndex = 11;
            this.comboBox_Output.SelectedIndexChanged += new System.EventHandler(this.comboBox_Output_SelectedIndexChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(131, 211);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // HiddenLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 252);
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
            this.Controls.Add(this.fct_intrare_textBox);
            this.Name = "HiddenLayers";
            this.Text = "Hidden Layer Information";
            ((System.ComponentModel.ISupportInitialize)(this.teta_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fct_intrare_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fct_intrare_comboBox;
        private System.Windows.Forms.ComboBox fct_activare_comboBox;
        private System.Windows.Forms.NumericUpDown teta_numericUpDown;
        private System.Windows.Forms.NumericUpDown a_numericUpDown;
        private System.Windows.Forms.NumericUpDown g_numericUpDown;
        private System.Windows.Forms.ComboBox comboBox_Output;
        private System.Windows.Forms.Button button_Save;
    }
}