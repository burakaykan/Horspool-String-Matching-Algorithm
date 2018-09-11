using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Diagnostics;

namespace Horspool
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Random rnd = new Random();
        private void metineslebutton1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Test();
            sw.Stop();
            string ExecutionTimeTaken = string.Format("{0} dk:{1} sn:{2} milisn", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            materialSingleLineTextField3.Text = ExecutionTimeTaken;
        }
        public void Test()
        {
            BoyerMooreHorspool bmh = new BoyerMooreHorspool();

            string haystack = metintextfield.Text;



            string needle = patterntextfield.Text;

            //int match = bmh.Find(haystack, needle);
            List<int> match = new List<int>();
            match = bmh.Find(haystack, needle);

            if (true)
            {
                if (match == null)
                {
                    materialSingleLineTextField1.Text = "Eşleşme Yok!";
                    return;
                }

                materialSingleLineTextField1.Text = listBox1.SelectedItem + ". Karakterde eşleme var";

                richTextBox1.Text = haystack;
                //arbitrary numbers to test
                for (int i = 0; i < match.Count; i++)
                {
                      int blockLength = patterntextfield.TextLength;
                      richTextBox1.SelectionStart = match[i];
                      richTextBox1.SelectionLength = blockLength;
                      richTextBox1.SelectionBackColor = Color.Yellow;
                }
                   int chars = metintextfield.Text.Length;
                   materialSingleLineTextField2.Text = chars.ToString();
                   materialSingleLineTextField5.Text = bmh.Karsi().ToString();
                   materialSingleLineTextField6.Text = bmh.Esle().ToString();
                   listBox1.DataSource = match;
                
            }
            
        }


        private void clsallbutton_Click(object sender, EventArgs e)
        {
            metintextfield.Text = string.Empty;
            patterntextfield.Text = string.Empty;
            materialSingleLineTextField1.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            materialSingleLineTextField2.Text = string.Empty;
            materialSingleLineTextField3.Text = string.Empty;
            richTextBox2.Text = string.Empty;
            materialSingleLineTextField5.Text = string.Empty;
            materialSingleLineTextField6.Text = string.Empty;
            listBox1.DataSource=null;
            
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
          //  Test1();
        }
        //public void Test1()
        //{
        //    BoyerMooreHorspool bmh = new BoyerMooreHorspool();

        //    string haystack = metintextfield.Text;

        //    List<int> match = new List<int>();


        //    string needle = patterntextfield.Text;

        //    if (haystack.Length > 25)
        //    {
        //        richTextBox1.Text = "metin 25 karakterden büyük";
        //    }
        //    else
        //    {
        //        int match = bmh.Find(haystack, needle);


        //        if (match == -1)
        //        {
        //            materialSingleLineTextField1.Text = "Eşleşme Yok!";
        //            return;
        //        }

        //        materialSingleLineTextField1.Text = match + ". Karakterde eşleme var";


        //        string bosluk = "X";
        //        for (int i = 0; i < match - 1; i++)
        //        {
        //            bosluk = bosluk + "X";
        //        }
        //        string isaret = bosluk;
        //        for (int i = 0; i < needle.Length; i++)
        //        {
        //            isaret = isaret + "^";
        //        }

        //        //richTextBox1.Text = haystack;
        //        //for (int i = 0; i < match; i++)
        //        //{richTextBox1.Text = haystack + System.Environment.NewLine + isaret;
        //        //}

        //        //deneme burada başlıyor


        //        Dictionary<char, int> BadMatchTable = new Dictionary<char, int>();

        //        // Initializes every letter with the default value
        //        foreach (char c in haystack)
        //        {
        //            if (!BadMatchTable.Keys.Contains(c))
        //                BadMatchTable.Add(c, needle.Length);
        //        }

        //        // The formula for every letter in the needle (except the last) is lenght - index - 1
        //        for (int i = 0; i < needle.Length - 1; i++)
        //        {
        //            BadMatchTable[needle[i]] = needle.Length - i - 1;
        //        }
        //        string xsayaci = "";
        //        int index = 0;
        //        richTextBox2.Text = haystack + System.Environment.NewLine + needle;

        //        while (index <= haystack.Length - needle.Length)
        //        {

        //            for (int i = needle.Length - 1; i >= 0; i--)
        //            {

        //                if (needle[i] != haystack[index + i])
        //                {
        //                    index += BadMatchTable[haystack[index + needle.Length - 1]];

        //                    for (int k = 0; k < 1; k++)
        //                    {
        //                        richTextBox2.Text = ("\n" + haystack);
        //                        for (int l = 0; l < index; l++)
        //                        {

        //                            xsayaci = xsayaci + "X";
        //                        }
        //                        richTextBox2.Text = (xsayaci);
        //                        richTextBox2.Text = (needle);
        //                    }
        //                }

        //            }

        //        }


        //    }

        //}

        private async void materialFlatButton3_Click(object sender, EventArgs e)
        {
            string textveri = "";
            try
            {

                metintextfield.Text = string.Empty;
                patterntextfield.Text = string.Empty;
                materialSingleLineTextField1.Text = string.Empty;
                richTextBox1.Text = string.Empty;
                materialSingleLineTextField2.Text = string.Empty;
                materialSingleLineTextField3.Text = string.Empty;

                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Dosyaları | *.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            textveri = await sr.ReadToEndAsync();
                        }
                    }
                }
                string textveri2 = textveri;
                richTextBox2.Text = textveri;
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        

        private void materialFlatButtonTxrAra_Click(object sender, EventArgs e)
        {
            {
                Test3();
            }
            void Test3()
            {
                BoyerMooreHorspool bmh = new BoyerMooreHorspool();

                string textveri = richTextBox2.Text;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                string haystack = textveri;
                List<int> match = new List<int>();



                string needle = patterntextfield.Text;
                match = bmh.Find(haystack, needle);

                if (true)
                {
                    if (match == null)
                    {
                        materialSingleLineTextField1.Text = "Eşleşme Yok!";
                        return;
                    }

                    materialSingleLineTextField1.Text = listBox1.SelectedItem + ". Karakterde eşleme var";

                    richTextBox1.Text = haystack;
                    //arbitrary numbers to test
                    for (int i = 0; i < match.Count; i++)
                    {
                        int blockLength = patterntextfield.TextLength;
                        richTextBox1.SelectionStart = match[i];
                        richTextBox1.SelectionLength = blockLength;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    

                }
                sw.Stop();
                string ExecutionTimeTaken = string.Format("{0} dk:{1} sn:{2} milisn", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
                materialSingleLineTextField3.Text = ExecutionTimeTaken;
                materialSingleLineTextField2.Text = haystack.Length.ToString();
                int chars = metintextfield.Text.Length;
                materialSingleLineTextField2.Text = chars.ToString();
                materialSingleLineTextField5.Text = bmh.Karsi().ToString();
                materialSingleLineTextField6.Text = bmh.Esle().ToString();
                listBox1.DataSource = match;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            int blockLength = patterntextfield.TextLength;
            richTextBox1.SelectionStart = Convert.ToInt32(listBox1.SelectedItem);
            richTextBox1.SelectionLength = blockLength;
            richTextBox1.SelectionBackColor = randomColor;
        }
    }
}