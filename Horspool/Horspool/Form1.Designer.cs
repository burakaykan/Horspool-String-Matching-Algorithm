namespace Horspool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.metingirin = new MaterialSkin.Controls.MaterialLabel();
            this.patterntextfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metineslebutton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.patterngirin = new MaterialSkin.Controls.MaterialLabel();
            this.metintextfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clsallbutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.materialFlatButtonTxrAra = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // metingirin
            // 
            this.metingirin.AutoSize = true;
            this.metingirin.Depth = 0;
            this.metingirin.Font = new System.Drawing.Font("Roboto", 11F);
            this.metingirin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metingirin.Location = new System.Drawing.Point(8, 67);
            this.metingirin.MouseState = MaterialSkin.MouseState.HOVER;
            this.metingirin.Name = "metingirin";
            this.metingirin.Size = new System.Drawing.Size(94, 19);
            this.metingirin.TabIndex = 3;
            this.metingirin.Text = "Metin Girin : ";
            // 
            // patterntextfield
            // 
            this.patterntextfield.Depth = 0;
            this.patterntextfield.Hint = "";
            this.patterntextfield.Location = new System.Drawing.Point(8, 167);
            this.patterntextfield.MaxLength = 32767;
            this.patterntextfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.patterntextfield.Name = "patterntextfield";
            this.patterntextfield.PasswordChar = '\0';
            this.patterntextfield.SelectedText = "";
            this.patterntextfield.SelectionLength = 0;
            this.patterntextfield.SelectionStart = 0;
            this.patterntextfield.Size = new System.Drawing.Size(481, 23);
            this.patterntextfield.TabIndex = 4;
            this.patterntextfield.TabStop = false;
            this.patterntextfield.Text = "Pattern Kutusu";
            this.patterntextfield.UseSystemPasswordChar = false;
            // 
            // metineslebutton1
            // 
            this.metineslebutton1.AutoSize = true;
            this.metineslebutton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metineslebutton1.Depth = 0;
            this.metineslebutton1.Icon = null;
            this.metineslebutton1.Location = new System.Drawing.Point(13, 214);
            this.metineslebutton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.metineslebutton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.metineslebutton1.Name = "metineslebutton1";
            this.metineslebutton1.Primary = false;
            this.metineslebutton1.Size = new System.Drawing.Size(110, 36);
            this.metineslebutton1.TabIndex = 5;
            this.metineslebutton1.Text = "Metinde ARA";
            this.metineslebutton1.UseVisualStyleBackColor = true;
            this.metineslebutton1.Click += new System.EventHandler(this.metineslebutton1_Click);
            // 
            // patterngirin
            // 
            this.patterngirin.AutoSize = true;
            this.patterngirin.Depth = 0;
            this.patterngirin.Font = new System.Drawing.Font("Roboto", 11F);
            this.patterngirin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patterngirin.Location = new System.Drawing.Point(6, 133);
            this.patterngirin.MouseState = MaterialSkin.MouseState.HOVER;
            this.patterngirin.Name = "patterngirin";
            this.patterngirin.Size = new System.Drawing.Size(104, 19);
            this.patterngirin.TabIndex = 6;
            this.patterngirin.Text = "Pattern Girin : ";
            // 
            // metintextfield
            // 
            this.metintextfield.Depth = 0;
            this.metintextfield.Hint = "";
            this.metintextfield.Location = new System.Drawing.Point(12, 99);
            this.metintextfield.MaxLength = 32767;
            this.metintextfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.metintextfield.Name = "metintextfield";
            this.metintextfield.PasswordChar = '\0';
            this.metintextfield.SelectedText = "";
            this.metintextfield.SelectionLength = 0;
            this.metintextfield.SelectionStart = 0;
            this.metintextfield.Size = new System.Drawing.Size(875, 23);
            this.metintextfield.TabIndex = 7;
            this.metintextfield.TabStop = false;
            this.metintextfield.Text = "Metin Kutusu";
            this.metintextfield.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(701, 129);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(186, 23);
            this.materialSingleLineTextField1.TabIndex = 8;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "Eşleşme Kaçıncı Karakterde Başlıyor?";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 344);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 503);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // clsallbutton
            // 
            this.clsallbutton.AutoSize = true;
            this.clsallbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clsallbutton.Depth = 0;
            this.clsallbutton.Icon = null;
            this.clsallbutton.Location = new System.Drawing.Point(753, 299);
            this.clsallbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clsallbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clsallbutton.Name = "clsallbutton";
            this.clsallbutton.Primary = false;
            this.clsallbutton.Size = new System.Drawing.Size(132, 36);
            this.clsallbutton.TabIndex = 13;
            this.clsallbutton.Text = "Hepsini Temizle";
            this.clsallbutton.UseVisualStyleBackColor = true;
            this.clsallbutton.Click += new System.EventHandler(this.clsallbutton_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(166, 214);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(123, 36);
            this.materialFlatButton2.TabIndex = 14;
            this.materialFlatButton2.Text = "Adım Adım Ara";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(16, 268);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(142, 36);
            this.materialFlatButton3.TabIndex = 15;
            this.materialFlatButton3.Text = "Text Dosyası Seç";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(703, 158);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(184, 23);
            this.materialSingleLineTextField2.TabIndex = 17;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "Toplam Karakter Sayısı";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(702, 187);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(185, 23);
            this.materialSingleLineTextField3.TabIndex = 18;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.Text = "Toplam İşlem Süresi";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(491, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(204, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Eşleşme Kaçıncı Karakterde :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(525, 158);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(172, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Toplam Karakter Sayısı :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(542, 191);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(155, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Toplam İşlem Süresi :";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(700, 214);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(186, 23);
            this.materialSingleLineTextField4.TabIndex = 22;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.Text = "Dakika : Saniye : Milisaniye";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(893, 782);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(317, 29);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // materialFlatButtonTxrAra
            // 
            this.materialFlatButtonTxrAra.AutoSize = true;
            this.materialFlatButtonTxrAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonTxrAra.Depth = 0;
            this.materialFlatButtonTxrAra.Icon = null;
            this.materialFlatButtonTxrAra.Location = new System.Drawing.Point(166, 268);
            this.materialFlatButtonTxrAra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonTxrAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonTxrAra.Name = "materialFlatButtonTxrAra";
            this.materialFlatButtonTxrAra.Primary = false;
            this.materialFlatButtonTxrAra.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButtonTxrAra.TabIndex = 25;
            this.materialFlatButtonTxrAra.Text = "Text dosyasında ara";
            this.materialFlatButtonTxrAra.UseVisualStyleBackColor = true;
            this.materialFlatButtonTxrAra.Click += new System.EventHandler(this.materialFlatButtonTxrAra_Click);
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(701, 243);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(186, 23);
            this.materialSingleLineTextField5.TabIndex = 26;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.Text = "Toplam Karşılaştırma";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(700, 272);
            this.materialSingleLineTextField6.MaxLength = 32767;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(186, 23);
            this.materialSingleLineTextField6.TabIndex = 27;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.Text = "Toplam Eşleşme";
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(893, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 719);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(486, 247);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(209, 19);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Toplam Karşılaştırma Sayısı : ";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(516, 276);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(178, 19);
            this.materialLabel7.TabIndex = 30;
            this.materialLabel7.Text = "Toplam Eşleşme Sayısı : ";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(893, 103);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(214, 19);
            this.materialLabel8.TabIndex = 31;
            this.materialLabel8.Text = "Eşleşmelerin İndisleri Listesi : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1222, 859);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialSingleLineTextField6);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Controls.Add(this.materialFlatButtonTxrAra);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.clsallbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.metintextfield);
            this.Controls.Add(this.patterngirin);
            this.Controls.Add(this.metineslebutton1);
            this.Controls.Add(this.patterntextfield);
            this.Controls.Add(this.metingirin);
            this.Name = "Form1";
            this.Text = "Horspool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel metingirin;
        private MaterialSkin.Controls.MaterialSingleLineTextField patterntextfield;
        private MaterialSkin.Controls.MaterialFlatButton metineslebutton1;
        private MaterialSkin.Controls.MaterialLabel patterngirin;
        private MaterialSkin.Controls.MaterialSingleLineTextField metintextfield;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialFlatButton clsallbutton;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonTxrAra;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}

