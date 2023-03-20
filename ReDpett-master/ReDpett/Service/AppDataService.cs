using ReDpett.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDpett.Service
{
    //public interface IAppDataService
    //{
    //     string FETP { get; set; }

    //     string CohortNumber { get; set; }
    //     string CohortEndDate { get; set; }
    //     string CohortStartDate { get; set; }
    //     string ResidentName { get; set; }
    //     string Given_FirstName { get; set; }
    //     string MiddleName { get; set; }
    //     string Sur_LastName { get; set; }
    //     string DOB { get; set; }
    //     int Age { get; set; }
    //     string Sex { get; set; }
    //     string Email { get; set; }
    //     string Phone { get; set; }
    //     string Professional_Background { get; set; }
    //     string Employer { get; set; }
    //     string JobTitle { get; set; }
    //     int YearsOnJob { get; set; }
    //     string SupervisorName { get; set; }
    //     string SiteAddress { get; set; }
    //     string City { get; set; }
    //     string State_Region_Pro { get; set; }
    //     string Postal_Zip { get; set; }
    //     string Country { get; set; }
    //     string RPFL19_Longitude { get; set; }
    //     string RPFL20_Latitude { get; set; }
    //     string Secondary_Subnational_Unit { get; set; }
    //     string Tertiary_Subnational_Unit { get; set; }
    //     string FacilityName { get; set; }
    //     string FacilityLevel { get; set; }
    //     string GUID { get; set; }
    //     int Status { get; set; }
    //     List<FileData> File_Att_Info { get; set; }

    //}

    public class AppDataService 
    {
        public string FETP { get; set; }
        
        public string CohortNumber { get; set; }
        public string CohortEndDate { get; set; }
        public string CohortStartDate { get; set; }
        public string ResidentName { get; set; }
        public string Given_FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Sur_LastName { get; set; }
        public string DOB { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Professional_Background { get; set; }
        public string Employer { get; set; }
        public string JobTitle { get; set; }
        public int YearsOnJob { get; set; }
        public string SupervisorName { get; set; }
        public string SiteAddress { get; set; }
        public string City { get; set; }
        public string State_Region_Pro { get; set; }
        public string Postal_Zip { get; set; }
        public string Country { get; set; }
        public string RPFL19_Longitude { get; set; }
        public string RPFL20_Latitude { get; set; }
        public string Secondary_Subnational_Unit { get; set; }
        public string Tertiary_Subnational_Unit { get; set; }
        public string FacilityName { get; set; }
        public string FacilityLevel { get; set; }
        public string GUID { get; set; }
        public int Status { get; set; } = 0;
        public List<FileData> File_Att_Info { get; set; }

    }

    public class ListAppDataService
    {
        public List<AppDataService> appDataServices { get; set; }
    }
}
