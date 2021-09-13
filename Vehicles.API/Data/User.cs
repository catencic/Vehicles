using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    internal class User
    {
        public string Address { get; set; }
        public string Document { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public object UserType { get; set; }
    }
}