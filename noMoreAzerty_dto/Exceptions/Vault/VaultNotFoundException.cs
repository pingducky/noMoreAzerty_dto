using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class VaultNotFoundException : DomainException
    {
        public Guid VaultId { get; }

        public VaultNotFoundException(Guid vaultId)
            : base($"Vault '{vaultId}' not found.")
        {
            VaultId = vaultId;
        }
    }
}
