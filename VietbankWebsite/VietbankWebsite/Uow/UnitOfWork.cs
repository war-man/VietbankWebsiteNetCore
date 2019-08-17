using System;
using VietbankWebsite.Context;
using VietbankWebsite.Repository;

namespace VietbankWebsite.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VietbankContext _context;
        public IVbBannerRepository _vbBannerRepository;
        public IShareholderRepository _shareholderRepository;
        public IVbBannerRepository VbBannerRepository => _vbBannerRepository = _vbBannerRepository ?? new VbBannerRepository(_context);
        public IShareholderRepository ShareholderRepository => _shareholderRepository = _shareholderRepository ?? new ShareholderRepository(_context);


        public void Complete()
        {
            _context.SaveChanges();
        }

        #region IDisposable Support
        private bool _disposedValue;

        public UnitOfWork(VietbankContext context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }

    public interface IUnitOfWork : IDisposable
    {
        IVbBannerRepository VbBannerRepository { get; }
        IShareholderRepository ShareholderRepository { get; }
        void Complete();
    }
}
