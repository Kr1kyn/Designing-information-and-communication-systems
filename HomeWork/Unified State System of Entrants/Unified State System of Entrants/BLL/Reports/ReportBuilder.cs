using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.Reports
{
    class ReportBuilder
    {
        private IReport _report;

        public ReportBuilder(IReport report)
        {
            _report = report;
        }

        public void ChangeReport(IReport report)
        {
            _report = report;
        }

        public JsonResult GetReport()
        {
            return _report.CreateReport();
        }
    }
}
