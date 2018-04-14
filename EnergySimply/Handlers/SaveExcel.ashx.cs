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
    /// Summary description for SaveExcel
    /// </summary>
    public class SaveExcel : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string path = "C:/Users/alkes_000/Documents/visual studio 2015/Projects/EnergySimply/EnergySimply/ExcelFile/powertochoose.xlsx";
            //var basePath = VirtualPathUtility.GetDirectory(context.Request.Url.AbsolutePath);
            var basePath = context.Request.Url.ToString();
            var bp = basePath.Substring(0, basePath.IndexOf("Handlers"));
            var fullPath = Path.Combine(bp, @"ExcelFile/powertochoose.xlsx");
            //var fullPath = Path.Combine(bp, @"ExcelFile/powertochoose.xlsx");
            // Hard coded but you can easily get from url parameters
            // string path = context.Request["path"];

            var file = new FileInfo(path);
            DocumentDal dal = new DocumentDal();
            // You should check for file.Exists !
            var savedFileName = "Powertochoose"+ DateTime.Now.ToString("yyyyMMddHHmmss")+".xls";
            EnergySavedFile sf = new EnergySavedFile();
            sf.CreateDate = DateTime.Now;
            sf.FileName = savedFileName;
            var result = dal.SaveFileRecord(sf);
            //context.Response.Clear();
            //context.Response.AddHeader("content-disposition",
            //    string.Format("attachment; filename=\"{0}\"", savedFileName));
            //context.Response.AddHeader("content-disposition", "attachment; filename=excelData.xls");
           // context.Response.ContentType = "application/vnd.ms-excel";
           // context.Response.WriteFile(file.FullName, false);
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