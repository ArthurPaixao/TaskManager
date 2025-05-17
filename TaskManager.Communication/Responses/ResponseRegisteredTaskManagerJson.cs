using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Communication.Responses
{
    public class ResponseRegisteredTaskManagerJson
    {
        public int Id { get; set; }
        public string Name  { get; set; } = string.Empty;
    }
}
