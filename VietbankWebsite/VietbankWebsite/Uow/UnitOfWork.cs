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
        public IAboutVietbankRepository _aboutVietbankRepository;
        public IPersonalRepository _personalRepository;
        public ICardRepository _cardRepository;
        public IVbBannerRepository VbBannerRepository => _vbBannerRepository = _vbBannerRepository ?? new VbBannerRepository(_context);
        public IShareholderRepository ShareholderRepository => _shareholderRepository = _shareholderRepository ?? new ShareholderRepository(_context);
        public IAboutVietbankRepository AboutVietbankRepository => _aboutVietbankRepository = _aboutVietbankRepository ?? new AboutVietbankRepository(_context);
        public IPersonalRepository PersonalRepository => _personalRepository = _personalRepository ?? new PersonalRepository(_context);
        public ICardRepository CardRepository => _cardRepository = _cardRepository ?? new CardRepository(_context);
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
        IAboutVietbankRepository AboutVietbankRepository { get; }
        IVbBannerRepository VbBannerRepository { get; }
        IShareholderRepository ShareholderRepository { get; }
        IPersonalRepository PersonalRepository { get; }
        ICardRepository CardRepository { get; }
        void Complete();
    }
}
