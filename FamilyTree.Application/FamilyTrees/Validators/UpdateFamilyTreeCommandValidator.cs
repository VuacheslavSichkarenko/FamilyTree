﻿using FamilyTree.Application.FamilyTrees.Commands;
using FluentValidation;

namespace FamilyTree.Application.FamilyTrees.Validators
{
    public class UpdateFamilyTreeCommandValidator : AbstractValidator<UpdateFamilyTreeCommand>
    {
        public UpdateFamilyTreeCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .Length(1, 50);
        }
    }
}
