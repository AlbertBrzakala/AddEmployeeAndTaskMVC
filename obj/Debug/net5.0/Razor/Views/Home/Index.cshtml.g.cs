#pragma checksum "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c944dd472069347f85d3864c8b2bcf6c22634b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c944dd472069347f85d3864c8b2bcf6c22634b7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d618a561986a6a07b80e3314140174ce86201f47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aplikacja_ASP_MVC.Infrastructure.ViewModel.EmployeesListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<button class=\"btn btn-secondary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 123, "\"", 194, 3);
            WriteAttributeValue("", 133, "location.href=\'", 133, 15, true);
#nullable restore
#line 3 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 148, Url.Action("OpenAddingEmployee", "Employee"), 148, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 193, "\'", 193, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Dodaj pracownika </button>\r\n<button class=\"btn btn-secondary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 272, "\"", 335, 3);
            WriteAttributeValue("", 282, "location.href=\'", 282, 15, true);
#nullable restore
#line 4 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 297, Url.Action("OpenAddingTask", "Task"), 297, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 334, "\'", 334, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"> Dodaj zadanie </button>

<h3> Lista pracowników:  </h3>

<div class=""container shadow min-vh-100 py-2"">
	<div class=""table-responsive"">
		<table class=""table accordion"">
			<thead>
				<tr>
					<th scope=""col"">Imię</th>
					<th scope=""col"">Nazwisko</th>
					<th scope=""col"">Email</th>
					<th scope=""col"">Stanowisko</th>
				</tr>
			</thead>

			<tbody>
");
#nullable restore
#line 21 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                 foreach (var employee in Model.EmployeesList)
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr data-toggle=\"collapse\" data-target=\"#AA_");
#nullable restore
#line 24 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                            Write(employee.ID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 850, "\"", 900, 1);
#nullable restore
#line 24 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 858, string.Format("toRemove{0}", employee.ID), 858, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t<td width=\"20%\" colspan=\"1\">");
#nullable restore
#line 25 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                               Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td width=\"20%\" colspan=\"1\">");
#nullable restore
#line 26 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                               Write(employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td width=\"20%\" colspan=\"1\">");
#nullable restore
#line 27 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                               Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td width=\"20%\" colspan=\"1\">");
#nullable restore
#line 28 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                               Write(employee.Position.FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td width=\"20%\" colspan=\"2\"><input");
            BeginWriteAttribute("class", " class=\"", 1189, "\"", 1258, 1);
#nullable restore
#line 29 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1197, string.Format("btn btn-secondary btnRemove{0}", employee.ID), 1197, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Usuń pracownika\" type=\"submit\"></td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr");
            BeginWriteAttribute("class", " class=\"", 1325, "\"", 1403, 1);
#nullable restore
#line 31 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1333, string.Format("collapse accordion-collapse toRemove{0}", employee.ID), 1333, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1404, "\"", 1437, 2);
            WriteAttributeValue("", 1409, "AA_", 1409, 3, true);
#nullable restore
#line 31 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1412, employee.ID.ToString(), 1412, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-parent="".table"" data-toggle=""collapse"">

						<th width=""16%"" scope=""col"">Tytuł</th>
						<th width=""16%"" scope=""col"">Opis</th>
						<th width=""16%"" scope=""col"">Status</th>
						<th width=""16%"" scope=""col"">Termin wykonania</th>
						<th width=""16%"" scope=""col""></th>
						<th width=""16%"" scope=""col""></th>

					</tr>
");
#nullable restore
#line 42 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                     foreach (var task in employee.Tasks)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr");
            BeginWriteAttribute("class", " class=\"", 1841, "\"", 1919, 1);
#nullable restore
#line 44 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1849, string.Format("collapse accordion-collapse toRemove{0}", employee.ID), 1849, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1920, "\"", 1953, 2);
            WriteAttributeValue("", 1925, "AA_", 1925, 3, true);
#nullable restore
#line 44 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1928, employee.ID.ToString(), 1928, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\".table\" data-toggle=\"collapse\">\r\n\r\n\t\t\t\t\t\t\t<td width=\"16%\" scope=\"col\" colspan=\"1\"> ");
#nullable restore
#line 46 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                                Write(task.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td width=\"16%\" scope=\"col\" colspan=\"1\"> ");
#nullable restore
#line 47 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                                Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td width=\"16%\"");
            BeginWriteAttribute("class", " class=\"", 2163, "\"", 2220, 1);
#nullable restore
#line 48 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2171, string.Format("statElem{0}", task.ID.ToString()), 2171, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" scope=\"col\" colspan=\"1\"></td>\r\n\t\t\t\t\t\t\t<td width=\"16%\" scope=\"col\" colspan=\"1\"> ");
#nullable restore
#line 49 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                                Write(task.Deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t\t\t\t<td width=\"16%\" class=\"text-center\" scope=\"col\" colspan=\"1\">\r\n\t\t\t\t\t\t\t\t<button");
            BeginWriteAttribute("class", " class=\"", 2407, "\"", 2479, 1);
#nullable restore
#line 51 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2415, string.Format("btn btn-secondary elem1{0}", task.ID.ToString()), 2415, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td width=\"16%\" class=\"text-center\" scope=\"col\" colspan=\"1\">\r\n\t\t\t\t\t\t\t\t<button");
            BeginWriteAttribute("class", " class=\"", 2590, "\"", 2662, 1);
#nullable restore
#line 54 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2598, string.Format("btn btn-secondary elem2{0}", task.ID.ToString()), 2598, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 58 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"

					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                     

				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-ajax-unobtrusive/3.2.6/jquery.unobtrusive-ajax.min.js""></script>
	<script>

		var isCancel = false;

		var firstElement;
		var secondElement;
		var firstBtn;
		var secondBtn;
		var btnToAdd;
		var statusElement;
		var newStatus;

		const listingStatuses = function (status, taskId) {
			switch (status) {
				case 'NEW':
					document.querySelector(`.elem1${taskId}`).textContent = 'IN PROGRESS';
					document.querySelector(`.elem2${taskId}`).textContent = 'CANCELED';
					break;
				case 'IN PROGRESS':
					document.querySelector(`.elem1${taskId}`).textContent = 'TO SPECIFY';
					document.querySelector(`.elem2${taskId}`).textContent = 'TO TEST';
					break;
				case 'REOPENED':
					if (isCancel) {
						document.querySelector(`.elem2${taskId}`).style.visibility = 'visible'
						isCancel = false;
					}
					document.querySelector(`.elem1${taskId}`).textContent = 'IN PROGRESS';
					document.querySelector(`.elem2${taskI");
                WriteLiteral(@"d}`).textContent = 'CANCELED';
					break;
				case 'TO TEST':
					document.querySelector(`.elem1${taskId}`).textContent = 'REOPENED';
					document.querySelector(`.elem2${taskId}`).textContent = 'COMPLETED';
					break;
				case 'TO SPECIFY':
					document.querySelector(`.elem1${taskId}`).textContent = 'REOPENED';
					document.querySelector(`.elem2${taskId}`).textContent = 'COMPLETED';
					break;
				case 'COMPLETED':
					document.querySelector(`.elem1${taskId}`).textContent = 'REOPENED';
					document.querySelector(`.elem2${taskId}`).textContent = 'CANCELED';
					break;
				case 'CANCELED':
					document.querySelector(`.elem1${taskId}`).textContent = 'REOPENED';
					isCancel = true;
					document.querySelector(`.elem2${taskId}`).style.visibility = 'hidden';
					break;
				default:
			}
		}
		const passStatusToController = function (taskId, newStatus) {
			$.ajax({
				url: ""/Task/SaveStatus"",
				type: ""POST"",
				data: { taskId: taskId, status: newStatus },
			});
		}

");
                WriteLiteral("\t\tconst updateBtn = function () {\r\n\r\n");
#nullable restore
#line 131 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
         foreach (var employee in Model.EmployeesList)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 133 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                 Write(string.Format(".btnRemove{0}", employee.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").addEventListener(\"click\", () => {\r\n\t\t\t");
                WriteLiteral("$.ajax({\r\n\t\t\t");
                WriteLiteral("url: \"/Employee/RemoveEmployee\",\r\n\t\t\t");
                WriteLiteral("type: \"POST\",\r\n\t\t\t");
                WriteLiteral("data: { id: ");
#nullable restore
#line 137 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                     Write(employee.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" },\r\n\t\t\t");
                WriteLiteral("success: function () {\r\n\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 139 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                 Write(string.Format(".toRemove{0}", employee.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").remove();\t\t\t\r\n\t\t\t");
                WriteLiteral("}\r\n\t\t\t");
                WriteLiteral("})\r\n\t\t\t");
                WriteLiteral("});\r\n");
#nullable restore
#line 146 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
             foreach (var task in employee.Tasks)
			{


#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 149 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(string.Format(".statElem{0}", task.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").innerHTML = \"");
#nullable restore
#line 149 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                                                            Write(task.Status.FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("listingStatuses(\"");
#nullable restore
#line 151 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                              Write(task.Status.FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 151 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                               Write(task.ID.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 154 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(string.Format(".elem1{0}", task.ID.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").addEventListener(\"click\", () => {\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("newStatus = document.querySelector(\"");
#nullable restore
#line 156 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                 Write(string.Format(".elem1{0}", task.ID.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").textContent;\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("passStatusToController(\"");
#nullable restore
#line 158 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(task.ID.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\", newStatus);\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 160 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(string.Format(".statElem{0}", task.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").textContent= newStatus;\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("listingStatuses(newStatus, \"");
#nullable restore
#line 162 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                         Write(task.ID.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n\t\t\t\t");
                WriteLiteral("});\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 166 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(string.Format(".elem2{0}", task.ID.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").addEventListener(\"click\", () => {\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("newStatus = document.querySelector(\"");
#nullable restore
#line 168 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                                 Write(string.Format(".elem2{0}", task.ID.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").textContent;\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("passStatusToController(\"");
#nullable restore
#line 170 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(task.ID.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\", newStatus);\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("document.querySelector(\"");
#nullable restore
#line 172 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                     Write(string.Format(".statElem{0}", task.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\").textContent= newStatus;\r\n");
                WriteLiteral("\t\t\t\t");
                WriteLiteral("listingStatuses(newStatus, \"");
#nullable restore
#line 174 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
                                         Write(task.ID.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n\t\t\t\t");
                WriteLiteral("});\r\n");
#nullable restore
#line 176 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"




			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\alber\Desktop\Aplikacja ASP MVC\Views\Home\Index.cshtml"
             
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t};\r\n\r\n\t\tupdateBtn();\r\n\r\n\r\n\r\n\r\n\r\n\r\n\t</script>\r\n\t\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aplikacja_ASP_MVC.Infrastructure.ViewModel.EmployeesListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
