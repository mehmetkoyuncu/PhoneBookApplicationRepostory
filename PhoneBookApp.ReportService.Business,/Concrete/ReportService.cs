using PhoneBookApp.ReportService.Business_.Abstract;
using PhoneBookApp.ReportService.Business_.DTOS;
using PhoneBookApp.ReportService.DataAccess.Abstract;
using PhoneBookApp.ReportService.DataAccess.Concrete;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp.ReportService.Business_.Concrete
{
    public class ReportService : IReportService
    {
        IUnitOfWork _unitOfWork = new UnitOfWork();
        public bool AddReport(ReportItemDTO reportItemDTO)
        {
            ReportItem reportItem = new ReportItem()
            {
                DemandTime = DateTime.Now,
                Id = Guid.NewGuid(),
                Location = reportItemDTO.Location,
                PersonCount = reportItemDTO.PersonCount,
                PhoneCount = reportItemDTO.PhoneCount,
                Status = reportItemDTO.Status
            };
            bool condition = _unitOfWork.ReportRepository.Add(reportItem);
            _unitOfWork.Save();
            return condition;
        }

        public List<ReportItemDTO> GetListReport(string locationName)
        {
            List<ReportItemDTO> reports = _unitOfWork.ReportRepository.Get(x => x.Location == locationName).Select(x => new ReportItemDTO
            {
                DemandTime = x.DemandTime,
                Id = x.Id,
                Location = x.Location,
                PersonCount = x.PersonCount,
                PhoneCount = x.PhoneCount,
                Status = x.Status,
                
            }).ToList();
            return reports;
        }

        public ReportItem GetReportItemById(Guid guid)
        {
            return _unitOfWork.ReportRepository.Get(x => x.Id == guid).FirstOrDefault();
        }

        public ReportItem RemandReport(string locationName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveReport(Guid id)
        {
            ReportItem reportItem = GetReportItemById(id);
            bool condition = _unitOfWork.ReportRepository.Remove(reportItem);
            return condition;
        }
    }
}
