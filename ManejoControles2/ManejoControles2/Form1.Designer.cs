namespace ManejoControles2
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
            ValidacionCheckBox = new CheckBox();
            ValidarButton = new Button();
            AlumnoTextBox = new TextBox();
            AlumnosComboBox = new ComboBox();
            AgregarButton = new Button();
            EliminarButton = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // ValidacionCheckBox
            // 
            ValidacionCheckBox.AutoSize = true;
            ValidacionCheckBox.Location = new Point(184, 64);
            ValidacionCheckBox.Name = "ValidacionCheckBox";
            ValidacionCheckBox.Size = new Size(100, 24);
            ValidacionCheckBox.TabIndex = 0;
            ValidacionCheckBox.Text = "Validacion";
            ValidacionCheckBox.UseVisualStyleBackColor = true;
            ValidacionCheckBox.CheckedChanged += ValidacionCheckBox_CheckedChanged;
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(184, 142);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(94, 29);
            ValidarButton.TabIndex = 1;
            ValidarButton.Text = "Ejecutar";
            ValidarButton.UseVisualStyleBackColor = true;
            ValidarButton.Click += ValidarButton_Click;
            // 
            // AlumnoTextBox
            // 
            AlumnoTextBox.Location = new Point(539, 61);
            AlumnoTextBox.Name = "AlumnoTextBox";
            AlumnoTextBox.Size = new Size(188, 27);
            AlumnoTextBox.TabIndex = 2;
            // 
            // AlumnosComboBox
            // 
            AlumnosComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AlumnosComboBox.FormattingEnabled = true;
            AlumnosComboBox.Location = new Point(540, 127);
            AlumnosComboBox.Name = "AlumnosComboBox";
            AlumnosComboBox.Size = new Size(187, 28);
            AlumnosComboBox.TabIndex = 3;
            AlumnosComboBox.SelectedIndexChanged += AlumnosComboBox_SelectedIndexChanged;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(583, 186);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(94, 29);
            AgregarButton.TabIndex = 4;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // EliminarButton
            // 
            EliminarButton.Location = new Point(706, 191);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(94, 29);
            EliminarButton.TabIndex = 5;
            EliminarButton.Text = "Eliminar";
            EliminarButton.UseVisualStyleBackColor = true;
            EliminarButton.Click += EliminarButton_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(948, 42);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(413, 260);
            treeView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 371);
            Controls.Add(treeView1);
            Controls.Add(EliminarButton);
            Controls.Add(AgregarButton);
            Controls.Add(AlumnosComboBox);
            Controls.Add(AlumnoTextBox);
            Controls.Add(ValidarButton);
            Controls.Add(ValidacionCheckBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ValidacionCheckBox;
        private Button ValidarButton;
        private TextBox AlumnoTextBox;
        private ComboBox AlumnosComboBox;
        private Button AgregarButton;
        private Button EliminarButton;
        private TreeView treeView1;
    }
}
