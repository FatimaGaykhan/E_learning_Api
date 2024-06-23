using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Informations
{
	public class InformationCreateDto
	{
        public string Title { get; set; }

        public string Description { get; set; }

        public string IconClassName { get; set; }

    }

    public class InformationCreateDtoValidator : AbstractValidator<InformationCreateDto>
    {
        public InformationCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Title is Required");

            RuleFor(x => x.Description).NotNull().WithMessage("Description is Required");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Description Max Length can be 200");


            RuleFor(x => x.IconClassName).NotNull().WithMessage("Icon Class name  is Required");


        }

    }
}

