#pragma checksum "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda78cfbdf7f312c98b32fc322c808945b9c871a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiseHost.Pages.Shared.Component.LatestArrival.Pages_Shared_Component_LatestArrival_LatestArrival), @"mvc.1.0.view", @"/Pages/Shared/Component/LatestArrival/LatestArrival.cshtml")]
namespace ServiseHost.Pages.Shared.Component.LatestArrival
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
#line 1 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\_ViewImports.cshtml"
using ServiseHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda78cfbdf7f312c98b32fc322c808945b9c871a", @"/Pages/Shared/Component/LatestArrival/LatestArrival.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920f8eaf06aba965e9402bed2e802d42d37e212d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Component_LatestArrival_LatestArrival : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contract.Product.ProductQueryModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""single-row-slider-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  section title  =======-->
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">آخرین محصولات</h2>
                    <p class=""section-subtitle"">
                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است

                    </p>
                </div>
                <!--=======  End of section title  =======-->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  single row slider wrapper  =======-->
                <div class=""single-row-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""s");
            WriteLiteral(@"lidesToShow"": 4,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""autoplay"": false,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""infinite"": false,
                        ""rtl"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                        {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrow");
            WriteLiteral("s\": false} },\r\n                        {\"breakpoint\":479, \"settings\": {\"slidesToShow\": 1, \"arrows\": false} }\r\n                    ]\'>\r\n");
#nullable restore
#line 42 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                        foreach(var product in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col"">
                                <!--=======  single grid product  =======-->
                                <div class=""single-grid-product"">
                                    <div class=""single-grid-product__image"">
                                        <div class=""single-grid-product__label"">
");
#nullable restore
#line 49 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                             if(product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"sale\">-");
#nullable restore
#line 51 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                                               Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                <span class=\"new\">جدید</span>\r\n");
#nullable restore
#line 53 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                          \r\n                                        </div>\r\n                                        <a href=\"single-product.html\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fda78cfbdf7f312c98b32fc322c808945b9c871a8051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3251, "~/ProductPictures/", 3251, 18, true);
#nullable restore
#line 57 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
AddHtmlAttributeValue("", 3269, product.Picture, 3269, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
AddHtmlAttributeValue("", 3310, product.PictureAlt, 3310, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
AddHtmlAttributeValue("", 3338, product.PictureTitle, 3338, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                           
                                        </a>

                                    </div>
                                    <div class=""single-grid-product__content"">
                                        <div class=""single-grid-product__category-rating"">
                                            <span class=""category""><a href=""shop-left-sidebar.html"">");
#nullable restore
#line 64 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                                                                               Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
                                            <span class=""rating"">
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star-outline""></i>
                                            </span>
                                        </div>

                                        <h3 class=""single-grid-product__title"">
                                            <a href=""single-product.html"">
                                             ");
#nullable restore
#line 76 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </h3>\r\n\r\n                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 81 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                             if(product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"discounted-price\">");
#nullable restore
#line 83 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                                                          Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                <span class=\"main-price discounted\">");
#nullable restore
#line 84 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 85 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"discounted-price\">");
#nullable restore
#line 88 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                                                          Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 89 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                 \r\n                            </div>\r\n");
#nullable restore
#line 96 "C:\Users\kalami-f\source\repos\LampShade_Project - 2\LampShade\ServiseHost\Pages\Shared\Component\LatestArrival\LatestArrival.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        \r\n\r\n                 \r\n\r\n                    </div>\r\n                </div>\r\n          \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contract.Product.ProductQueryModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591