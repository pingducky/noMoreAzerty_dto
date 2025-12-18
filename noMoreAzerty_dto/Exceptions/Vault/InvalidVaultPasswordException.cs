using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.Exceptions.Vault
{
    public sealed class InvalidVaultPasswordException : DomainException
    {
        public InvalidVaultPasswordException()
            : base("Incorrect vault password.")
        {
        }
    }
}
