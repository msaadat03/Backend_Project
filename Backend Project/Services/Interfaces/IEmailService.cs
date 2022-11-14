using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string body, string subject);
    }
}
