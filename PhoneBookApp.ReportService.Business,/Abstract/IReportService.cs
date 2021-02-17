using PhoneBookApp.ReportService.Business_.DTOS;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.Business_.Abstract
{
   public interface IReportService
    {
        List<ReportItemDTO> GetListReport(string locationName);
        bool AddReport(ReportItemDTO reportItem);
        bool RemoveReport(Guid id);
        ReportItem RemandReport(string locationName);
        ReportItem GetReportItemById(Guid guid);
    }
}
