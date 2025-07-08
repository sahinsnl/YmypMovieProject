﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;

namespace YmypMovieProject.Business.Validators;

public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateRequestDto>
{
    public CategoryUpdateValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name cannot be empty.")
            .Length(2, 50).WithMessage("Category name must be between 2 and 50 characters long.");
        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Description cannot be empty.")
            .Length(10, 200).WithMessage("Category description must be between 10 and 200 characters long.");
        RuleFor(c => c.IsActive).NotNull().WithMessage("IsActive cannot be null.");
        RuleFor(c => c.IsDeleted).NotNull().WithMessage("IsDeleted cannot be null.");
    }
}
