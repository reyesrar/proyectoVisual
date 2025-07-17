using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
            // Reportes ? abre Planilla de notas desde evento
            btnReportes.Click += (s, e) =>
            {
                var pantallaReportes = new Reportes();
                pantallaReportes.MostrarPlanillaNotas += (sender, args) =>
                {
                    CargarPantalla(new Planilladenotas(), "Planilla de notas abierta desde módulo Reportes");
                };
                CargarPantalla(pantallaReportes, "Módulo de Reportes cargado");
            };

            // Mantenimiento ? abre submódulos
            btnMantenimiento.Click += (s, e) =>
            {
                var pantallaMantenimiento = new Mantenimiento();

                pantallaMantenimiento.MostrarMateria += (sender, args) =>
                {
                    CargarPantalla(new Materia(), "Ficha de Materia abierta");
                };
                pantallaMantenimiento.MostrarSeccion += (sender, args) =>
                {
                    CargarPantalla(new Seccion(), "Ficha de Sección abierta");
                };
                pantallaMantenimiento.MostrarPersona += (sender, args) =>
                {
                    CargarPantalla(new Persona(), "Ficha de Persona abierta");
                };
                pantallaMantenimiento.MostrarCurso += (sender, args) =>
                {
                    CargarPantalla(new Curso(), "Ficha de Curso abierta");
                };

                CargarPantalla(pantallaMantenimiento, "Módulo de Mantenimiento cargado");
            };

            
            btnInscripcion.Click += (s, e) =>
            {
                CargarPantalla(new Inscripcion(), "Módulo de Inscripción cargado");
            };


            // Notas ? abre control visual
            btnNotas.Click += (s, e) =>
            {
                CargarPantalla(new Notas(), "Módulo de Notas cargado");
            };
        }

        private void CargarPantalla(UserControl pantalla, string mensaje)
        {
            panelContent.Controls.Clear();
            pantalla.Dock = DockStyle.Fill;
            panelContent.Controls.Add(pantalla);
            tsslStatus.Text = mensaje;
        }
    }
}
