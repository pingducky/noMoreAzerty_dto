using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noMoreAzerty_dto.DTOs.Request
{
    public class CreateVaultRequest
    {
        public string Name { get; set; } = null!;

        public string DerivedPassword { get; set; } = null!;

        public string PasswordSalt { get; set; } = null!;
    }
}
