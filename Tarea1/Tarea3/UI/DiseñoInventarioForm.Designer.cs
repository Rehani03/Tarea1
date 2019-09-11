namespace Tarea1.Tarea3
{
    partial class DiseñoInventarioForm
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
            this.IDProductoNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DepartamentoLabel = new System.Windows.Forms.Label();
            this.Costolabel = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ItbisLabel = new System.Windows.Forms.Label();
            this.ITBISTextBox = new System.Windows.Forms.TextBox();
            this.MostrarDatosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDProductoNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDProductoNumericUpDown1
            // 
            this.IDProductoNumericUpDown1.Location = new System.Drawing.Point(143, 24);
            this.IDProductoNumericUpDown1.Name = "IDProductoNumericUpDown1";
            this.IDProductoNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.IDProductoNumericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto:";
            // 
            // DepartamentoComboBox
            // 
            this.DepartamentoComboBox.FormattingEnabled = true;
            this.DepartamentoComboBox.Items.AddRange(new object[] {
            "Limpieza",
            "Comida",
            "Electrónica"});
            this.DepartamentoComboBox.Location = new System.Drawing.Point(143, 110);
            this.DepartamentoComboBox.Name = "DepartamentoComboBox";
            this.DepartamentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartamentoComboBox.TabIndex = 2;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(143, 64);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(176, 20);
            this.NombreTextBox.TabIndex = 3;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // DepartamentoLabel
            // 
            this.DepartamentoLabel.AutoSize = true;
            this.DepartamentoLabel.Location = new System.Drawing.Point(12, 118);
            this.DepartamentoLabel.Name = "DepartamentoLabel";
            this.DepartamentoLabel.Size = new System.Drawing.Size(123, 13);
            this.DepartamentoLabel.TabIndex = 1;
            this.DepartamentoLabel.Text = "Departamento Producto:";
            // 
            // Costolabel
            // 
            this.Costolabel.AutoSize = true;
            this.Costolabel.Location = new System.Drawing.Point(12, 158);
            this.Costolabel.Name = "Costolabel";
            this.Costolabel.Size = new System.Drawing.Size(83, 13);
            this.Costolabel.TabIndex = 1;
            this.Costolabel.Text = "Costo Producto:";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(143, 155);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(121, 20);
            this.CostoTextBox.TabIndex = 3;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(12, 198);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(86, 13);
            this.PrecioLabel.TabIndex = 1;
            this.PrecioLabel.Text = "Precio Producto:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(143, 191);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(121, 20);
            this.PrecioTextBox.TabIndex = 3;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(12, 238);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(98, 13);
            this.CantidadLabel.TabIndex = 1;
            this.CantidadLabel.Text = "Cantidad Producto:";
            // 
            // CantidadmaskedTextBox
            // 
            this.CantidadmaskedTextBox.Location = new System.Drawing.Point(143, 231);
            this.CantidadmaskedTextBox.Mask = "000000";
            this.CantidadmaskedTextBox.Name = "CantidadmaskedTextBox";
            this.CantidadmaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.CantidadmaskedTextBox.TabIndex = 4;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 275);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(112, 13);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Descripción Producto:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(143, 275);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(176, 20);
            this.DescripcionTextBox.TabIndex = 3;
            this.DescripcionTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // ItbisLabel
            // 
            this.ItbisLabel.AutoSize = true;
            this.ItbisLabel.Location = new System.Drawing.Point(12, 314);
            this.ItbisLabel.Name = "ItbisLabel";
            this.ItbisLabel.Size = new System.Drawing.Size(83, 13);
            this.ItbisLabel.TabIndex = 1;
            this.ItbisLabel.Text = "ITBIS Producto:";
            // 
            // ITBISTextBox
            // 
            this.ITBISTextBox.Location = new System.Drawing.Point(143, 311);
            this.ITBISTextBox.Name = "ITBISTextBox";
            this.ITBISTextBox.Size = new System.Drawing.Size(176, 20);
            this.ITBISTextBox.TabIndex = 3;
            this.ITBISTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // MostrarDatosButton
            // 
            this.MostrarDatosButton.Location = new System.Drawing.Point(110, 362);
            this.MostrarDatosButton.Name = "MostrarDatosButton";
            this.MostrarDatosButton.Size = new System.Drawing.Size(125, 40);
            this.MostrarDatosButton.TabIndex = 5;
            this.MostrarDatosButton.Text = "Mostrar Datos";
            this.MostrarDatosButton.UseVisualStyleBackColor = true;
            this.MostrarDatosButton.Click += new System.EventHandler(this.MostrarDatosButton_Click);
            // 
            // DiseñoInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 433);
            this.Controls.Add(this.MostrarDatosButton);
            this.Controls.Add(this.CantidadmaskedTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.ITBISTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.DepartamentoComboBox);
            this.Controls.Add(this.ItbisLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.Costolabel);
            this.Controls.Add(this.DepartamentoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDProductoNumericUpDown1);
            this.MaximizeBox = false;
            this.Name = "DiseñoInventarioForm";
            this.Text = "Diseño Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.IDProductoNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDProductoNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DepartamentoComboBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label DepartamentoLabel;
        private System.Windows.Forms.Label Costolabel;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.MaskedTextBox CantidadmaskedTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label ItbisLabel;
        private System.Windows.Forms.TextBox ITBISTextBox;
        private System.Windows.Forms.Button MostrarDatosButton;
    }
}