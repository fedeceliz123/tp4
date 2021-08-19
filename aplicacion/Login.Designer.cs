
namespace aplicacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbClave = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.llRecuperar = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbUsuario.Location = new System.Drawing.Point(80, 159);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(267, 22);
            this.tbUsuario.TabIndex = 2;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.Enter += new System.EventHandler(this.tbUsuario_Enter);
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // tbClave
            // 
            this.tbClave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbClave.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbClave.Location = new System.Drawing.Point(80, 222);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(267, 22);
            this.tbClave.TabIndex = 3;
            this.tbClave.Text = "Contraseña";
            this.tbClave.Enter += new System.EventHandler(this.tbClave_Enter);
            this.tbClave.Leave += new System.EventHandler(this.tbClave_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(30, 209);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(338, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pbClave
            // 
            this.pbClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClave.Image = ((System.Drawing.Image)(resources.GetObject("pbClave.Image")));
            this.pbClave.Location = new System.Drawing.Point(312, 211);
            this.pbClave.Name = "pbClave";
            this.pbClave.Size = new System.Drawing.Size(35, 33);
            this.pbClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClave.TabIndex = 7;
            this.pbClave.TabStop = false;
            this.pbClave.Click += new System.EventHandler(this.pbClave_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(80, 331);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(242, 43);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // llRecuperar
            // 
            this.llRecuperar.AutoSize = true;
            this.llRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llRecuperar.Location = new System.Drawing.Point(105, 291);
            this.llRecuperar.Name = "llRecuperar";
            this.llRecuperar.Size = new System.Drawing.Size(188, 20);
            this.llRecuperar.TabIndex = 0;
            this.llRecuperar.TabStop = true;
            this.llRecuperar.Text = "Recuperar contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(80, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(242, 43);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(394, 473);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.llRecuperar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pbClave);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel llRecuperar;
        private System.Windows.Forms.Button btnCancelar;
    }
}