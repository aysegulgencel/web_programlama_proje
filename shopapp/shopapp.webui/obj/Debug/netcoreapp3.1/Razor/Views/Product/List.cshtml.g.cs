#pragma checksum "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722fee9c520903b3d805e7103cb457fb0a4c4d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722fee9c520903b3d805e7103cb457fb0a4c4d7d", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a37584fdbe64ca31cd20fae569eeb6d30eee5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count>2? "popular":"";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
 if(products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">                  \r\n");
#nullable restore
#line 21 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
         foreach (var product in products)
        {    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n        </div>       \r\n");
#nullable restore
#line 26 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Excalibur\Desktop\shopapp\shopapp.webui\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
