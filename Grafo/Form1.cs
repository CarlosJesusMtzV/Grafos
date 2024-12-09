namespace Grafo
{
    public partial class Form1 : Form
    {
        private Grafo grafo = new Grafo();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Gestión de Grafos";
            this.ClientSize = new System.Drawing.Size(400, 300);

            // Componentes
            Label lblNodo = new Label() { Text = "Nodo:", Location = new System.Drawing.Point(20, 20) };
            TextBox txtNodo = new TextBox() { Location = new System.Drawing.Point(80, 20), Width = 100 };
            Button btnAgregarNodo = new Button() { Text = "Agregar Nodo", Location = new System.Drawing.Point(200, 20) };

            Label lblOrigen = new Label() { Text = "Origen:", Location = new System.Drawing.Point(20, 60) };
            TextBox txtOrigen = new TextBox() { Location = new System.Drawing.Point(80, 60), Width = 100 };
            Label lblDestino = new Label() { Text = "Destino:", Location = new System.Drawing.Point(20, 100) };
            TextBox txtDestino = new TextBox() { Location = new System.Drawing.Point(80, 100), Width = 100 };
            Button btnConectar = new Button() { Text = "Conectar Nodos", Location = new System.Drawing.Point(200, 80) };

            Button btnMostrarGrafo = new Button() { Text = "Mostrar Grafo", Location = new System.Drawing.Point(20, 140) };
            TextBox txtGrafo = new TextBox() { Location = new System.Drawing.Point(20, 180), Width = 350, Height = 100, Multiline = true, ReadOnly = true };

            // Eventos
            btnAgregarNodo.Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txtNodo.Text))
                {
                    grafo.AgregarNodo(txtNodo.Text);
                    MessageBox.Show($"Nodo {txtNodo.Text} agregado.");
                    txtNodo.Clear();
                }
            };

            btnConectar.Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txtOrigen.Text) && !string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    grafo.ConectarNodos(txtOrigen.Text, txtDestino.Text);
                    MessageBox.Show($"Nodos {txtOrigen.Text} y {txtDestino.Text} conectados.");
                    txtOrigen.Clear();
                    txtDestino.Clear();
                }
            };

            btnMostrarGrafo.Click += (s, e) =>
            {
                txtGrafo.Text = grafo.MostrarGrafo();
            };

            // Agregar componentes al formulario
            this.Controls.Add(lblNodo);
            this.Controls.Add(txtNodo);
            this.Controls.Add(btnAgregarNodo);
            this.Controls.Add(lblOrigen);
            this.Controls.Add(txtOrigen);
            this.Controls.Add(lblDestino);
            this.Controls.Add(txtDestino);
            this.Controls.Add(btnConectar);
            this.Controls.Add(btnMostrarGrafo);
            this.Controls.Add(txtGrafo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
