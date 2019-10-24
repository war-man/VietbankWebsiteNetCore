using System;
using VietbankWebsite.Context;
using VietbankWebsite.Repository;

namespace VietbankWebsite.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VietbankContext _context;
        public IHomeRepository _homeRepository;
        public IShareholderRepository _shareholderRepository;
        public IAboutVietbankRepository _aboutVietbankRepository;
        public IProductRepository _productRepository;
        public ICardRepository _cardRepository;
        public ICareersRepository _careersRepository;
        public IBranchRepository _branchRepository;
        public ISupportRepository _supportRepository;
        public IVbPostSeoRepository _vbPostSeoRepository;
        public IHomeRepository HomeRepository => _homeRepository = _homeRepository ?? new HomeRepository(_context);
        public IShareholderRepository ShareholderRepository => _shareholderRepository = _shareholderRepository ?? new ShareholderRepository(_context);
        public IAboutVietbankRepository AboutVietbankRepository => _aboutVietbankRepository = _aboutVietbankRepository ?? new AboutVietbankRepository(_context);
        public IProductRepository ProductRepository => _productRepository = _productRepository ?? new ProductRepository(_context);
        public ICardRepository CardRepository => _cardRepository = _cardRepository ?? new CardRepository(_context);
        public ICareersRepository CareersRepository => _careersRepository = _careersRepository ?? new CareersRepository(_context);
        public IBranchRepository BranchRepository => _branchRepository = _branchRepository ?? new BranchRepository(_context);
        public ISupportRepository SupportRepository => _supportRepository = _supportRepository ?? new SupportRepository(_context);
        public IVbPostSeoRepository VbPostSeoRepository => _vbPostSeoRepository = _vbPostSeoRepository ?? new VbPostSeoRepository(_context);
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
        IHomeRepository HomeRepository { get; }
        IShareholderRepository ShareholderRepository { get; }
        IProductRepository ProductRepository { get; }
        ICardRepository CardRepository { get; }
        ICareersRepository CareersRepository { get; }
        IBranchRepository BranchRepository { get; }
        ISupportRepository SupportRepository { get; }
        IVbPostSeoRepository VbPostSeoRepository { get; }
        void Complete();
    }
}
