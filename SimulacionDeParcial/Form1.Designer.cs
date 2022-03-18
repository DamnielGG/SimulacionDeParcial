
namespace SimulacionDeParcial
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
            this.buttonVisualizarEdificios = new System.Windows.Forms.Button();
            this.textBoxIdentificacionDepa = new System.Windows.Forms.TextBox();
            this.textBoxGrados = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonVisualizarEdificios
            // 
            this.buttonVisualizarEdificios.Location = new System.Drawing.Point(126, 292);
            this.buttonVisualizarEdificios.Name = "buttonVisualizarEdificios";
            this.buttonVisualizarEdificios.Size = new System.Drawing.Size(157, 84);
            this.buttonVisualizarEdificios.TabIndex = 0;
            this.buttonVisualizarEdificios.Text = "Seleccionar un edificio";
            this.buttonVisualizarEdificios.UseVisualStyleBackColor = true;
            // 
            // textBoxIdentificacionDepa
            // 
            this.textBoxIdentificacionDepa.Location = new System.Drawing.Point(183, 70);
            this.textBoxIdentificacionDepa.Name = "textBoxIdentificacionDepa";
            this.textBoxIdentificacionDepa.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdentificacionDepa.TabIndex = 1;
            // 
            // textBoxGrados
            // 
            this.textBoxGrados.Location = new System.Drawing.Point(183, 129);
            this.textBoxGrados.Name = "textBoxGrados";
            this.textBoxGrados.Size = new System.Drawing.Size(100, 22);
            this.textBoxGrados.TabIndex = 2;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(183, 195);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFecha.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 426);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxGrados);
            this.Controls.Add(this.textBoxIdentificacionDepa);
            this.Controls.Add(this.buttonVisualizarEdificios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVisualizarEdificios;
        private System.Windows.Forms.TextBox textBoxIdentificacionDepa;
        private System.Windows.Forms.TextBox textBoxGrados;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
    }
}

