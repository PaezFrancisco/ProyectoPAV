﻿
namespace Trabajo_Practico_PAV_I.GUI
{
    partial class frmNuevoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoFormulario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPerfiles = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.cmbNombreForm = new System.Windows.Forms.ComboBox();
            this.btnPermitirAcceso = new System.Windows.Forms.Button();
            this.btnRemoverAcceso = new System.Windows.Forms.Button();
            this.grdPermisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Nombre del Formulario:";
            // 
            // lblPerfiles
            // 
            this.lblPerfiles.AutoSize = true;
            this.lblPerfiles.Location = new System.Drawing.Point(102, 81);
            this.lblPerfiles.Name = "lblPerfiles";
            this.lblPerfiles.Size = new System.Drawing.Size(33, 13);
            this.lblPerfiles.TabIndex = 31;
            this.lblPerfiles.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(141, 78);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(94, 21);
            this.cmbPerfil.TabIndex = 30;
            // 
            // cmbNombreForm
            // 
            this.cmbNombreForm.FormattingEnabled = true;
            this.cmbNombreForm.Location = new System.Drawing.Point(141, 39);
            this.cmbNombreForm.Name = "cmbNombreForm";
            this.cmbNombreForm.Size = new System.Drawing.Size(94, 21);
            this.cmbNombreForm.TabIndex = 32;
            // 
            // btnPermitirAcceso
            // 
            this.btnPermitirAcceso.Location = new System.Drawing.Point(339, 37);
            this.btnPermitirAcceso.Name = "btnPermitirAcceso";
            this.btnPermitirAcceso.Size = new System.Drawing.Size(113, 23);
            this.btnPermitirAcceso.TabIndex = 33;
            this.btnPermitirAcceso.Text = "Permitir Acceso";
            this.btnPermitirAcceso.UseVisualStyleBackColor = true;
            this.btnPermitirAcceso.Click += new System.EventHandler(this.btnPermitirAcceso_Click);
            // 
            // btnRemoverAcceso
            // 
            this.btnRemoverAcceso.Location = new System.Drawing.Point(339, 76);
            this.btnRemoverAcceso.Name = "btnRemoverAcceso";
            this.btnRemoverAcceso.Size = new System.Drawing.Size(113, 23);
            this.btnRemoverAcceso.TabIndex = 34;
            this.btnRemoverAcceso.Text = "Remover Acceso";
            this.btnRemoverAcceso.UseVisualStyleBackColor = true;
            this.btnRemoverAcceso.Click += new System.EventHandler(this.btnRemoverAcceso_Click);
            // 
            // grdPermisos
            // 
            this.grdPermisos.AllowUserToAddRows = false;
            this.grdPermisos.AllowUserToOrderColumns = true;
            this.grdPermisos.AllowUserToResizeRows = false;
            this.grdPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPermisos.Location = new System.Drawing.Point(141, 128);
            this.grdPermisos.Name = "grdPermisos";
            this.grdPermisos.ReadOnly = true;
            this.grdPermisos.Size = new System.Drawing.Size(311, 192);
            this.grdPermisos.TabIndex = 35;
            // 
            // frmNuevoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 332);
            this.Controls.Add(this.grdPermisos);
            this.Controls.Add(this.btnRemoverAcceso);
            this.Controls.Add(this.btnPermitirAcceso);
            this.Controls.Add(this.cmbNombreForm);
            this.Controls.Add(this.lblPerfiles);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNuevoFormulario";
            this.Text = "Formularios";
            this.Load += new System.EventHandler(this.frmNuevoFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPerfiles;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ComboBox cmbNombreForm;
        private System.Windows.Forms.Button btnPermitirAcceso;
        private System.Windows.Forms.Button btnRemoverAcceso;
        private System.Windows.Forms.DataGridView grdPermisos;
    }
}