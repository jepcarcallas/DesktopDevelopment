namespace ContactsManager.models
{
    public class Contact
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }

        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public string? Department { get; set; }

        public DateTime Birthday { get; set; }

        public string? ImageName { get; set; }

        public List<string> tasks = new List<string>();

        public string FullName => $"{FirstName} {LastName}";
    }
}
