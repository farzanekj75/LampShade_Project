#pragma checksum "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b379c62badaaa2ab68167be4bdadce9cf9ef31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiseHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ServiseHost.Pages
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
#line 1 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\_ViewImports.cshtml"
using ServiseHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b379c62badaaa2ab68167be4bdadce9cf9ef31", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920f8eaf06aba965e9402bed2e802d42d37e212d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/img/banners/img1-middle-eposi1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/img/banners/img2-middle-eposi1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mc-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Slide"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategoryWithProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArrivals"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

   
    <!--====================  banner hover area ====================-->
    <div class=""banner-hover-area section-space"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  banner hover wrapper  =======-->
                    <div class=""banner-hover-wrapper"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <!--=======  single hover banner  =======-->
                                <div class=""single-hover-banner"">
                                    <div class=""single-hover-banner__image"">
                                        <a href=""shop-left-sidebar.html"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28b379c62badaaa2ab68167be4bdadce9cf9ef317649", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                                        </a>
                                        <div class=""single-hover-banner__content"">
                                            <h4 class=""small-text"">Black Friday</h4>
                                            <h3 class=""big-text"">Save Up To 50% Off</h3>
                                            <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                        </div>
                                    </div>
                                </div>
                                <!--=======  End of single hover banner  =======-->
                            </div>

                            <div class=""col-md-6"">
                                <!--=======  single hover banner  =======-->
                                <div class=""single-hover-banner"">
                                    <div class=""single-hover-banner__image"">
                                        <a href=""shop-left-sidebar.html"">
");
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28b379c62badaaa2ab68167be4bdadce9cf9ef319960", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                        </a>
                                        <div class=""single-hover-banner__content"">
                                            <h4 class=""small-text"">Best Selling !</h4>
                                            <h3 class=""big-text"">Living Room Up To 70% Off</h3>
                                            <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                        </div>
                                    </div>
                                </div>
                                <!--=======  End of single hover banner  =======-->
                            </div>
                        </div>
                    </div>
                    <!--=======  End of banner hover wrapper  =======-->
                </div>
            </div>
        </div>
    </div>
    <!--====================  End of banner hover area  ====================-->
    <!--====================  feature logo area ========");
            WriteLiteral(@"============-->
    <div class=""feature-logo-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  feature logo wrapper  =======-->
                    <div class=""feature-logo-wrapper section-space--inner-bottom"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <!--=======  single feature logo  =======-->
                                <div class=""single-feature-logo"">
                                    <div class=""single-feature-logo__image"">
                                        <img src=""assets/img/icons/free_shipping.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4212, "\"", 4218, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""single-feature-logo__content"">
                                        <h4 class=""title"">FREE SHIPPING WORLDWIDE</h4>
                                        <p class=""short-desc"">
                                            We offer free shipping via Standard Shipping on orders
                                            over $200.00
                                        </p>
                                    </div>
                                </div>
                                <!--=======  End of single feature logo  =======-->
                            </div>
                            <div class=""col-md-4"">
                                <!--=======  single feature logo  =======-->
                                <div class=""single-feature-logo"">
                                    <div class=""single-feature-logo__image"">
                                        <img src=""assets/img/");
            WriteLiteral("icons/money_back.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 5282, "\"", 5288, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""single-feature-logo__content"">
                                        <h4 class=""title"">MONEY BACK GUARANTEE</h4>
                                        <p class=""short-desc"">
                                            If you're not satisfied with our product, we'll refund the
                                            purchase price*.
                                        </p>
                                    </div>
                                </div>
                                <!--=======  End of single feature logo  =======-->
                            </div>
                            <div class=""col-md-4"">
                                <!--=======  single feature logo  =======-->
                                <div class=""single-feature-logo"">
                                    <div class=""single-feature-logo__image"">
                                        <img src=""assets");
            WriteLiteral("/img/icons/support247.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 6357, "\"", 6363, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""single-feature-logo__content"">
                                        <h4 class=""title"">ONLINE SUPPORT 24/7</h4>
                                        <p class=""short-desc"">
                                            Our friendly support team is available to help you 24
                                            hours a day, seven days a week
                                        </p>
                                    </div>
                                </div>
                                <!--=======  End of single feature logo  =======-->
                            </div>
                        </div>
                    </div>
                    <!--=======  End of feature logo wrapper  =======-->
                </div>
            </div>
        </div>
    </div>
    <!--====================  End of feature logo area  ====================-->
");
#nullable restore
#line 131 "E:\personalProject\LampShade_Project\LampShade\ServiseHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!--====================  newsletter area ====================-->
    <div class=""newsletter-area section-space--inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 offset-lg-2"">
                    <div class=""newsletter-wrapper"">
                        <p class=""small-text"">Special Ofers For Subscribers</p>
                        <h3 class=""title"">Ten Percent Member Discount</h3>
                        <p class=""short-desc"">
                            Subscribe to our newsletters now and stay up to date with new collections,
                            the latest lookbooks and exclusive offers.
                        </p>

                        <div class=""newsletter-form"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b379c62badaaa2ab68167be4bdadce9cf9ef3117670", async() => {
                WriteLiteral("\r\n                                <input type=\"email\" placeholder=\"Enter Your Email Address Here...\" required>\r\n                                <button type=\"submit\" value=\"submit\">SUBSCRIBE</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                        <!-- mailchimp-alerts Start -->
                        <div class=""mailchimp-alerts"">
                            <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                            <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                            <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                        </div>
                        <!-- mailchimp-alerts end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--====================  End of newsletter area  ====================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
