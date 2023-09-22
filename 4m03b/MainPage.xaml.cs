namespace _4m03b
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string? ent = emailEnt.Text;
            bool czyOk = false;
            if (ent != null)
            {
               if( ent.Contains('@'))
                {       
                    if(ent.IndexOf('@')>0 && ent.IndexOf('@')<ent.Length-1)
                        czyOk = true;
                }
            }

            if(czyOk)
            {
                weryfikacjaLbl.Text = "poprawny";
            }
            else
            {
                weryfikacjaLbl.Text = "zły";
            }
            SemanticScreenReader.Announce(weryfikacjaLbl.Text);
        }
    }
}