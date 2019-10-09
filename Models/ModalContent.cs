using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    [NotMapped]
    public class ModalContent
    {
        // https://dotnetthoughts.net/how-to-reuse-html-snippets-in-cshtml-view/
        private Func<object, Microsoft.AspNetCore.Html.IHtmlContent> _function;

        public void SetContentFromRazor(Func<object, Microsoft.AspNetCore.Html.IHtmlContent> razor)
        {
            _function = razor;
        }
        public IHtmlContent Content => _function?.Invoke(null);
    }
}
