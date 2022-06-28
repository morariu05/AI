
namespace ArhitecturaNeuronala
{
    partial class Input
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
            this.numericInput = new System.Windows.Forms.NumericUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // numericInput
            // 
            this.numericInput.DecimalPlaces = 2;
            this.numericInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericInput.Location = new System.Drawing.Point(173, 14);
            this.numericInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput.Name = "numericInput";
            this.numericInput.Size = new System.Drawing.Size(104, 27);
            this.numericInput.TabIndex = 1;
            this.numericInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(100, 56);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(68, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "_______________";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(289, 97);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.numericInput);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.Text = "Input Information";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericInput;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label5;
    }
}