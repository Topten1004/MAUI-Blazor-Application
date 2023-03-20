namespace ReDpett_API.Modal
{
    public class Projects
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
        public int Status { get; set; }
        public List<FileData> File_Att_Info { get; set; }
    }
}
