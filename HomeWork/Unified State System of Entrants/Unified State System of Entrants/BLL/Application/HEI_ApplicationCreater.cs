using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.Interfaces;
using iTextSharp;
using iTextSharp.text.pdf;
using System.IO;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL
{
    class HEI_ApplicationCreater : ApplicationCreater
    {
        public Application returnApplication(Entrant entrant, HEI hEI)
        {
            return new HEI_Application(entrant, hEI);
        }
    }
}
