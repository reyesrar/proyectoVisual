namespace Visual
{
    partial class Materia
    {
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblHorario;
        private TextBox txtNombre;
        private TextBox txtHorario;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblHorario = new Label();
            txtNombre = new TextBox();
            txtHorario = new TextBox();

            // Título
            lblTitulo.Text = "📘 Materia";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Campo Nombre
            lblNombre.Text = "Nombre de la materia:";
            lblNombre.Location = new Point(30, 80);
            lblNombre.Size = new Size(200, 30);
            lblNombre.Font = new Font("Segoe UI", 12F);

            txtNombre.Location = new Point(30, 110);
            txtNombre.Size = new Size(300, 30);

            // Campo Horario
            lblHorario.Text = "Horario:";
            lblHorario.Location = new Point(30, 160);
            lblHorario.Size = new Size(200, 30);
            lblHorario.Font = new Font("Segoe UI", 12F);

            txtHorario.Location = new Point(30, 190);
            txtHorario.Size = new Size(300, 30);

            // UserControl
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblHorario);
            Controls.Add(txtHorario);
            BackColor = Color.White;
            Size = new Size(400, 260);
        }
    }
}
