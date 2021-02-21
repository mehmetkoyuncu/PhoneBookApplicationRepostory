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
    public class LocationReportService : ILocationReportService
    {
        IUnitOfWork _unitOfWork = new UnitOfWork();
        public LocationReport AddLocationReport(LocationReportItemDTO reportItemDTO)
        {
            LocationReport reportItem = new LocationReport()
            {
                DemandTime = DateTime.Now,
                Id = Guid.NewGuid(),
                Location = reportItemDTO.Location,
                PersonCount = reportItemDTO.PersonCount,
                PhoneCount = reportItemDTO.PhoneCount,
                Status = reportItemDTO.Status,
                CreaatedTime=DateTime.Now
            };

            bool condition = _unitOfWork.ReportRepository.Add(reportItem);
            _unitOfWork.Save();
            return reportItem;
        }

        public List<LocationReportItemDTO> GetListofLocationReport(string locationName)
        {
            List<LocationReportItemDTO> reports = _unitOfWork.ReportRepository.Get(x => x.Location == locationName).
                Select(x => new LocationReportItemDTO
            {
                DemandTime = x.DemandTime,
                Id = x.Id,
                Location = x.Location,
                PersonCount = x.PersonCount,
                PhoneCount = x.PhoneCount,
                Status = x.Status,
                CreaatedTime=DateTime.Now
                
            }).ToList();
            return reports;
        }

        public LocationReport GetLocationReportByItemById(Guid guid)
        {
            return _unitOfWork.ReportRepository.Get(x => x.Id == guid).FirstOrDefault();
        }

        public LocationReport RemandReport(string locationName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLocationReport(Guid id)
        {
            LocationReport reportItem = GetLocationReportByItemById(id);
            reportItem.IsDeleted = true;
            bool condition=_unitOfWork.ReportRepository.Remove(reportItem);
            _unitOfWork.Save();
            return condition;
        }
        public List<LocationReportItemDTO> GetAll()
        {
            return _unitOfWork.ReportRepository.Get(x=>x.IsDeleted==false).Select(x=>new LocationReportItemDTO { 
            CreaatedTime=x.CreaatedTime,
            DemandTime=x.DemandTime,
            Id=x.Id,
            Location=x.Location,
            PersonCount=x.PersonCount,
            PhoneCount=x.PhoneCount,
            Status=x.Status
            }).OrderByDescending(x=>x.CreaatedTime).ToList();
        }
    }
}
