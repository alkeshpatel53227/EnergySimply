using EnergySimplyLib.Entities;
using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace EnergySimply.Handlers
{
    /// <summary>
    /// Summary description for SaveFileDb
    /// </summary>
    public class SaveFileDb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string path = "C:/Users/alkes_000/Documents/visual studio 2015/Projects/EnergySimply/EnergySimply/ExcelFile/powertochoose.xlsx";
            var file = new FileInfo(path);
            //FileInfo fi = new FileInfo(openFileDlg.FileName);

            FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);

            BinaryReader rdr = new BinaryReader(fs);

            byte[] fileData = rdr.ReadBytes((int)fs.Length);

            rdr.Close();

            fs.Close();
            var savedFileName = "Powertochoose" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
            DocumentDal dal = new DocumentDal();
            EnergyFile ef = new EnergyFile();
            ef.CreateDate = DateTime.Now;
            ef.FileData = fileData;
            ef.FileName = savedFileName;
            var result = dal.SaveFile(ef);
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}