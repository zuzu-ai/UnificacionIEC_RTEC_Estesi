
namespace CapaVistaGestorInventarios
{
	partial class frmUbicacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbicacion));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnActivo = new System.Windows.Forms.RadioButton();
			this.rbnInactivo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtIdBodega = new System.Windows.Forms.TextBox();
			this.cbxBodega = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(589, 102);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 174;
			this.txtEstado.Tag = "Estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(78, 98);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(200, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.Tag = "Nombre";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(78, 68);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(200, 20);
			this.txtID.TabIndex = 1;
			this.txtID.Tag = "ID_Ubicacion";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnActivo);
			this.panel1.Controls.Add(this.rbnInactivo);
			this.panel1.Location = new System.Drawing.Point(383, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 175;
			// 
			// rbnActivo
			// 
			this.rbnActivo.AutoSize = true;
			this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnActivo.Location = new System.Drawing.Point(16, 7);
			this.rbnActivo.Name = "rbnActivo";
			this.rbnActivo.Size = new System.Drawing.Size(64, 21);
			this.rbnActivo.TabIndex = 4;
			this.rbnActivo.TabStop = true;
			this.rbnActivo.Text = "Activo";
			this.rbnActivo.UseVisualStyleBackColor = true;
			this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
			// 
			// rbnInactivo
			// 
			this.rbnInactivo.AutoSize = true;
			this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnInactivo.Location = new System.Drawing.Point(123, 7);
			this.rbnInactivo.Name = "rbnInactivo";
			this.rbnInactivo.Size = new System.Drawing.Size(74, 21);
			this.rbnInactivo.TabIndex = 5;
			this.rbnInactivo.TabStop = true;
			this.rbnInactivo.Text = "Inactivo";
			this.rbnInactivo.UseVisualStyleBackColor = true;
			this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblEstatus.Location = new System.Drawing.Point(321, 103);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(56, 17);
			this.lblEstatus.TabIndex = 173;
			this.lblEstatus.Text = "Estado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(16, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 168;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(16, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 169;
			this.label1.Text = "ID:";
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(245, 0);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 177;
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(0, 1);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
			this.navegadorMantenimientos1.TabIndex = 170;
			this.navegadorMantenimientos1.TabStop = false;
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 130);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(632, 228);
			this.dgvVistaPrevia.TabIndex = 176;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// txtIdBodega
			// 
			this.txtIdBodega.Location = new System.Drawing.Point(589, 68);
			this.txtIdBodega.Name = "txtIdBodega";
			this.txtIdBodega.Size = new System.Drawing.Size(39, 20);
			this.txtIdBodega.TabIndex = 180;
			this.txtIdBodega.TabStop = false;
			this.txtIdBodega.Tag = "Fk_Bodega";
			this.txtIdBodega.Visible = false;
			this.txtIdBodega.TextChanged += new System.EventHandler(this.txtIdBodega_TextChanged);
			// 
			// cbxBodega
			// 
			this.cbxBodega.FormattingEnabled = true;
			this.cbxBodega.Location = new System.Drawing.Point(383, 67);
			this.cbxBodega.Name = "cbxBodega";
			this.cbxBodega.Size = new System.Drawing.Size(200, 21);
			this.cbxBodega.TabIndex = 3;
			this.cbxBodega.SelectedIndexChanged += new System.EventHandler(this.cbxBodega_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(321, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 179;
			this.label4.Text = "Bodega:";
			// 
			// frmUbicacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 370);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtIdBodega);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbxBodega);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmUbicacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ubicación";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImprimir;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtIdBodega;
		private System.Windows.Forms.ComboBox cbxBodega;
		private System.Windows.Forms.Label label4;
	}
}