namespace Visnje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Visnja[] Visnje = new Visnja[25];
        Random r = new Random();
        public int n = 20;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                Visnje[i] = new Visnja(25, r.Next(ClientRectangle.Width - 50), r.Next(ClientRectangle.Height - 50));
            }

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                Visnje[i].Crtaj(e.Graphics);

            }
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                if (Visnje[i].container(new Point(e.X, e.Y)))
                {
                    Visnje[i].del();
                    Refresh();
                    Visnje[i] = Visnje[n - 1];
                    n--;
                    i--;
                }

            }
        }
    }
}