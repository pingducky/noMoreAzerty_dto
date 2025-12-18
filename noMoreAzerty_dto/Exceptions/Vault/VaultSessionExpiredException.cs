using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class VaultSessionExpiredException : DomainException
    {
        public VaultSessionExpiredException()
            : base("No valid vault session found. Re-authentication required.")
        {
        }
    }
}
