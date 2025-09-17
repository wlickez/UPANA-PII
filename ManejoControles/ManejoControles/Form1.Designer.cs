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
            components = new System.ComponentModel.Container();
            ListadoAlumnosListBox = new ListBox();
            AgregarButton = new Button();
            NombreAlumnoTextBox = new TextBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ListadoAlumnosListBox
            // 
            ListadoAlumnosListBox.FormattingEnabled = true;
            ListadoAlumnosListBox.ItemHeight = 15;
            ListadoAlumnosListBox.Location = new Point(94, 24);
            ListadoAlumnosListBox.Margin = new Padding(3, 2, 3, 2);
            ListadoAlumnosListBox.Name = "ListadoAlumnosListBox";
            ListadoAlumnosListBox.Size = new Size(340, 79);
            ListadoAlumnosListBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(94, 165);
            AgregarButton.Margin = new Padding(3, 2, 3, 2);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(82, 22);
            AgregarButton.TabIndex = 1;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click_1;
            // 
            // NombreAlumnoTextBox
            // 
            NombreAlumnoTextBox.Location = new Point(100, 129);
            NombreAlumnoTextBox.Margin = new Padding(3, 2, 3, 2);
            NombreAlumnoTextBox.Name = "NombreAlumnoTextBox";
            NombreAlumnoTextBox.Size = new Size(232, 23);
            NombreAlumnoTextBox.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(316, 182);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(334, 29);
            progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(progressBar1);
            Controls.Add(NombreAlumnoTextBox);
            Controls.Add(AgregarButton);
            Controls.Add(ListadoAlumnosListBox);
            Margin = new Padding(3, 2, 3, 2);
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
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
