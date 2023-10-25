namespace hafta1ybs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ad = new Label();
            Adres = new Label();
            yas1 = new Label();
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yas = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            unvanTxt = new ComboBox();
            mesTxt = new TextBox();
            SuspendLayout();
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Location = new Point(35, 56);
            ad.Name = "ad";
            ad.Size = new Size(57, 15);
            ad.TabIndex = 0;
            ad.Text = "Ad Soyad";
            ad.Click += label1_Click;
            // 
            // Adres
            // 
            Adres.AutoSize = true;
            Adres.Location = new Point(35, 120);
            Adres.Name = "Adres";
            Adres.Size = new Size(37, 15);
            Adres.TabIndex = 1;
            Adres.Text = "Adres";
            Adres.Click += label2_Click;
            // 
            // yas1
            // 
            yas1.AutoSize = true;
            yas1.Location = new Point(35, 232);
            yas1.Name = "yas1";
            yas1.Size = new Size(24, 15);
            yas1.TabIndex = 2;
            yas1.Text = "Yaş";
            yas1.Click += yas_Click;
            // 
            // adTxt
            // 
            adTxt.Location = new Point(109, 56);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(151, 23);
            adTxt.TabIndex = 3;
            adTxt.TextChanged += textBox1_TextChanged;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(109, 101);
            adresTxt.Multiline = true;
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(151, 96);
            adresTxt.TabIndex = 4;
            // 
            // yas
            // 
            yas.Location = new Point(109, 232);
            yas.Name = "yas";
            yas.Size = new Size(151, 23);
            yas.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(124, 375);
            button1.Name = "button1";
            button1.Size = new Size(109, 49);
            button1.TabIndex = 6;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 285);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Unvan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 321);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Mesai Saati";
            // 
            // unvanTxt
            // 
            unvanTxt.FormattingEnabled = true;
            unvanTxt.Items.AddRange(new object[] { "İşçi", "Mühendis" });
            unvanTxt.Location = new Point(109, 277);
            unvanTxt.Name = "unvanTxt";
            unvanTxt.Size = new Size(151, 23);
            unvanTxt.TabIndex = 9;
            // 
            // mesTxt
            // 
            mesTxt.Location = new Point(106, 318);
            mesTxt.Name = "mesTxt";
            mesTxt.Size = new Size(154, 23);
            mesTxt.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(mesTxt);
            Controls.Add(unvanTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(yas);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Controls.Add(yas1);
            Controls.Add(Adres);
            Controls.Add(ad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ad;
        private Label Adres;
        private Label yas1;
        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yas;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox unvanTxt;
        private TextBox mesTxt;
    }
}