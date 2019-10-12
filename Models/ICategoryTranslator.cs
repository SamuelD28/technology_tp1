using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public interface ICategoryTranslator
    {
        string Translate(Category category, string language = null);
    }

    public class AspNetCoreICategoryTranslator : ICategoryTranslator
    {
        private IStringLocalizer<AspNetCoreICategoryTranslator> _localizer;

        public AspNetCoreICategoryTranslator(IStringLocalizer<AspNetCoreICategoryTranslator> stringLocalizer)
        {
            _localizer = stringLocalizer;
        }

        public string Translate(Category category, string language = null)
        {
            var personalizedLocalizer = String.IsNullOrEmpty(language) ? _localizer : _localizer.WithCulture(new System.Globalization.CultureInfo(language));
            switch (category)
            {
                case Category.Pizza:
                    return personalizedLocalizer["Pizza"];
                case Category.Drink:
                    return personalizedLocalizer["Drink"];
                case Category.Dessert:
                    return personalizedLocalizer["Dessert"];
                case Category.Other:
                    return personalizedLocalizer["Other"];
                default:
                    return null;
            }
        }
    }
}
