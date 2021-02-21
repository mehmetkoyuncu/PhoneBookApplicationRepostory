using PhoneBookApp.ReportService.Business_.DTOS;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.Business_.Abstract
{
   public interface ILocationReportService
    {
        List<LocationReportItemDTO> GetListofLocationReport(string locationName);
        LocationReport AddLocationReport(LocationReportItemDTO reportItem);
        bool RemoveLocationReport(Guid id);
        LocationReport GetLocationReportByItemById(Guid guid);
        List<LocationReportItemDTO> GetAll();
    }
}
