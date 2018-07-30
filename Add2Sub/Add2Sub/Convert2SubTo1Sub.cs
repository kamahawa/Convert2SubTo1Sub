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
        
        void progress()
        {
            try
            {
                // so thu tu cua sub, bat dau bang 1
                //string sub = "";

                List<Subtitle> Eng = _shEng.getSub();
                List<Subtitle> Viet = _shViet.getSub();
                
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
        #endregion
    }
}
