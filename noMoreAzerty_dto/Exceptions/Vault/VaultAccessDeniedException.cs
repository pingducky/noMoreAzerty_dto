using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class VaultAccessDeniedException : DomainException
    {
        public VaultAccessDeniedException()
            : base("User does not have access to this vault.")
        {
        }
    }
}
