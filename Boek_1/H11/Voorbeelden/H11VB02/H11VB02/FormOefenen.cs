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
    public partial class FormOefenen : Form
    {
        public FormOefenen()
        {
            InitializeComponent();
        }


        // Globale variabelen
        private string _lastFileName = ""; 

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Spreken procedure tekst en listbox leegmaken aan.
            TekstVakkenLeegmaken(true);
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Inlezen bestand met Ned/Eng woorden via een dialoogvenster.
            TekstVakkenLeegmaken(true);

            // Instellen van het dialoogvenster Openen
            OpenFileDialog dlgOpen = new OpenFileDialog();
            // Eigenschappen instellen
            dlgOpen.Title = "Openen";
            dlgOpen.FileName = "";
            dlgOpen.DefaultExt = ".txt";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "Tekstbestanden (.txt)|*.txt|Alle bestanden (*.*)|*.*";

            // Dialoogvenster tonen en de keuze opvangen
            DialogResult resultaat = dlgOpen.ShowDialog();

            // Kijken of de gebruiker "openen" (ok) geklikt heeft
            if (resultaat == DialogResult.OK)
            {
                // We bewaren de naam van het bestand
                _lastFileName = dlgOpen.FileName;

                // We lezen het bestand in.
                using (StreamReader streamLees = new StreamReader(dlgOpen.FileName))
                {
                    // Zolang het bestand lijnen heeft en we de cursor (peek) kunnen plaatsen...
                    while (streamLees.Peek() != -1)
                    {
                        listBoxWoorden.Items.Add(streamLees.ReadLine());
                    }
                }
            }
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // We kijken of er al een bestand open is
            if (File.Exists(_lastFileName))
            {
                // indien ja, schrijven items weg naar de geopende file
                BestandWegschrijven(_lastFileName);
            }
            else
            {
                // er was nog geen bestand open, dus verwijzen door naar opslaan als
                opslaanAlsToolStripMenuItem_Click(sender, e);
            }
        }

        private void opslaanAlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // We bewaren de items in een bestand dat de gebruiker opgeeft.

            // Instellen van het dialoogvenster Bewaren
            SaveFileDialog dlgSave = new SaveFileDialog();
            // Eigenschappen instellen
            dlgSave.Title = "Opslaan als";
            dlgSave.FileName = "";
            dlgSave.DefaultExt = ".txt";
            dlgSave.InitialDirectory = Application.StartupPath;
            dlgSave.Filter = "Tekstbestanden (.txt)|*.txt|Alle bestanden (*.*)|*.*";

            // Dialoogvenster tonen en de keuze opvangen
            DialogResult resultaat = dlgSave.ShowDialog();

            // Kijken of de gebruiker "opslaan" (ok) geklikt heeft
            if (resultaat == DialogResult.OK)
            {
                // Items wegschrijven
                BestandWegschrijven(dlgSave.FileName);
            }
        }

        private void BestandWegschrijven(string fileName)
        {
            // In deze procedure schrijven we alle gegevens uit de listBox weg naar een bestand.
            using (StreamWriter streamSchrijf = new StreamWriter(fileName, false))
            {
                // Eerst bewaren we de filename (voor bij bewaren straks!)
                _lastFileName = fileName;

                // We lopen door onze listBox en schrijven ieder item naar het bestand.
                for (int i = 0; i < listBoxWoorden.Items.Count; i++)
                {
                    streamSchrijf.WriteLine(listBoxWoorden.Items[i].ToString());
                }
            }

            // We geven een melding dat het is opgeslagen
            MessageBox.Show("Het bestand is opgeslagen.", "Opslaan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TekstVakkenLeegmaken(bool listBoxLeeg = false)
        {
            // Tekstvakken leegmaken en listbox items verwijderen indien nodig.
            if (listBoxLeeg)
            {
                // Verwijderen de items uit de Listbox
                listBoxWoorden.Items.Clear();
            }

            // Tekstvakken leegmaken (2 verschillende manieren) en txtNed de focus geven
            textBoxNederlands.Clear();
            textBoxEngels.Text = "";

            textBoxNederlands.Focus();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            // Deze procedure voegt een Ned en Eng woord toe.
            string item;

            if (string.IsNullOrWhiteSpace(textBoxNederlands.Text))
            {
                MessageBox.Show("Er is geen Nederlands woord ingegeven.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNederlands.Focus();
                // Niet vergeten uit deze procedure te stappen.
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEngels.Text))
            {
                MessageBox.Show("Er is geen Engels woord ingegeven.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEngels.Focus();
                // Niet vergeten uit deze procedure te stappen.
                return;
            }

            // We bouwen de lijn op om toe te voegen aan de listbox
            item = textBoxNederlands.Text.PadRight(20) + textBoxEngels.Text;
            listBoxWoorden.Items.Add(item);

            TekstVakkenLeegmaken(false);
        }

        private void buttonVerwijderen_Click(object sender, EventArgs e)
        {
            // Verwijderen van het geselecteerde list item.

            // Controle  of er wel een item geselecteerd is.
            if (listBoxWoorden.SelectedIndex == -1)
            {
                // Geen item geselecteerd
                MessageBox.Show("Er is geen item geselecteerd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxWoorden.Focus();
                // Niet vergeten uit deze procedure te stappen.
                return;
            }

            // Indien er wel een item geselecteerd is => vragen extra bevestiging.
            DialogResult antwoord = MessageBox.Show("Ben je zeker dat je \"" + stripSpaces(listBoxWoorden.SelectedItem.ToString()) + "\" wenst te verwijderen?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Indien de gebruiker "YES" klikt, verwijderen we het item
            if (antwoord == DialogResult.Yes)
            {
                listBoxWoorden.Items.RemoveAt(listBoxWoorden.SelectedIndex);
            }

        }

        private string stripSpaces(string woorden)
        {
            return String.Join(" ", woorden.Split(new char[] { ' ' },
    StringSplitOptions.RemoveEmptyEntries));
        }

        private void nederlandsEngelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // We starten het formulier "Testen" op...
            FormTesten frmTesten = new FormTesten();

            // 2 manieren om dit formulier te tonen:
            // frmTesten.Show();
            frmTesten.ShowDialog();
        }


    }
}
