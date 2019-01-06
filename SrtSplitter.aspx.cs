using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;

namespace SRT_Project
{
    public partial class SrtSplitter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRead_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(FU1.FileName);
            string path = Server.MapPath("~/") + filename;
            FU1.SaveAs(path);
            StreamReader Sr = new StreamReader(path);
            string InnerText = Sr.ReadToEnd();
            Sr.Close();

            string PattrenEn = @"([-@.',?:""/#&+A-Za-z0-9\s]+)";
            string PattrenAr = @"([^a-zA-Z]+)";
            /*(\d+):(\d+):(\d+),(\d+) --> (\d+):(\d+):(\d+),(\d+)*/
            MatchCollection matchesEn = Regex.Matches(InnerText, PattrenEn);
            MatchCollection matchesAr = Regex.Matches(InnerText, PattrenAr);
            foreach (Match m in matchesEn)
            {
                TxtEn.Text +=  m.Value;
            }
            foreach (Match m in matchesAr)
            {
                TxtAr.Text += m.Value;
            }

            var dir = Server.MapPath("~\\TxtSrt");
            var fileEn = Path.Combine(dir, "en.srt");
            var fileAr = Path.Combine(dir, "ar.srt");

            Directory.CreateDirectory(dir);
            File.WriteAllText(fileEn, TxtEn.Text);
            File.WriteAllText(fileAr, TxtAr.Text);

            var _count1 = File.ReadAllText(fileEn);
            var _count2 = File.ReadAllText(fileAr);
            Application["NoOfVisitors"] = _count1;
            Application["NoOfVisitors"] = _count2;

        }
    }
}