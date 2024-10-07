
namespace Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtResult = new System.Windows.Forms.TextBox();
            grpInput = new System.Windows.Forms.GroupBox();
            btnDivision = new System.Windows.Forms.Button();
            btnMultiplication = new System.Windows.Forms.Button();
            btnSubtraction = new System.Windows.Forms.Button();
            btnAddition = new System.Windows.Forms.Button();
            txtSecondNumber = new System.Windows.Forms.TextBox();
            txtFirstNumber = new System.Windows.Forms.TextBox();
            lblSecondNumber = new System.Windows.Forms.Label();
            lblFirstNumber = new System.Windows.Forms.Label();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            txtResult.Dock = System.Windows.Forms.DockStyle.Top;
            txtResult.Location = new System.Drawing.Point(0, 0);
            txtResult.Margin = new System.Windows.Forms.Padding(5);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new System.Drawing.Size(374, 36);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnDivision);
            grpInput.Controls.Add(btnMultiplication);
            grpInput.Controls.Add(btnSubtraction);
            grpInput.Controls.Add(btnAddition);
            grpInput.Controls.Add(txtSecondNumber);
            grpInput.Controls.Add(txtFirstNumber);
            grpInput.Controls.Add(lblSecondNumber);
            grpInput.Controls.Add(lblFirstNumber);
            grpInput.Location = new System.Drawing.Point(12, 58);
            grpInput.Name = "grpInput";
            grpInput.Size = new System.Drawing.Size(344, 443);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "Input";
            // 
            // btnDivision
            // 
            btnDivision.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            btnDivision.Font = new System.Drawing.Font("Segoe UI", 42F);
            btnDivision.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDivision.Location = new System.Drawing.Point(197, 318);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new System.Drawing.Size(134, 105);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseCompatibleTextRendering = true;
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 50F);
            btnMultiplication.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnMultiplication.Location = new System.Drawing.Point(21, 313);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new System.Drawing.Size(134, 105);
            btnMultiplication.TabIndex = 3;
            btnMultiplication.Text = "x";
            btnMultiplication.UseCompatibleTextRendering = true;
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            btnSubtraction.Font = new System.Drawing.Font("Segoe UI", 72F);
            btnSubtraction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSubtraction.Location = new System.Drawing.Point(197, 188);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new System.Drawing.Size(134, 105);
            btnSubtraction.TabIndex = 3;
            btnSubtraction.Text = "-";
            btnSubtraction.UseCompatibleTextRendering = true;
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            btnAddition.Font = new System.Drawing.Font("Segoe UI", 64F);
            btnAddition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddition.Location = new System.Drawing.Point(21, 188);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new System.Drawing.Size(134, 105);
            btnAddition.TabIndex = 3;
            btnAddition.Text = "+";
            btnAddition.UseCompatibleTextRendering = true;
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new System.Drawing.Point(173, 113);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new System.Drawing.Size(145, 36);
            txtSecondNumber.TabIndex = 2;
            txtSecondNumber.Text = "0";
            txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new System.Drawing.Point(173, 44);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new System.Drawing.Size(145, 36);
            txtFirstNumber.TabIndex = 2;
            txtFirstNumber.Text = "0";
            txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSecondNumber
            // 
            lblSecondNumber.AutoSize = true;
            lblSecondNumber.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblSecondNumber.Location = new System.Drawing.Point(21, 124);
            lblSecondNumber.Name = "lblSecondNumber";
            lblSecondNumber.Size = new System.Drawing.Size(145, 25);
            lblSecondNumber.TabIndex = 1;
            lblSecondNumber.Text = "Second number";
            // 
            // lblFirstNumber
            // 
            lblFirstNumber.AutoSize = true;
            lblFirstNumber.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblFirstNumber.Location = new System.Drawing.Point(21, 51);
            lblFirstNumber.Name = "lblFirstNumber";
            lblFirstNumber.Size = new System.Drawing.Size(118, 25);
            lblFirstNumber.TabIndex = 0;
            lblFirstNumber.Text = "First number";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(374, 513);
            Controls.Add(grpInput);
            Controls.Add(txtResult);
            Font = new System.Drawing.Font("Segoe UI", 16F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5);
            Name = "MainForm";
            Text = "Calculator";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblFirstNumber;
    }
}

