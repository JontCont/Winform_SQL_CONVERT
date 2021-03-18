using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SCM_Convert
{
    class InfoResponse
    {
        public string Result { get; set; }
        public string Message { get; set; }
        public object Num { get; set; }
        public object Data { get; set; }

        public void Set_MesResponse(string status, string message)
        {
            Result = status;
            Message = message;
        }
    }

    class Setting
    {
        public string item { get; set; }
        public string Table { get; set; }
        public string InitialCtr { get; set; }
        public string changeCtr { get; set; }

    }

}
