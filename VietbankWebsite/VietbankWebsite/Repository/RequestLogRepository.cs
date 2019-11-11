using VietbankWebsite.Context;
using VietbankWebsite.Entities.Analytic;

namespace VietbankWebsite.Repository
{
    public class RequestLogRepository : IRequestLogRepository
    {
        private readonly VietbankContext _context;
        public RequestLogRepository(VietbankContext context)
        {
            _context = context;
        }
        public void Create(RequestLogs item)
        {
            _context.RequestLogs.Add(item);
            _context.SaveChanges();
        }
    }

    public interface IRequestLogRepository
    {
        void Create(RequestLogs item);
    }
}
