#pragma checksum "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aba2eb01b87ba424c5dce39f58954e4a7bae24f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
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
#line 1 "C:\Users\admin\Desktop\Demo1\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Demo1\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aba2eb01b87ba424c5dce39f58954e4a7bae24f", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5028ecf9aecdaf7c53dcd6b626e3c0e3279dbf89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Presentation.Models.ShoppingCartViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 635, true);
            WriteLiteral(@"<title>Cart Page</title>
<div class=""container-fluid"">
    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    </div>
    <a href=""/"">
        <button class=""btn""><i class=""fa fa-home""></i></button>
    </a>
    <!-- Content Row -->
    <div class=""row"">
        <div class=""col-lg-12"">

            <!-- Approach -->
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Item in Cart</h6>
                    <h5 class=""m-0 font-weight-bold text-md-right""> Cart has ");
            EndContext();
            BeginContext(694, 11, false);
#line 19 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                                                                        Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(705, 36, true);
            WriteLiteral(" item</h5>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                 if (Model.Any())
                {


#line default
#line hidden
            BeginContext(797, 498, true);
            WriteLiteral(@"                    <table class=""table"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th hidden scope=""col"">ID</th>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Action</th>
                            </tr>
                        </thead>
                        <tbody id=""productBinding"">
");
            EndContext();
#line 34 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1384, 85, true);
            WriteLiteral("                                <tr>\r\n                                    <td hidden>");
            EndContext();
            BeginContext(1470, 15, false);
#line 37 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                                          Write(item.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1533, 17, false);
#line 38 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1550, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1598, 13, false);
#line 39 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1611, 116, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n                                        <button");
            EndContext();
            BeginWriteAttribute("cart-id", " cart-id=\"", 1727, "\"", 1753, 1);
#line 41 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1737, item.Product.Id, 1737, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1754, 159, true);
            WriteLiteral(" type=\"button\" class=\"btn btn-light removefromcart\">Remove To Cart</button>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 44 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"

                            }

#line default
#line hidden
            BeginContext(1946, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
            BeginContext(2012, 112, true);
            WriteLiteral("                    <button id=\"removeall\" type=\"button\" class=\"btn btn-success view-more\">Remove All</button>\r\n");
            EndContext();
#line 50 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(2186, 131, true);
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <p>Not Found Product in Cart</p>\r\n                    </div>\r\n");
            EndContext();
#line 57 "C:\Users\admin\Desktop\Demo1\Presentation\Views\Home\Cart.cshtml"
                }

#line default
#line hidden
            BeginContext(2336, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2413, 1925, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('body').on('click', '.view-more,#removeall', function (e) {
                e.preventDefault();
                $.ajax({
                    type: ""GET"",
                    url: '/Home/ClearCart',
                    data: {
                    },
                    // contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (response) {
                        //  alert('success');
                        console.log(response);
                        pageIndex++;

                    },
                    error: function (response) {
                        alert('Remove Success !')
                        $(""#removeall"").hide();
                    }
                });
            });
        });



        $(document).ready(function () {
            $('body').on('click', '.removefromcart', function (e) {
                e.preventDefault(");
                WriteLiteral(@");
                var id = $(this).attr(""cart-id"");
                $.ajax({
                    type: ""POST"",
                    url: '/Home/RemoveFromCart',
                    data: {
                        productId: id
                    },
                    dataType: ""json"",
                    success: function (response) {
                        console.log(response);
                        pageIndex++;

                    },
                    error: function (response) {
                        alert(""Remove Succes !"");
                        setInterval('location.reload()', 1000);
                        var a = response.responseJSON.length;
                        console.log(a);
                        $(""#productCount"").text(response.responseJSON.length)
                    }
                });
            });
        });
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Presentation.Models.ShoppingCartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
