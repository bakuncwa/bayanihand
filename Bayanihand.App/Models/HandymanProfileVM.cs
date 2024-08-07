namespace Bayanihand.App.Models
{
    public class HandymanProfileVM
    {
        public int HandymanID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BarangayNo { get; set; } = string.Empty;
        public string BarangayName { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZIPCode { get; set; } = string.Empty;
        public decimal SalaryRange { get; set; }
        public decimal YearsOfExperience { get; set; }
    }
}
