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
using System.Runtime.InteropServices;

namespace Add2Sub
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public int MakeLong(short lowPart, short highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }

        public void ListViewItem_SetSpacing(ListView listview, short leftPadding, short topPadding)
        {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            SendMessage(listview.Handle, LVM_SETICONSPACING, IntPtr.Zero, (IntPtr)MakeLong(leftPadding, topPadding));
        }

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
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = true;
                if (DialogResult.OK == op.ShowDialog())
                {
                    if(op.FileNames.Length > 1)
                    {
                        //load 2 sub
                        SubtitlesHelper subHelper = new SubtitlesHelper(op.FileNames[0]);
                        sub = subHelper.getSub();
                        SubtitlesHelper subHelper1 = new SubtitlesHelper(op.FileNames[1]);
                        sub1 = subHelper1.getSub();
                        LoadSub(sub);
                        LoadSub(sub1);
                    }
                    else if (op.FileNames.Length == 1)
                    {
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

        private void LoadSub(List<Subtitle> sub)
        {
            ListViewItem_SetSpacing(_lvSub, 432 + 32, 599 + 16);
            for (int i = 0; i < sub.Count; i++)
            {
                string content = sub[i].Content;
                try
                {
                    content = ReplaceTag(content);                                       
                }
                catch(Exception ex)
                { }
                var item = _lvSub.Items.Add(content);
                item.BackColor = (_lvSub.Items.Count % 2 == 0) ? Color.Beige : Color.White;
            }
        }

        private string ReplaceTag(string content)
        {
            while (content.Contains("<") && content.Contains(">"))
            {
                int start = content.IndexOf("<");
                int end = content.IndexOf(">");
                string result = content.Substring(start, end - start + 1);
                content = content.Replace(result, "");
            }
            return content;
        }
    }
}