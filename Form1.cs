namespace Battaglia_navale
{
    public partial class Form1 : Form
    {
        bool partitaTerminata = false;
        bool[,] campo1 = new bool[10, 10];
        bool[,] campo2 = new bool[10, 10];

        public Form1()
        {

            

            InitializeComponent();


            while (!partitaTerminata)
            {


            }

            

        }

        void PosizionaBarche(bool[,] campo)
        {

            for (int i = 0; i < campo.GetLength(0); i++)
            {
                for (int j = 0; j < campo.GetLength(1); j++)
                    campo[i, j] = false;
            }

            Random random = new Random();
            int barchePosizionate = 0;

            while (barchePosizionate < 10)
            {
                int coordinataX = random.Next(0, 10);
                int coordinataY = random.Next(0, 10);

                if (!campo[coordinataX, coordinataY])
                {
                    campo[coordinataX, coordinataY] = true;
                    barchePosizionate++;
                }
            }
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            PosizionaBarche(campo1);
            PosizionaBarche(campo2);
        }
    }
}
