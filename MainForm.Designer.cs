using System.Drawing;
using System.Windows.Forms;

namespace Visual
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStrip toolStripMain;
        private Panel panelContent;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel tsslStatus;

        private ToolStripButton btnReportes;
        private ToolStripDropDownButton btnMantenimiento;
        private ToolStripButton btnInscripcion;
        private ToolStripButton btnNotas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // MenuStrip
            menuStripMain = new MenuStrip();
            var reportesItem = new ToolStripMenuItem("Reportes");
            var mantenimientoItem = new ToolStripMenuItem("Mantenimiento");
            mantenimientoItem.DropDownItems.Add("Materia");
            mantenimientoItem.DropDownItems.Add("Sección");
            mantenimientoItem.DropDownItems.Add("Persona");
            mantenimientoItem.DropDownItems.Add("Curso");
            var inscripcionItem = new ToolStripMenuItem("Inscripción");
            var notasItem = new ToolStripMenuItem("Notas");

            menuStripMain.Items.AddRange(new ToolStripItem[]
            {
                reportesItem,
                mantenimientoItem,
                inscripcionItem,
                notasItem
            });
            menuStripMain.Dock = DockStyle.Top;

            // ToolStrip
            toolStripMain = new ToolStrip
            {
                ImageScalingSize = new Size(48, 48),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Top
            };

            btnReportes = new ToolStripButton("Reportes")
            {
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            btnMantenimiento = new ToolStripDropDownButton("Mantenimiento")
            {
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            btnMantenimiento.DropDownItems.Add("Materia");
            btnMantenimiento.DropDownItems.Add("Sección");
            btnMantenimiento.DropDownItems.Add("Persona");
            btnMantenimiento.DropDownItems.Add("Curso");

            btnInscripcion = new ToolStripButton("Inscripción")
            {
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            btnNotas = new ToolStripButton("Notas")
            {
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            toolStripMain.Items.AddRange(new ToolStripItem[]
            {
                btnReportes,
                btnMantenimiento,
                btnInscripcion,
                btnNotas
            });

            // Panel de contenido dinámico
            panelContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            // Barra de estado
            statusStripMain = new StatusStrip();
            tsslStatus = new ToolStripStatusLabel("Listo");
            statusStripMain.Items.Add(tsslStatus);
            statusStripMain.Dock = DockStyle.Bottom;

            // Formulario principal
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";

            Controls.Add(panelContent);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
        }
    }
}
