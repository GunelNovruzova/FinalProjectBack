#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a91428ab8a058159b0c0ddf2fd003e484b43df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 2 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\PriveFinal\Final\Views\_ViewImports.cshtml"
using Final.ViewModels.Table;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a91428ab8a058159b0c0ddf2fd003e484b43df", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437baa4820bc8d9fe72342d1023ce00483fc0df", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "about", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"about\">\r\n    <div class=\"about-text\">\r\n        <h1>About Us</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a91428ab8a058159b0c0ddf2fd003e484b43df6238", async() => {
                WriteLiteral("Home ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <i class=\"fa-solid fa-angle-right\"></i>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a91428ab8a058159b0c0ddf2fd003e484b43df7659", async() => {
                WriteLiteral(" <span>About Us</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</section>
<section class=""aboutus"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <h5>Fun, Friends, and Food</h5>
                <i><h3>For Every Special Occasion, <br> There's Prive Steak Gallery</h3></i>
                <ul>
                    <li>Sharkuteri</li>
                    <li>Baklava</li>
                    <li>Butcher</li>
                    <li>Meza Gallery</li>
                    <li>Dry Aged</li>
                    <li>Wine bar</li>
                    <li>VIP cabinets</li>
                    <li>Prive Kids Gallery</li>
               </ul>
            </div>
            <div class=""col-lg-6"">
                <div class=""aboutimage"">

                    <img src=""/assets/img/background/cabinet2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1108, "\"", 1114, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/background/singing.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 1184, "\"", 1190, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/interier/_0010021.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1258, "\"", 1264, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/background/looking.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1333, "\"", 1339, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/interier/sing2.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 1405, "\"", 1411, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/interier/_MRN1178.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1479, "\"", 1485, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/assets/img/interier/sing.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1549, "\"", 1555, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                </div>
                <!-- <img src=""/assets/img/interier/prive-steak-gallery.jpg"" alt=""""> -->
            </div>
        </div>
    </div>
</section>

<section class=""mission"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12 col-md-7 imagebox"">
                <img class=""img1"" src=""/assets/img/chefs/breakfast-at-prive-steak.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1967, "\"", 1973, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"img2\" src=\"/assets/img/chefs/prive-staff.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2050, "\"", 2056, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"img3\" src=\"/assets/img/meals/pleasure2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2131, "\"", 2137, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-lg-6 col-md-5"">
                <h3>Our Mission</h3>
                <h5>We are here to choose products with special care to create the clean, fresh and delicious blessings that are always worthy of your mouth, to be friendly to customers by serving them to the highest standards and to add color and flavor to the most special moments of their lives!</h5>
            </div>
        </div>
    </div>

</section>

<section class=""vision"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-12"">
                <h3>Our Vision</h3>
                <span>
                    ""
                    To be the first family holiday restaurant  in the center  <br>  that our customers constantly  recommend and visit, <br> presenting the perfect  delicacies that our palate longs <br> for with our  friendly, hospitable team, while maintaining <br> our principle of quality service, which always prioritizes <br> customer");
            WriteLiteral(@" satisfaction!""
                </span>
            </div>
        </div>
    </div>


</section>
<section class=""booking"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 form-text"">
                <h3>Book A Table</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a91428ab8a058159b0c0ddf2fd003e484b43df13642", async() => {
                WriteLiteral(@"
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <input type=""text"" placeholder=""Name"">
                                <input type=""text"" placeholder=""Person"">
                                <br>
                                <input type=""time"" placeholder=""01.00am"">
                            </div>
                            <div class=""col-lg-6"">
                                <input type=""number"" placeholder=""Phone"">
                                <input type=""email"" placeholder=""Email ID"">

                                <input type=""date"" placeholder=""mm/dd/yy"">
                            </div>
                            <div class=""col-lg-12"">
                                <button type=""submit"">Book Now</button>
                            </div>
                        </div>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <img src=\"/assets/img/interier/_54A5232.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4588, "\"", 4594, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
