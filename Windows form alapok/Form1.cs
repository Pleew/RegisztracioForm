using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_alapok
{
    public partial class hobbik : Form
    {
        static List<string> hobbikLista = new List<string>();
        public hobbik()
        {
            
        }

        private void hozzaAd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hobbikLista.Count; i++)
            {
                hobbikLista.Add("hobbikListaSzoveg.txt");
            }
        }

        private void textBoxUjHobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hozzaAd.PerformClick();
            }
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            var mentes = saveFileDialog1.ShowDialog();
            for (int i = 0; i < hobbikLista.Count; i++)
            {
                if (mentes != DialogResult.OK)
                {
                    return;
                }
            }
            string fileNev = saveFileDialog1.FileName;
            try
            {
                using (var sw = new StreamWriter(fileNev))
                {
                    sw.WriteLine(textBoxNev.Text);
                    sw.WriteLine(szulDatumPicker.Value.ToString());
                    sw.WriteLine(ferfi.Checked);
                    sw.WriteLine(no.Checked);

                    foreach (var item in hobbiLista.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem jó a mentés, hiba");
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            var megnyit = openFileDialog1.ShowDialog();
            if (megnyit != DialogResult.OK)
            {
                return;
            }

            string fileNev = openFileDialog1.FileName;

            try
            {
                using (var sr = new StreamReader(fileNev))
                {
                    hobbiLista.Items.Clear();

                    textBoxNev.Text = sr.ReadLine();
                    szulDatumPicker = sr.ReadLine(szulDatumPicker.Value.ToString());
                    ferfi.Checked = bool.Parse(sr.ReadLine());
                    no.Checked = bool.Parse(sr.ReadLine());


                    while (!sr.EndOfStream)
                    {
                        hobbiLista.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem jó a megnyitás, hiba");
            }
        }
    }
}
