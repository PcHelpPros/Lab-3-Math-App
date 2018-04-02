namespace Lab_3C_Math_App
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
            this.FormIntro = new System.Windows.Forms.RichTextBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UserValue1 = new System.Windows.Forms.TextBox();
            this.UserValue2 = new System.Windows.Forms.TextBox();
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormIntro
            // 
            this.FormIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormIntro.Location = new System.Drawing.Point(179, 12);
            this.FormIntro.Name = "FormIntro";
            this.FormIntro.ReadOnly = true;
            this.FormIntro.Size = new System.Drawing.Size(288, 42);
            this.FormIntro.TabIndex = 1;
            this.FormIntro.Text = "Select A Math Function";
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(55, 99);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(63, 17);
            this.radioAdd.TabIndex = 2;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Addition";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(186, 99);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(79, 17);
            this.radioSubtract.TabIndex = 3;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "Subtraction";
            this.radioSubtract.UseVisualStyleBackColor = true;
            this.radioSubtract.CheckedChanged += new System.EventHandler(this.radioSubtract_CheckedChanged);
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Location = new System.Drawing.Point(333, 99);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(86, 17);
            this.radioMultiply.TabIndex = 4;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "Multiplication";
            this.radioMultiply.UseVisualStyleBackColor = true;
            this.radioMultiply.CheckedChanged += new System.EventHandler(this.radioMultiply_CheckedChanged);
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Location = new System.Drawing.Point(487, 99);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(62, 17);
            this.radioDivide.TabIndex = 5;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "Division";
            this.radioDivide.UseVisualStyleBackColor = true;
            this.radioDivide.CheckedChanged += new System.EventHandler(this.radioDivide_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(55, 341);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(473, 341);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UserValue1
            // 
            this.UserValue1.Location = new System.Drawing.Point(271, 147);
            this.UserValue1.Name = "UserValue1";
            this.UserValue1.Size = new System.Drawing.Size(115, 20);
            this.UserValue1.TabIndex = 8;
            this.UserValue1.TextChanged += new System.EventHandler(this.UserValue1_TextChanged);
            // 
            // UserValue2
            // 
            this.UserValue2.Location = new System.Drawing.Point(271, 216);
            this.UserValue2.Name = "UserValue2";
            this.UserValue2.Size = new System.Drawing.Size(115, 20);
            this.UserValue2.TabIndex = 9;
            this.UserValue2.TextChanged += new System.EventHandler(this.UserValue2_TextChanged);
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(183, 150);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(43, 13);
            this.Value1.TabIndex = 10;
            this.Value1.Text = "Value 1";
            this.Value1.Click += new System.EventHandler(this.Value1_Click);
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(183, 219);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(43, 13);
            this.Value2.TabIndex = 11;
            this.Value2.Text = "Value 2";
            this.Value2.Click += new System.EventHandler(this.Value2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.UserValue2);
            this.Controls.Add(this.UserValue1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.radioDivide);
            this.Controls.Add(this.radioMultiply);
            this.Controls.Add(this.radioSubtract);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.FormIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Lab 3C Math Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FormIntro;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox UserValue1;
        private System.Windows.Forms.TextBox UserValue2;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
    }
}

