using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BO.Utils.Extensions
{
    public static class HtmlHelperExtension
    {

        private static TagBuilder HtmlStart = new TagBuilder("<div class="form - group">");
        private static string HtmlMiddle = "< div class=\"col-md-10\">";
        private static string HtmlEnd = " </ div ></ div >";


        public static MvcHtmlString CustomMvcHtmlStringFor<TModel1, TValue>(
            this HtmlHelper<TModel1> html1, Expression<Func<TModel1, TValue>> expression1)
        {
            return MvcHtmlString.Create(HtmlStart.ToString() +
                                        html1.LabelFor(expression1,
                                            htmlAttributes: new { @class = "control-label col-md-2" }) +
                                        HtmlMiddle +
                                        html1.EditorFor(expression1,
                                            new { htmlAttributes = new { @class = "form-control" } }) +
                                        html1.ValidationMessageFor(expression1, "", new { @class = "text-danger" }) +
                                        HtmlEnd);
        }
        public static MvcHtmlString CustomDropdownHtmlString<TModel1, TValueLabel, TValueSeleted>(
            this HtmlHelper<TModel1> html1,
            Expression<Func<TModel1, TValueLabel>> expression1,
            Expression<Func<TModel1, TValueSeleted>> expressionSeleted,
            IEnumerable<SelectListItem> list)
        {
            return MvcHtmlString.Create(HtmlStart.ToString() +
                                        html1.LabelFor(expression1,
                                            htmlAttributes: new { @class = "control-label col-md-2" }) +
                                        HtmlMiddle +
                                        html1.DropDownListFor(expressionSeleted, list,
                                            new { htmlAttributes = new { @class = "form-control" } })
                                       );
        }
        public static MvcHtmlString CustomButtonSubmitHtmlString<TModel1>(
            this HtmlHelper<TModel1> html1, string label)
        {
            var firstDiv = new TagBuilder("<div>");
            firstDiv.AddCssClass("form-group");
            var seconDiv = new TagBuilder("<div>");
            seconDiv.AddCssClass("col-md-2");
            seconDiv.AddCssClass("col-md-10");
            var input = new TagBuilder("input");
            input.MergeAttribute("type", "submit");
            input.MergeAttribute("value", label);
            input.AddCssClass("btn");
            input.AddCssClass("btn-default");

            seconDiv.InnerHtml = input.ToString(TagRenderMode.SelfClosing);
            firstDiv.InnerHtml = seconDiv.ToString();

            return MvcHtmlString.Create(firstDiv.ToString());


        }
    }
}
