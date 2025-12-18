using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.VaultEntry
{
    public sealed class VaultEntryNotFoundException : DomainException
    {
        public Guid EntryId { get; }

        public VaultEntryNotFoundException(Guid entryId)
            : base($"Vault entry '{entryId}' not found.")
        {
            EntryId = entryId;
        }
    }

}
