namespace RecordKeeper
{
    public class Tenant 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }

    }

    public class TenantSecurityInfo 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhoneNumber { get; set; }
    }

    public class TenantStayInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Room { get; set; }
        public double Rent { get; set; }
    }
}
