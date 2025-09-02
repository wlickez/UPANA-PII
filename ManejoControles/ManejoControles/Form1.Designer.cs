namespace ManejoControles
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
            ListadoAlumnosListBox = new ListBox();
            AgregarButton = new Button();
            NombreAlumnoTextBox = new TextBox();
            SuspendLayout();
            // 
            // ListadoAlumnosListBox
            // 
            ListadoAlumnosListBox.FormattingEnabled = true;
            ListadoAlumnosListBox.Location = new Point(107, 32);
            ListadoAlumnosListBox.Name = "ListadoAlumnosListBox";
            ListadoAlumnosListBox.Size = new Size(388, 104);
            ListadoAlumnosListBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(107, 220);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(94, 29);
            AgregarButton.TabIndex = 1;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            //AgregarButton.Click += AgregarButton_Click;
            // 
            // NombreAlumnoTextBox
            // 
            NombreAlumnoTextBox.Location = new Point(114, 172);
            NombreAlumnoTextBox.Name = "NombreAlumnoTextBox";
            NombreAlumnoTextBox.Size = new Size(265, 27);
            NombreAlumnoTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NombreAlumnoTextBox);
            Controls.Add(AgregarButton);
            Controls.Add(ListadoAlumnosListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListadoAlumnosListBox;
        private Button AgregarButton;
        private TextBox NombreAlumnoTextBox;
    }
}
