using System;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Api.Models
{
	public class Information:BaseEntity
	{
        public string Title { get; set; }

        public string Description { get; set; }

        public Icon Icon { get; set; }

        public int IconId { get; set; }
    }
}

