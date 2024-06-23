using System;
using E_learning_Api.Models;

namespace E_learning_Api.DTOs.Informations
{
	public class InformationDto
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ClassName { get; set; }
    }
}

