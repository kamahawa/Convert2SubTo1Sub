using Add2Sub.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add2Sub
{
    public partial class FrmMain : Form
    {
        OpenFileDialog op;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSub frm = new FrmEditSub();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loadMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(DialogResult.OK == op.ShowDialog())
            {
                _wdmMovie.URL = op.FileName;
                _wdmMovie.Ctlcontrols.play();
            }
        }

        private void _btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (_wdmMovie.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    _wdmMovie.Ctlcontrols.pause();
                }
                else
                {
                    _wdmMovie.Ctlcontrols.play();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSubtitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Subtitle> sub = new List<Subtitle>();
                List<Subtitle> sub1 = new List<Subtitle>();
                op = new OpenFileDialog();
                op.Multiselect = true;
                if (DialogResult.OK == op.ShowDialog())
                {
                    if(op.FileNames.Length > 1)
                    {
                        _lvSub.Items.Clear();
                        //load 2 sub
                        SubtitlesHelper subHelper = new SubtitlesHelper(op.FileNames[0]);
                        sub = subHelper.getSub();
                        SubtitlesHelper subHelper1 = new SubtitlesHelper(op.FileNames[1]);
                        sub1 = subHelper1.getSub();
                        LoadSub(sub, sub1);
                    }
                    else if (op.FileNames.Length == 1)
                    {
                        _lvSub.Items.Clear();
                        SubtitlesHelper subHelper = new SubtitlesHelper(op.FileNames[0]);
                        sub = subHelper.getSub();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSub(List<Subtitle> sub, List<Subtitle> sub1)
        {
            for (int i = 0; i < sub.Count; i++)
            {
                _lvSub.Items.Add(sub[i].Content);
                for (int j = 0; j < sub1.Count; j++)
                {
                    TimeSpan tem = sub[i].StartShow.Subtract(sub1[j].StartShow);
                    if (tem.TotalSeconds <= 1 && tem.TotalSeconds >= -1)
                    {
                        var item = _lvSub.Items.Add(sub1[j].Content);
                        item.BackColor = Color.Beige;
                    }
                }
            }
        }        

        private void convertSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convert2SubTo1Sub frm = new Convert2SubTo1Sub();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void changeSubLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change order 2 sub
            if (op.FileNames.Length > 1)
            {
                _lvSub.Items.Clear();
                List<Subtitle> sub = new List<Subtitle>();
                List<Subtitle> sub1 = new List<Subtitle>();
                //load 2 sub
                SubtitlesHelper subHelper = new SubtitlesHelper(op.FileNames[1]);
                sub = subHelper.getSub();
                SubtitlesHelper subHelper1 = new SubtitlesHelper(op.FileNames[0]);
                sub1 = subHelper1.getSub();
                LoadSub(sub, sub1);
            }
        }
    }
}