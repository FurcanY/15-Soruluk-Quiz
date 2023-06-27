# :muscle: 15 Soruluk Quiz

### Bu projemde 15 tane kolay sorular sırasıyla geliyor ve biz de zamanında cevaplamaya çalışıyoruz! :ok_hand:

![quizResim1](https://github.com/FurcanY/15-Soruluk-Quiz/assets/69853025/358898ea-7ca1-4581-a641-14aee74e69e7)

### Bu projeyi yapmamdaki nedenlerim:

#### :point_right: Timer'ı proje içinde etkili bir şekilde kullanmak.
#### :point_right: Soruları sırasıyla gelmesini sağlamak ve radiobuttonlardan hangisinin dorğu sonuç olduğunun algoritmasını yazmak.
#### :point_right: C#Form'da arayüzü daha etkili olacak şekilde kullamak(renkli ve kullanıcı dostu).


## Proje İçinden Örnek Kodlar 💾


    private void d_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dogurcevap[suankisoruIndexi] == "d" && d_rdbtn.Checked)
            {
                dogrusayisi++;
                doğru_lbl.Text = "Doğru : " + dogrusayisi.ToString();
                SolTarafSoruRenkDegistir(1);
                SonrakiSoru();
            }
            else if (dogurcevap[suankisoruIndexi] != "d" && d_rdbtn.Checked)
            {
                yanlissayisi++;
                yanlış_lbl.Text = "Yanlış : " + yanlissayisi.ToString();
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
                sonuc_lbl.Text = "Quizi Bitirdiniz Sonuçlarınız:\nDoğru sayısı : " + dogrusayisi.ToString() + "\nYanlış                      Sayısı : " + yanlissayisi.ToString();
                tekrardene_btn.Visible = true;
                timer1.Stop();
            }

            if (suankisoruIndexi < 14)
            {
                suankisoruIndexi++;

                sorutext_lbl.Text = "Soru " + (suankisoruIndexi + 1).ToString();
                sorukisimi_lbl.Text = sorular[suankisoruIndexi];

                a_rdbtn.Text = aşıkkı[suankisoruIndexi].ToString();
                b_rdbtn.Text = bşıkkı[suankisoruIndexi].ToString();
                c_rdbtn.Text = cşıkkı[suankisoruIndexi].ToString();
                d_rdbtn.Text = dşıkkı[suankisoruIndexi].ToString();

            }

        }

![quizResim2](https://github.com/FurcanY/15-Soruluk-Quiz/assets/69853025/291f3e11-6f5f-4b3b-8734-9efb4bce1ac1)
![quizResim3](https://github.com/FurcanY/15-Soruluk-Quiz/assets/69853025/fbcd774e-2233-4be6-9740-1a8a4b5140c4)

## ✴️ Belki Bakarsın Diye Bırakıyorum ✴️
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
