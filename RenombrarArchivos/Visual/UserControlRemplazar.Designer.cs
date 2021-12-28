namespace RenombrarArchivos.Visual
{
    partial class UserControlRemplazar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRempazarTextoNuevo = new System.Windows.Forms.TextBox();
            this.buttonRemplazar = new System.Windows.Forms.Button();
            this.textBoxRemplazarTextoAnterior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texto a remplazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Remplazar Parte del Nombre";
            // 
            // textBoxRempazarTextoNuevo
            // 
            this.textBoxRempazarTextoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRempazarTextoNuevo.Location = new System.Drawing.Point(239, 65);
            this.textBoxRempazarTextoNuevo.Name = "textBoxRempazarTextoNuevo";
            this.textBoxRempazarTextoNuevo.Size = new System.Drawing.Size(228, 27);
            this.textBoxRempazarTextoNuevo.TabIndex = 12;
            // 
            // buttonRemplazar
            // 
            this.buttonRemplazar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemplazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemplazar.Location = new System.Drawing.Point(466, 65);
            this.buttonRemplazar.Name = "buttonRemplazar";
            this.buttonRemplazar.Size = new System.Drawing.Size(180, 27);
            this.buttonRemplazar.TabIndex = 10;
            this.buttonRemplazar.Text = "Remplazar";
            this.buttonRemplazar.UseVisualStyleBackColor = false;
            this.buttonRemplazar.Click += new System.EventHandler(this.buttonRemplazar_Click);
            // 
            // textBoxRemplazarTextoAnterior
            // 
            this.textBoxRemplazarTextoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemplazarTextoAnterior.Location = new System.Drawing.Point(11, 65);
            this.textBoxRemplazarTextoAnterior.Name = "textBoxRemplazarTextoAnterior";
            this.textBoxRemplazarTextoAnterior.Size = new System.Drawing.Size(228, 27);
            this.textBoxRemplazarTextoAnterior.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(236, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Texto nuevo:";
            // 
            // UserControlRemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRempazarTextoNuevo);
            this.Controls.Add(this.buttonRemplazar);
            this.Controls.Add(this.textBoxRemplazarTextoAnterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UserControlRemplazar";
            this.Size = new System.Drawing.Size(659, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRempazarTextoNuevo;
        private System.Windows.Forms.Button buttonRemplazar;
        private System.Windows.Forms.TextBox textBoxRemplazarTextoAnterior;
        private System.Windows.Forms.Label label3;
    }
}
