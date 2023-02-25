using AngleSharp;
using HtmlAgilityPack;
using iTextSharp.tool.xml.html;
using System.Configuration;
using System.Net.Http;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using Configuration = AngleSharp.Configuration;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Network_programming_Dz1
{
    public partial class Form1 : Form
    {
        int totalScore = 0;
        List<string> tag;
        public Form1()
        {
            InitializeComponent();
            Procent.Enabled = false;
            Uniqueness.Enabled = false;
            buttonTag.Enabled= false;
             tag = new List<string>() {"!DOCTYPE",
"a",
"abbr",
"acronym",
"address",
"applet",
"area",
"article",
"aside",
"audio",
"b",
"base",
"basefont",
"bdi",
"bdo",
"bgsound",
"big",
"blink",
"blockquote",
"body",
"br",
"button",
"canvas",
"caption",
"center",
"cite",
"code",
"col",
"colgroup",
"command",
"comment",
"datalist",
"dd",
"del",
"details",
"dfn",
"dir",
"div",
"dl",
"dt",
"em",
"embed",
"fieldset",
"figcaption",
"figure",
"font",
"footer",
"form",
"frame",
"frameset",
"h1",
"h2",
"h3",
"h4",
"h5",
"h6",
"head",
"header",
"hgroup",
"hr",
"html",
"i",
"iframe",
"img",
"input",
"ins",
"isindex",
"<keygen",
"label",
"legend",
"li",
"link",
"listing",
"main",
"map",
"mark",
"marquee",
"menu",
"meta",
"meter",
"multicol",
"nav",
"nobr",
"noembed",
"noframes",
"noscript",
"object",
"ol",
"optgroup",
"option",
"output",
"p",
"param",
"plaintext",
"pre",
"progress",
"q",
"rp",
"rt",
"ruby",
"s",
"samp",
"script",
"section",
"select",
"small",
"source",
"spacer",
"span",
"strike",
"strong",
"style",
"sub",
"summary",
"sup",
"table",
"tbody",
"textarea",
"tfoot",
"th",
"thead",
"time",
"title",
"tr",
"track",
"tt",
"u",
"ul",
"var",
"video",
"wbr",
"xmp" };
            PrintTextBox.ReadOnly = true;
            TextBoxTag.ReadOnly = true;
            textBox1.ReadOnly= true;

        }
        private async void Start_Click(object sender, EventArgs e)
        {
            if ( this.listBox1.SelectedItems.Count != 0)
            {
                string a = listBox1.SelectedItem.ToString();
                HttpClient httpClient1 = new HttpClient();
                using Stream stream1 = await httpClient1.GetStreamAsync(a);
                StreamReader reader1 = new StreamReader(stream1);
                string content = await reader1.ReadToEndAsync();
                PrintTextBox.Text = content;
                buttonTag.Enabled = true;
                TextBoxTag.Clear();
                labelInput.Text = "";
                textBox1.Clear();
                Procent.Enabled = false;
                Uniqueness.Enabled = false;
                textBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Не выбран элемент списка");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
           
            string filename = saveFileDialog1.FileName;
            
            File.WriteAllText(filename, PrintTextBox.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            totalScore = 0;
            string b = listBox1.SelectedItem.ToString();
            string a = PrintTextBox.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(b);
            for (int i = 0; i < tag.Count; i++)
            {
                int TagCount = doc.DocumentNode.Descendants(tag[i]).Count();
                if (TagCount > 0)
                {
                    TextBoxTag.Text +=$" <{tag[i]}>  -  {TagCount.ToString()}\r\n";
                    totalScore += TagCount;
                }
            }
            Procent.Enabled = true;
            Uniqueness.Enabled = true;
            textBox1.ReadOnly = false;
        }

        private void Procent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Введите тег");
            }
            else
            {
                string b = listBox1.SelectedItem.ToString();
                string a = PrintTextBox.Text;
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(b);
                int TagCount = doc.DocumentNode.Descendants(textBox1.Text).Count();
                int c =Convert.ToInt32((Convert.ToSingle(TagCount)/ Convert.ToSingle(totalScore))*100);
                labelInput.Text = c.ToString()+"%";
            }
        }

        private void Uniqueness_Click(object sender, EventArgs e)
        {
            labelInput.Text = "";
            string b = listBox1.SelectedItem.ToString();
            string a = PrintTextBox.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(b);
            int TagCount = doc.DocumentNode.Descendants(textBox1.Text).Count();
            if (TagCount==1)
            {
                labelInput.Text = "Тег  уникален";
            }
            else
            {
                labelInput.Text = "Тег не уникален";
            }
        }
    }
}