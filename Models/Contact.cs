using System;
namespace contact_manager.Models
{
	public class Contact
	{
		public int ID { get; set; }
		public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}

