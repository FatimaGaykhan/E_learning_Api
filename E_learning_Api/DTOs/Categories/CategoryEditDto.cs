using System;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Categories
{
	public class CategoryEditDto
	{
        public string Name { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public string Image { get; set; }

        public IFormFile UploadImage { get; set; }
    }

    public class CategoryEditDtoValidator : AbstractValidator<CategoryEditDto>
    {
        public CategoryEditDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Category Name  is Required");
            RuleFor(x => x.Name).MaximumLength(200).WithMessage("Title Max Length can be 200");


            RuleFor(x => x.UploadImage).NotNull().WithMessage("Upload Image  is Required");


        }

    }
}

