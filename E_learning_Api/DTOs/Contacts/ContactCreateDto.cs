using System;
using E_learning_Api.DTOs.Sliders;
using FluentValidation;

namespace E_learning_Api.DTOs.Contacts
{
	public class ContactCreateDto
	{
        public string Username { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }

    public class ContactCreateDtoValidator : AbstractValidator<ContactCreateDto>
    {
        public ContactCreateDtoValidator()
        {
            RuleFor(x => x.Username).NotNull().WithMessage("Username is Required");

            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage("Email is Required");

            RuleFor(x => x.Subject).NotNull().WithMessage("Subject is Required");
            RuleFor(x => x.Subject).MaximumLength(200).WithMessage("Subject Max Length can be 200");

            RuleFor(x => x.Message).NotNull().WithMessage("Message is Required");
            RuleFor(x => x.Message).MaximumLength(400).WithMessage("Message Max Length can be 400");

        }

    }
}

