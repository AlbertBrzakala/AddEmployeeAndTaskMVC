#pragma checksum "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09822455608f2ba36ea61004dbf4fd98ce9f428a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_OpenAddingTask), @"mvc.1.0.view", @"/Views/Task/OpenAddingTask.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\_ViewImports.cshtml"
using Aplikacja_ASP_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\_ViewImports.cshtml"
using Aplikacja_ASP_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09822455608f2ba36ea61004dbf4fd98ce9f428a", @"/Views/Task/OpenAddingTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d618a561986a6a07b80e3314140174ce86201f47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_OpenAddingTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aplikacja_ASP_MVC.Infrastructure.ViewModel.TaskViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui-themes-1.13.2/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui-1.13.2/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3> Dodawanie zadań </h3>\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
     using (Html.BeginForm("SaveTask", "Task"))
	{

		

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 10 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.Label("Tytuł","Tytuł", new { @class = "control-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 11 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 12 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<br />\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 16 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.Label("Opis", "Opis", new { @class = "control-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 17 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.TextBoxFor(model => model.Description, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 18 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.ValidationMessageFor(model => model.Description, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<br />\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 22 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.Label("Termin wykonania", "Termin wykonania", new { @class = "control-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 23 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.EditorFor(model => model.Deadline, new { htmlAttributes = new
		{
		Value =  Model.Deadline.ToString("dd-MM-yyyy"),
		@class= "form-control"
		}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 28 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.ValidationMessageFor(model => model.Deadline, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<br />\r\n");
            WriteLiteral("\t\t<div class=\"mb-3\">\r\n\t\t\t");
#nullable restore
#line 33 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.Label("Pracownik","Pracownik", new {@class= "form -label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09822455608f2ba36ea61004dbf4fd98ce9f428a8532", async() => {
                WriteLiteral("\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.EmployeesSelectList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedEmployee);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 39 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
       Write(Html.Label("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\t\t\t<select name=\"status\">\r\n");
#nullable restore
#line 43 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
                 foreach (var status in Model.Status)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09822455608f2ba36ea61004dbf4fd98ce9f428a11153", async() => {
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
                                        Write(status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
                       WriteLiteral(status);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</select>\r\n\t\t</div>\r\n\t\t<br />\r\n\t\t<input class=\"btn btn-secondary\" type=\"submit\" value=\"Dodaj zadanie\" />\r\n");
#nullable restore
#line 52 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Task\OpenAddingTask.cshtml"

	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09822455608f2ba36ea61004dbf4fd98ce9f428a13628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09822455608f2ba36ea61004dbf4fd98ce9f428a14805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.12/jquery.validate.unobtrusive.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.13.2/jquery-ui.min.js""></script>	
	<script type=""text/javascript"">
		$(document).ready(function () {
			$('.datepicker').datepicker({
				changeMonth: true,
				changeYear: true,
			});
		});

	</script>
    ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aplikacja_ASP_MVC.Infrastructure.ViewModel.TaskViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591