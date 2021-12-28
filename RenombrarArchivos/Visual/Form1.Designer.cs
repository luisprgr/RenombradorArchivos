namespace RenombrarArchivos.Visual
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.abrirDirectorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTextFinal = new System.Windows.Forms.Button();
            this.buttonTextInicio = new System.Windows.Forms.Button();
            this.buttonRempPartNomb = new System.Windows.Forms.Button();
            this.buttonEliminarPartNomb = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // abrirDirectorio
            // 
            this.abrirDirectorio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.abrirDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirDirectorio.Location = new System.Drawing.Point(14, 20);
            this.abrirDirectorio.Name = "abrirDirectorio";
            this.abrirDirectorio.Size = new System.Drawing.Size(157, 33);
            this.abrirDirectorio.TabIndex = 0;
            this.abrirDirectorio.Text = "Abrir Directorio";
            this.abrirDirectorio.UseVisualStyleBackColor = false;
            this.abrirDirectorio.Click += new System.EventHandler(this.abrirDirectorio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonTextFinal);
            this.panel1.Controls.Add(this.buttonTextInicio);
            this.panel1.Controls.Add(this.buttonRempPartNomb);
            this.panel1.Controls.Add(this.buttonEliminarPartNomb);
            this.panel1.Controls.Add(this.buttonActualizar);
            this.panel1.Controls.Add(this.abrirDirectorio);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 459);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(33, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Acción a realizar:";
            // 
            // buttonTextFinal
            // 
            this.buttonTextFinal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTextFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextFinal.Location = new System.Drawing.Point(14, 314);
            this.buttonTextFinal.Name = "buttonTextFinal";
            this.buttonTextFinal.Size = new System.Drawing.Size(157, 48);
            this.buttonTextFinal.TabIndex = 4;
            this.buttonTextFinal.Text = "Agregar texto al final";
            this.buttonTextFinal.UseVisualStyleBackColor = false;
            this.buttonTextFinal.Click += new System.EventHandler(this.buttonTextFinal_Click);
            // 
            // buttonTextInicio
            // 
            this.buttonTextInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTextInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextInicio.Location = new System.Drawing.Point(14, 260);
            this.buttonTextInicio.Name = "buttonTextInicio";
            this.buttonTextInicio.Size = new System.Drawing.Size(157, 48);
            this.buttonTextInicio.TabIndex = 3;
            this.buttonTextInicio.Text = "Agregar texto al principio";
            this.buttonTextInicio.UseVisualStyleBackColor = false;
            this.buttonTextInicio.Click += new System.EventHandler(this.buttonTextInicio_Click);
            // 
            // buttonRempPartNomb
            // 
            this.buttonRempPartNomb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRempPartNomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRempPartNomb.Location = new System.Drawing.Point(14, 205);
            this.buttonRempPartNomb.Name = "buttonRempPartNomb";
            this.buttonRempPartNomb.Size = new System.Drawing.Size(157, 48);
            this.buttonRempPartNomb.TabIndex = 2;
            this.buttonRempPartNomb.Text = "Remplazar parte del nombre";
            this.buttonRempPartNomb.UseVisualStyleBackColor = false;
            this.buttonRempPartNomb.Click += new System.EventHandler(this.buttonRempPartNomb_Click);
            // 
            // buttonEliminarPartNomb
            // 
            this.buttonEliminarPartNomb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarPartNomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarPartNomb.Location = new System.Drawing.Point(14, 151);
            this.buttonEliminarPartNomb.Name = "buttonEliminarPartNomb";
            this.buttonEliminarPartNomb.Size = new System.Drawing.Size(157, 48);
            this.buttonEliminarPartNomb.TabIndex = 1;
            this.buttonEliminarPartNomb.Text = "Eliminar parte del nombre";
            this.buttonEliminarPartNomb.UseVisualStyleBackColor = false;
            this.buttonEliminarPartNomb.Click += new System.EventHandler(this.buttonEliminarPartNomb_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Location = new System.Drawing.Point(14, 56);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(157, 33);
            this.buttonActualizar.TabIndex = 0;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(183, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 341);
            this.panel2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(639, 324);
            this.listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(183, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 123);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Renombrador de archivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abrirDirectorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRempPartNomb;
        private System.Windows.Forms.Button buttonEliminarPartNomb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTextFinal;
        private System.Windows.Forms.Button buttonTextInicio;
    }
}

