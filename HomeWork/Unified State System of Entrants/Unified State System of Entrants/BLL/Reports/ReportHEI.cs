using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Reports
{
    public class ReportHEI: IReport
    {
        private RankedListApplicants _rankedListApplicants;
        public ReportHEI(RankedListApplicants rankedListApplicants)
        {
            _rankedListApplicants = rankedListApplicants;
        }
        public JsonResult CreateReport()
        {
            var students = _rankedListApplicants.TankedList;
            //string[] textReport = students. .Keys.ToArray();
            /*foreach (var student in students)
            {
                textReport += student.Key + "\n";
            }*/
            return new JsonResult(students);
            /*StringWriter stringWriter = new StringWriter();
            stringWriter.Write(textReport);
            stringWriter.*/
            //var path = @"~/App_data/";
            //var text = new ReadOnlyMemory<string>();
            //text.
            /*using (FileStream file = new FileStream($"{path}{_rankedListApplicants.HEI.Name}'s_ReportFile.txt", FileMode.OpenOrCreate))
            {
                byte[] textInByte = System.Text.Encoding.Default.GetBytes(textReport);
                file.Write(textInByte, 0, textInByte.Length);
            }*/
            //return jsonResult;
            //file.Write(new ReadOnlyMemory<string>(textReport)
        }
    }
}
