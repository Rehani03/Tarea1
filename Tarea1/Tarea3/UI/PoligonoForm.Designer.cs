namespace Tarea1.Tarea3
{
    partial class PoligonoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroLadosMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcularPerimetroButton = new System.Windows.Forms.Button();
            this.LongitudTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Lados:";
            // 
            // NumeroLadosMaskedText
            // 
            this.NumeroLadosMaskedText.Location = new System.Drawing.Point(161, 26);
            this.NumeroLadosMaskedText.Mask = "000";
            this.NumeroLadosMaskedText.Name = "NumeroLadosMaskedText";
            this.NumeroLadosMaskedText.Size = new System.Drawing.Size(60, 20);
            this.NumeroLadosMaskedText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Longitud de Lados:";
            // 
            // CalcularPerimetroButton
            // 
            this.CalcularPerimetroButton.Location = new System.Drawing.Point(55, 119);
            this.CalcularPerimetroButton.Name = "CalcularPerimetroButton";
            this.CalcularPerimetroButton.Size = new System.Drawing.Size(132, 55);
            this.CalcularPerimetroButton.TabIndex = 2;
            this.CalcularPerimetroButton.Text = "Calcular Perímetro";
            this.CalcularPerimetroButton.UseVisualStyleBackColor = true;
            this.CalcularPerimetroButton.Click += new System.EventHandler(this.CalcularPerimetroButton_Click);
            // 
            // LongitudTextBox
            // 
            this.LongitudTextBox.Location = new System.Drawing.Point(161, 60);
            this.LongitudTextBox.Name = "LongitudTextBox";
            this.LongitudTextBox.Size = new System.Drawing.Size(60, 20);
            this.LongitudTextBox.TabIndex = 3;
            // 
            // PoligonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 211);
            this.Controls.Add(this.LongitudTextBox);
            this.Controls.Add(this.CalcularPerimetroButton);
            this.Controls.Add(this.NumeroLadosMaskedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PoligonoForm";
            this.Text = "Poligono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox NumeroLadosMaskedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcularPerimetroButton;
        private System.Windows.Forms.TextBox LongitudTextBox;
    }
}