using BLL;
using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly PartidoBLL _partidoBLL;
        public Form1()
        {
            InitializeComponent();
            _partidoBLL = new PartidoBLL();

        }


        private void CargarDeportes()
        {
            try
            {
               
                var deportes = _partidoBLL.ObtenerDeportes();

               
                if (deportes != null && deportes.Count > 0)
                {
                    
                    cmbDeporte.DataSource = deportes;
                    cmbDeporte.DisplayMember = "Descripcion";  
                    cmbDeporte.ValueMember = "ID";           
                    cmbDeporte.SelectedIndex = 0; 
                }
                else
                {
                    MessageBox.Show("No se encontraron deportes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar deportes: {ex.Message}");
            }
        }

        private void CargarPartidos()
        {
            try
            {
                dataGridView1.DataSource = _partidoBLL.ObtenerPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar partidos: {ex.Message}");
            }
        }

        private Partido CrearPartidoDesdeFormulario()
        {
           
            if (cmbDeporte.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un deporte.");
                return null;  
            }

            var deporteSeleccionado = (Deporte)cmbDeporte.SelectedItem; 

            return new Partido
            {
                Deporte = deporteSeleccionado,  
                EquipoLocal = txtEquipoLocal.Text,
                EquipoVisitante = txtEquipoVisitante.Text,
                FechaPartido = dtpFechaPartido.Value
            };
        }


        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                var partido = CrearPartidoDesdeFormulario();
                _partidoBLL.GuardarPartido(partido);
                MessageBox.Show("Partido guardado exitosamente.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarMarcador_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdModificar.Text, out int idPartido))
                {
                    MessageBox.Show("ID del partido inválido.");
                    return;
                }

                if (!int.TryParse(txtMarcadorLocal.Text, out int marcadorLocal))
                {
                    MessageBox.Show("Marcador local inválido.");
                    return;
                }

                if (!int.TryParse(txtMarcadorVisitante.Text, out int marcadorVisitante))
                {
                    MessageBox.Show("Marcador visitante inválido.");
                    return;
                }

                _partidoBLL.ModificarMarcador(idPartido, marcadorLocal, marcadorVisitante);
                MessageBox.Show("Marcador actualizado correctamente.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el marcador: {ex.Message}");
            }
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEliminar.Text, out int idPartido))
                {
                    MessageBox.Show("ID del partido inválido.");
                    return;
                }

                _partidoBLL.EliminarPartido(idPartido);
                MessageBox.Show("Partido eliminado.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
      
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDeportes();
        }
    }
}

