#pragma checksum "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "245c5d883aa5b6770770196c7ad9b3e6bd0a1316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_ProductCategory), @"mvc.1.0.razor-page", @"/Pages/ProductCategory.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245c5d883aa5b6770770196c7ad9b3e6bd0a1316", @"/Pages/ProductCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProductCategory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
  
    ViewData["Title"] = $"گروه محصولی {Model.CategoryQueryModel.Name}";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumb-area section-space--half"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-wrapper breadcrumb-bg"">
                    <div class=""breadcrumb-content"">
                        <h1 class=""breadcrumb-content__title h1"">");
#nullable restore
#line 15 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                            Write(Model.CategoryQueryModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul class=\"breadcrumb-content__page-map h4\">\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "245c5d883aa5b6770770196c7ad9b3e6bd0a13164490", async() => {
                WriteLiteral("صفحه اصلی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"active\">");
#nullable restore
#line 18 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                          Write(Model.CategoryQueryModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""page-content-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  shop page wrapper  =======-->
                <div class=""page-wrapper"">
                    <div class=""page-content-wrapper"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <!--=======  shop page header  =======-->
                                <div class=""shop-header"">
                                    <div class=""shop-header__left"">
                                        <div class=""shop-header__left__message"">
                                            تعداد محصول در گروه {");
#nullable restore
#line 39 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                            Write(Model.CategoryQueryModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("} به تعداد {");
#nullable restore
#line 39 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                                      Write(Model.CategoryQueryModel.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"} می باشد 
                                        </div>
                                    </div>

                                    
                                </div>
                                <!--=======  End of shop page header  =======-->
                            </div>

                            <div class=""col-lg-12"">
                                <!--=======  shop page content  =======-->
                                <div class=""shop-page-content"">

                                    <div class=""row shop-product-wrap grid three-column"">
");
#nullable restore
#line 53 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                         foreach (var item in Model.CategoryQueryModel.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""col-12 col-lg-4 col-md-4 col-sm-6"">
                                                <!--=======  product grid view  =======-->
                                                <div class=""single-grid-product grid-view-product"">
                                                    <div class=""single-grid-product__image"">
");
#nullable restore
#line 59 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                         if (item.HasDiscount)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"single-grid-product__label\">\r\n                                                                <span class=\"sale\">-");
#nullable restore
#line 62 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                               Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                            </div>\r\n");
#nullable restore
#line 64 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"single-product.html\">\r\n                                                            <img");
            BeginWriteAttribute("src", " src=\"", 3434, "\"", 3453, 1);
#nullable restore
#line 66 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
WriteAttributeValue("", 3440, item.Picture, 3440, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", "\r\n                                                                 alt=\"", 3472, "\"", 3560, 1);
#nullable restore
#line 67 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
WriteAttributeValue("", 3544, item.PictureAlt, 3544, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                           
                                                        </a>
                                                    </div>
                                                    <div class=""single-grid-product__content"">
                                                        <div class=""single-grid-product__category-rating"">
                                                            <span class=""category"">
                                                                <a href=""shop-left-sidebar.html"">");
#nullable restore
#line 74 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                            Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                            </span>
                                                            <span class=""rating"">
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star-outline""></i>
                                                            </span>
                                                        </div>

                                                        <h3 class=""single-grid-product__title"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "245c5d883aa5b6770770196c7ad9b3e6bd0a131612802", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 87 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </h3>\r\n                                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 91 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                             if (item.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"discounted-price\">");
#nullable restore
#line 93 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                          Write(item.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                                <span class=\"main-price discounted\">");
#nullable restore
#line 94 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <div class=\"product-countdown\" data-countdown=\"");
#nullable restore
#line 95 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                                          Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n");
#nullable restore
#line 96 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"

                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"main-price \">");
#nullable restore
#line 100 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"
                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 101 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </p>
                                                    </div>
                                                </div>
                                                <!--=======  End of product grid view  =======-->

                                            </div>
");
#nullable restore
#line 109 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\ProductCategory.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>

                                </div>

                                <!--=======  pagination area =======-->
                                <div class=""pagination-area"">
                                    <div class=""pagination-area__left"">
                                        Showing 1 to 9 of 11 (2 Pages)
                                    </div>
                                    <div class=""pagination-area__right"">
                                        <ul class=""pagination-section"">
                                            <li>
                                                <a class=""active"" href=""#"">1</a>
                                            </li>
                                            <li>
                                                <a href=""#"">2</a>
                                            </li>
                                        </ul>
                                    </div>
                  ");
            WriteLiteral(@"              </div>
                                <!--=======  End of pagination area  =======-->
                                <!--=======  End of shop page content  =======-->
                            </div>
                        </div>
                    </div>
                </div>
                <!--=======  End of shop page wrapper  =======-->
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ProductCategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductCategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductCategoryModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ProductCategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
