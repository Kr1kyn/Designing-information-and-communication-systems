using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;
using Unified_State_System_of_Entrants.DAL.Repositories;

namespace Unified_State_System_of_Entrants.BLL
{
    public class HEI_Application : Application
    {
        private Entrant applicationEntrant;
        private HEI applicationHEI;
        public HEI_Application(Entrant entrant, HEI hEI)
        {
            applicationEntrant = entrant;
            applicationHEI = hEI;
        }
        public string CreateApplication()
        {
            var textOfApplication = $"Ректору ВУЗа \"{applicationHEI.Name}\" \nФамилия Имя Отчество {applicationEntrant.Surname} {applicationEntrant.Name}" +
                $" {applicationEntrant.SecondName}, пол {applicationEntrant.Sex}\nГражданство: {applicationEntrant.Citizenship}\n" +
                $"Документ, удостоверяющий личность:{applicationEntrant.IdentityDocument}\nАдресс проживания: {applicationEntrant.ResidentialAddress}\n" +
                $"Тел:{applicationEntrant.Phone} О себе: {applicationEntrant.About}";
            return textOfApplication;
        }
    }
}
