using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Data.Dtos;
using Restaurant.API.Converters;
using FluentValidation;

namespace Restaurant.API.Validators
{
    /// <summary>
    /// 
    /// </summary>
    public class ReservationValidator : AbstractValidator<ReservationDto>
    {
        /// <summary>
        /// 
        /// </summary>
        public ReservationValidator()
        {

            RuleFor(x => x.Description).NotEmpty();

            When(x => !string.IsNullOrEmpty(x.Description) || !string.IsNullOrEmpty(x.ReservationStatusId.ToString()),
                () => {

                    RuleFor(x => x.Description).NotEmpty();
                    RuleFor(x => x.ReservationStatusId).NotEmpty();
                });
        }

    }
}
