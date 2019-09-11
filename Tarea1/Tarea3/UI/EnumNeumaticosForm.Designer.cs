namespace Tarea1.Tarea3
{
    partial class EnumNeumaticosForm
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
            this.NuematicoLabel = new System.Windows.Forms.Label();
            this.NeumaticoComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NuematicoLabel
            // 
            this.NuematicoLabel.AutoSize = true;
            this.NuematicoLabel.Location = new System.Drawing.Point(13, 28);
            this.NuematicoLabel.Name = "NuematicoLabel";
            this.NuematicoLabel.Size = new System.Drawing.Size(100, 13);
            this.NuematicoLabel.TabIndex = 0;
            this.NuematicoLabel.Text = "Tipo de Neumático:";
            // 
            // NeumaticoComboBox
            // 
            this.NeumaticoComboBox.FormattingEnabled = true;
            this.NeumaticoComboBox.Items.AddRange(new object[] {
            "Neumáticos Anchos",
            "Neumáticos Usados",
            "Neumáticos Verano",
            "Neumáticos Todo Terreno",
            "Neumáticos Invierno"});
            this.NeumaticoComboBox.Location = new System.Drawing.Point(163, 28);
            this.NeumaticoComboBox.Name = "NeumaticoComboBox";
            this.NeumaticoComboBox.Size = new System.Drawing.Size(187, 21);
            this.NeumaticoComboBox.TabIndex = 1;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(16, 65);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(42, 13);
            this.CriterioLabel.TabIndex = 2;
            this.CriterioLabel.Text = "Criterio:";
            this.CriterioLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(163, 65);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(187, 20);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(144, 105);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(112, 34);
            this.MostrarButton.TabIndex = 4;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // EnumNeumaticosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 161);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.NeumaticoComboBox);
            this.Controls.Add(this.NuematicoLabel);
            this.MaximizeBox = false;
            this.Name = "EnumNeumaticosForm";
            this.Text = "Enum Neumaticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NuematicoLabel;
        private System.Windows.Forms.ComboBox NeumaticoComboBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}