namespace ConexionBD.Desktop
{
    partial class Notas
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
            GuardarButton = new Button();
            label2 = new Label();
            label1 = new Label();
            NombreMateriaTextBox = new TextBox();
            CodigoAlumnoTextBox = new TextBox();
            CalificacionTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(355, 277);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 29);
            GuardarButton.TabIndex = 9;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 213);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 151);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // NombreMateriaTextBox
            // 
            NombreMateriaTextBox.Location = new Point(353, 204);
            NombreMateriaTextBox.Name = "NombreMateriaTextBox";
            NombreMateriaTextBox.Size = new Size(247, 27);
            NombreMateriaTextBox.TabIndex = 6;
            // 
            // CodigoAlumnoTextBox
            // 
            CodigoAlumnoTextBox.Location = new Point(353, 145);
            CodigoAlumnoTextBox.Name = "CodigoAlumnoTextBox";
            CodigoAlumnoTextBox.Size = new Size(247, 27);
            CodigoAlumnoTextBox.TabIndex = 5;
            // 
            // CalificacionTextBox
            // 
            CalificacionTextBox.Location = new Point(357, 244);
            CalificacionTextBox.Name = "CalificacionTextBox";
            CalificacionTextBox.Size = new Size(243, 27);
            CalificacionTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 251);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 11;
            label3.Text = "Calificacion";
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(CalificacionTextBox);
            Controls.Add(GuardarButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NombreMateriaTextBox);
            Controls.Add(CodigoAlumnoTextBox);
            Name = "Notas";
            Text = "Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuardarButton;
        private Label label2;
        private Label label1;
        private TextBox NombreMateriaTextBox;
        private TextBox CodigoAlumnoTextBox;
        private TextBox CalificacionTextBox;
        private Label label3;
    }
}