
namespace WinFormsApp1
{
    partial class CalculatorForm
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownLeftValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRightValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(170, 73);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(232, 48);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numericUpDownLeftValue
            // 
            this.numericUpDownLeftValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownLeftValue.Location = new System.Drawing.Point(20, 12);
            this.numericUpDownLeftValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownLeftValue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownLeftValue.Name = "numericUpDownLeftValue";
            this.numericUpDownLeftValue.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownLeftValue.TabIndex = 1;
            // 
            // numericUpDownRightValue
            // 
            this.numericUpDownRightValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownRightValue.Location = new System.Drawing.Point(375, 12);
            this.numericUpDownRightValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRightValue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownRightValue.Name = "numericUpDownRightValue";
            this.numericUpDownRightValue.Size = new System.Drawing.Size(150, 43);
            this.numericUpDownRightValue.TabIndex = 2;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.comboBoxOperator.Location = new System.Drawing.Point(197, 10);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(151, 45);
            this.comboBoxOperator.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(20, 137);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(505, 43);
            this.textBoxResult.TabIndex = 4;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 196);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.numericUpDownRightValue);
            this.Controls.Add(this.numericUpDownLeftValue);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownLeftValue;
        private System.Windows.Forms.NumericUpDown numericUpDownRightValue;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
