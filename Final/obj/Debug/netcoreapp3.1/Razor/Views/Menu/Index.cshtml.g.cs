#pragma checksum "C:\Users\User\Desktop\PriveFinal\Final\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3439236176fc267ef633cb0148ecc3e7afa2a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3439236176fc267ef633cb0148ecc3e7afa2a0b", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8effd5ebf685575619ec5dbfdc3e6de872a685d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/meals/lunch2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/meals/dryaged1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/meals/forburger.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/meals/fordessert2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"menu\">\r\n    <div class=\"menu-text\">\r\n        <h1>Our Menu</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3439236176fc267ef633cb0148ecc3e7afa2a0b6711", async() => {
                WriteLiteral("Home ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <i class=""fa-solid fa-angle-right""></i>
        <span>Menu</span>
    </div>
</section>
<section data-aos=""fade-down-right"" class=""lunch"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-12 col-sm-12 col-12"">
                <div class=""lunch-text"">
                    <ul>
                        <li>
                            <p>
                                Hummus
                                <span> -------------------------------------------------------8₼</span>
                            </p>
                            <h6>Hummus with pistachio or pressed casserole</h6>
                        </li>
                        <li>
                            <p>
                                Mushrooms in the oven
                                <span>-------------------------------7₼</span>
                            </p>
                            <h6>Mushrooms, colored peppers, smoked meat and cottage cheese</h6>
");
            WriteLiteral(@"                        </li>
                        <li>
                            <p>
                                Grilled Vegetables
                                <span>-----------------------------------------6₼</span>
                            </p>
                            <h6>Mixed vegetables, spices and pesto sauce</h6>
                        </li>
                        <li>
                            <p>
                                Potato Souffles
                                <span>----------------------------------------------6₼</span>
                            </p>
                            <h6>Mashed potatoes, various spices, butter and cottage cheese</h6>
                        </li>
                        <li>
                            <p>
                                Small Potatoes in the oven

                                <span>----------------------------5₼</span>
                            </p>
                            <h6>Baked s");
            WriteLiteral(@"mall potatoes, colored peppers, onions and special spices</h6>
                        </li>
                        <li>
                            <p>
                                Stuffed Meatballs

                                <span>-------------------------------------------4₼</span>
                            </p>
                            <h6>Bulgur, minced meat, pistachios, walnuts</h6>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12 col-sm-12 col-12"">
                <div class=""lunchimage"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3439236176fc267ef633cb0148ecc3e7afa2a0b10555", async() => {
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
            WriteLiteral(@"
                    <div class=""lunchtext"">
                        <h1>Great Appetizer</h1>
                        <h3>Our Daily Specials</h3>
                        <!-- <span class=""dblh__divider"">...</span> -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section data-aos=""fade-down-left"" class=""dryaged"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""dryagedimage"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3439236176fc267ef633cb0148ecc3e7afa2a0b12236", async() => {
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
                    <div class=""dryagedtext"">
                        <h1>Main Dishes</h1>
                        <h3>Our Daily Specials</h3>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-12"">
                <div class=""dyraged-text"">
                    <ul>
                        <li>
                            <p>
                                Nyu-York Steak
                                <span> --------------------------------------------------90₼</span>
                            </p>
                            <h6>350-400 GR</h6>
                        </li>
                        <li>
                            <p>
                                Club Steak (national)
                                <span>------------------------------------------60₼</span>
                            </p>
                            <h6>400 - 500 GR</h6>
                        </li>
                        <li>
         ");
            WriteLiteral(@"                   <p>
                                T-Bon (national)
                                <span>--------------------------------------------------60₼</span>
                            </p>
                            <h6>450-500 GR</h6>
                        </li>
                        <li>
                            <p>
                                Rib Eye Steak (national)
                                <span>--------------------------------------60₼</span>
                            </p>
                            <h6>350GR</h6>
                        </li>
                        <li>
                            <p>
                                Dallas Steak (national)

                                <span>-----------------------------------------60₼</span>
                            </p>
                            <h6>350-400 GR</h6>
                        </li>

                    </ul>
                </div>
            </div>
        </div>
  ");
            WriteLiteral(@"  </div>
</section>
<section data-aos=""fade-up-right"" class=""burger"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""burger-text"">
                    <ul>
                        <li>
                            <p>
                                Cheddar Burger
                                <span> ----------------------------------------------15₼</span>
                            </p>
                            <h6>Burger cutlet (200g), cheddar cheese, fried onions and fried potatoes</h6>
                        </li>
                        <li>
                            <p>
                                Prive Double Burger
                                <span>---------------------------------------21₼</span>
                            </p>
                            <h6>Two-layer burger cutlet, roasted mushrooms, roasted onions, cheddar cheese, and french fries</h6>
                        </li>
 ");
            WriteLiteral(@"                       <li>
                            <p>
                                Lokum Burger
                                <span>------------------------------------------------25₼</span>
                            </p>
                            <h6>Melted cheddar cheese and fried potatoes on can meat</h6>
                        </li>
                        <li>
                            <p>
                                Prive Chicken Burger
                                <span>-------------------------------------13₼</span>
                            </p>
                            <h6>Grilled chicken, tomatoes, greens, sauce and french fries</h6>
                        </li>
                        <li>
                            <p>
                                Mini Burger Trio

                                <span>--------------------------------------------15₼</span>
                            </p>
                            <h6>Mini cheddar burger an");
            WriteLiteral("d fried potatoes</h6>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-12\">\r\n                <div class=\"burgerimage\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3439236176fc267ef633cb0148ecc3e7afa2a0b17838", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""burgertext"">
                        <h1>Great Burgers</h1>
                        <h3>Our Daily Specials</h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section data-aos=""fade-down-left"" class=""dessert"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""dessertimage"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3439236176fc267ef633cb0148ecc3e7afa2a0b19441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""desserttext"">
                        <h1>Best Dessert</h1>
                        <h3>Our Daily Specials</h3>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-12"">
                <div class=""dessert-text"">
                    <ul>
                        <li>
                            <p>
                                Walnut Baklava
                                <span> --------------------------------------------------2₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Walnut Kadayif
                                <span>--------------------------------------------------2₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Peanut Kadayif
                        ");
            WriteLiteral(@"        <span>--------------------------------------------------4₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Peanut Baklava
                                <span>------------------------------------------------2.50₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Carrot Slice Baklava

                                <span>--------------------------------------------9₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Sobiyet

                                <span>----------------------------------------------------------------4₼</span>
                            </p>

                        </li>
                        <li>
         ");
            WriteLiteral(@"                   <p>
                                Special Roll Baklava

                                <span>--------------------------------------------4₼</span>
                            </p>

                        </li>
                        <li>
                            <p>
                                Green Leaf Baklava

                                <span>---------------------------------------------5₼</span>
                            </p>

                        </li>

                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>


");
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
