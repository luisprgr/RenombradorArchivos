namespace RenombrarArchivos.Visual
{
    partial class UserControlAgregarInicio
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
            this.buttonAgregarInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAgregarInicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAgregarInicio
            // 
            this.buttonAgregarInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarInicio.Location = new System.Drawing.Point(466, 65);
            this.buttonAgregarInicio.Name = "buttonAgregarInicio";
            this.buttonAgregarInicio.Size = new System.Drawing.Size(180, 27);
            this.buttonAgregarInicio.TabIndex = 8;
            this.buttonAgregarInicio.Text = "Agregar";
            this.buttonAgregarInicio.UseVisualStyleBackColor = false;
            this.buttonAgregarInicio.Click += new System.EventHandler(this.buttonAgregarInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texto a agregar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Agregar al inicio del nombre";
            // 
            // textBoxAgregarInicio
            // 
            this.textBoxAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarInicio.Location = new System.Drawing.Point(11, 65);
            this.textBoxAgregarInicio.Name = "textBoxAgregarInicio";
            this.textBoxAgregarInicio.Size = new System.Drawing.Size(456, 27);
            this.textBoxAgregarInicio.TabIndex = 9;
            // 
            // UserControlAgregarInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAgregarInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAgregarInicio);
            this.Name = "UserControlAgregarInicio";
            this.Size = new System.Drawing.Size(659, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAgregarInicio;
    }
}
