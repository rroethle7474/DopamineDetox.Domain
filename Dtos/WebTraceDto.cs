using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopamineDetox.Domain.Dtos
{
    public class WebTraceDto
    {
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public string? CallStack { get; set; }
    }
}
