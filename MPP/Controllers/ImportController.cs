﻿using DAL.Common;
using Microsoft.AspNetCore.Mvc;
using Model;
using MPP.Filter;
using MPP.ViewModel;
using System.Data;
using System.Text;

namespace MPP.Controllers
{
    //[SessionTimeoutDimension]
    //[SessionTimeoutEntity]
    //public class ImportController: Controller
    //{
    //    public ActionResult Index() { return View(); }
    //    [AcceptVerbs(HttpVerbs.Post)]
    //    /// <summary>
    //    /// This method is to import data
    //    /// </summary>    
    //    /// <param name="form">form values .</param>
    //    /// <param name="Command">command name for checking button type .</param>
    //    /// <returns> View</returns>
    //    public ActionResult ImportData(FormCollection form, string Command, HttpPostedFileBase file)
    //    {
    //        if (Command == "Import")
    //        {
    //            #region varaiable declaration
    //            bool download = true;
    //            int totalRowcount = 0;
    //            int errorRowcount = 0;
    //            int loadErrorCount = 0;
    //            bool hasLoadErrors = false;
    //            string outMsg = Constant.statusSuccess;
    //            StringBuilder strExport = new StringBuilder();
    //            StringBuilder strDataType = new StringBuilder();
    //            #endregion varaiable declaration
    //            try
    //            {
    //                int entityTypeId = Convert.ToInt32(Session["EntityTypeID"]);
    //                List<ENTITY_TYPE_ATTR_DETAIL> attributeList = new List<ENTITY_TYPE_ATTR_DETAIL>();
    //                attributeList = (List<ENTITY_TYPE_ATTR_DETAIL>)TempData["attributeList"];
    //                TempData.Keep();
    //                string formatedDate = DateTime.Now.ToString("dd-MM-yyyy-hh-mm");

    //                string[] userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split(new[] { "\\" }, StringSplitOptions.None);
    //                string FileName = "I" + userName[1] + Convert.ToString(Session["EntityName"]) + formatedDate + ".csv";
    //                string FilePath = Request.MapPath("") + @"\App_Data\";
    //                string strRejectFileName = "RejI" + userName[1] + Convert.ToString(Session["EntityName"]) + ".csv";
    //                string strRejectFilePath = Request.MapPath("") + @"\App_Data\";
    //                if (!Directory.Exists(FilePath))
    //                    Directory.CreateDirectory(FilePath);
    //                FilePath = FilePath + FileName;
    //                if (!Directory.Exists(strRejectFilePath))
    //                    Directory.CreateDirectory(strRejectFilePath);
    //                strRejectFilePath = strRejectFilePath + strRejectFileName;
    //                ValidateUploadedFile(file, form, out outMsg);
    //                if (outMsg != Constant.statusSuccess)
    //                    return Content("error" + outMsg);
    //                file.SaveAs(FilePath);

    //                foreach (var data in attributeList)
    //                {

    //                    if (data.ISVISIBLE != "N")
    //                    {
    //                        string attrName = attributeList.Where(x => x.ATTR_DATA_TYPE == "SUPPLIED_CODE").Where(y => y.ATTR_NAME == data.ATTR_NAME).Select(x => x.ATTR_NAME).FirstOrDefault();
    //                        if (!string.IsNullOrEmpty(attrName))
    //                        {
    //                            strExport.Append(data.ATTR_NAME + ",");
    //                            strDataType.Append("VARCHAR" + ",");
    //                        }
    //                        if (!(form[data.ATTR_NAME] == "false"))
    //                        {
    //                            strExport.Append(data.ATTR_NAME + ",");
    //                            strDataType.Append(FindDataType(attributeList, data.ATTR_NAME) + ",");
    //                        }
    //                    }
    //                }
    //                if (!(form[Constant.dateFromColumnName] == "false"))
    //                {
    //                    strExport.Append(Constant.dateFromColumnName + ",");
    //                    strDataType.Append("DATE" + ",");
    //                }

    //                int[] ArrayRowsCount = new int[] { 0, 0 };
    //                using (DataImportExportViewModel objDataExportViewModel = new DataImportExportViewModel())
    //                {
    //                    if (form["ddlFileFormat"] == "Excel")
    //                    {
    //                        outMsg = objDataExportViewModel.LoadExcelToTable2(attributeList, entityTypeId, FilePath, "", strExport.ToString().Trim(','), true, "", "", true,
    //                    userName[1].ToString(), 1, strRejectFilePath, strDataType.ToString().Trim(','), out ArrayRowsCount, out loadErrorCount,
    //                    out hasLoadErrors, out download);
    //                    }
    //                    else if (form["ddlFileFormat"] == "Csv")
    //                    {
    //                        outMsg = objDataExportViewModel.LoadFlatFileToTable(attributeList, entityTypeId, FilePath, strExport.ToString().Trim(','), true, ",",
    //                             userName[1].ToString(), 1, strRejectFilePath, strDataType.ToString().Trim(','), out ArrayRowsCount,
    //                             out loadErrorCount, out hasLoadErrors, out download);
    //                    }
    //                    if (outMsg != Constant.statusSuccess && hasLoadErrors == false)
    //                        return Content("error" + outMsg);
    //                    totalRowcount = ArrayRowsCount[0];
    //                    errorRowcount = ArrayRowsCount[1];

    //                }

    //                errorRowcount = errorRowcount + loadErrorCount;
    //                int successRowCount = totalRowcount - errorRowcount;
    //                if (successRowCount > 0)
    //                {
    //                    SendMail(successRowCount.ToString(), out outMsg);
    //                }
    //                if ((errorRowcount != 0 || hasLoadErrors == true) && download == true)
    //                {
    //                    TempData["filepath"] = strRejectFilePath;
    //                    string path = System.Configuration.ConfigurationManager.AppSettings["FileDownLoadPath"];

    //                    return Content("import," + Convert.ToString(Session["EntityName"]) + "," + strRejectFilePath);
    //                }

    //                else if (download == true)
    //                {
    //                    return Content("success" + Constant.importSuccessFullyMessage);
    //                }

    //            }
    //            catch (Exception ex)
    //            {
    //                using (LogErrorViewModel objLogErrorViewModel = new LogErrorViewModel())
    //                {
    //                    objLogErrorViewModel.LogErrorInTextFile(ex);
    //                }
    //                return Content("error" + Constant.commonErrorMsg);

    //            }

    //        }
    //        #region cancelUpdateCommand
    //        else if (Command == "Cancel")
    //        {
    //            return RedirectToRoute(new { controller = "Menu", action = "ShowAttribute", entityTypeId = Convert.ToInt32(Session["EntityTypeID"]), entityName = Convert.ToString(Session["EntityName"]), viewType = "search" });
    //        }
    //        #endregion
    //        return Content("");
    //    }
    //    private string FindDataType(List<ENTITY_TYPE_ATTR_DETAIL> attributeList, string attrName)
    //    {
    //        string dataType = attributeList.Where(y => y.ATTR_NAME == attrName).Select(x => x.ATTR_DATA_TYPE).FirstOrDefault();
    //        string rDataType = string.Empty; ;
    //        switch (dataType)
    //        {
    //            case "VARCHAR":
    //            case "VC":
    //            case "PARENT_CODE":
    //            case "SUPPLIED_CODE":
    //                rDataType = "VARCHAR";
    //                break;
    //            case "NUMERIC":
    //            case "INTEGER":
    //            case "DECIMAL":
    //            case "N":
    //                rDataType = "NUMERIC";
    //                break;
    //            case "DATE":
    //            case "DATETIME":
    //            case "DT":
    //                rDataType = "DATE";
    //                break;
    //        }
    //        return rDataType;
    //    }
    //    [HttpGet]
    //    public ActionResult Download(string path)
    //    {
    //        try
    //        {
    //            string[] userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split(new[] { "\\" }, StringSplitOptions.None);
    //            string FileName = "RejI" + userName[1] + path.Split(',')[1] + ".csv";
    //            Response.Clear();
    //            Response.ContentType = "application/vnd.ms-excel";
    //            Response.AddHeader("Content-Disposition",
    //            "attachment; filename=\"" + FileName + "\"");
    //            Response.Flush();
    //            Response.WriteFile(path.Split(',')[2]);
    //            Response.End();
    //            return Content("");
    //        }
    //        catch (Exception ex)
    //        {
    //            using (LogErrorViewModel objLogErrorViewModel = new LogErrorViewModel())
    //            {
    //                objLogErrorViewModel.LogErrorInTextFile(ex);
    //            }
    //            return Content(ex.Message + ex.StackTrace);
    //        }

    //    }

    //    private void ValidateUploadedFile(HttpPostedFileBase file, FormCollection form, out string outMsg)
    //    {
    //        outMsg = Constant.statusSuccess;
    //        if (file == null)
    //            outMsg = "Please Select the Source File.";
    //        else
    //        {
    //            switch (Path.GetExtension(Path.GetFileName(file.FileName)).ToUpper())
    //            {
    //                case ".CSV":
    //                    if (form["ddlFileFormat"] != "Csv")
    //                        outMsg = "Selected File Type and file are mismatched.";
    //                    break;
    //                case ".XLSX":
    //                    if (form["ddlFileFormat"] != "Excel")
    //                        outMsg = "Selected File Type and file are mismatched.";
    //                    break;
    //                case ".XLS":
    //                    if (form["ddlFileFormat"] != "Excel")
    //                        outMsg = "Selected File Type and file are mismatched.";
    //                    break;
    //                default:
    //                    outMsg = "Please choose appropriate file either excel or Csv.";
    //                    break;
    //            }

    //        }
    //    }

    //}
}
