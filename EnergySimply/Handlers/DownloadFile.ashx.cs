using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnergySimply.Handlers
{
    /// <summary>
    /// Summary description for DownloadFile
    /// </summary>
    public class DownloadFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (!string.IsNullOrEmpty(context.Request.QueryString["fileId"]))
            {
                int itemid = int.Parse(context.Request.QueryString["fileId"].ToString());
                DocumentDal dal = new DocumentDal();
                var result = dal.GetSavedFile(itemid);
                var fileItem = dal.GetFile();
                context.Response.Clear();
                context.Response.AddHeader("content-disposition",
                    string.Format("attachment; filename=\"{0}\"", result.FileName));
                context.Response.ContentType = "application/vnd.ms-excel";
                context.Response.Write(fileItem.FileData);
                context.Response.Flush();
                context.Response.End();
            }
            else
            {
                context.Response.ContentType = "text/plain";
                 context.Response.Write("Fileot be found!");
                }

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