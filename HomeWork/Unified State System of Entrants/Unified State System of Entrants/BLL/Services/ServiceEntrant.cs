using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;
using AutoMapper;
using System.Net.Http;
using System.IO;
using Unified_State_System_of_Entrants.BLL.Interfaces;
using System.Net;
using iTextSharp.text.pdf;
using System.Net.Http.Headers;

namespace Unified_State_System_of_Entrants.BLL.Services
{
    public class ServiceEntrant
    {
        private IRepositoryEntrant repositoryEntrant;
        private IRepositoryHEI repositoryHEI;
        public ServiceEntrant(IRepositoryEntrant repositoryEntrant, IRepositoryHEI repositoryHEI)
        {
            this.repositoryEntrant = repositoryEntrant;
            this.repositoryHEI = repositoryHEI;
        }

        public void CreateEntrant(Entrant_DTO entrant_DTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Entrant_DTO, Entrant>()).CreateMapper();
            repositoryEntrant.AddEntrant(mapper.Map<Entrant_DTO, Entrant>(entrant_DTO));
        }

        /*
         {
  "name": "Имя",
  "surname": "Фамилия",
  "secondName": "Отчество",
  "sex": "мужской",
  "citizenship": "Россия",
  "identityDocument": "Паспорт РФ",
  "residentialAddress": "Санкт-Петербург",
  "phone": "8-800-555-35-35",
  "about": "first"
}
        */

        public string CreateApplication(int userId, int HEI_Id)
        {
            ApplicationCreater hEI_ApplicationCreater = new HEI_ApplicationCreater(repositoryEntrant.GetById(userId), repositoryHEI.GetById(HEI_Id));
            Application application = hEI_ApplicationCreater.returnApplication();

            return application.CreateApplication();
            /*string fileName;
            string localFilePath;
            int fileSize;

            localFilePath = getFileFromID(id, out fileName, out fileSize);*/

            /*var document = new iTextSharp.text.Document();
            using (var writer = PdfWriter.GetInstance(document, new FileStream("Application.pdf", FileMode.Create)))
            {
                document.Open();

                var helvetica = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
                var helveticaBase = helvetica.GetCalculatedBaseFont(false);
                writer.DirectContent.BeginText();
                writer.DirectContent.SetFontAndSize(helveticaBase, 12f);
                writer.DirectContent.ShowTextAligned(iTextSharp.text.Element.ALIGN_LEFT, application.CreateApplication(), 35, 766, 0);
                writer.DirectContent.EndText();

                document.Close();
                writer.Close();
                //return writer;
            }
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(new FileStream("Application.pdf", FileMode.Open));
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = "Application";
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

            return response;*/
        }
    }
}
