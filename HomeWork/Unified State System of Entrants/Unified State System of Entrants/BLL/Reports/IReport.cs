using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.Reports
{
    public interface IReport
    {
        public JsonResult CreateReport();
    }
}
