﻿using DAL.Common;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;

namespace DAL
{
    public class Mail_Manager : IDisposable
    {
        void IDisposable.Dispose()
        {

        }
        #region GetMailDetails
        public Mail_Master GetMailDetails(int EventId, out string outMSg)
        {
            Mail_Master objMailMaster = new Mail_Master();
            outMSg = Constant.statusSuccess;
            try
            {
                string Query = "SELECT SUBJECT AS MailSubject,BODYTEXT AS MailBody FROM MPP_CORE.MPP_EMAIL_DETAILS WHERE EVENT_ID=" + EventId;
                using (MPP_Context objMPP_Context = new MPP_Context())
                {
                    objMailMaster = objMPP_Context.Set<Mail_Master>().FromSqlRaw(Query).FirstOrDefault(); ;
                }
            }
            catch (Exception ex)
            {
                using (LogError objLogError = new LogError())
                {
                    objLogError.LogErrorInTextFile(ex);
                }
                outMSg = ex.Message;
            }
            return objMailMaster;
        }
        #endregion GetMailDetails
    }
}
