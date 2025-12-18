using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class SharedVaultReadOnlyException : DomainException
    {
        public SharedVaultReadOnlyException()
            : base("Shared vaults are read-only.")
        {
        }
    }
}
