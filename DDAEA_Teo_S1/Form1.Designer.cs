namespace DDAEA_Teo_S1
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
            this.btnMensaje = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.BackColor = System.Drawing.Color.Red;
            this.btnMensaje.Location = new System.Drawing.Point(531, 151);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(75, 60);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Click Aqui";
            this.btnMensaje.UseVisualStyleBackColor = false;
            this.btnMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(531, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(720, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(531, 230);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(75, 23);
            this.btnSegundo.TabIndex = 3;
            this.btnSegundo.Text = "button1";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSegundo;
    }
}

