using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.VaultEntry
{
    public sealed class VaultEntryMismatchException : DomainException
    {
        public VaultEntryMismatchException()
            : base("Vault entry does not belong to this vault.")
        {
        }
    }
}
