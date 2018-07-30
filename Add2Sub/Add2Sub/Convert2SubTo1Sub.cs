using Add2Sub.Model;
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
        SubtitlesHelper _shEng, _shViet;

        List<Subtitle> Eng;
        List<Subtitle> Viet;

        public Convert2SubTo1Sub()
        {
            InitializeComponent();            
        }

        #region event
        private void _btnLoadEngSub_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                //op.InitialDirectory = @"E:\Friends";
                // Set filter options and filter index.
                op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
                op.FilterIndex = 1;

                //op.Multiselect = true;

                // Process input if the user clicked OK.
                if (op.ShowDialog() == DialogResult.OK)
                {
                    _shEng = new SubtitlesHelper(op.FileName);
                    Eng = _shEng.getSub();
                    for(int i = 0; i < Eng.Count; i++)
                    {
                        _lvSub.Items.Add(Eng[i].Content);
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
                    _shViet = new SubtitlesHelper(op.FileName);
                    Viet = _shViet.getSub();
                    for (int i = 0; i < Viet.Count; i++)
                    {
                        _lvSub.Items.Add(Viet[i].Content);
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

        private void _btnExport_Click(object sender, EventArgs e)
        {
            Export2Excel();
        }
        #endregion

        #region progress

        void progress()
        {
            try
            {
                // so thu tu cua sub, bat dau bang 1
                //string sub = "";
                
                _pbSub.Maximum = Eng.Count;

                for (int i = 0; i < Eng.Count; i++)
                {
                    //sub += Eng[i].Content + "\r\n";
                    _lv2Sub.Items.Add(Eng[i].Content);
                    for (int j = 0; j < Viet.Count; j++)
                    {
                        TimeSpan tem = Eng[i].StartShow.Subtract(Viet[j].StartShow);
                        if(tem.TotalSeconds <= 1 && tem.TotalSeconds >= -1)
                        {
                            //sub += Viet[j].Content + "\r\n";
                            var item = _lv2Sub.Items.Add(Viet[j].Content);
                            item.BackColor = Color.Beige;
                        }
                    }
                    _pbSub.Value = i;
                }
                
                //_txtSub.Text = sub;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Export2Excel()
        {
            try
            {
                //lvPDF is nothing but the listview control name
                string[] st = new string[_lv2Sub.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@"D:\PDFExtraction\");
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(@"D:\PDFExtraction\sub.xls", false);
                sw.AutoFlush = true;
                for (int col = 0; col < _lv2Sub.Columns.Count; col++)
                {
                    sw.Write("\t" + _lv2Sub.Columns[col].Text.ToString());
                }

                int rowIndex = 1;
                int row = 0;
                string st1 = "";
                for (row = 0; row < _lv2Sub.Items.Count; row++)
                {
                    if (rowIndex <= _lv2Sub.Items.Count)
                        rowIndex++;
                    st1 = "\n";
                    for (int col = 0; col < _lv2Sub.Columns.Count; col++)
                    {
                        st1 = st1 + "\t" + "'" + _lv2Sub.Items[row].SubItems[col].Text.ToString();
                    }
                    sw.WriteLine(st1);
                }
                sw.Close();
                FileInfo fil = new FileInfo(@"c:\PDFExtraction\sub.xls");
                if (fil.Exists == true)
                    MessageBox.Show("Process Completed", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion
    }
}
