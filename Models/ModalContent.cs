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
        public enum ModalWidth { Fit, _50};

        // https://dotnetthoughts.net/how-to-reuse-html-snippets-in-cshtml-view/
        private IHtmlContent _content;

        public void SetContentFromRazor(Func<object, Microsoft.AspNetCore.Html.IHtmlContent> razor)
        {
            _content = razor?.Invoke(null); ;
        }
        public IHtmlContent Content
        {
            get => _content;
            set
            {
                _content = value;
            }
        }

        public ModalWidth Width { get; set; } = ModalWidth.Fit;
    }
}
