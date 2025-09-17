namespace OperacionesMatematicas.WinForms
{
    partial class Form1
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
            NumeroATextBox = new TextBox();
            NumeroBTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ResultadoTextBox = new TextBox();
            SignoOperacionTextBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // NumeroATextBox
            // 
            NumeroATextBox.Location = new Point(161, 96);
            NumeroATextBox.Name = "NumeroATextBox";
            NumeroATextBox.Size = new Size(125, 27);
            NumeroATextBox.TabIndex = 0;
            // 
            // NumeroBTextBox
            // 
            NumeroBTextBox.Location = new Point(161, 153);
            NumeroBTextBox.Name = "NumeroBTextBox";
            NumeroBTextBox.Size = new Size(125, 27);
            NumeroBTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(164, 210);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Operar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Numero a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 158);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Numero b";
            // 
            // ResultadoTextBox
            // 
            ResultadoTextBox.Location = new Point(339, 153);
            ResultadoTextBox.Name = "ResultadoTextBox";
            ResultadoTextBox.Size = new Size(125, 27);
            ResultadoTextBox.TabIndex = 5;
            // 
            // SignoOperacionTextBox
            // 
            SignoOperacionTextBox.Location = new Point(339, 99);
            SignoOperacionTextBox.Name = "SignoOperacionTextBox";
            SignoOperacionTextBox.Size = new Size(125, 27);
            SignoOperacionTextBox.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(356, 210);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(SignoOperacionTextBox);
            Controls.Add(ResultadoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(NumeroBTextBox);
            Controls.Add(NumeroATextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumeroATextBox;
        private TextBox NumeroBTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox ResultadoTextBox;
        private TextBox SignoOperacionTextBox;
        private Button button2;
    }
}
