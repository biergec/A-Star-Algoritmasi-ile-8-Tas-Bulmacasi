using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapayZekaAStar8Tas
{
    public partial class SekizTas : Form
    {
        public SekizTas()
        {
            InitializeComponent();
            panel_bilgilendirme_Ekrani.Show();
            panel1_numaraEkrani.Hide();
            BitisDurumuUret();
        }

        Node node;
        public static int gezilenDugunToplamSayi;

        private void button_Uret_Click(object sender, EventArgs e)
        {
            try
            {
                label_RandomUretilenSayilar_Baslangic_Durumu.Text = "";
                textBox_Adimlar.Text = "";
                BaslangicDurumuUret();
                BulmacayiCoz();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void BulmacayiCoz()
        {
            gezilenDugunToplamSayi = 0;
            node = new Node();
            node.UretilenGUIOkuma(label_RandomUretilenSayilar_Baslangic_Durumu);
            List<Node> acikListKuyruk = new List<Node>();
            List<int[]> kapaliListe = new List<int[]>();

            /* Çözülebilir mi kontrol et!
             * Çözülebilir olması için ters sıralı eleman sayisi çift olmalıymış!
             * 
             */

            if (!İsProblemCozulebilirMi(node.matrisDegerler,Node.sonucMatrisimiz))
            {
                label_ProblemCozulebilirMiKontrol.Text = "Problem Çözülemez, Lütfen Tekrar Deneyin";
                return;
            }else
                label_ProblemCozulebilirMiKontrol.Text = "Adımlar Sağ Tarafta Listelenmektedir.";

            node.HdegeriniHesapla();
            node.FdegeriniGuncelle();

            acikListKuyruk.Add(node);
            Node minYol;

            do
            {
                minYol = MinimumYolBul(acikListKuyruk);
                kapaliListe.Add(minYol.matrisDegerler);
                KuyrugaCocuklariEkle(minYol, acikListKuyruk, kapaliListe);
                gezilenDugunToplamSayi++;
            } while (minYol.h != 0 && acikListKuyruk.Count > 0);
         
                 // sonuç duruma ulaşana kadar
                // veya liste boş olana akdar sürdür
                SonucGUIyaz(minYol,textBox_Adimlar,0);
        }

        private bool SonucGUIyaz(Node minYol, TextBox label_ProblemCozulebilirMiKontrol, int v)
        {
            if (minYol==null)
            {
                label_ProblemCozulebilirMiKontrol.Text += "Toplam Adım Sayisi" + (v-1);
                return true;
            }

            SonucGUIyaz(minYol.parent,label_ProblemCozulebilirMiKontrol,v);
            minYol.TextboxMatrisSonucYaz(label_ProblemCozulebilirMiKontrol);
            return false;
        }

        private void KuyrugaCocuklariEkle(Node minYol, List<Node> acikListKuyruk, List<int[]> kapaliListe)
        {
            // boşluk bizde 0
            int boslukIndex = Array.IndexOf(minYol.matrisDegerler,0);
            if ((boslukIndex%3)!=2)
            {
                // boşluğun sağda komşusu var mı? varsa;
                Node child = CreateChild(minYol,boslukIndex,boslukIndex+1);
                if (!İsDonnn(child.matrisDegerler,kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex%3) !=0)
            {
                // boşluğun sol komşusu varsa
                Node child = CreateChild(minYol,boslukIndex,boslukIndex-1);
                if (!İsDonnn(child.matrisDegerler,kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex - 3) >= 0)
            { 
                //boşluğun üst kısımda komşusu varsa
                Node child = CreateChild(minYol, boslukIndex, boslukIndex - 3);
                if (!İsDonnn(child.matrisDegerler, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }

            if ((boslukIndex+3) < 9)
            {
                //boşluğun alt kısmında komşusu varsa
                Node child = CreateChild(minYol, boslukIndex, boslukIndex + 3);
                if (!İsDonnn(child.matrisDegerler, kapaliListe))
                {
                    acikListKuyruk.Add(child);
                }
            }
            acikListKuyruk.Remove(minYol);
        }

        private bool İsDonnn(int[] matrisDegerler, List<int[]> kapaliListe)
        {
            foreach (int[] item in kapaliListe)
            {
                bool isEqual = true;
                for (int i = 0; i < 9; i++)
                {
                    if (item[i] != matrisDegerler[i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual == true)
                    return true;
            }
            return false;
        }

        private Node CreateChild(Node minYol, int boslukIndex, int v_degerIndex)
        {
            // yeni düğüm ekle/oluştur
            Node child = new Node();
            Array.Copy(minYol.matrisDegerler,child.matrisDegerler,minYol.matrisDegerler.Length);

            // başlangıçtan gelinen mesafeyi bul
            child.g = minYol.g + 1;

            SwapDegerler(child.matrisDegerler,boslukIndex, v_degerIndex);

            child.HdegeriniHesapla();
            child.FdegeriniGuncelle();
            child.parent = minYol;
            return child;
        }

        private void SwapDegerler(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private Node MinimumYolBul(List<Node> acikListKuyruk)
        {
            int minIndex = 0;
            for (int i = 0; i < acikListKuyruk.Count; i++)
            {
                if (acikListKuyruk[i].f<acikListKuyruk[minIndex].f)
                {
                    minIndex = i;
                }
            }
            return acikListKuyruk[minIndex];
        }

        private bool İsProblemCozulebilirMi(int[] matrisDegerler, int[] sonucMatrisimiz)
        {
            int cevrim_kontrol = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    for (int k = 0; k < Array.IndexOf(sonucMatrisimiz, matrisDegerler[i]); k++)
                    {
                        if (sonucMatrisimiz[k] == matrisDegerler[j] && matrisDegerler[i] != 0 && matrisDegerler[j] != 0)
                            cevrim_kontrol++;
                    }
                }
            }
            if (cevrim_kontrol % 2 == 0)
                return true;

            return false;
        }

        private void BitisDurumuUret()
        {
            label_RandomUretilenSayilar_Bitis_Durumu.Text = "123\n\r804\n\r765";

        }

        private List<int> RandomSayiUret()
        {
            int[] randomSayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> randomListe = new List<int>();

            foreach (var item in randomSayilar)
            {
                randomListe.Add(item);
            }

            randomListe.Shuffle();

            return randomListe;
        }

        private void BaslangicDurumuUret()
        {
            List<int> list_baslama_durumu = RandomSayiUret();

            label_RandomUretilenSayilar_Baslangic_Durumu.Text = "";
            int listCount = list_baslama_durumu.Count;
            foreach (var item in list_baslama_durumu)
            {
                listCount--;
                label_RandomUretilenSayilar_Baslangic_Durumu.Text += item;
                if (listCount % 3 == 0)
                {
                    label_RandomUretilenSayilar_Baslangic_Durumu.Text += "\r\n";
                }
            }
        }

        private void button_info_sifir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 0 Butonu 0 olarak yazmaktadır. Ancak normalde boşluk işlevini görmektedir!..");
        }

        private void checkBox_SonDurumRandomSecilsin_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_SonDurumRandomSecilsin.Checked == true)
            {
                ButonlariAktifYao();
                panel_bilgilendirme_Ekrani.Show();
                panel1_numaraEkrani.Hide();
                BitisDurumuUret();
                button_Uret.Enabled = true;
            }
            else {
                panel_bilgilendirme_Ekrani.Hide();
                panel1_numaraEkrani.Show();
                label_RandomUretilenSayilar_Bitis_Durumu.Text = "";
                BaslangicDurumuUret();
                button_Uret.Enabled = false;
            }
        }

        int listCount = 0;
        private void button_Numaralar_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            listCount++;
            label_RandomUretilenSayilar_Bitis_Durumu.Text +=tiklanan.Text.ToString();
            if (listCount % 3 == 0)
            {
                label_RandomUretilenSayilar_Baslangic_Durumu.Text += "\r\n";
            }
            tiklanan.Enabled = false;
        }

        private void button_Coz_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_RandomUretilenSayilar_Baslangic_Durumu.Text != ""&& label_RandomUretilenSayilar_Bitis_Durumu.Text!="")
                {
                    textBox_Adimlar.Text = "";
                    SonucMatrisiDegerDegistir();
                    BulmacayiCoz();
                }
                else
                    MessageBox.Show("Lütfen Tüm Sayiları Girin");
                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void SonucMatrisiDegerDegistir()
        {
            string[] okunanGUIdegerleri = label_RandomUretilenSayilar_Baslangic_Durumu.Text.Replace("\n", " ").Replace("\r", "").Split();
            string[] okunanGUIdegerleri2 = { okunanGUIdegerleri[0], okunanGUIdegerleri[1], okunanGUIdegerleri[2] };
            char[] c = okunanGUIdegerleri2[0].ToArray();
            char[] c2 = okunanGUIdegerleri2[1].ToArray();
            char[] c3 = okunanGUIdegerleri2[2].ToArray();

            for (int i = 0; i < 3; i++)
            {
                Node.sonucMatrisimiz[i] = Int32.Parse(c[i].ToString());
                Node.sonucMatrisimiz[i + 3] = Int32.Parse(c2[i].ToString());
                Node.sonucMatrisimiz[i + 6] = Int32.Parse(c3[i].ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label_RandomUretilenSayilar_Bitis_Durumu.Text = "";
            textBox_Adimlar.Text = "";
            button_Numaralar.Enabled = true;
            ButonlariAktifYao();
        }

        private void ButonlariAktifYao()
        {
            button17.Enabled = true;
            button14.Enabled = true;
            button19.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = true;
            button18.Enabled = true;
            button15.Enabled = true;
            button12.Enabled = true;
        }

        private void SekizTas_Load(object sender, EventArgs e)
        {

        }
    }
}
