#pragma checksum "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "759371668e2f7d7e4eb32e5a6298feb22b259deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GenelAyarlar), @"mvc.1.0.view", @"/Views/Admin/GenelAyarlar.cshtml")]
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
#line 1 "Q:\source\repos\KoronaTakipV2\Views\_ViewImports.cshtml"
using KoronaTakipV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Q:\source\repos\KoronaTakipV2\Views\_ViewImports.cshtml"
using KoronaTakipV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759371668e2f7d7e4eb32e5a6298feb22b259deb", @"/Views/Admin/GenelAyarlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bbbf5711b02b4ffafa0c11198b17084e4bffaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GenelAyarlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KoronaTakipV2.Models.AdminObjects.UpdateTime>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
  
    ViewData["Title"] = "GenelAyarlar";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- page content -->\r\n<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 240, "\"", 248, 0);
            EndWriteAttribute();
            WriteLiteral(@">

        <div class=""clearfix""></div>

        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>
                            GenelAyarlar
");
#nullable restore
#line 21 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                             if (TempData["sonuc1"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <small class=\"text-muted text-sm alert alert-success\">Bilgiler Güncellendi. </small>\r\n");
#nullable restore
#line 24 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                            }
                            else if (TempData["sonuc0"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <small class=\"text-muted text-sm alert alert-danger\">Bilgiler Güncellenemedi. </small>\r\n");
#nullable restore
#line 28 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <small class=\"text-muted text-sm \">Panele Hoşgeldiniz. </small>\r\n");
#nullable restore
#line 32 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </h2>\r\n\r\n                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                    <div class=\"x_content\">\r\n\r\n                        <p>Sitede yayınlanan bilgileri güncelle.</p>\r\n");
#nullable restore
#line 42 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                         if (TempData["exHata"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"alert alert-danger\">");
#nullable restore
#line 44 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                                     Write(TempData["exHata"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""table-responsive"">
                            <table class=""table table-striped jambo_table bulk_action"">
                                <thead>
                                    <tr class=""headings"">
                                        <th class=""column-title"">Güncellenecek Bölüm</th>
                                        <th class=""column-title"">Son Güncelleme Tarihi</th>
                                        <th class=""column-title no-link last"">
                                            <span class=""nobr"">Action</span>
                                        </th>
                                        <th class=""bulk-actions"" colspan=""7"">
                                            <a class=""antoo"" style=""color:#fff; font-weight:500;"">Bulk Actions ( <span class=""action-cnt""> </span> ) <i class=""fa fa-chevron-down""></i></a>
                                        </th>
                                    </tr>
                              ");
            WriteLiteral("  </thead>\r\n\r\n                                <tbody>\r\n");
#nullable restore
#line 63 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"even pointer\">\r\n                                            <td class=\" \">");
#nullable restore
#line 66 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                                     Write(item.ActionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\" \">");
#nullable restore
#line 67 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                                     Write(item.Updated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\" last\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759371668e2f7d7e4eb32e5a6298feb22b259deb8553", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                                   WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 72 "Q:\source\repos\KoronaTakipV2\Views\Admin\GenelAyarlar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KoronaTakipV2.Models.AdminObjects.UpdateTime>> Html { get; private set; }
    }
}
#pragma warning restore 1591
