using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace H11VB02
{
    public partial class FormTesten : Form
    {
        private string[] eng, ned;
        private int aantalWoorden;

        public FormTesten()
        {
            InitializeComponent();
        }

        private void buttonSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonControle_Click(object sender, EventArgs e)
        {
            // variabelen declareren
            Random willekeurig = new Random();
            int indexWoord;

            // Controleren
            indexWoord = Array.IndexOf(ned, textBoxNederlands.Text);
            if (eng[indexWoord].ToUpper() == textBoxEngels.Text.ToUpper())
            {
                labelJuistFout.Text = "Goed zo!";
            }
            else
            {
                labelJuistFout.Text = ned[indexWoord] + " = " + eng[indexWoord];
            }

            // nieuw woord tonen
            textBoxEngels.Text = "";
            textBoxNederlands.Text = ned[willekeurig.Next(aantalWoorden)];
        }

        private void FormTesten_Load(object sender, EventArgs e)
        {
            // variabelen declareren
            int teller;
            string volledigeLijn;
            Random willekeurig = new Random();

            // Arrays initialiseren.
            ned = new string[100];
            eng = new string[100];

            // Inlezen van Nederlandse en Engelse woorden uit een bestand
            DialogResult resultaat;

            // Instellen van het dialoogvenster Openen
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Openen";
            dlg.FileName = "";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt|All files (*.*)|*.*";

            // Dialog box tonen
            resultaat = dlg.ShowDialog();

            // Openen en lezen van het bestand 
            if (resultaat == DialogResult.OK)
            {
                using (StreamReader streamLees = new StreamReader(dlg.FileName))
                {
                    teller = 0;
                    while (streamLees.Peek() != -1)
                    {
                        volledigeLijn = streamLees.ReadLine();

                        ned[teller] = volledigeLijn.Substring(0, 20).Trim();
                        eng[teller] = volledigeLijn.Substring(20).Trim();

                        teller++;
                    }

                    aantalWoorden = teller;

                    // nieuw woord tonen
                    textBoxNederlands.Text = ned[willekeurig.Next(aantalWoorden)];
                }
            }
            else
            {
                resultaat = MessageBox.Show("U moet een bestand kiezen om mee te oefenen.", "Fout", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (resultaat == DialogResult.Retry)
                {
                    FormTesten_Load(sender, e);
                }
                else
                {
                    this.Close();
                }
                return;
            }
        }
    }
}
