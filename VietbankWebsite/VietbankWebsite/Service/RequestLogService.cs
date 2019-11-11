using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities.Analytic;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class RequestLogService : IRequestLogService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RequestLogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(RequestLogs item)
        {
            _unitOfWork.RequestLogRepository.Create(item);
        }
    }

    public interface IRequestLogService
    {
        void Create(RequestLogs item);
    }
}
