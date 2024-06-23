using System;
using E_learning_Api.DTOs.Sliders;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Instructors
{
	public class InstructorCreateDto
	{
        public string FullName { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public string Image { get; set; }

        public IFormFile UploadImage { get; set; }

        public string Position { get; set; }
    }
    public class InstructorCreateDtoValidator : AbstractValidator<InstructorCreateDto>
    {
        public InstructorCreateDtoValidator()
        {
            RuleFor(x => x.FullName).NotNull().WithMessage("FullName is Required");
            RuleFor(x => x.FullName).MaximumLength(200).WithMessage("FullName Max Length can be 200");

            RuleFor(x => x.Position).MaximumLength(400).NotNull().WithMessage("Position is Required");
            RuleFor(x => x.Position).MaximumLength(400).WithMessage("Position Max Length can be 400");


            RuleFor(x => x.UploadImage).NotNull().WithMessage("Upload Image  is Required");


        }

    }
}

