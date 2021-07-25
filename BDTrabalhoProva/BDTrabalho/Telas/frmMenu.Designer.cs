namespace BDTrabalho
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.PictureBox();
            this.lblAtribuirMulta = new System.Windows.Forms.Label();
            this.lblMarcarChegada = new System.Windows.Forms.Label();
            this.lblNovaSaida = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::BDTrabalho.Properties.Resources.menu6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.lblAtribuirMulta);
            this.panel1.Controls.Add(this.lblMarcarChegada);
            this.panel1.Controls.Add(this.lblNovaSaida);
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 384);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BDTrabalho.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(499, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = global::BDTrabalho.Properties.Resources.trash;
            this.btnDeletar.Location = new System.Drawing.Point(48, 295);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(56, 51);
            this.btnDeletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Image = global::BDTrabalho.Properties.Resources.search2;
            this.btnConsultar.Location = new System.Drawing.Point(132, 92);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(56, 51);
            this.btnConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblAtribuirMulta
            // 
            this.lblAtribuirMulta.AutoSize = true;
            this.lblAtribuirMulta.BackColor = System.Drawing.Color.Transparent;
            this.lblAtribuirMulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtribuirMulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtribuirMulta.ForeColor = System.Drawing.Color.White;
            this.lblAtribuirMulta.Location = new System.Drawing.Point(681, 194);
            this.lblAtribuirMulta.Name = "lblAtribuirMulta";
            this.lblAtribuirMulta.Size = new System.Drawing.Size(63, 38);
            this.lblAtribuirMulta.TabIndex = 4;
            this.lblAtribuirMulta.Text = "Atribuir\r\nMulta";
            this.lblAtribuirMulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtribuirMulta.Click += new System.EventHandler(this.lblAtribuirMulta_Click);
            // 
            // lblMarcarChegada
            // 
            this.lblMarcarChegada.AutoSize = true;
            this.lblMarcarChegada.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcarChegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMarcarChegada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcarChegada.ForeColor = System.Drawing.Color.White;
            this.lblMarcarChegada.Location = new System.Drawing.Point(233, 145);
            this.lblMarcarChegada.Name = "lblMarcarChegada";
            this.lblMarcarChegada.Size = new System.Drawing.Size(67, 38);
            this.lblMarcarChegada.TabIndex = 3;
            this.lblMarcarChegada.Text = "Marcar\r\nChegada";
            this.lblMarcarChegada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMarcarChegada.Click += new System.EventHandler(this.lblMarcarChegada_Click);
            // 
            // lblNovaSaida
            // 
            this.lblNovaSaida.AutoSize = true;
            this.lblNovaSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovaSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSaida.ForeColor = System.Drawing.Color.White;
            this.lblNovaSaida.Location = new System.Drawing.Point(63, 73);
            this.lblNovaSaida.Name = "lblNovaSaida";
            this.lblNovaSaida.Size = new System.Drawing.Size(46, 38);
            this.lblNovaSaida.TabIndex = 2;
            this.lblNovaSaida.Text = "Nova\r\nSaída";
            this.lblNovaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNovaSaida.Click += new System.EventHandler(this.lblNovaSaida_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Font = new System.Drawing.Font("Dolphins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.LightGray;
            this.lblFechar.Location = new System.Drawing.Point(773, 351);
            this.lblFechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(28, 32);
            this.lblFechar.TabIndex = 1;
            this.lblFechar.Text = "x";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(812, 394);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Family\'s Rid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAtribuirMulta;
        private System.Windows.Forms.Label lblMarcarChegada;
        private System.Windows.Forms.Label lblNovaSaida;
        private System.Windows.Forms.PictureBox btnConsultar;
        private System.Windows.Forms.PictureBox btnDeletar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

