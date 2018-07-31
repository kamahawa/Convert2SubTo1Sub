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
using System.Web;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Add2Sub
{
    public partial class FrmTranslate : Form
    {
        static string host = "https://api.cognitive.microsofttranslator.com";
        static string path = "/transliterate?api-version=3.0";
        // Transliterate text in Japanese from Japanese script (i.e. Hiragana/Katakana/Kanji) to Latin script.
        static string params_ = "&language=ja&fromScript=jpan&toScript=latn";

        static string uri = host + path + params_;

        // NOTE: Replace this example key with a valid subscription key.
        static string key = "ENTER KEY HERE";

        // Transliterate "good afternoon".
        static string text = "";

        public FrmTranslate()
        {
            InitializeComponent();
        }

        private void _btnTranslate_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
            op.FilterIndex = 1;

            //op.Multiselect = true;

            // Process input if the user clicked OK.
            if (op.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllText(op.FileName);
                _txtEng.Text = text;

                string[] lines = File.ReadAllLines(op.FileName);
                string translator = "";
                foreach (string line in lines)
                {
                    _txtViet.Text += TranslateGoogle(line, "en", "vi");
                }
            }
        }

        public string TranslateGoogle(string text, string fromCulture, string toCulture)
        {
            fromCulture = fromCulture.ToLower();
            toCulture = toCulture.ToLower();

            // normalize the culture in case something like en-us was passed 
            // retrieve only en since Google doesn't support sub-locales
            string[] tokens = fromCulture.Split('-');
            if (tokens.Length > 1)
                fromCulture = tokens[0];

            // normalize ToCulture
            tokens = toCulture.Split('-');
            if (tokens.Length > 1)
                toCulture = tokens[0];

            string url = string.Format(@"http://translate.google.com/translate_a/t?client=j&text={0}&hl=en&sl={1}&tl={2}",
                                       HttpUtility.UrlEncode(text), fromCulture, toCulture);

            // Retrieve Translation with HTTP GET call
            string html = null;
            try
            {
                WebClient web = new WebClient();

                // MUST add a known browser user agent or else response encoding doen't return UTF-8 (WTF Google?)
                web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");

                // Make sure we have response encoding to UTF-8
                web.Encoding = Encoding.UTF8;
                html = web.DownloadString(url);
            }
            catch (Exception ex)
            {
                //this.ErrorMessage = Westwind.Globalization.Resources.Resources.ConnectionFailed + ": " + ex.GetBaseException().Message;
                return null;
            }

            // Extract out trans":"...[Extracted]...","from the JSON string
            /*
            string result = Regex.Match(html, "trans\":(\".*?\"),\"", RegexOptions.IgnoreCase).Groups[1].Value;

            if (string.IsNullOrEmpty(result))
            {
                //this.ErrorMessage = Westwind.Globalization.Resources.Resources.InvalidSearchResult;
                return null;
            }
            */

            //return WebUtils.DecodeJsString(result);

            // Result is a JavaScript string so we need to deserialize it properly
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize(html, typeof(string)) as string;
        }

    }
}
