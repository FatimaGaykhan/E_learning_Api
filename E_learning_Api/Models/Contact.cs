using System;
namespace E_learning_Api.Models
{
	public class Contact:BaseEntity
	{
        public string Username { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

    }
}

