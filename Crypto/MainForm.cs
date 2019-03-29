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
using Verschlüsselung;

namespace Crypto
{
    public partial class MainForm : Form
    {
        private int entered = 0;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public MainForm()
        {
            InitializeComponent();

        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            var selectedAlg = comboBoxAlgorithmus.SelectedIndex;
            ICrypto base64 = new Base64();
            ICrypto encrypter = new Rijndael();
            ICrypto rot13 = new Rot13();
            if (entered == 1)
            {
                if (selectedAlg == 0)
                {
                    string encodedText = rot13.Encode(DecodedTextBox.Text);
                    CodedTextBox.Clear();
                    CodedTextBox.Text = encodedText;
                }
                if (selectedAlg == 1)
                {
                    string encodedText = base64.Encode(DecodedTextBox.Text);
                    CodedTextBox.Clear();
                    CodedTextBox.Text = encodedText;
                }
                if (selectedAlg == 2)
                {
                    string encodedText = encrypter.Encode(DecodedTextBox.Text);
                    CodedTextBox.Clear();
                    CodedTextBox.Text = encodedText;
                }
            }
            else
            {
                MessageBox.Show("Es ist kein Algorithmus ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxAlgorithmus.Items.AddRange(new object[] {"Rot13",
                        "Base64",
                        "Rijndael" });
        }

        private void comboBoxAlgorithmus_SelectedIndexChanged(object sender, EventArgs e)
        {
            entered = 1;
        }

        private void chooseDirectory(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Desktop",
                Title = "Zu öffnende Datei",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialogResult.Text = openFileDialog.FileName;
                DecodedTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void chooseDirectoryEncoded(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Desktop",
                Title = "Zu öffnende Datei",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialogResultDecoded.Text = openFileDialog.FileName;
                CodedTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            var selectedAlg = comboBoxAlgorithmus.SelectedIndex;
            ICrypto base64 = new Base64();
            ICrypto encrypter = new Rijndael();
            ICrypto rot13 = new Rot13();
            if (entered == 1)
            {
                if (selectedAlg == 0)
                {
                    string decodedText = rot13.Decode(CodedTextBox.Text);
                    DecodedTextBox.Clear();
                    DecodedTextBox.Text = decodedText;
                }
                if (selectedAlg == 1)
                {
                    string decodedText = base64.Decode(CodedTextBox.Text);
                    DecodedTextBox.Clear();
                    DecodedTextBox.Text = decodedText;
                }
                if (selectedAlg == 2)
                {
                    string decodedText = encrypter.Decode(CodedTextBox.Text);
                    DecodedTextBox.Clear();
                    DecodedTextBox.Text = decodedText;
                }
            }
            else
            {
                MessageBox.Show("Es ist kein Algorithmus ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void saveEncodedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogToSaveEncode = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Datei, in die gespeichert werden soll",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2
            };
            if (openFileDialogToSaveEncode.ShowDialog() == DialogResult.OK)
            {
                dialogResult.Text = openFileDialog.FileName;
                File.WriteAllText(openFileDialogToSaveEncode.FileName, CodedTextBox.Text, Encoding.UTF8);
            }
        }

        private void saveDecodedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogToSaveEncode = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Datei, in die gespeichert werden soll",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2
            };
            if (openFileDialogToSaveEncode.ShowDialog() == DialogResult.OK)
            {
                dialogResult.Text = openFileDialog.FileName;
                File.WriteAllText(openFileDialogToSaveEncode.FileName, DecodedTextBox.Text, Encoding.UTF8);
            }
        }
    }
}
 