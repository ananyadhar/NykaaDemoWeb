#pragma checksum "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383196a1792fcd73ab497e758e7c4a611375f986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPageHome_UserHomePage), @"mvc.1.0.view", @"/Views/UserPageHome/UserHomePage.cshtml")]
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
#line 1 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\_ViewImports.cshtml"
using NykaaDemoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\_ViewImports.cshtml"
using NykaaDemoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383196a1792fcd73ab497e758e7c4a611375f986", @"/Views/UserPageHome/UserHomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd5a2934cbdd13e502b5f17a97c71338c239280", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserPageHome_UserHomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NykaaDemoWeb.Data.Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomePage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
  
    ViewData["Title"] = string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "383196a1792fcd73ab497e758e7c4a611375f9865578", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 12 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Nykaa - Shopping</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "383196a1792fcd73ab497e758e7c4a611375f9866239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "383196a1792fcd73ab497e758e7c4a611375f9867417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "383196a1792fcd73ab497e758e7c4a611375f9868595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.3.1/css/all.css\" integrity=\"sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU\" crossorigin=\"anonymous\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "383196a1792fcd73ab497e758e7c4a611375f9869983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link type=\"image/png\" rel=\"icon\" href=\".../wwwroot/css/icons8-nykaa-100.png\" />\r\n    <link rel=\"icon\" type=\"image/png\" href=\"https://th.bing.com/th/id/OIP.kMlP3CWpxDnp9rCDKq-dJQAAAA?w=150&h=150&c=7&r=0&o=5&dpr=1.5&pid=1.7\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "383196a1792fcd73ab497e758e7c4a611375f98612113", async() => {
                WriteLiteral("\r\n    \r\n    <div>\r\n\r\n        <div class=\"topnav d-flex justify-content-around\">\r\n");
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
              
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul class=\"list-unstyled pb-0\">\r\n                        <li class=\"dropdown-submenu\">\r\n                            <a class=\"dropdown-item\" tabindex=\"-1\"");
                BeginWriteAttribute("href", " href=\"", 1421, "\"", 1428, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                                                                      Write(item.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 35 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                             if (item.SubCategories.Count > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul class=\"dropdown-menu text-black-50\">\r\n");
#nullable restore
#line 38 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                                     foreach (var item2 in item.SubCategories)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li><a class=\"dropdown-item text-black-50\" tabindex=\"-1\"");
                BeginWriteAttribute("href", " href=\"", 1833, "\"", 1879, 2);
                WriteAttributeValue("", 1840, "/Category/DisplayProducts/", 1840, 26, true);
#nullable restore
#line 40 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
WriteAttributeValue("", 1866, item2.ScatId, 1866, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                                                                                                                                           Write(item2.ScatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 41 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 43 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </li>\r\n                    </ul>\r\n");
#nullable restore
#line 46 "C:\Users\ananydhar\Desktop\NykaaDemoWeb\NykaaDemoWeb\Views\UserPageHome\UserHomePage.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 2146, "\"", 2154, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <img class=\"card-img-top\" src=\"/banner.jpg\">\r\n    </div>\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 2232, "\"", 2240, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <img class=""card-img-top"" src=""/banner2.jpg"">
    </div>
    <div class=""py-5"" style=""background-color:purple"">
        <h2 class=""p-5"">
            The Nykaa Story
        </h2>
        <p class=""text-white-50 p-5"">
            Since our launch, we have not only redefined the art of e-retailing beauty and personal care in India, but also have been instrumental in fostering the growth of a previously relatively nascent ecosystem.
            
        </p>
        <p class=""text-white-50 p-5"">
            From bringing you domestic brands, international brands, luxury and prestige brands, premium brands, niche and cult brands and expert advice and videos, coupled with our understanding of the needs and preferences of the consumers,to more than 72 Luxe and On-Trend and Kiosk Stores, an ever growing online community for beauty buffs, and a Beauty Helpline, we go out of our way to give you only the very best. With 2400+, 100% authentic brands Nykaa offers a well curated comprehensive selecti");
                WriteLiteral(@"on of makeup, skincare, haircare, bath and body, fragrance, grooming appliances, personal care, and health and wellness categories.
           
        </p>
        <p class=""text-white-50 p-5"">
             Derived from the Sanskrit word ‘Nayaka’ meaning actress or one in the spotlight, Nykaa is all about celebrating the star in each woman, and being her confidante and companion as she embarks on her own journey to discover her unique identity and personal style. From the widest selection of genuine beauty products from around the world to beauty advice, Nykaa is truly passionate about catering to your every beauty and wellness need. Because after all, Your Beauty is Our Passion.
        </p>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NykaaDemoWeb.Data.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
