#pragma checksum "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd3ededa14fc728d62d3aea03cd691693630f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\_ViewImports.cshtml"
using MvcRazorLabb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\_ViewImports.cshtml"
using MvcRazorLabb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\_ViewImports.cshtml"
using MvcRazorLabb.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd3ededa14fc728d62d3aea03cd691693630f60", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84b74bb53634f94bb00f7b636ecbb5373466127", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AvailibleBooksViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Tillgängliga böcker i biblioteket</h2>\n\n<table class=\"table table-bordered table-striped\">\n    <thead>\n        <tr>\n            <th>Titel</th>\n            <th>Författare</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 13 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\Book\Index.cshtml"
         foreach (var book in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 16 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\Book\Index.cshtml"
               Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 17 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\Book\Index.cshtml"
               Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 19 "C:\Users\johan\OneDrive\Dokument\Code2\MvcRazorLabb\MvcRazorLabb\Views\Book\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AvailibleBooksViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
