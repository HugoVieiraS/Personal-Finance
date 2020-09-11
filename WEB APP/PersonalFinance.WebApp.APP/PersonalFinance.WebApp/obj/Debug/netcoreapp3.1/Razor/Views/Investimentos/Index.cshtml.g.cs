#pragma checksum "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260cc02e2fd89fd73b94b0463d9fc6b6305544cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Investimentos_Index), @"mvc.1.0.view", @"/Views/Investimentos/Index.cshtml")]
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
#line 1 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\_ViewImports.cshtml"
using PersonalFinance.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\_ViewImports.cshtml"
using PersonalFinance.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260cc02e2fd89fd73b94b0463d9fc6b6305544cb", @"/Views/Investimentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e31123a1487bb8d998e9d12cf76e9c4270ec96d", @"/Views/_ViewImports.cshtml")]
    public class Views_Investimentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PersonalFinance.WebApp.Model.Investimentos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Lista de competência</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Competências</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                          ");
            WriteLiteral("  <h3 class=\"card-title\">Competências</h3>\r\n                            <h3 class=\"left\">Contas </h3>\r\n                        </div>\r\n                        <!-- /.card-header -->\r\n                        <div class=\"card-body\">\r\n");
#nullable restore
#line 38 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                             if (Model != null && Model.Count() > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <table id=\"example1\" class=\"table table-bordered table-striped\">\r\n                                    <thead>\r\n                                        <tr>\r\n                                            <th>");
#nullable restore
#line 43 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NomeInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 44 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ValorInvestido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 45 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Rendimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 46 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.DataInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>Ações</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 51 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 54 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.NomeInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 55 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.ValorInvestido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 56 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Rendimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 57 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.DataInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 59 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                                    ");
#nullable restore
#line 60 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                                    ");
#nullable restore
#line 61 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 64 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                    <tfoot>\r\n                                        <tr>\r\n                                            <th>");
#nullable restore
#line 68 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NomeInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 69 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ValorInvestido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 70 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Rendimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 71 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.DataInvestimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>Ações</th>\r\n                                        </tr>\r\n                                    </tfoot>\r\n                                </table>\r\n");
#nullable restore
#line 76 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h3>Sem informações</h3>\r\n");
#nullable restore
#line 80 "C:\Hugo Vieira\Projetos\Personal Finance\WEB APP\PersonalFinance.WebApp.APP\PersonalFinance.WebApp\Views\Investimentos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PersonalFinance.WebApp.Model.Investimentos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
