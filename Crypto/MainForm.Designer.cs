namespace Crypto
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncode = new System.Windows.Forms.Button();
            this.comboBoxAlgorithmus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dialogResult = new System.Windows.Forms.MaskedTextBox();
            this.DecodedTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.saveDecodedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodedTextBox = new System.Windows.Forms.RichTextBox();
            this.saveEncodedButton = new System.Windows.Forms.Button();
            this.dialogResultDecoded = new System.Windows.Forms.MaskedTextBox();
            this.EncodedDatei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(135, 326);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(88, 23);
            this.buttonEncode.TabIndex = 0;
            this.buttonEncode.Text = "Verschlüsseln";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // comboBoxAlgorithmus
            // 
            this.comboBoxAlgorithmus.FormattingEnabled = true;
            this.comboBoxAlgorithmus.Location = new System.Drawing.Point(198, 87);
            this.comboBoxAlgorithmus.Name = "comboBoxAlgorithmus";
            this.comboBoxAlgorithmus.Size = new System.Drawing.Size(386, 21);
            this.comboBoxAlgorithmus.TabIndex = 1;
            this.comboBoxAlgorithmus.Text = "wähle einen Algorithmus aus..";
            this.comboBoxAlgorithmus.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithmus_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Datei wählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.chooseDirectory);
            // 
            // dialogResult
            // 
            this.dialogResult.Location = new System.Drawing.Point(12, 39);
            this.dialogResult.Name = "dialogResult";
            this.dialogResult.Size = new System.Drawing.Size(282, 20);
            this.dialogResult.TabIndex = 3;
            this.dialogResult.Text = "Dateipfad";
            // 
            // DecodedTextBox
            // 
            this.DecodedTextBox.Location = new System.Drawing.Point(12, 144);
            this.DecodedTextBox.Name = "DecodedTextBox";
            this.DecodedTextBox.Size = new System.Drawing.Size(386, 176);
            this.DecodedTextBox.TabIndex = 4;
            this.DecodedTextBox.Text = "";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(536, 326);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(88, 23);
            this.buttonDecode.TabIndex = 5;
            this.buttonDecode.Text = "Entschlüsseln";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // saveDecodedButton
            // 
            this.saveDecodedButton.Location = new System.Drawing.Point(135, 355);
            this.saveDecodedButton.Name = "saveDecodedButton";
            this.saveDecodedButton.Size = new System.Drawing.Size(88, 23);
            this.saveDecodedButton.TabIndex = 6;
            this.saveDecodedButton.Text = "sichern";
            this.saveDecodedButton.UseVisualStyleBackColor = true;
            this.saveDecodedButton.Click += new System.EventHandler(this.saveDecodedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entschlüsselt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(410, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Verschlüsselt";
            // 
            // CodedTextBox
            // 
            this.CodedTextBox.Location = new System.Drawing.Point(413, 144);
            this.CodedTextBox.Name = "CodedTextBox";
            this.CodedTextBox.Size = new System.Drawing.Size(348, 176);
            this.CodedTextBox.TabIndex = 9;
            this.CodedTextBox.Text = "";
            // 
            // saveEncodedButton
            // 
            this.saveEncodedButton.Location = new System.Drawing.Point(536, 355);
            this.saveEncodedButton.Name = "saveEncodedButton";
            this.saveEncodedButton.Size = new System.Drawing.Size(88, 23);
            this.saveEncodedButton.TabIndex = 10;
            this.saveEncodedButton.Text = "sichern";
            this.saveEncodedButton.UseVisualStyleBackColor = true;
            this.saveEncodedButton.Click += new System.EventHandler(this.saveEncodedButton_Click);
            // 
            // dialogResultDecoded
            // 
            this.dialogResultDecoded.Location = new System.Drawing.Point(413, 39);
            this.dialogResultDecoded.Name = "dialogResultDecoded";
            this.dialogResultDecoded.Size = new System.Drawing.Size(246, 20);
            this.dialogResultDecoded.TabIndex = 11;
            this.dialogResultDecoded.Text = "Dateipfad";
            // 
            // EncodedDatei
            // 
            this.EncodedDatei.Location = new System.Drawing.Point(657, 39);
            this.EncodedDatei.Name = "EncodedDatei";
            this.EncodedDatei.Size = new System.Drawing.Size(104, 22);
            this.EncodedDatei.TabIndex = 12;
            this.EncodedDatei.Text = "Datei wählen";
            this.EncodedDatei.UseVisualStyleBackColor = true;
            this.EncodedDatei.Click += new System.EventHandler(this.chooseDirectoryEncoded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 446);
            this.Controls.Add(this.EncodedDatei);
            this.Controls.Add(this.dialogResultDecoded);
            this.Controls.Add(this.saveEncodedButton);
            this.Controls.Add(this.CodedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveDecodedButton);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.DecodedTextBox);
            this.Controls.Add(this.dialogResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAlgorithmus);
            this.Controls.Add(this.buttonEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verschlüssler und Entschlüssler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.ComboBox comboBoxAlgorithmus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox dialogResult;
        private System.Windows.Forms.RichTextBox DecodedTextBox;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button saveDecodedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox encodedTextBox;
        private System.Windows.Forms.RichTextBox CodedTextBox;
        private System.Windows.Forms.Button saveEncodedButton;
        private System.Windows.Forms.MaskedTextBox dialogResultDecoded;
        private System.Windows.Forms.Button EncodedDatei;
    }
}

