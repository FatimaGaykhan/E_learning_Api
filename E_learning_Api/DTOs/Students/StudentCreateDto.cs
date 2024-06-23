using System;
using E_learning_Api.DTOs.Instructors;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Students
{
	public class StudentCreateDto
	{
        public string FullName { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public string Image { get; set; }

        public IFormFile UploadImage { get; set; }

        public string Profession { get; set; }

        public string Description { get; set; }

    }

    public class StudentCreateDtoValidator : AbstractValidator<StudentCreateDto>
    {
        public StudentCreateDtoValidator()
        {
            RuleFor(x => x.FullName).NotNull().WithMessage("FullName is Required");
            RuleFor(x => x.FullName).MaximumLength(200).WithMessage("FullName Max Length can be 200");

            RuleFor(x => x.Profession).MaximumLength(400).NotNull().WithMessage("Profession is Required");
            RuleFor(x => x.Profession).MaximumLength(400).WithMessage("Profession Max Length can be 400");

            RuleFor(x => x.Description).MaximumLength(400).NotNull().WithMessage("Description is Required");
            RuleFor(x => x.Description).MaximumLength(400).WithMessage("Description Max Length can be 400");


            RuleFor(x => x.UploadImage).NotNull().WithMessage("Upload Image  is Required");


        }

    }
}

