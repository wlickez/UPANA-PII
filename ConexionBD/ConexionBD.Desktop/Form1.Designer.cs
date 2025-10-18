namespace ConexionBD.Desktop
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
            CodigoTextBox = new TextBox();
            NombreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GuardarButton = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CodigoTextBox
            // 
            CodigoTextBox.Location = new Point(222, 39);
            CodigoTextBox.Name = "CodigoTextBox";
            CodigoTextBox.Size = new Size(247, 27);
            CodigoTextBox.TabIndex = 0;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(222, 98);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(247, 27);
            NombreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 45);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 107);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(69, 174);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 29);
            GuardarButton.TabIndex = 4;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(417, 172);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(189, 174);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(GuardarButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NombreTextBox);
            Controls.Add(CodigoTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CodigoTextBox;
        private TextBox NombreTextBox;
        private Label label1;
        private Label label2;
        private Button GuardarButton;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
