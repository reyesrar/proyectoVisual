namespace Visual
{
    partial class Reportes
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnReportes;
        private Button btnPlanillaNotas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnReportes = new Button();
            btnPlanillaNotas = new Button();

            // Estilo del botón “Reportes”
            btnReportes.Text = "Reportes";
            btnReportes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReportes.Size = new Size(240, 60);
            btnReportes.Location = new Point(30, 30);
            btnReportes.BackColor = Color.LightGray;

            // Estilo del botón “Planilla de notas”
            btnPlanillaNotas.Text = "📗 Planilla de notas";
            btnPlanillaNotas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPlanillaNotas.Size = new Size(240, 60);
            btnPlanillaNotas.Location = new Point(30, 110);
            btnPlanillaNotas.BackColor = Color.LightGreen;

            // UserControl
            Controls.Add(btnReportes);
            Controls.Add(btnPlanillaNotas);
            BackColor = Color.White;
            Size = new Size(300, 200);
        }
    }
}
