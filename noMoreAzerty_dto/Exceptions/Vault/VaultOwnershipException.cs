using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class VaultOwnershipException : DomainException
    {
        public VaultOwnershipException()
            : base("User is not the owner of this vault.")
        {
        }
    }
}
