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

        public Convert2SubTo1Sub()
        {
            InitializeComponent();
        }

        #region event
        private void _btnLoadEngSub_Click(object sender, EventArgs e)
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
                    while((line = sr.ReadLine()) != null)
                    {
                        _lvSub.Items.Add(line);
                    }
                }
                catch (IOException)
                {

                }
            }

        }

        private void _btnLoadVietSub_Click(object sender, EventArgs e)
        {
            textVietSub = LoadSub();
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

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
