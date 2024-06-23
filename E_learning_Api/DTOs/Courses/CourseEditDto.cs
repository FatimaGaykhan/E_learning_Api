using System;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Courses
{
	public class CourseEditDto
	{
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public int Rating { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int InstructorId { get; set; }

        public string Description { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public List<CourseImageDto> Images { get; set; }

        public List<IFormFile> NewImages { get; set; }
    }

    public class CourseEditDtoValidator : AbstractValidator<CourseEditDto>
    {
        public CourseEditDtoValidator()
        {
            RuleFor(x => x.Price).NotNull().WithMessage("Price is Required");

            RuleFor(x => x.Description).MaximumLength(400).NotNull().WithMessage("Description is Required");
            RuleFor(x => x.Description).MaximumLength(400).WithMessage("Description Max Length can be 400");

            RuleFor(x => x.InstructorId).NotNull().WithMessage("Instructor Id is Required");

            RuleFor(x => x.CategoryId).NotNull().WithMessage("Category Id is Required");

            RuleFor(x => x.Rating).NotNull().WithMessage("Rating Id is Required");

            RuleFor(x => x.StartDate).NotNull().WithMessage("StartDate Id is Required");

            RuleFor(x => x.EndDate).NotNull().WithMessage("EndDate Id is Required");

            RuleFor(x => x.Description).NotNull().WithMessage("Upload Image  is Required");


        }
    }
}

