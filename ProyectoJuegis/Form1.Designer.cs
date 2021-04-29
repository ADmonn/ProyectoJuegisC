
namespace ProyectoJuegis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.textDisponibles = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textTamaño = new System.Windows.Forms.TextBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.ptbJuego = new System.Windows.Forms.PictureBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnJuegoMasVendido = new System.Windows.Forms.Button();
            this.btnBuscarJuego = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJuego)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamaño en KB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disponibles:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoJuegis.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.cmbJuegos);
            this.groupBox1.Controls.Add(this.textDisponibles);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.textTamaño);
            this.groupBox1.Controls.Add(this.textCategoria);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.ptbJuego);
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juegos";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(168, 222);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Location = new System.Drawing.Point(15, 28);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(500, 21);
            this.cmbJuegos.TabIndex = 13;
            this.cmbJuegos.SelectedIndexChanged += new System.EventHandler(this.cmbJuegos_SelectedIndexChanged);
            // 
            // textDisponibles
            // 
            this.textDisponibles.Location = new System.Drawing.Point(132, 170);
            this.textDisponibles.Name = "textDisponibles";
            this.textDisponibles.Size = new System.Drawing.Size(100, 20);
            this.textDisponibles.TabIndex = 12;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(132, 144);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 20);
            this.textPrecio.TabIndex = 11;
            // 
            // textTamaño
            // 
            this.textTamaño.Location = new System.Drawing.Point(132, 118);
            this.textTamaño.Name = "textTamaño";
            this.textTamaño.Size = new System.Drawing.Size(100, 20);
            this.textTamaño.TabIndex = 10;
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(132, 92);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(100, 20);
            this.textCategoria.TabIndex = 9;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(132, 66);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 8;
            // 
            // ptbJuego
            // 
            this.ptbJuego.Location = new System.Drawing.Point(270, 66);
            this.ptbJuego.Name = "ptbJuego";
            this.ptbJuego.Size = new System.Drawing.Size(245, 179);
            this.ptbJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbJuego.TabIndex = 7;
            this.ptbJuego.TabStop = false;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(87, 222);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(6, 222);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnJuegoMasVendido);
            this.groupBox2.Controls.Add(this.btnBuscarJuego);
            this.groupBox2.Location = new System.Drawing.Point(550, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 251);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnJuegoMasVendido
            // 
            this.btnJuegoMasVendido.Location = new System.Drawing.Point(15, 144);
            this.btnJuegoMasVendido.Name = "btnJuegoMasVendido";
            this.btnJuegoMasVendido.Size = new System.Drawing.Size(206, 79);
            this.btnJuegoMasVendido.TabIndex = 1;
            this.btnJuegoMasVendido.Text = "Juego Mas Vendido";
            this.btnJuegoMasVendido.UseVisualStyleBackColor = true;
            this.btnJuegoMasVendido.Click += new System.EventHandler(this.btnJuegoMasVendido_Click);
            // 
            // btnBuscarJuego
            // 
            this.btnBuscarJuego.Location = new System.Drawing.Point(15, 37);
            this.btnBuscarJuego.Name = "btnBuscarJuego";
            this.btnBuscarJuego.Size = new System.Drawing.Size(206, 86);
            this.btnBuscarJuego.TabIndex = 0;
            this.btnBuscarJuego.Text = "Buscar Juego";
            this.btnBuscarJuego.UseVisualStyleBackColor = true;
            this.btnBuscarJuego.Click += new System.EventHandler(this.btnBuscarJuego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJuego)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDisponibles;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textTamaño;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.PictureBox ptbJuego;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnJuegoMasVendido;
        private System.Windows.Forms.Button btnBuscarJuego;
        private System.Windows.Forms.ComboBox cmbJuegos;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

