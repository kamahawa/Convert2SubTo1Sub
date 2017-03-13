using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add2Sub
{
    public partial class Form1 : Form
    {
        string title = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadEngsub_Click(object sender, EventArgs e)
        {
            txtEngsub.Text = LoadFileSub();
            string[] temp = title.Split('\\');
            txtTitle.Text = temp[temp.Length - 1];// title;
        }

        private void btnLoadVietsub_Click(object sender, EventArgs e)
        {
            txtVietsub.Text = LoadFileSub();
        }

        private string LoadFileSub()
        {
            string textSub = "";
            // Create an instance of the open file dialog box.
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = @"E:\Friends";
            // Set filter options and filter index.
            op.Filter = "Text Files (.srt)|*.srt|All Files (*.*)|*.*";
            op.FilterIndex = 1;

            op.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = op.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                string file = op.FileName;
                title = file;
                try
                {
                    textSub = File.ReadAllText(file);
                }
                catch (IOException)
                {

                }
            }

            return textSub;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            if(txtEngsub.Text == "" || txtVietsub.Text == "")
            {
                MessageBox.Show("sub is null");
                return;
            }
            ProcessSub();
            CreateDocument();
        }

        private void ProcessSub()
        {
            //string engsub = txtEngsub.Text.Split("\r\n");
            //string vietsub = txtVietsub.Text;
            
            /*
            string line;
            System.IO.StreamReader stream = new System.IO.StreamReader(file);
            while ((line = stream.ReadLine()) != null)
            {
                if (IsNumber(line))
                {

                }
                textSub += line + "\r\n";//Environment.NewLine
            }
            */
        }

        private void CreateDocument()
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = txtTitle.Text;//"Header text goes here";
                }

                /*
                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Footer text goes here";
                }
                 * */

                /*
                //adding text to document
                document.Content.SetRange(0, 0);
                document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Para 1 text";
                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();
                 * */

                //them, neu lay o tren thi bo cai nay
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                //Create a 5X5 table and insert some dummy record
                Table firstTable = document.Tables.Add(para1.Range, 2, 2, ref missing, ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row
                        if (cell.RowIndex == 1)
                        {
                            if(cell.ColumnIndex == 1)
                            {
                                cell.Range.Text = "Engsub";//"Column " + cell.ColumnIndex.ToString();
                            }
                            else
                            {
                                cell.Range.Text = "Vietsub";
                            }
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row
                        else
                        {
                            if (cell.ColumnIndex == 1)
                            {
                                cell.Range.Text = txtEngsub.Text;
                            }
                            else
                            {
                                cell.Range.Text = txtVietsub.Text;
                            }
                            //cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                        }
                    }
                }

                //Save the document
                object filename = @"E:\Friends\documents\"+ txtTitle.Text +".docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
