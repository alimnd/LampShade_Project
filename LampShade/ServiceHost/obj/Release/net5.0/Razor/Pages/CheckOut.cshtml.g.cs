#pragma checksum "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_CheckOut), @"mvc.1.0.razor-page", @"/Pages/CheckOut.cshtml")]
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
#nullable restore
#line 2 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
using _0_Framework.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
using ShopManagement.Application.Contracts.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd", @"/Pages/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CheckOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""breadcrumb-area section-space--half"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-wrapper breadcrumb-bg"">
                    <div class=""breadcrumb-content"">
                        <h1 class=""breadcrumb-content__title"">سبد خرید</h1>
                        <ul class=""breadcrumb-content__page-map"">
                            <li>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd6610", async() => {
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
            WriteLiteral(@"
                            </li>
                            <li>
                                <a class=""active"">تایید نهایی و پرداخت</a>
                            </li>

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
                <div class=""page-wrapper"">
                    <div class=""page-content-wrapper"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd8350", async() => {
                WriteLiteral(@"
                            <div class=""cart-table table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""pro-thumbnail"">عکس</th>
                                            <th class=""pro-thumbnail"">محصول</th>
                                            <th class=""pro-title"">قیمت واحد</th>
                                            <th class=""pro-price"">تعداد</th>
                                            <th class=""pro-price"">درصد تخفیف</th>
                                            <th class=""pro-quantity"">مبلغ کل بدون تخفیف</th>
                                            <th class=""pro-subtotal"">مبلغ کل تخفیف</th>
                                            <th class=""pro-remove"">مبلغ پس از تخفیف</th>
                                        </tr>
                                    </thead>
                                  ");
                WriteLiteral("  <tbody>\r\n");
#nullable restore
#line 52 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                         foreach (var item in Model.CheckOutCart.CartItems)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <tr>
                                                <td class=""pro-thumbnail"">
                                                    <a href=""single-product.html"">
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd10289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2692, "~/UploadedFile/Pictures/", 2692, 24, true);
#nullable restore
#line 57 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
AddHtmlAttributeValue("", 2716, item.Picture, 2716, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                                                </td>
                                                <td class=""pro-title"">
                                                    <a href=""single-product.html"">
                                                        ");
#nullable restore
#line 63 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </a>\r\n                                                </td>\r\n                                                <td class=\"pro-price\">\r\n                                                    <span>");
#nullable restore
#line 67 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td class=\"pro-price\">\r\n                                                    <span>");
#nullable restore
#line 70 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td class=\"pro-price\">\r\n                                                    <span>");
#nullable restore
#line 73 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</span>\r\n                                                </td>\r\n                                                <td class=\"pro-subtotal\">\r\n                                                    <span>");
#nullable restore
#line 76 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.TotalPrice.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span>\r\n                                                </td>\r\n                                                <td class=\"pro-subtotal\">\r\n                                                    <span>");
#nullable restore
#line 79 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.DiscountAmount.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span>\r\n                                                </td>\r\n                                                <td class=\"pro-subtotal\">\r\n                                                    <span>");
#nullable restore
#line 82 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                     Write(item.ItemPayAmount.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 85 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""row "">
                                <div class=""col-lg-6 col-12 d-flex"">
                                    <div class=""checkout-payment-method"">
                                        <h4>نحوه پرداخت</h4>
");
#nullable restore
#line 94 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                         foreach (var method in PaymentMethod.GetList())
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"single-method\">\r\n                                                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 5342, "\"", 5365, 2);
                WriteAttributeValue("", 5347, "payment_", 5347, 8, true);
#nullable restore
#line 97 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
WriteAttributeValue("", 5355, method.Id, 5355, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"paymentMethod\"");
                BeginWriteAttribute("value", " value=\"", 5387, "\"", 5405, 1);
#nullable restore
#line 97 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
WriteAttributeValue("", 5395, method.Id, 5395, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 97 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                                                                                                Write(PaymentMethod.GetList().First().Id == method.Id ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 5531, "\"", 5555, 2);
                WriteAttributeValue("", 5537, "payment_", 5537, 8, true);
#nullable restore
#line 98 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
WriteAttributeValue("", 5545, method.Id, 5545, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 98 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                                           Write(method.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                                <p data-method=\"");
#nullable restore
#line 99 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                           Write(method.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"");
                BeginWriteAttribute("style", " style=\"", 5654, "\"", 5739, 2);
                WriteAttributeValue("", 5662, "display:", 5662, 8, true);
#nullable restore
#line 99 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
WriteAttributeValue("", 5670, PaymentMethod.GetList().First().Id == method.Id ? "block" : "none", 5670, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 99 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                                                                                                                             Write(method.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            </div>\r\n");
#nullable restore
#line 101 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12 d-flex"">
                                    <div class=""cart-summary"">
                                        <div class=""cart-summary-wrap"">
                                            <h4>خلاصه وضعیت فاکتور</h4>
                                            <p>مبلغ نهایی <span>");
#nullable restore
#line 108 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                           Write(Model.CheckOutCart.TotalAmount.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span></p>\r\n                                            <p>مبلغ تخفیف <span>");
#nullable restore
#line 109 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                           Write(Model.CheckOutCart.DiscountAmount.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span></p>\r\n                                            <h2>مبلغ قابل پرداخت <span>");
#nullable restore
#line 110 "F:\New Shop Project\Code\LampShade\ServiceHost\Pages\CheckOut.cshtml"
                                                                  Write(Model.CheckOutCart.CartForPayAmount.ToMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" تومان</span></h2>
                                        </div>
                                    
                                    </div>
                                </div>
                            </div>
                            <div class=""row text-center"">
                                <div class=""col-12 text-center"">
                                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36abf680a0e5d3afc052df2a09d22f4b1bc8e2cd22085", async() => {
                    WriteLiteral("ثبت سفارش و پرداخت");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.CheckOutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CheckOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CheckOutModel>)PageContext?.ViewData;
        public ServiceHost.Pages.CheckOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
