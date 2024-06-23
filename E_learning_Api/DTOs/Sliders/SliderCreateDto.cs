using System;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace E_learning_Api.DTOs.Sliders
{
	public class SliderCreateDto
	{
		public string Title { get; set; }

		public string Subject { get; set; }

		public string Description { get; set; }

		[SwaggerSchema(ReadOnly =true)]
		public string Image { get; set; }

		public IFormFile UploadImage { get; set; }

	}
	public class SliderCreateDtoValidator: AbstractValidator<SliderCreateDto>
	{
		public SliderCreateDtoValidator()
		{
			RuleFor(x => x.Title).NotNull().WithMessage("Title Fatya is Required");
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Title Max Length can be 200");

            RuleFor(x => x.Description).MaximumLength(400).NotNull().WithMessage("Description Fatya is Required");
			RuleFor(x => x.Description).MaximumLength(400).WithMessage("Description Max Length can be 400");

            RuleFor(x => x.Subject).NotNull().WithMessage("Subject Fatya is Required");
            RuleFor(x => x.Subject).MaximumLength(200).WithMessage("Subject Max Length can be 200");

            RuleFor(x => x.UploadImage).NotNull().WithMessage("Upload Image  is Required");


        }

    }
}

