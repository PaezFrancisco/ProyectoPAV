﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico_PAV_I.Entidades;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmNuevoPerfil : Form
    {
        public frmNuevoPerfil()
        {
            InitializeComponent();
            CargarGrilla();
            btnActualizarBug.Enabled = false;
        }

        private void CargarGrilla()
        {
            
            try
            { 
                string consulta = "select nombre as 'Nombre' from Perfiles";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdPerfiles.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                btnActualizarBug.Enabled = true;
                int indice = e.RowIndex;
                if (indice == -1)
                {
                    return;
                }
                DataGridViewRow filaSeleccionada = grdPerfiles.Rows[indice];
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                {
                    parametros.Add("Nombre", nombre);
                }
                string consulta = "SELECT * FROM Perfiles WHERE nombre LIKE @nombre";
                DataTable tabla = new DataTable();
                tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                /*Bug b = new Bug();
                b.Titulo1 = tabla.Rows[0]["titulo"].ToString();
                b.Descripcion1 = tabla.Rows[0]["descripcion"].ToString();
                DateTime fecha = DateTime.Parse(tabla.Rows[0]["fecha_alta"].ToString());
                string fechaSalida = fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES"));
                b.FechaAlta1 = DateTime.Parse(fechaSalida);

                b.IdUsuarioResponsable1 = (int)tabla.Rows[0]["id_usuario_responsable"];
                b.IdUsuarioAsignado1 = (int)tabla.Rows[0]["id_usuario_asignado"];
                b.IdProducto1 = (int)tabla.Rows[0]["id_producto"];
                b.IdPrioridad1 = (int)tabla.Rows[0]["id_prioridad"];
                b.IdCriticiadad1 = (int)tabla.Rows[0]["id_criticidad"];
                b.IdEstado1 = (int)tabla.Rows[0]["id_estado"];
                b.Borrado1 = 0;

                txtNombre.Text = b.Titulo1;*/

                Perfil p = new Perfil();
                p.NombrePerfil = tabla.Rows[0]["nombre"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
            }
            
        }
        private void btnAgregarBug_Click(object sender, EventArgs e)
        {
            Perfil nuevoPerfil = new Perfil();
            nuevoPerfil.NombrePerfil = txtNombre.Text;
            nuevoPerfil.Borrado = 0;
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var idEstado = txtNombre.ToString();
                parametros.Add("nombre", txtNombre.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un titulo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            parametros.Add("borrado", 0);
            try
            {
                string consultaSql = "INSERT INTO Perfiles (nombre,borrado) VALUES (@nombre,@borrado)";
                int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                if(resultado == 0)
                {
                    MessageBox.Show("Error al cargar el Perfil.");
                }
                else
                {
                    MessageBox.Show("Carga exitosa del Perfil.");
                    CargarGrilla();
                    btnActualizarBug.Enabled = false;
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                
            }
            
        }

        private void btnActualizarBug_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var idEstado = txtNombre.ToString();
                parametros.Add("nombre", txtNombre.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un titulo valido","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            int indice = grdPerfiles.CurrentCell.RowIndex;
            DataGridViewRow filaSeleccionada = grdPerfiles.Rows[indice];
            string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
            
            string consultaId = "select id_perfil from Perfiles where nombre  = '"+nombre +"'";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
            int id = (int)rtdo.Rows[0]["id_perfil"];
            parametros.Add("id", id);
            string consultaSql = "UPDATE Perfiles SET nombre = @nombre  WHERE  id_perfil = @id";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
            if (resultado == 0)
            {
                    MessageBox.Show("Error al actualizar el Perfil.");
            }
            else
            {
                MessageBox.Show("Actualizacion exitosa del Perfil.");
                btnActualizarBug.Enabled = false;
                CargarGrilla();
            }
            
            
        }
        private void btnConsultarPerfil_Click(object sender, EventArgs e)
        {
            string  consulta = "SELECT nombre AS Nombre FROM Perfiles WHERE nombre LIKE '%"+ txtNombre.Text +"%'";
            /*Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("Nombre",txtNombre.Text);*/
            grdPerfiles.DataSource = DataManager.GetInstance().ConsultaSQL(consulta);
            btnActualizarBug.Enabled = false;
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}