namespace Ejercicio10
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnJugadorVsCPU = new System.Windows.Forms.Button();
            this.btnJugadorVsJugador = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineMenu = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.panelCasillas = new System.Windows.Forms.Panel();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.picBox9 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblPuntos1 = new System.Windows.Forms.Label();
            this.lblPuntos2 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgList2 = new System.Windows.Forms.ImageList(this.components);
            this.grpBoxTurno = new System.Windows.Forms.GroupBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnPartidaNueva = new System.Windows.Forms.Button();
            this.lblCabecera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.panelCasillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.grpBoxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJugadorVsCPU
            // 
            this.btnJugadorVsCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJugadorVsCPU.BackColor = System.Drawing.Color.Azure;
            this.btnJugadorVsCPU.Enabled = false;
            this.btnJugadorVsCPU.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnJugadorVsCPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnJugadorVsCPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnJugadorVsCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadorVsCPU.Location = new System.Drawing.Point(403, 313);
            this.btnJugadorVsCPU.Name = "btnJugadorVsCPU";
            this.btnJugadorVsCPU.Size = new System.Drawing.Size(105, 23);
            this.btnJugadorVsCPU.TabIndex = 0;
            this.btnJugadorVsCPU.Text = "Jugador - CPU";
            this.btnJugadorVsCPU.UseVisualStyleBackColor = false;
            // 
            // btnJugadorVsJugador
            // 
            this.btnJugadorVsJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJugadorVsJugador.BackColor = System.Drawing.Color.Azure;
            this.btnJugadorVsJugador.Enabled = false;
            this.btnJugadorVsJugador.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnJugadorVsJugador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnJugadorVsJugador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnJugadorVsJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadorVsJugador.Location = new System.Drawing.Point(403, 359);
            this.btnJugadorVsJugador.Name = "btnJugadorVsJugador";
            this.btnJugadorVsJugador.Size = new System.Drawing.Size(105, 23);
            this.btnJugadorVsJugador.TabIndex = 1;
            this.btnJugadorVsJugador.Text = "Jugador - Jugador";
            this.btnJugadorVsJugador.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineMenu});
            this.shapeContainer1.Size = new System.Drawing.Size(520, 471);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineMenu
            // 
            this.lineMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineMenu.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lineMenu.Enabled = false;
            this.lineMenu.Name = "lineMenu";
            this.lineMenu.X1 = 364;
            this.lineMenu.X2 = 364;
            this.lineMenu.Y1 = 106;
            this.lineMenu.Y2 = 413;
            // 
            // picBox1
            // 
            this.picBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Enabled = false;
            this.picBox1.Location = new System.Drawing.Point(10, 14);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(70, 70);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // panelCasillas
            // 
            this.panelCasillas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCasillas.BackColor = System.Drawing.SystemColors.Info;
            this.panelCasillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCasillas.Controls.Add(this.picBox7);
            this.panelCasillas.Controls.Add(this.picBox8);
            this.panelCasillas.Controls.Add(this.picBox9);
            this.panelCasillas.Controls.Add(this.picBox4);
            this.panelCasillas.Controls.Add(this.picBox6);
            this.panelCasillas.Controls.Add(this.picBox5);
            this.panelCasillas.Controls.Add(this.picBox2);
            this.panelCasillas.Controls.Add(this.picBox3);
            this.panelCasillas.Controls.Add(this.picBox1);
            this.panelCasillas.Location = new System.Drawing.Point(33, 106);
            this.panelCasillas.Name = "panelCasillas";
            this.panelCasillas.Size = new System.Drawing.Size(306, 289);
            this.panelCasillas.TabIndex = 4;
            // 
            // picBox7
            // 
            this.picBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox7.Enabled = false;
            this.picBox7.Location = new System.Drawing.Point(10, 206);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(70, 70);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox7.TabIndex = 11;
            this.picBox7.TabStop = false;
            this.picBox7.Click += new System.EventHandler(this.picBox7_Click);
            // 
            // picBox8
            // 
            this.picBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox8.Enabled = false;
            this.picBox8.Location = new System.Drawing.Point(115, 206);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(70, 70);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox8.TabIndex = 10;
            this.picBox8.TabStop = false;
            this.picBox8.Click += new System.EventHandler(this.picBox8_Click);
            // 
            // picBox9
            // 
            this.picBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox9.Enabled = false;
            this.picBox9.Location = new System.Drawing.Point(223, 206);
            this.picBox9.Name = "picBox9";
            this.picBox9.Size = new System.Drawing.Size(70, 70);
            this.picBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox9.TabIndex = 9;
            this.picBox9.TabStop = false;
            this.picBox9.Click += new System.EventHandler(this.picBox9_Click);
            // 
            // picBox4
            // 
            this.picBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox4.Enabled = false;
            this.picBox4.Location = new System.Drawing.Point(10, 109);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(70, 70);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox4.TabIndex = 8;
            this.picBox4.TabStop = false;
            this.picBox4.Click += new System.EventHandler(this.picBox4_Click);
            // 
            // picBox6
            // 
            this.picBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox6.Enabled = false;
            this.picBox6.Location = new System.Drawing.Point(223, 109);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(70, 70);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox6.TabIndex = 7;
            this.picBox6.TabStop = false;
            this.picBox6.Click += new System.EventHandler(this.picBox6_Click);
            // 
            // picBox5
            // 
            this.picBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox5.Enabled = false;
            this.picBox5.Location = new System.Drawing.Point(115, 109);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(70, 70);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox5.TabIndex = 6;
            this.picBox5.TabStop = false;
            this.picBox5.Click += new System.EventHandler(this.picBox5_Click);
            // 
            // picBox2
            // 
            this.picBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox2.Enabled = false;
            this.picBox2.Location = new System.Drawing.Point(115, 14);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(70, 70);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 5;
            this.picBox2.TabStop = false;
            this.picBox2.Click += new System.EventHandler(this.picBox2_Click);
            // 
            // picBox3
            // 
            this.picBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox3.Enabled = false;
            this.picBox3.Location = new System.Drawing.Point(223, 14);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(70, 70);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 4;
            this.picBox3.TabStop = false;
            this.picBox3.Click += new System.EventHandler(this.picBox3_Click);
            // 
            // lblJugador1
            // 
            this.lblJugador1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1.Location = new System.Drawing.Point(30, 55);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(77, 18);
            this.lblJugador1.TabIndex = 5;
            this.lblJugador1.Text = "Jugador 1   -";
            // 
            // lblPuntos1
            // 
            this.lblPuntos1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntos1.AutoSize = true;
            this.lblPuntos1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos1.Location = new System.Drawing.Point(110, 55);
            this.lblPuntos1.Name = "lblPuntos1";
            this.lblPuntos1.Size = new System.Drawing.Size(15, 18);
            this.lblPuntos1.TabIndex = 6;
            this.lblPuntos1.Text = "0";
            // 
            // lblPuntos2
            // 
            this.lblPuntos2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntos2.AutoSize = true;
            this.lblPuntos2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos2.Location = new System.Drawing.Point(233, 55);
            this.lblPuntos2.Name = "lblPuntos2";
            this.lblPuntos2.Size = new System.Drawing.Size(15, 18);
            this.lblPuntos2.TabIndex = 8;
            this.lblPuntos2.Text = "0";
            // 
            // lblJugador2
            // 
            this.lblJugador2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2.Location = new System.Drawing.Point(153, 55);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(77, 18);
            this.lblJugador2.TabIndex = 7;
            this.lblJugador2.Text = "Jugador 2   -";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "EquisNegra.png");
            // 
            // imgList2
            // 
            this.imgList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList2.ImageStream")));
            this.imgList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList2.Images.SetKeyName(0, "circulo.png");
            // 
            // grpBoxTurno
            // 
            this.grpBoxTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxTurno.BackColor = System.Drawing.SystemColors.Menu;
            this.grpBoxTurno.Controls.Add(this.lblTurno);
            this.grpBoxTurno.Location = new System.Drawing.Point(377, 121);
            this.grpBoxTurno.Name = "grpBoxTurno";
            this.grpBoxTurno.Size = new System.Drawing.Size(131, 100);
            this.grpBoxTurno.TabIndex = 9;
            this.grpBoxTurno.TabStop = false;
            this.grpBoxTurno.Text = "Turno";
            // 
            // lblTurno
            // 
            this.lblTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(29, 45);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(83, 18);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Jugador 1";
            // 
            // btnPartidaNueva
            // 
            this.btnPartidaNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPartidaNueva.BackColor = System.Drawing.Color.Azure;
            this.btnPartidaNueva.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPartidaNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnPartidaNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnPartidaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidaNueva.Location = new System.Drawing.Point(403, 265);
            this.btnPartidaNueva.Name = "btnPartidaNueva";
            this.btnPartidaNueva.Size = new System.Drawing.Size(105, 23);
            this.btnPartidaNueva.TabIndex = 10;
            this.btnPartidaNueva.Text = "Nueva Partida";
            this.btnPartidaNueva.UseVisualStyleBackColor = false;
            this.btnPartidaNueva.Click += new System.EventHandler(this.btnPartidaNueva_Click);
            // 
            // lblCabecera
            // 
            this.lblCabecera.BackColor = System.Drawing.SystemColors.Info;
            this.lblCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCabecera.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(0, 0);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(520, 22);
            this.lblCabecera.TabIndex = 11;
            this.lblCabecera.Text = "TRES EN RAYA";
            this.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 471);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.btnPartidaNueva);
            this.Controls.Add(this.grpBoxTurno);
            this.Controls.Add(this.lblPuntos2);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblPuntos1);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.panelCasillas);
            this.Controls.Add(this.btnJugadorVsJugador);
            this.Controls.Add(this.btnJugadorVsCPU);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmPrincipal";
            this.Text = "Ejercicio 10";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.panelCasillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.grpBoxTurno.ResumeLayout(false);
            this.grpBoxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugadorVsCPU;
        private System.Windows.Forms.Button btnJugadorVsJugador;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineMenu;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Panel panelCasillas;
        private System.Windows.Forms.PictureBox picBox7;
        private System.Windows.Forms.PictureBox picBox8;
        private System.Windows.Forms.PictureBox picBox9;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox6;
        private System.Windows.Forms.PictureBox picBox5;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblPuntos1;
        private System.Windows.Forms.Label lblPuntos2;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.GroupBox grpBoxTurno;
        private System.Windows.Forms.Label lblTurno;
        public System.Windows.Forms.ImageList imgList2;
        public System.Windows.Forms.ImageList imgList1;
        private System.Windows.Forms.Button btnPartidaNueva;
        private System.Windows.Forms.Label lblCabecera;
    }
}

