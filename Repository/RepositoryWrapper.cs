using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IAccountRepository _accountRepository;
        private IOwnerRepository _ownerRepository;
       public IAccountRepository AccountRepository
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new AccountRepository(_repoContext);
                return _accountRepository;
            }
        }

        public IOwnerRepository OwnerRepository
        {
            get
            {
                if (_ownerRepository == null)
                    _ownerRepository = new OwnerRepository(_repoContext);
                return _ownerRepository;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
