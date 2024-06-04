namespace MiPrimerAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttPres = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttPres
            // 
            this.bttPres.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttPres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttPres.Image = ((System.Drawing.Image)(resources.GetObject("bttPres.Image")));
            this.bttPres.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttPres.Location = new System.Drawing.Point(72, 65);
            this.bttPres.Name = "bttPres";
            this.bttPres.Size = new System.Drawing.Size(250, 92);
            this.bttPres.TabIndex = 0;
            this.bttPres.Text = "Presiona aca!";
            this.bttPres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttPres.UseVisualStyleBackColor = false;
            this.bttPres.Click += new System.EventHandler(this.bttPres_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(459, 122);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Aqui va el Titulo.";
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // tbx1
            // 
            this.tbx1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx1.Location = new System.Drawing.Point(439, 230);
            this.tbx1.MaxLength = 6;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 2;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            this.tbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(109, 230);
            this.tbx2.Multiline = true;
            this.tbx2.Name = "tbx2";
            this.tbx2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 3;
            this.tbx2.Leave += new System.EventHandler(this.tbx2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.bttPres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPres;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
    }
}

