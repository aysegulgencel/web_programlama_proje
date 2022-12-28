#pragma checksum "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27058c12e2ccca36e9a167bf71e76c83a5d7c053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27058c12e2ccca36e9a167bf71e76c83a5d7c053", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a37584fdbe64ca31cd20fae569eeb6d30eee5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 15 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 900, "\"", 964, 2);
            WriteAttributeValue("", 908, "page-item", 908, 9, true);
#nullable restore
#line 27 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 917, Model.PageInfo.CurrentPage==i+1?"active":"", 918, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1052, 2);
            WriteAttributeValue("", 1031, "/products?page=", 1031, 15, true);
#nullable restore
#line 28 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1046, i+1, 1046, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 29 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>  \r\n");
#nullable restore
#line 32 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1318, "\"", 1382, 2);
            WriteAttributeValue("", 1326, "page-item", 1326, 9, true);
#nullable restore
#line 35 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1335, Model.PageInfo.CurrentPage==i+1?"active":"", 1336, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1442, "\"", 1502, 4);
            WriteAttributeValue("", 1449, "/products/", 1449, 10, true);
#nullable restore
#line 36 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1459, Model.PageInfo.CurrentCategory, 1459, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1490, "?page=", 1490, 6, true);
#nullable restore
#line 36 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1496, i+1, 1496, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 37 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 40 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             

                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
