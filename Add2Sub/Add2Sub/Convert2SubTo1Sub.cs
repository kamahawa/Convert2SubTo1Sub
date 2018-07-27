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

namespace Add2Sub
{
    public partial class Convert2SubTo1Sub : Form
    {

        string textEngSub = "";
        string textVietSub = "";

        List<string> _lstSubEng, _lstSubViet;

        public Convert2SubTo1Sub()
        {
            InitializeComponent();

            _lstSubEng = new List<string>();
            _lstSubViet = new List<string>();
        }

        #region event
        private void _btnLoadEngSub_Click(object sender, EventArgs e)
        {
            try
            {
                //textEngSub = LoadSub();
                OpenFileDialog op = new OpenFileDialog();
                //op.InitialDirectory = @"E:\Friends";
                // Set filter options and filter index.
                op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
                op.FilterIndex = 1;

                //op.Multiselect = true;

                // Process input if the user clicked OK.
                if (op.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(op.FileName);
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            //_lvSub.Items.Add(line);
                            _lstSubEng.Add(line);
                        }
                    }
                    catch (IOException)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnLoadVietSub_Click(object sender, EventArgs e)
        {
            try
            {
                //textEngSub = LoadSub();
                OpenFileDialog op = new OpenFileDialog();
                //op.InitialDirectory = @"E:\Friends";
                // Set filter options and filter index.
                op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
                op.FilterIndex = 1;

                //op.Multiselect = true;

                // Process input if the user clicked OK.
                if (op.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(op.FileName);
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            //_lvSub.Items.Add(line);
                            _lstSubViet.Add(line);
                        }
                    }
                    catch (IOException)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnProgress_Click(object sender, EventArgs e)
        {
            progress();
        }
        #endregion

        #region progress

        string LoadSub()
        {
            string sub = "";
            // Create an instance of the open file dialog box.
            OpenFileDialog op = new OpenFileDialog();
            //op.InitialDirectory = @"E:\Friends";
            // Set filter options and filter index.
            op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
            op.FilterIndex = 1;

            //op.Multiselect = true;

            // Process input if the user clicked OK.
            if (op.ShowDialog() == DialogResult.OK)
            {
                string file = op.FileName;
                try
                {
                    sub = File.ReadAllText(file);
                }
                catch (IOException)
                {

                }
            }
            return sub;
        }

        void progress()
        {
            try
            {
                // so thu tu cua sub, bat dau bang 1
                int sttSubEng = 1;
                int sttSubViet = 1;
                int lineOld = 0;
                string s = "";
                for (int i = 0; i < _lstSubEng.Count; i++)
                {
                    if (Int32.TryParse(_lstSubEng.ElementAt(i), out sttSubEng))
                    {
                        for(int j = lineOld; j < _lstSubViet.Count; j++)
                        {
                            if (Int32.TryParse(_lstSubViet.ElementAt(j), out sttSubViet))
                            {



                                i += 2;
                                s += _lstSubEng.ElementAt(i);
                                _lvSub.Items.Add(_lstSubEng.ElementAt(i));
                                while(_lstSubEng.ElementAt(++i) != "")
                                {
                                    s += _lstSubEng.ElementAt(i);
                                    _lvSub.Items.Add(_lstSubEng.ElementAt(i));
                                }
                                //Cong xuong dong
                                s += "\r\n";

                                j += 2;
                                s += _lstSubViet.ElementAt(j);
                                _lvSub.Items.Add(_lstSubViet.ElementAt(j));
                                while (_lstSubViet.ElementAt(++j) != "")
                                {
                                    s += _lstSubViet.ElementAt(j);
                                    _lvSub.Items.Add(_lstSubViet.ElementAt(j));
                                }
                                s += "\r\n";
                                lineOld = j;
                                break;
                            }
                        }
                    }
                }
                _txtSub.Text = s;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
