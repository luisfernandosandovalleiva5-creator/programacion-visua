using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestordeTareas
{
    public partial class cmbEstado : Form
    {
        List<Tarea> listaTareas = new List<Tarea>();
        public cmbEstado()
        {
            InitializeComponent();
        }

        private void btnBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmb_Estado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmb_Estado.SelectedIndex = 0; // Opcional: selecciona el primer estado
            dtpFecha.Value = DateTime.Now; // Opcional: volver a la fecha actual
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmb_Estado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmb_Estado.SelectedIndex = 0; // Opcional: selecciona el primer estado
            dtpFecha.Value = DateTime.Now; // Opcional: volver a la fecha actual
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmb_Estado.SelectedIndex = 0; // Opcional: selecciona el primer estado
            dtpFecha.Value = DateTime.Now; // Opcional: volver a la fecha actual
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_Estado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTareas.AllowUserToAddRows = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtCodigo.Text.Trim();
            string estadoBuscar = cmb_Estado.SelectedItem?.ToString();
            DateTime fechaBuscar = dtpFecha.Value.Date;

            // Iniciar filtrado con toda la lista
            var resultados = listaTareas.AsEnumerable();

            // Filtrar por código si se ingresó algo
            if (!string.IsNullOrEmpty(codigoBuscar))
                resultados = resultados.Where(t => t.Codigo.Contains(codigoBuscar));

            // Filtrar por estado si se seleccionó un valor distinto al primer índice
            if (!string.IsNullOrEmpty(estadoBuscar) && cmb_Estado.SelectedIndex > 0)
                resultados = resultados.Where(t => t.Estado == estadoBuscar);

            // Filtrar por fecha si deseas (opcional)
            bool filtrarFecha = false; // Cambia a true si quieres usar el filtro de fecha
            if (filtrarFecha)
                resultados = resultados.Where(t => t.Fecha.Date == fechaBuscar);

            // Convertir a lista
            var listaResultados = resultados.ToList();

            // Verificar si hay resultados
            if (listaResultados.Count > 0)
            {
                dgvTareas.DataSource = listaResultados;
                dgvTareas.ClearSelection();
                dgvTareas.Rows[0].Selected = true;
                MessageBox.Show("Tarea(s) encontrada(s).", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvTareas.DataSource = null;
                dgvTareas.ClearSelection();
                MessageBox.Show("No existe ninguna tarea con los criterios ingresados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            // Mostrar todas las tareas
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;

            // Limpiar selección
            dgvTareas.ClearSelection();

            // Limpiar los TextBox y ComboBox existentes
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmb_Estado.SelectedIndex = 0; // Selecciona el primer estado
            dtpFecha.Value = DateTime.Now;

            // Mensaje opcional
            MessageBox.Show("Se muestran todas las tareas.", "Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


        public class Tarea
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Lugar { get; set; }
            public string Estado { get; set; }
        }
    }


