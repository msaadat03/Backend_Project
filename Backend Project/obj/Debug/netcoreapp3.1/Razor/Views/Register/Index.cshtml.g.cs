#pragma checksum "D:\Code Academy\ASP.NET Core\Backend Project\Backend Project\Backend Project\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5bb58999d653e3f259698c5a4f432bb2ab26ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "D:\Code Academy\ASP.NET Core\Backend Project\Backend Project\Backend Project\Views\_ViewImports.cshtml"
using Backend_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\ASP.NET Core\Backend Project\Backend Project\Backend Project\Views\_ViewImports.cshtml"
using Backend_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\ASP.NET Core\Backend Project\Backend Project\Backend Project\Views\_ViewImports.cshtml"
using Backend_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5bb58999d653e3f259698c5a4f432bb2ab26ac", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647252969bb92e82798997f2fa4907e13b0434a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex bdr-bottom w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Code Academy\ASP.NET Core\Backend Project\Backend Project\Backend Project\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- off-canvas menu start -->
<aside class=""off-canvas-wrapper"">
    <div class=""off-canvas-overlay""></div>
    <div class=""off-canvas-inner-content"">
        <div class=""btn-close-off-canvas"">
            <i class=""ion-android-close""></i>
        </div>

        <div class=""off-canvas-inner"">
            <!-- search box start -->
            <div class=""search-box-offcanvas"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5bb58999d653e3f259698c5a4f432bb2ab26ac5207", async() => {
                WriteLiteral("\r\n                    <input type=\"text\" placeholder=\"Search Here...\">\r\n                    <button class=\"search-btn\"><i class=\"ion-ios-search-strong\"></i></button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- search box end -->
            <!-- mobile menu start -->
            <div class=""mobile-navigation"">
                <!-- mobile menu navigation start -->
                <nav>
                    <ul class=""mobile-menu"">
                        <li class=""menu-item-has-children"">
                            <a href=""index.html"">Home</a>
                            <ul class=""dropdown"">
                                <li><a href=""index.html"">Home version 01</a></li>
                                <li><a href=""index-2.html"">Home version 02</a></li>
                            </ul>
                        </li>
                        <li class=""menu-item-has-children"">
                            <a href=""#"">pages</a>
                            <ul class=""megamenu dropdown"">
                                <li class=""mega-title menu-item-has-children"">
                                    <a href=""#"">column 01</a>
                                    ");
            WriteLiteral(@"<ul class=""dropdown"">
                                        <li>
                                            <a href=""shop.html"">
                                                shop grid left
                                                sidebar
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""shop-grid-right-sidebar.html"">
                                                shop grid right
                                                sidebar
                                            </a>
                                        </li>
                                        <li><a href=""shop-list-left-sidebar.html"">shop list left sidebar</a></li>
                                        <li><a href=""shop-list-right-sidebar.html"">shop list right sidebar</a></li>
                                    </ul>
                                </li>
       ");
            WriteLiteral(@"                         <li class=""mega-title menu-item-has-children"">
                                    <a href=""#"">column 02</a>
                                    <ul class=""dropdown"">
                                        <li><a href=""product-details.html"">product details</a></li>
                                        <li>
                                            <a href=""product-details-affiliate.html"">
                                                product
                                                details
                                                affiliate
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""product-details-variable.html"">
                                                product details
                                                variable
                                            </a>
                    ");
            WriteLiteral(@"                    </li>
                                        <li>
                                            <a href=""product-details-group.html"">
                                                product details
                                                group
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""mega-title menu-item-has-children"">
                                    <a href=""#"">column 03</a>
                                    <ul class=""dropdown"">
                                        <li><a href=""cart.html"">cart</a></li>
                                        <li><a href=""checkout.html"">checkout</a></li>
                                        <li><a href=""compare.html"">compare</a></li>
                                        <li><a href=""wishlist.html"">wishlist</a></li>
                             ");
            WriteLiteral(@"       </ul>
                                </li>
                                <li class=""mega-title menu-item-has-children"">
                                    <a href=""#"">column 04</a>
                                    <ul class=""dropdown"">
                                        <li><a href=""my-account.html"">my-account</a></li>
                                        <li><a href=""login-register.html"">login-register</a></li>
                                        <li><a href=""contact-us.html"">contact us</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""menu-item-has-children "">
                            <a href=""#"">shop</a>
                            <ul class=""dropdown"">
                                <li class=""menu-item-has-children"">
                                    <a href=""#"">shop grid layout</a>
                                    <u");
            WriteLiteral(@"l class=""dropdown"">
                                        <li><a href=""shop.html"">shop grid left sidebar</a></li>
                                        <li><a href=""shop-grid-right-sidebar.html"">shop grid right sidebar</a></li>
                                        <li><a href=""shop-grid-full-3-col.html"">shop grid full 3 col</a></li>
                                        <li><a href=""shop-grid-full-4-col.html"">shop grid full 4 col</a></li>
                                    </ul>
                                </li>
                                <li class=""menu-item-has-children"">
                                    <a href=""#"">shop list layout</a>
                                    <ul class=""dropdown"">
                                        <li><a href=""shop-list-left-sidebar.html"">shop list left sidebar</a></li>
                                        <li><a href=""shop-list-right-sidebar.html"">shop list right sidebar</a></li>
                                        <li><a href=""sh");
            WriteLiteral(@"op-list-full-width.html"">shop list full width</a></li>
                                    </ul>
                                </li>
                                <li class=""menu-item-has-children"">
                                    <a href=""#"">products details</a>
                                    <ul class=""dropdown"">
                                        <li><a href=""product-details.html"">product details</a></li>
                                        <li><a href=""product-details-affiliate.html"">product details affiliate</a></li>
                                        <li><a href=""product-details-variable.html"">product details variable</a></li>
                                        <li><a href=""product-details-group.html"">product details group</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""menu-item-has-children "">
                        ");
            WriteLiteral(@"    <a href=""#"">Blog</a>
                            <ul class=""dropdown"">
                                <li><a href=""blog-left-sidebar.html"">blog left sidebar</a></li>
                                <li><a href=""blog-right-sidebar.html"">blog right sidebar</a></li>
                                <li><a href=""blog-grid-full-width.html"">blog grid no sidebar</a></li>
                                <li><a href=""blog-details.html"">blog details</a></li>
                                <li><a href=""blog-details-audio.html"">blog details audio</a></li>
                                <li><a href=""blog-details-video.html"">blog details video</a></li>
                                <li><a href=""blog-details-left-sidebar.html"">blog details left sidebar</a></li>
                            </ul>
                        </li>
                        <li><a href=""contact-us.html"">Contact us</a></li>
                    </ul>
                </nav>
                <!-- mobile menu navigation end -->
     ");
            WriteLiteral(@"       </div>
            <!-- mobile menu end -->
            <!-- user setting option start -->
            <div class=""mobile-settings"">
                <ul class=""nav"">
                    <li>
                        <div class=""dropdown mobile-top-dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" id=""currency"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Currency
                                <i class=""fa fa-angle-down""></i>
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""currency"">
                                <a class=""dropdown-item"" href=""#"">$ USD</a>
                                <a class=""dropdown-item"" href=""#"">$ EURO</a>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""dropdown mobile-top-dropdown"">
                            <a href=");
            WriteLiteral(@"""#"" class=""dropdown-toggle"" id=""myaccount"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                My Account
                                <i class=""fa fa-angle-down""></i>
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""myaccount"">
                                <a class=""dropdown-item"" href=""my-account.html"">my account</a>
                                <a class=""dropdown-item"" href=""login-register.html""> login</a>
                                <a class=""dropdown-item"" href=""login-register.html"">register</a>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- user setting option end -->
            <!-- offcanvas widget area start -->
            <div class=""offcanvas-widget-area"">
                <div class=""off-canvas-contact-widget"">
                    <ul>
                        <li>");
            WriteLiteral(@"
                            <i class=""fa fa-mobile""></i>
                            <a href=""#"">0123456789</a>
                        </li>
                        <li>
                            <i class=""fa fa-envelope-o""></i>
                            <a href=""#"">info@yourdomain.com</a>
                        </li>
                    </ul>
                </div>
                <div class=""off-canvas-social-widget"">
                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                    <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
                    <a href=""#""><i class=""fa fa-linkedin""></i></a>
                    <a href=""#""><i class=""fa fa-youtube-play""></i></a>
                </div>
            </div>
            <!-- offcanvas widget area end -->
        </div>
    </div>
</aside>
<!-- off-canvas menu end -->
<!-- main wrapper start -->
<main>
    <!-- breadcrumb area start -->
   ");
            WriteLiteral(@" <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Register</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Register</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- login register wrapper start -->
    <div class=""login-register-wrapper section-padding"">
        <div class=""container"">
            <div class=""member-area-from-wrap"">
        ");
            WriteLiteral(@"        <div class=""row"">


                    <!-- Register Content Start -->
                    <div class=""col-lg-6"">
                        <div class=""login-reg-form-wrap signup-form"">
                            <h2>Singup Form</h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5bb58999d653e3f259698c5a4f432bb2ab26ac19855", async() => {
                WriteLiteral(@"
                                <div class=""single-input-item"">
                                    <input type=""text"" placeholder=""Full Name"" required />
                                </div>
                                <div class=""single-input-item"">
                                    <input type=""email"" placeholder=""Enter your Email"" required />
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""single-input-item"">
                                            <input type=""password"" placeholder=""Enter your Password"" required />
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""single-input-item"">
                                            <input type=""password"" placeholder=""Repeat your Passw");
                WriteLiteral(@"ord"" required />
                                        </div>
                                    </div>
                                </div>
                                <div class=""single-input-item"">
                                    <div class=""login-reg-form-meta"">
                                        <div class=""remember-meta"">
                                            <div class=""custom-control custom-checkbox"">
                                                <input type=""checkbox"" class=""custom-control-input"" id=""subnewsletter"">
                                                <label class=""custom-control-label"" for=""subnewsletter"">Subscribe Our Newsletter</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""single-input-item"">
                                    <button class=""btn"">Register</butto");
                WriteLiteral("n>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
                    </div>
                    <!-- Register Content End -->
                </div>
            </div>
        </div>
    </div>
    <!-- login register wrapper end -->
</main>
<!-- main wrapper end -->
<!-- offcanvas search form start -->
<div class=""offcanvas-search-wrapper"">
    <div class=""offcanvas-search-inner"">
        <div class=""offcanvas-close"">
            <i class=""ion-android-close""></i>
        </div>
        <div class=""container"">
            <div class=""offcanvas-search-box"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5bb58999d653e3f259698c5a4f432bb2ab26ac24204", async() => {
                WriteLiteral("\r\n                    <input type=\"text\" placeholder=\"Search entire storage here...\">\r\n                    <button class=\"search-btn\"><i class=\"ion-ios-search-strong\"></i>search</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<!-- offcanvas search form end -->
<!-- offcanvas mini cart start -->
<div class=""offcanvas-minicart-wrapper"">
    <div class=""minicart-inner"">
        <div class=""offcanvas-overlay""></div>
        <div class=""minicart-inner-content"">
            <div class=""minicart-close"">
                <i class=""ion-android-close""></i>
            </div>
            <div class=""minicart-content-box"">
                <div class=""minicart-item-wrapper"">
                    <ul>
                        <li class=""minicart-item"">
                            <div class=""minicart-thumb"">
                                <a href=""product-details.html"">
                                    <img src=""assets/img/cart/cart-1.jpg"" alt=""product"">
                                </a>
                            </div>
                            <div class=""minicart-content"">
                                <h3 class=""product-name"">
                           ");
            WriteLiteral(@"         <a href=""product-details.html"">Flowers bouquet pink for all flower lovers</a>
                                </h3>
                                <p>
                                    <span class=""cart-quantity"">1 <strong>&times;</strong></span>
                                    <span class=""cart-price"">$100.00</span>
                                </p>
                            </div>
                            <button class=""minicart-remove""><i class=""ion-android-close""></i></button>
                        </li>
                        <li class=""minicart-item"">
                            <div class=""minicart-thumb"">
                                <a href=""product-details.html"">
                                    <img src=""assets/img/cart/cart-2.jpg"" alt=""product"">
                                </a>
                            </div>
                            <div class=""minicart-content"">
                                <h3 class=""product-name"">
                 ");
            WriteLiteral(@"                   <a href=""product-details.html"">Jasmine flowers white for all flower lovers</a>
                                </h3>
                                <p>
                                    <span class=""cart-quantity"">1 <strong>&times;</strong></span>
                                    <span class=""cart-price"">$80.00</span>
                                </p>
                            </div>
                            <button class=""minicart-remove""><i class=""ion-android-close""></i></button>
                        </li>
                    </ul>
                </div>

                <div class=""minicart-pricing-box"">
                    <ul>
                        <li>
                            <span>sub-total</span>
                            <span><strong>$300.00</strong></span>
                        </li>
                        <li>
                            <span>Eco Tax (-2.00)</span>
                            <span><strong>$10.00</strong></span>
");
            WriteLiteral(@"                        </li>
                        <li>
                            <span>VAT (20%)</span>
                            <span><strong>$60.00</strong></span>
                        </li>
                        <li class=""total"">
                            <span>total</span>
                            <span><strong>$370.00</strong></span>
                        </li>
                    </ul>
                </div>

                <div class=""minicart-button"">
                    <a href=""cart.html""><i class=""fa fa-shopping-cart""></i> view cart</a>
                    <a href=""cart.html""><i class=""fa fa-share""></i> checkout</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- offcanvas mini cart end -->
<!-- Scroll to top start -->
<div class=""scroll-top not-visible"">
    <i class=""fa fa-angle-up""></i>
</div>
<!-- Scroll to Top End -->
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