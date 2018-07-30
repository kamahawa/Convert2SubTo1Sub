using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Sub.Model
{
    public class SubtitlesHelper
    {
        private string fileName;
        private List<Subtitle> lstSub = new List<Subtitle>();

        public SubtitlesHelper(string fileName)
        {
            this.fileName = fileName;
            LoadSub();
        }

        private void LoadSub()
        {
            string[] lines = System.IO.File.ReadAllLines(this.fileName);
            List<string> lstTemp = new List<string>();
            foreach (string line in lines)
            {
                if(line == "")
                {
                    try
                    {
                        //get start time and end time
                        string[] separatingChars = { " --> " };
                        string[] time = lstTemp[1].Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
                        
                        TimeSpan startTime = DateTime.ParseExact(time[0], "HH:mm:ss,fff", CultureInfo.InvariantCulture).TimeOfDay;                        
                        TimeSpan endTime = DateTime.ParseExact(time[1], "HH:mm:ss,fff", CultureInfo.InvariantCulture).TimeOfDay;

                        //get content sub
                        string content = "";
                        for (int i = 2; i < lstTemp.Count; i++)
                        {
                            content += lstTemp[i];
                        }

                        content = ReplaceTag(content);

                        Subtitle sub = new Subtitle(Int32.Parse(lstTemp[0]), startTime, endTime, content);
                        lstSub.Add(sub);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    lstTemp.Clear();
                }
                else
                {
                    lstTemp.Add(line);
                }
            }
        }

        public List<Subtitle> getSub()
        {
            return lstSub;
        }

        public static string ReplaceTag(string content)
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
