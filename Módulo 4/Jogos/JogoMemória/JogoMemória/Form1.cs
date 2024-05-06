namespace JogoMemória
{
    public partial class JogoMemória : Form
    {
        int movimentos, clicks, cartasEncontradas, tagIndex;

        Image[] img = new Image[9];

        List<string> lista = new List<string>();

        int[] tags = new int[2];
        public JogoMemória()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(string.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.verso;
                item.Enabled= true;
            }
            RandomPosition();
        }

        private void RandomPosition()
        {
            //Baralhar items
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                //Position Items
                int[] xP = { 11, 174, 337, 500, 663, 826 };
                int[] yP = { 29, 159, 292 };


                Repete:
                //Baralhar
                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];

                //Verificar se nenhuma imagem fica em cima de outra
                string Verificar = X.ToString() + Y.ToString();

               if (lista.Contains(Verificar))
                {
                    goto Repete;
                }
               else
                {
                    item.Location = new Point(X, Y);
                    lista.Add(Verificar);
                }
            }

        }

        private void ImagensClick(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            clicks++;

            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (clicks == 1) 
            {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            } 
            else if (clicks == 2) 
            {
                movimentos++;
                lblMovimentos.Text = "Movimentos " + movimentos.ToString();
                tags[1] = int.Parse(string.Format("{0}", pic.Tag));
                parEncontrado = CheckPares();
                Desvirar(parEncontrado);
            }

        }

        private bool CheckPares()
        {
            clicks = 0;
            if (tags[0] == tags[1]) { return true; } else { return false; }
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(string.Format("{0}", item.Tag)) == tags[0] ||
                    int.Parse(string.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled= false;
                        cartasEncontradas++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.verso;
                        item.Refresh();
                    }
                }
                FinalJogo();
            }
        }
        private void FinalJogo()
        {
            if (cartasEncontradas == img.Length * 2)
            {
                MessageBox.Show("Parabéns! \n Conseguiste vencer o Encontra o Meme! \n Fizeste no total " + movimentos.ToString() + " jogadas!");

                DialogResult msg = MessageBox.Show("Pretendes continuar a jogar?", "Caixa de Pergimta", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    clicks = 0; movimentos = 0; cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();
                }

                else if (msg == DialogResult.No)
                {
                    MessageBox.Show("Obrigado por teres jogado!");
                    Application.Exit();
                }
            }
        }
        private void JogoMemória_Load(object sender, EventArgs e)
        {

        }
    }
}