using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EuroXam.Core.Utils
{
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
