using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        public int kredit = 0;
        public int[] broj_novcanica = new int[8] { 5, 2, 1, 0, 3, 6, 4, 2 };
        public int[] novcanice = new int[8] { 1, 2, 5, 10, 20, 50, 100, 200 };
        public Label[] labels;
        public Form1()
        {
            InitializeComponent();
            labels = new Label[8] { Broj1, Broj2, Broj5, Broj10, Broj20, Broj50, Broj100, Broj200 };
        }

        public void Dodaj_Kredit(int a)
        {
            kredit += a;
            Vas_kredit.Text = kredit.ToString();
        }

        public void Kupi(int cena, PictureBox proizvod)
        {
            if (kredit >= cena)
            {
                kredit -= cena;
                Vas_kredit.Text = kredit.ToString();
                proizvod.Visible = false;
            }
        }

        public void Dodaj_Novac(Label Broj)
        {
            int pom = Convert.ToInt32(Broj.Text) + 1;
            Broj.Text = pom.ToString();
        }

        public void Uzmi_Novac(Label Broj)
        {
            if (Convert.ToInt32(Broj.Text) >= 1)
            {
                int pom = Convert.ToInt32(Broj.Text) - 1;
                Broj.Text = pom.ToString();
            }
        }

        private void Dodaj_1_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_1.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj1);
            broj_novcanica[0]++;
        }

        private void Dodaj_2_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_2.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj2);
            broj_novcanica[1]++;
        }

        private void Dodaj_5_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_5.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj5);
            broj_novcanica[2]++;
        }

        private void Dodaj_10_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_10.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj10);
            broj_novcanica[3]++;
        }

        private void Dodaj_20_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_20.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj20);
            broj_novcanica[4]++;
        }

        private void Dodaj_50_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_50.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj50);
            broj_novcanica[5]++;
        }

        private void Dodaj_100_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_100.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj100);
            broj_novcanica[6]++;
        }

        private void Dodaj_200_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Dodaj_200.Text);
            Dodaj_Kredit(novcanica);
            Dodaj_Novac(Broj200);
            broj_novcanica[7]++;
        }

        private void Kupi_smoki_Click(object sender, EventArgs e)
        {
            int cena = Convert.ToInt32(Cena_smoki.Text);
            if (Smoki1.Visible == true)
            {
                Kupi(cena, Smoki1);
            }
            else if (Smoki2.Visible == true)
            {
                Kupi(cena, Smoki2);
            } 
            else if (Smoki3.Visible == true)
            {
                Kupi(cena, Smoki3);
            }
            else if (Smoki4.Visible == true)
            {
                Kupi(cena, Smoki4);
            }
            else if (Smoki5.Visible == true)
            {
                Kupi(cena, Smoki5);
            }
        }

        private void Kupi_ribice_Click(object sender, EventArgs e)
        {
            int cena = Convert.ToInt32(Cena_ribice.Text);
            if (Ribice1.Visible == true)
            {
                Kupi(cena, Ribice1);
            }
            else if (Ribice2.Visible == true)
            {
                Kupi(cena, Ribice2);
            }
            else if (Ribice3.Visible == true)
            {
                Kupi(cena, Ribice3);
            }
            else if (Ribice4.Visible == true)
            {
                Kupi(cena, Ribice4);
            }
            else if (Ribice5.Visible == true)
            {
                Kupi(cena, Ribice5);
            }
        }

        private void Kupi_twix_Click(object sender, EventArgs e)
        {
            int cena = Convert.ToInt32(Cena_twix.Text);
            if (Twix1.Visible == true)
            {
                Kupi(cena, Twix1);
            }
            else if (Twix2.Visible == true)
            {
                Kupi(cena, Twix2);
            }
            else if (Twix3.Visible == true)
            {
                Kupi(cena, Twix3);
            }
            else if (Twix4.Visible == true)
            {
                Kupi(cena, Twix4);
            }
            else if (Twix5.Visible == true)
            {
                Kupi(cena, Twix5);
            }
        }

        private void Kupi_skittles_Click(object sender, EventArgs e)
        {
            int cena = Convert.ToInt32(Cena_skittles.Text);
            if (Skittles1.Visible == true)
            {
                Kupi(cena, Skittles1);
            }
            else if (Skittles2.Visible == true)
            {
                Kupi(cena, Skittles2);
            }
            else if (Skittles3.Visible == true)
            {
                Kupi(cena, Skittles3);
            }
            else if (Skittles4.Visible == true)
            {
                Kupi(cena, Skittles4);
            }
            else if (Skittles5.Visible == true)
            {
                Kupi(cena, Skittles5);
            }
        }

        private void Kupi_ivi_Click(object sender, EventArgs e)
        {
            int cena = Convert.ToInt32(Cena_ivi.Text);
            if (Ivi1.Visible == true)
            {
                Kupi(cena, Ivi1);
            }
            else if (Ivi2.Visible == true)
            {
                Kupi(cena, Ivi2);
            }
            else if (Ivi3.Visible == true)
            {
                Kupi(cena, Ivi3);
            }
            else if (Ivi4.Visible == true)
            {
                Kupi(cena, Ivi4);
            }
            else if (Ivi5.Visible == true)
            {
                Kupi(cena, Ivi5);
            }
        }

        private void Kljuc_TextChanged(object sender, EventArgs e)
        {
            if (Kljuc.Text == "123")
            {
                Kasa.Visible = true;
                Novac1.Visible = true;
                Novac2.Visible = true;
                Novac5.Visible = true;
                Novac10.Visible = true;
                Novac20.Visible = true;
                Novac50.Visible = true;
                Novac100.Visible = true;
                Novac200.Visible = true;
                Broj1.Visible = true;
                Broj2.Visible = true;
                Broj5.Visible = true;
                Broj10.Visible = true;
                Broj20.Visible = true;
                Broj50.Visible = true;
                Broj100.Visible = true;
                Broj200.Visible = true;
                Dodaj1.Visible = true;
                Dodaj2.Visible = true;
                Dodaj5.Visible = true;
                Dodaj10.Visible = true;
                Dodaj20.Visible = true;
                Dodaj50.Visible = true;
                Dodaj100.Visible = true;
                Dodaj200.Visible = true;
                Uzmi1.Visible = true;
                Uzmi2.Visible = true;
                Uzmi5.Visible = true;
                Uzmi10.Visible = true;
                Uzmi20.Visible = true;
                Uzmi50.Visible = true;
                Uzmi100.Visible = true;
                Uzmi200.Visible = true;
                Dodaj_novi_artikal.Visible = true;
                Izaberi_artikal.Visible = true;
                Dodaj_artikal.Visible = true;
                Skloni_sve_artikle.Visible = true;
                Skloni_artikal.Visible = true;
                Skloni.Visible = true;
            }
        }

        private void Dodaj1_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac1.Text);
            Dodaj_Novac(Broj1);
            broj_novcanica[0]++;
        }

        private void Dodaj2_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac2.Text);
            Dodaj_Novac(Broj2);
            broj_novcanica[1]++;
        }

        private void Dodaj5_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac5.Text);
            Dodaj_Novac(Broj5);
            broj_novcanica[2]++;
        }

        private void Dodaj10_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac10.Text);
            Dodaj_Novac(Broj10);
            broj_novcanica[3]++;
        }

        private void Dodaj20_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac20.Text);
            Dodaj_Novac(Broj20);
            broj_novcanica[4]++;
        }

        private void Dodaj50_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac50.Text);
            Dodaj_Novac(Broj50);
            broj_novcanica[5]++;
        }

        private void Dodaj100_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac100.Text);
            Dodaj_Novac(Broj100);
            broj_novcanica[6]++;
        }

        private void Dodaj200_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac200.Text);
            Dodaj_Novac(Broj200);
            broj_novcanica[7]++;
        }

        private void Uzmi1_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac1.Text);
            Uzmi_Novac(Broj1);
            broj_novcanica[0]--;
        }

        private void Uzmi2_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac2.Text);
            Uzmi_Novac(Broj2);
            broj_novcanica[1]--;
        }

        private void Uzmi5_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac5.Text);
            Uzmi_Novac(Broj5);
            broj_novcanica[2]--;
        }

        private void Uzmi10_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac10.Text);
            Uzmi_Novac(Broj10);
            broj_novcanica[3]--;
        }

        private void Uzmi20_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac20.Text);
            Uzmi_Novac(Broj20);
            broj_novcanica[4]--;
        }

        private void Uzmi50_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac50.Text);
            Uzmi_Novac(Broj50);
            broj_novcanica[5]--;
        }

        private void Uzmi100_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac100.Text);
            Uzmi_Novac(Broj100);
            broj_novcanica[6]--;
        }

        private void Uzmi200_Click(object sender, EventArgs e)
        {
            int novcanica = Convert.ToInt32(Novac200.Text);
            Uzmi_Novac(Broj200);
            broj_novcanica[7]--;
        }

        private void Kusur_Click(object sender, EventArgs e)
        {
            int[] kusur = new int[kredit + 1];
            kusur[0] = -1;
            for (int i = 0; i < broj_novcanica.Length; i++)
            {
                for (int j = kusur.Length - 1; j >= 0; j--)
                {
                    for (int k = 1; k < broj_novcanica[i] + 1; k++)
                    {
                        if (kusur[j] != 0)
                        {
                            if (j + k * novcanice[i] >= kusur.Length) continue;
                            kusur[j + k * novcanice[i]] = i + 1;
                        }
                    }
                }
            }
            int pre_promene = kredit;
            int current = kusur.Length - 1;
            while (kusur[current] != -1)
            {
                if (kusur[current] == 0)
                {
                    current--;
                    continue;
                }
                int pom = current;
                current -= novcanice[kusur[pom] - 1];
                kredit -= novcanice[kusur[pom] - 1];
                broj_novcanica[kusur[pom] - 1]--;
            }
            Kusur_Text.Text = (pre_promene - kredit).ToString();
            Vas_kredit.Text = kredit.ToString();
            for (int i = 0; i < 8; i++)
            {
                labels[i].Text = broj_novcanica[i].ToString();
            }
        }

        private void Dodaj_artikal_Click(object sender, EventArgs e)
        {
            string artikal = Izaberi_artikal.SelectedItem.ToString();
            if (artikal == "Smoki")
            {
                if (Smoki5.Visible == false)
                {
                    Smoki5.Visible = true;
                }
                else if (Smoki4.Visible == false)
                {
                    Smoki4.Visible = true;
                }
                else if (Smoki3.Visible == false)
                {
                    Smoki3.Visible = true;
                }
                else if (Smoki2.Visible == false)
                {
                    Smoki2.Visible = true;
                }
                else if (Smoki1.Visible == false)
                {
                    Smoki1.Visible = true;
                }
            }
            else if (artikal == "Ribice")
            {
                if (Ribice5.Visible == false)
                {
                    Ribice5.Visible = true;
                }
                else if (Ribice4.Visible == false)
                {
                    Ribice4.Visible = true;
                }
                else if (Ribice3.Visible == false)
                {
                    Ribice3.Visible = true;
                }
                else if (Ribice2.Visible == false)
                {
                    Ribice2.Visible = true;
                }
                else if (Ribice1.Visible == false)
                {
                    Ribice1.Visible = true;
                }
            }
            else if (artikal == "Twix")
            {
                if (Twix5.Visible == false)
                {
                    Twix5.Visible = true;
                }
                else if (Twix4.Visible == false)
                {
                    Twix4.Visible = true;
                }
                else if (Twix3.Visible == false)
                {
                    Twix3.Visible = true;
                }
                else if (Twix2.Visible == false)
                {
                    Twix2.Visible = true;
                }
                else if (Twix1.Visible == false)
                {
                    Twix1.Visible = true;
                }
            }
            else if (artikal == "Skittles")
            {
                if (Skittles5.Visible == false)
                {
                    Skittles5.Visible = true;
                }
                else if (Skittles4.Visible == false)
                {
                    Skittles4.Visible = true;
                }
                else if (Skittles3.Visible == false)
                {
                    Skittles3.Visible = true;
                }
                else if (Skittles2.Visible == false)
                {
                    Skittles2.Visible = true;
                }
                else if (Skittles1.Visible == false)
                {
                    Skittles1.Visible = true;
                }
            }
            else if (artikal == "Ivi")
            {
                if (Ivi5.Visible == false)
                {
                    Ivi5.Visible = true;
                }
                else if (Ivi4.Visible == false)
                {
                    Ivi4.Visible = true;
                }
                else if (Ivi3.Visible == false)
                {
                    Ivi3.Visible = true;
                }
                else if (Ivi2.Visible == false)
                {
                    Ivi2.Visible = true;
                }
                else if (Ivi1.Visible == false)
                {
                    Ivi1.Visible = true;
                }
            }
        }

        private void Skloni_Click(object sender, EventArgs e)
        {
            string artikal = Skloni_artikal.SelectedItem.ToString();
            if (artikal == "Smoki")
            {
                Smoki1.Visible = false;
                Smoki2.Visible = false;
                Smoki3.Visible = false;
                Smoki4.Visible = false;
                Smoki5.Visible = false;
            }
            else if (artikal == "Ribice")
            {
                Ribice1.Visible = false;
                Ribice2.Visible = false;
                Ribice3.Visible = false;
                Ribice4.Visible = false;
                Ribice5.Visible = false;
            }
            else if (artikal == "Twix")
            {
                Twix1.Visible = false;
                Twix2.Visible = false;
                Twix3.Visible = false;
                Twix4.Visible = false;
                Twix5.Visible = false;
            }
            else if (artikal == "Skittles")
            {
                Skittles1.Visible = false;
                Skittles2.Visible = false;
                Skittles3.Visible = false;
                Skittles4.Visible = false;
                Skittles5.Visible = false;
            }
            else if (artikal == "Ivi")
            {
                Ivi1.Visible = false;
                Ivi2.Visible = false;
                Ivi3.Visible = false;
                Ivi4.Visible = false;
                Ivi5.Visible = false;
            }
        }
    }
}
