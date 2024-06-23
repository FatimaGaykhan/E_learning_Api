using System;
using E_learning_Api.DTOs.Sliders;
using FluentValidation;

namespace E_learning_Api.DTOs.Settings
{
	public class SettingEditDto
	{
        public string Key { get; set; }

        public string Value { get; set; }
    }

    public class SettingEditDtoValidator : AbstractValidator<SettingEditDto>
    {
        public SettingEditDtoValidator()
        {
            RuleFor(x => x.Key).NotNull().WithMessage("Key  is Required");

            RuleFor(x => x.Value).NotNull().WithMessage("Value  is Required");




        }

    }
}

