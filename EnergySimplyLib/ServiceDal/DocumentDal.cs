using EnergySimplyLib.Entities;
using EnergySimplyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySimplyLib.ServiceDal
{
    public class DocumentDal
    {

        public List<DocumentGridItem> GetAllFiles()
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    var customers = (from c in ctx.EnergySavedFiles
                                     orderby c.CreateDate descending
                                     select new DocumentGridItem()
                                     {
                                         FileId = c.FileId,
                                         FileName = c.FileName,
                                         CreateDate = c.CreateDate
                                         
                                     });
                    if (customers.Any())
                    {
                        return customers.ToList();
                    }
                    else
                    {
                        return new List<DocumentGridItem>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EnergySavedFile SaveFileRecord(EnergySavedFile file)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    ctx.EnergySavedFiles.Add(file);
                    ctx.SaveChanges();
                    return file;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EnergyFile SaveFile(EnergyFile file)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    ctx.EnergyFiles.Add(file);
                    ctx.SaveChanges();
                    return file;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EnergyFile GetFile()
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {

                    return ctx.EnergyFiles.FirstOrDefault() ;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EnergySavedFile GetSavedFile(int fileId)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {

                    return ctx.EnergySavedFiles.Where(c => c.FileId == fileId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
