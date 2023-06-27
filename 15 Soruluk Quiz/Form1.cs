namespace _15_Soruluk_Quiz
{
    public partial class Form1 : Form
    {

        //sorularýn tutuldugu strýng dýzýsý.
        string[] sorular = new string[]
        {
            "Aþaðýdakilerden hangisi hatalý deðiþken ismidir ?",
            "Asagidakilerden hangisi bir dongu degildir ?",
            "Bir donguyu kirmak icin hangisi yazilmalidir ?",
            "1 den 10 a kadar sayilari yazdirmak icin assagidakilerden hangisi secilmelidir ?",
            "C# ta yorum satiri nasil yapilir ?",
            "int a=33;\nif(a<33){\nConsole.WriteLine(a);}\nelse{\nConsole.WriteLine(a-30);}\n Kod parcasinin ciktisi nedir ?",
            "Asagidakilerden hangisi 6 uzunluktaki bir stringdir ?",
            "Asagidakilerden hangisinin cevabi 14'tur ?",
            "C#'ta bolme islemi nasil yapilir ?",
            "Asagidakilerden hangisi dogrudur ?",
            "Hangisi true degerini dondurur ?",
            "Nissan GTR-R35 Arabasinin motor hacmi 3.8l'dir\nBuna gore bu degeri hangi kod parcasi dogru gosterir ?",
            "Nissan GTR-R35 Arabasi 6 silindirdir.\n Buna gore silindir sayisini gosteren þýk hangisidir ?",
            "Furkan'in Nissan GTR-R35 Arabasinin rengi mavidir./n Buna gore bu bilgiyi kod olarak gosteren þýk hangisidir ?",
            "Asagidaki þýklardan hangilerinin sonucu gül dür?",
        };
        //a þýkkýnýn cevaplarýný tutan strýng disizi.
        string[] aþýkký = new string[]
        {
            "degiskenismi1",
            "if",
            "contiune;",
            "for(int i=1:i<=10:i++){\nConsole.WriteLine(i);}",
            "//",
            "33",
            "int str[6];",
            "int a=7;\n int b=a*a;\nConsole.WriteLine(b/a);",
            "|",
            "int a==5;",
            "bool dogru=false;\nif(dogru==true)\ndogru=true;\nConsole.WriteLine(dogru);",
            "float float=3.8l;",
            "int silindir=1;\nsilindir++;\nsilindir+=5;\nConsole.WriteLine(silindir);",
            "Nissan.Color=Color.Blue();",
            "string gul=gul;\nConsole.WriteLine(gul[0]);",
        };

        //b þýkkýnýn cevaplarýný tutan strýng disizi.
        string[] bþýkký = new string[]
        {
            "Degiskenismi2",
            "while()",
            "go to;",
            "for(int i=0:i<10:i++){\nConsole.WriteLine(i);}",
            "&&",
            "0",
            "double str[7];",
            "int a=7;\nint c=a*2;\n a=5;\nConsole.WriteLine(c);",
            "//",
            "Int a=5;",
            "bool dogru=true;\nif(dogru==true)\ndogru=false;\nConsole.WriteLine(dogru);",
            "float hacim=3.8;",
            "int silindir=1;\nsilindir++;\nsilindir-=5;\nConsole.WriteLine(silindir+6);",
            "Nissan.Color=Color.RED();",
            "string gul=gul;\nConsole.WriteLine(gul[1]);",
        };

        //c þýkkýnýn cevaplarýný tutan strýng disizi.
        string[] cþýkký = new string[]
        {
            "3degiskenismi3",
            "for()",
            "case:",
            "for(int i=0:i<10:i++){\nConsole.WriteLine(i--);}",
            "++",
            "3",
            "char str[6];",
            "int c=7;\nint a=14;\nConsole.WriteLine(a-c);",
            "\\",
            "int a=5;",
            "bool dogru=false;\nif(dogru==false)\ndogru=true;\nConsole.WriteLine(dogru);",
            "double=3.8;",
            "int silindir=-1;\nsilindir++;\nsilindir+=5;\nConsole.WriteLine(silindir+1-1);",
            "Nissan.Color=Color.BlUE();",
            "string gul=gul;\nConsole.WriteLine(gul);",
        };


        //d þýkkýnýn cevaplarýný tutan strýng disizi.
        string[] dþýkký = new string[]
        {
            "_isimDegisken4",
            "do while()",
            "break;",
            "for(int i=2:i<12:i++){\nConsole.WriteLine(i+2-2);}",
            "+=",
            "bos cikti",
            "string str;",
            "int a=14;\nConsole.WriteLine(a-a/2);",
            "/",
            "int -a=5;",
            "bool dogru=false;\nif(dogru!=true)\ndogru=false;\nConsole.WriteLine(dogru);",
            "double hacim=3.8l;",
            "int silindir=-1;\nsilindir--;\nsilindir+=8;\nConsole.WriteLine(silindir);",
            "Nissan.Colors==Colors.Blue();",
            "string gull=gul;\nConsole.WriteLine(gul);",
        };

        string[] dogurcevap = new string[]
        {
            "c",
            "a",
            "d",
            "a",
            "a",
            "c",
            "c",
            "b",
            "d",
            "c",
            "c",
            "b",
            "d",
            "a",
            "c",

        };

        int suankisoruIndexi = 0;

        int süre = 15;

        int dogrusayisi = 0, yanlissayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void soru15_lbl_Click(object sender, EventArgs e)
        {

        }

        private void basla_btn_Click(object sender, EventArgs e)
        {
            //basla butona basýldýgý zaman sorularýn oldugu panel acýlýr.

            sorusunum_pnl.Visible = true;

            //ilk baþlangýç olarak soru stringi ve þýklar stringi burada getirlir.

            sorutext_lbl.Text = "Soru " + (suankisoruIndexi + 1).ToString();

            sorukisimi_lbl.Text = sorular[suankisoruIndexi];

            a_rdbtn.Text = aþýkký[suankisoruIndexi].ToString();
            b_rdbtn.Text = bþýkký[suankisoruIndexi].ToString();
            c_rdbtn.Text = cþýkký[suankisoruIndexi].ToString();
            d_rdbtn.Text = dþýkký[suankisoruIndexi].ToString();
            timer1.Enabled = true;
            basla_btn.Visible = false;

        }

        private void a_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dogurcevap[suankisoruIndexi] == "a" && a_rdbtn.Checked)
            {

                dogrusayisi++;
                doðru_lbl.Text = "Doðru : " + dogrusayisi.ToString();
                SolTarafSoruRenkDegistir(1);
                SonrakiSoru();
            }
            else if (dogurcevap[suankisoruIndexi] != "a" && a_rdbtn.Checked)
            {
                yanlissayisi++;
                yanlýþ_lbl.Text = "Yanlýþ : " + yanlissayisi.ToString();
                SolTarafSoruRenkDegistir(0);
                SonrakiSoru();
            }
            a_rdbtn.Checked = false;

        }

        private void b_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dogurcevap[suankisoruIndexi] == "b" && b_rdbtn.Checked)
            {
                dogrusayisi++;
                doðru_lbl.Text = "Doðru : " + dogrusayisi.ToString();
                SolTarafSoruRenkDegistir(1);
                SonrakiSoru();
            }
            else if (dogurcevap[suankisoruIndexi] != "b" && b_rdbtn.Checked)
            {
                yanlissayisi++;
                yanlýþ_lbl.Text = "Yanlýþ : " + yanlissayisi.ToString();
                SolTarafSoruRenkDegistir(0);
                SonrakiSoru();
            }
            b_rdbtn.Checked = false;

        }

        private void c_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dogurcevap[suankisoruIndexi] == "c" && c_rdbtn.Checked)
            {
                dogrusayisi++;
                doðru_lbl.Text = "Doðru : " + dogrusayisi.ToString();
                SolTarafSoruRenkDegistir(1);
                SonrakiSoru();
            }
            else if (dogurcevap[suankisoruIndexi] != "c" && c_rdbtn.Checked)
            {
                yanlissayisi++;
                yanlýþ_lbl.Text = "Yanlýþ : " + yanlissayisi.ToString();
                SolTarafSoruRenkDegistir(0);
                SonrakiSoru();
            }
            c_rdbtn.Checked = false;
        }

        private void d_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dogurcevap[suankisoruIndexi] == "d" && d_rdbtn.Checked)
            {
                dogrusayisi++;
                doðru_lbl.Text = "Doðru : " + dogrusayisi.ToString();
                SolTarafSoruRenkDegistir(1);
                SonrakiSoru();
            }
            else if (dogurcevap[suankisoruIndexi] != "d" && d_rdbtn.Checked)
            {
                yanlissayisi++;
                yanlýþ_lbl.Text = "Yanlýþ : " + yanlissayisi.ToString();
                SolTarafSoruRenkDegistir(0);
                SonrakiSoru();
            }
            d_rdbtn.Checked = false;
        }
        void SonrakiSoru()
        {
            süre_lbl.BackColor = Color.White;
            if (suankisoruIndexi == 14)
            {
                sorusunum_pnl.Visible = false;
                sonuc_lbl.Text = "Quizi Bitirdiniz Sonuçlarýnýz:\nDoðru sayýsý : " + dogrusayisi.ToString() + "\nYanlýþ Sayýsý : " + yanlissayisi.ToString();
                tekrardene_btn.Visible = true;
                timer1.Stop();
            }

            if (suankisoruIndexi < 14)
            {
                suankisoruIndexi++;

                sorutext_lbl.Text = "Soru " + (suankisoruIndexi + 1).ToString();
                sorukisimi_lbl.Text = sorular[suankisoruIndexi];

                a_rdbtn.Text = aþýkký[suankisoruIndexi].ToString();
                b_rdbtn.Text = bþýkký[suankisoruIndexi].ToString();
                c_rdbtn.Text = cþýkký[suankisoruIndexi].ToString();
                d_rdbtn.Text = dþýkký[suankisoruIndexi].ToString();

            }

        }
        void SolTarafSoruRenkDegistir(int dogruluk)
        {
            Color clr = new Color();
            if (dogruluk == 1)
            {
                clr = Color.Green;
            }
            else
            {
                clr = Color.Red;
            }
            switch (suankisoruIndexi)
            {
                case 0:
                    soru1_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 1:
                    soru2_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 2:
                    soru3_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 3:
                    soru4_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 4:
                    soru5_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 5:
                    soru6_lbl.BackColor = clr;
                    süre = 15;
                    break;
                case 6:
                    soru7_lbl.BackColor = clr;
                    süre = 30;
                    break;
                case 7:
                    soru8_lbl.BackColor = clr;
                    süre = 30;
                    break;
                case 8:
                    soru9_lbl.BackColor = clr;
                    süre = 30;
                    break;
                case 9:
                    soru10_lbl.BackColor = clr;
                    süre = 30;
                    break;
                case 10:
                    soru11_lbl.BackColor = clr;
                    süre = 60;
                    break;
                case 11:
                    soru12_lbl.BackColor = clr;
                    süre = 60;
                    break;
                case 12:
                    soru13_lbl.BackColor = clr;
                    süre = 60;
                    break;
                case 13:
                    soru14_lbl.BackColor = clr;
                    süre = 60;
                    break;
                case 14:
                    soru15_lbl.BackColor = clr;
                    süre = 60;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre_lbl.Text = "Kalan Süre : " + süre.ToString();
            if (süre == 0)
            {
                süre_lbl.BackColor = Color.White;
                timer1.Enabled = false;
                sorusunum_pnl.Visible = false;
                sonuc_lbl.Text = "Süre bitti tekrar deneyiniz.";
                tekrardene_btn.Visible = true;

            }
            if (süre == 15)
            {
                süre_lbl.BackColor = Color.Tomato;
            }
            if (süre == 5)
            {
                süre_lbl.BackColor = Color.Red;
            }
            süre--;



        }

        private void tekrardene_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
