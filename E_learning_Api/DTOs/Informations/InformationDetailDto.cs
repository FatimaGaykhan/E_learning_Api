using System;
using E_learning_Api.DTOs.Contacts;
using FluentValidation;

namespace E_learning_Api.DTOs.Informations
{
	public class InformationDetailDto
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ClassName { get; set; }

        public string CreatedDate { get; set; }

    }

    
}

