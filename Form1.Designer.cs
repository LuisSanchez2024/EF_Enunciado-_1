namespace Enunciado_1
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
            this.components = new System.ComponentModel.Container();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btndesordenar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnordenar = new System.Windows.Forms.Button();
            this.txtarray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(450, 97);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btndesordenar
            // 
            this.btndesordenar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndesordenar.Location = new System.Drawing.Point(138, 333);
            this.btndesordenar.Name = "btndesordenar";
            this.btndesordenar.Size = new System.Drawing.Size(162, 35);
            this.btndesordenar.TabIndex = 3;
            this.btndesordenar.Text = "Mostrar Desordenado";
            this.btndesordenar.UseVisualStyleBackColor = true;
            this.btndesordenar.Click += new System.EventHandler(this.btndesordenar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(579, 97);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 134);
            this.listBox1.TabIndex = 5;
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(423, 333);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(179, 35);
            this.btnordenar.TabIndex = 6;
            this.btnordenar.Text = "Ordenar Ascendente";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // txtarray
            // 
            this.txtarray.Location = new System.Drawing.Point(208, 102);
            this.txtarray.Name = "txtarray";
            this.txtarray.Size = new System.Drawing.Size(185, 20);
            this.txtarray.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresar Array :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarray);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btndesordenar);
            this.Controls.Add(this.btnregistrar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btndesordenar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.TextBox txtarray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

