namespace Tarea1.Tarea3
{
    partial class EstructuraTiendaForm
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
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.CodigoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.DepartamentoLabel = new System.Windows.Forms.Label();
            this.DepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Location = new System.Drawing.Point(22, 31);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(43, 13);
            this.CodigoLabel.TabIndex = 0;
            this.CodigoLabel.Text = "Codigo:";
            // 
            // CodigoNumericUpDown
            // 
            this.CodigoNumericUpDown.Location = new System.Drawing.Point(105, 29);
            this.CodigoNumericUpDown.Name = "CodigoNumericUpDown";
            this.CodigoNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.CodigoNumericUpDown.TabIndex = 1;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(22, 75);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(47, 13);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(105, 72);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(126, 20);
            this.NombreTextBox.TabIndex = 2;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(22, 114);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(52, 13);
            this.CantidadLabel.TabIndex = 0;
            this.CantidadLabel.Text = "Cantidad:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(105, 111);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(77, 20);
            this.CantidadTextBox.TabIndex = 2;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(22, 154);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(40, 13);
            this.PrecioLabel.TabIndex = 0;
            this.PrecioLabel.Text = "Precio:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(105, 147);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(77, 20);
            this.PrecioTextBox.TabIndex = 2;
            // 
            // DepartamentoLabel
            // 
            this.DepartamentoLabel.AutoSize = true;
            this.DepartamentoLabel.Location = new System.Drawing.Point(22, 199);
            this.DepartamentoLabel.Name = "DepartamentoLabel";
            this.DepartamentoLabel.Size = new System.Drawing.Size(77, 13);
            this.DepartamentoLabel.TabIndex = 0;
            this.DepartamentoLabel.Text = "Departamento:";
            // 
            // DepartamentoTextBox
            // 
            this.DepartamentoTextBox.Location = new System.Drawing.Point(105, 196);
            this.DepartamentoTextBox.Name = "DepartamentoTextBox";
            this.DepartamentoTextBox.Size = new System.Drawing.Size(126, 20);
            this.DepartamentoTextBox.TabIndex = 2;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(89, 242);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(104, 45);
            this.MostrarButton.TabIndex = 3;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // EstructuraTiendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 319);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.DepartamentoTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CodigoNumericUpDown);
            this.Controls.Add(this.DepartamentoLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CodigoLabel);
            this.Name = "EstructuraTiendaForm";
            this.Text = "Estructura Tienda ";
            ((System.ComponentModel.ISupportInitialize)(this.CodigoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.NumericUpDown CodigoNumericUpDown;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label DepartamentoLabel;
        private System.Windows.Forms.TextBox DepartamentoTextBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}