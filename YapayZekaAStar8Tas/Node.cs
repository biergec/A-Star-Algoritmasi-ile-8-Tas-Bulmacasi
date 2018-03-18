using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapayZekaAStar8Tas
{
    class Node
    {
        public static int[] sonucMatrisimiz = {1,2,3,8,0,4,7,6,5};
        public int[] matrisDegerler;
        public int g; // Başlangıca olan uzaklığımız
        public int h; // Sonuca olan sezgisel uzaklığımız 
        public int f; // f = g + h
        public Node parent;

        public Node()
        {
            matrisDegerler = new int[9];
            parent = null;
        }

        public void FdegeriniGuncelle()
        {
            f = g + h;
        }

        // Verilen akreden hedef noktaya olan uzaklık
        public void HdegeriniHesapla()
        {
            // manathan kullanarak hesaplıyoruz
            h = 0;
            for (int i = 0; i < 9; i++)
            {
                int sonucIndex = Array.IndexOf(sonucMatrisimiz, matrisDegerler[i]);
                int sutun = Math.Abs((i % 3) - (sonucIndex % 3));
                int satir = Math.Abs((i/3) - (sonucIndex / 3));
                // hedefe olan manathan uzaklığımız
                h += sutun + satir;
            }
        }

        //UretilenGUIOkuma(textBox_GUI);
        public void UretilenGUIOkuma(Label textBox_GUI)
        {
            string[] okunanGUIdegerleri = textBox_GUI.Text.Replace("\n", " ").Replace("\r", "").Split();
            string[] okunanGUIdegerleri2 = {okunanGUIdegerleri[0] , okunanGUIdegerleri[1], okunanGUIdegerleri[2]};
            char[] c=okunanGUIdegerleri2[0].ToArray();
            char[] c2 = okunanGUIdegerleri2[1].ToArray();
            char[] c3 = okunanGUIdegerleri2[2].ToArray();

            for (int i = 0; i < 3; i++)
            {
                matrisDegerler[i] = Int32.Parse(c[i].ToString());
                matrisDegerler[i+3] = Int32.Parse(c2[i].ToString());
                matrisDegerler[i+6] = Int32.Parse(c3[i].ToString());
            }
        }

        public void TextboxMatrisSonucYaz(TextBox textBox)
        {
            textBox.Text += " ********** \r\n";
            for (int i = 0; i < 9; i++)
            {
                if (matrisDegerler[i] == 0)
                {
                    textBox.Text += "   ";
                }
                else
                    textBox.Text += matrisDegerler[i].ToString() + "";

                if (i%3==2)
                {
                    textBox.Text += "\r\n";
                }
            }
        }
    }

    static class Extension
    {
        // Random Liste Üretmek İçin Liste Karıştırılıyor
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
