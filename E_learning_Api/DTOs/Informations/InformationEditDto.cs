using System;
using FluentValidation;

namespace E_learning_Api.DTOs.Informations
{
	public class InformationEditDto
	{
        public string Title { get; set; }

        public string Description { get; set; }

        public string IconClassName { get; set; }
    }

    public class InformationEditDtoValidator : AbstractValidator<InformationEditDto>
    {
        public InformationEditDtoValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Title is Required");

            RuleFor(x => x.Description).NotNull().WithMessage("Description is Required");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Description Max Length can be 200");


            RuleFor(x => x.IconClassName).NotNull().WithMessage("Icon Class name  is Required");


        }

    }
}

