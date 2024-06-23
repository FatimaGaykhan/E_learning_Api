using System;
using E_learning_Api.DTOs.Sliders;
using FluentValidation;

namespace E_learning_Api.DTOs.SocialMedias
{
	public class SocialMediaCreateDto
	{
        public string Name { get; set; }
        public string Icon { get; set; }
    }

    public class SocialMediaCreateDtoValidator : AbstractValidator<SocialMediaCreateDto>
    {
        public SocialMediaCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name is Required");
            RuleFor(x => x.Name).MaximumLength(200).WithMessage("Name Max Length can be 200");


            RuleFor(x => x.Icon).NotNull().WithMessage("Icon is Required");
            RuleFor(x => x.Icon).MaximumLength(200).WithMessage("Icon Max Length can be 200");



        }

    }
}

