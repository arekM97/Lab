using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labki.TagHelpers
{
    [HtmlTargetElement("alert")] // define HTML tag names this class should process
    public class AlertTagHelper : TagHelper // class name doesn’t matter
    {
        public string Type { get; set; }
        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            var className = "alert";
            if (Type == null)
            {
                className += " alert-primary";
            }
            else
            {
                className += $" alert-{ Type}";
            }
            output.TagName = "div"; // replace tag name "alert" with a regular div
            output.Attributes.Add("class", className);
            // TODO make the "primary" color as the helper's parameter
            // HINT: this should be a property of this class
        }
    }
}
