#pragma checksum "C:\Users\bduguest\Desktop\Juan\myJuan\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fc96f48be62f7c5df5e937b32f38820f937655a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 4 "C:\Users\bduguest\Desktop\Juan\myJuan\Views\_ViewImports.cshtml"
using myJuan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bduguest\Desktop\Juan\myJuan\Views\_ViewImports.cshtml"
using myJuan.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc96f48be62f7c5df5e937b32f38820f937655a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6150543e00a88c693cf0283a323ce6f789402ffa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex bdr-bottom w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html class=\"no-js\" lang=\"zxx\">\r\n\r\n<!-- Mirrored from demo.hasthemes.com/juan-preview-v1/juan/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sun, 07 Mar 2021 22:36:22 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc96f48be62f7c5df5e937b32f38820f937655a4039", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""meta description"">
    <title>Juan - Shoes Store HTML Template</title>
    <!--=== Favicon ===-->
    <link rel=""shortcut icon"" href=""assets/img/favicon.ico"" type=""image/x-icon"" />
    <!--=== All Plugins CSS ===-->
    <link href=""assets/css/plugins.css"" rel=""stylesheet"">
    <!--=== All Vendor CSS ===-->
    <link href=""assets/css/vendor.css"" rel=""stylesheet"">
    <!--=== Main Style CSS ===-->
    <link href=""assets/css/style.css"" rel=""stylesheet"">
    <!-- Modernizer JS -->
    <script src=""assets/js/modernizr-2.8.3.min.js""></script>

    <!--[if lt IE 9]>
    <script src=""//oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
    <script src=""//oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc96f48be62f7c5df5e937b32f38820f937655a5997", async() => {
                WriteLiteral(@"

    <!-- Start Header Area -->
    <header class=""header-area"">
        <!-- main header start -->
        <div class=""main-header d-none d-lg-block"">
            <!-- header top start -->
            <div class=""header-top theme-bg"">
                <div class=""container"">
                    <div class=""row align-items-center"">
                        <div class=""col-lg-6"">
                            <div class=""welcome-message"">
                                <p>Welcome to Juan online store</p>
                            </div>
                        </div>
                        <div class=""col-lg-6 text-right"">
                            <div class=""header-top-settings"">
                                <ul class=""nav align-items-center justify-content-end"">
                                    <li class=""curreny-wrap"">
                                        $ Dollar (US)
                                        <i class=""fa fa-angle-down""></i>
                                 ");
                WriteLiteral(@"       <ul class=""dropdown-list curreny-list"">
                                            <li><a href=""#"">$ usd</a></li>
                                            <li><a href=""#""> € EURO</a></li>
                                        </ul>
                                    </li>
                                    <li class=""language"">
                                        <img src=""assets/img/icon/en.png"" alt=""flag""> English
                                        <i class=""fa fa-angle-down""></i>
                                        <ul class=""dropdown-list"">
                                            <li><a href=""#""><img src=""assets/img/icon/en.png"" alt=""flag""> english</a></li>
                                            <li><a href=""#""><img src=""assets/img/icon/fr.png"" alt=""flag""> french</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        ");
                WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
            <!-- header top end -->
            <!-- header middle area start -->
            <div class=""header-main-area sticky"">
                <div class=""container"">
                    <div class=""row align-items-center position-relative"">
                        <!-- start logo area -->
                        <div class=""col-lg-2"">
                            <div class=""logo"">
                                <a href=""index.html"">
                                    <img src=""assets/img/logo/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 3829, "\"", 3835, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                        <!-- start logo area -->
                        <!-- main menu area start -->
                        <div class=""col-lg-8 position-static"">
                            <div class=""main-menu-area"">
                                <div class=""main-menu"">
                                    <!-- main menu navbar start -->
                                    <nav class=""desktop-menu"">
                                        <ul>
                                            <li class=""active"">
                                                <a href=""index.html"">Home <i class=""fa fa-angle-down""></i></a>
                                                <ul class=""dropdown"">
                                                    <li><a href=""index.html"">Home version 01</a></li>
                                                    <li><a href=""index-2.html"">Home version 02</a></l");
                WriteLiteral(@"i>
                                                </ul>
                                            </li>
                                            <li class=""static"">
                                                <a href=""#"">pages <i class=""fa fa-angle-down""></i></a>
                                                <ul class=""megamenu dropdown"">
                                                    <li class=""mega-title"">
                                                        <a href=""#"">column 01</a>
                                                        <ul>
                                                            <li>
                                                                <a href=""shop.html"">
                                                                    shop grid left
                                                                    sidebar
                                                                </a>
                                                            ");
                WriteLiteral(@"</li>
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
                                                    <li class=""mega-title"">
                                                        <a href=""#"">column 0");
                WriteLiteral(@"2</a>
                                                        <ul>
                                                            <li><a href=""product-details.html"">product details</a></li>
                                                            <li><a href=""product-details-affiliate.html"">product details affiliate</a></li>
                                                            <li><a href=""product-details-variable.html"">product details variable</a></li>
                                                            <li><a href=""product-details-group.html"">product details group</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class=""mega-title"">
                                                        <a href=""#"">column 03</a>
                                                        <ul>
                                                            <li><a href=""cart");
                WriteLiteral(@".html"">cart</a></li>
                                                            <li><a href=""checkout.html"">checkout</a></li>
                                                            <li><a href=""compare.html"">compare</a></li>
                                                            <li><a href=""wishlist.html"">wishlist</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class=""mega-title"">
                                                        <a href=""#"">column 04</a>
                                                        <ul>
                                                            <li><a href=""my-account.html"">my-account</a></li>
                                                            <li><a href=""login-register.html"">login-register</a></li>
                                                            <li><a href=""contact-us.html"">contact us</a></li>");
                WriteLiteral(@"
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li>
                                                <a href=""shop.html"">shop <i class=""fa fa-angle-down""></i></a>
                                                <ul class=""dropdown"">
                                                    <li>
                                                        <a href=""#"">shop grid layout <i class=""fa fa-angle-right""></i></a>
                                                        <ul class=""dropdown"">
                                                            <li><a href=""shop.html"">shop grid left sidebar</a></li>
                                                            <li><a href=""shop-grid-right-sidebar.html"">shop grid right sidebar</a></li>
                                               ");
                WriteLiteral(@"             <li><a href=""shop-grid-full-3-col.html"">shop grid full 3 col</a></li>
                                                            <li><a href=""shop-grid-full-4-col.html"">shop grid full 4 col</a></li>
                                                        </ul>
                                                    </li>
                                                    <li>
                                                        <a href=""#"">shop list layout <i class=""fa fa-angle-right""></i></a>
                                                        <ul class=""dropdown"">
                                                            <li><a href=""shop-list-left-sidebar.html"">shop list left sidebar</a></li>
                                                            <li><a href=""shop-list-right-sidebar.html"">shop list right sidebar</a></li>
                                                            <li><a href=""shop-list-full-width.html"">shop list full width</a></li>
                       ");
                WriteLiteral(@"                                 </ul>
                                                    </li>
                                                    <li>
                                                        <a href=""#"">products details <i class=""fa fa-angle-right""></i></a>
                                                        <ul class=""dropdown"">
                                                            <li><a href=""product-details.html"">product details</a></li>
                                                            <li><a href=""product-details-affiliate.html"">product details affiliate</a></li>
                                                            <li><a href=""product-details-variable.html"">product details variable</a></li>
                                                            <li><a href=""product-details-group.html"">product details group</a></li>
                                                        </ul>
                                                    </li>
        ");
                WriteLiteral(@"                                        </ul>
                                            </li>
                                            <li>
                                                <a href=""blog-left-sidebar.html"">Blog <i class=""fa fa-angle-down""></i></a>
                                                <ul class=""dropdown"">
                                                    <li><a href=""blog-left-sidebar.html"">blog left sidebar</a></li>
                                                    <li><a href=""blog-right-sidebar.html"">blog right sidebar</a></li>
                                                    <li><a href=""blog-grid-full-width.html"">blog grid no sidebar</a></li>
                                                    <li><a href=""blog-details.html"">blog details</a></li>
                                                    <li><a href=""blog-details-audio.html"">blog details audio</a></li>
                                                    <li><a href=""blog-details-video.html"">blog d");
                WriteLiteral(@"etails video</a></li>
                                                    <li><a href=""blog-details-left-sidebar.html"">blog details left sidebar</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""contact-us.html"">Contact us</a></li>
                                        </ul>
                                    </nav>
                                    <!-- main menu navbar end -->
                                </div>
                            </div>
                        </div>
                        <!-- main menu area end -->
                        <!-- mini cart area start -->
                        <div class=""col-lg-2"">
                            <div class=""header-configure-wrapper"">
                                <div class=""header-configure-area"">
                                    <ul class=""nav justify-content-end"">
                                  ");
                WriteLiteral(@"      <li>
                                            <a href=""#"" class=""offcanvas-btn"">
                                                <i class=""ion-ios-search-strong""></i>
                                            </a>
                                        </li>
                                        <li class=""user-hover"">
                                            <a href=""#"">
                                                <i class=""ion-ios-gear-outline""></i>
                                            </a>
                                            <ul class=""dropdown-list"">
                                                <li><a href=""login-register.html"">login</a></li>
                                                <li><a href=""login-register.html"">register</a></li>
                                                <li><a href=""my-account.html"">my account</a></li>
                                            </ul>
                                        </li>
                     ");
                WriteLiteral(@"                   <li>
                                            <a href=""#"" class=""minicart-btn"">
                                                <i class=""ion-bag""></i>
                                                <div class=""notification"">2</div>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!-- mini cart area end -->
                    </div>
                </div>
            </div>
            <!-- header middle area end -->
        </div>
        <!-- main header start -->
        <!-- mobile header start -->
        <div class=""mobile-header d-lg-none d-md-block sticky"">
            <!--mobile header top start -->
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-12"">
             ");
                WriteLiteral(@"           <div class=""mobile-main-header"">
                            <div class=""mobile-logo"">
                                <a href=""index.html"">
                                    <img src=""assets/img/logo/logo.png"" alt=""Brand Logo"">
                                </a>
                            </div>
                            <div class=""mobile-menu-toggler"">
                                <div class=""mini-cart-wrap"">
                                    <a href=""cart.html"">
                                        <i class=""ion-bag""></i>
                                    </a>
                                </div>
                                <div class=""mobile-menu-btn"">
                                    <div class=""off-canvas-btn"">
                                        <i class=""ion-navicon""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </di");
                WriteLiteral("v>\r\n                </div>\r\n            </div>\r\n            <!-- mobile header top start -->\r\n        </div>\r\n        <!-- mobile header end -->\r\n    </header>\r\n    ");
#nullable restore
#line 266 "C:\Users\bduguest\Desktop\Juan\myJuan\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- Start Footer Area Wrapper -->
    <footer class=""footer-wrapper"">
        <!-- footer main area start -->
        <div class=""footer-widget-area section-padding"">
            <div class=""container"">
                <div class=""row mtn-40"">
                    <!-- footer widget item start -->
                    <div class=""col-xl-5 col-lg-3 col-md-6"">
                        <div class=""widget-item mt-40"">
                            <h5 class=""widget-title"">My Account</h5>
                            <div class=""widget-body"">
                                <ul class=""location-wrap"">
                                    <li><i class=""ion-ios-location-outline""></i>184 Main Rd E, St Albans VIC 3021, Australia</li>
                                    <li><i class=""ion-ios-email-outline""></i>Mail Us: <a href=""mailto:yourmail@gmail.com"">yourmail@gmail.com</a></li>
                                    <li><i class=""ion-ios-telephone-outline""></i>Phone: <a href=""%2b0025425456554"">+ 00 254 2");
                WriteLiteral(@"54565</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!-- footer widget item end -->
                    <!-- footer widget item start -->
                    <div class=""col-xl-2 col-lg-3 col-md-6"">
                        <div class=""widget-item mt-40"">
                            <h5 class=""widget-title"">Categories</h5>
                            <div class=""widget-body"">
                                <ul class=""useful-link"">
                                    <li><a href=""#"">Ecommerce</a></li>
                                    <li><a href=""#"">Shopify</a></li>
                                    <li><a href=""#"">Prestashop</a></li>
                                    <li><a href=""#"">Opencart</a></li>
                                    <li><a href=""#"">Magento</a></li>
                                    <li><a href=""#"">Jigoshop</a></li>
                                </ul");
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <!-- footer widget item end -->
                    <!-- footer widget item start -->
                    <div class=""col-xl-2 col-lg-3 col-md-6"">
                        <div class=""widget-item mt-40"">
                            <h5 class=""widget-title"">Information</h5>
                            <div class=""widget-body"">
                                <ul class=""useful-link"">
                                    <li><a href=""#"">Home</a></li>
                                    <li><a href=""#"">About Us</a></li>
                                    <li><a href=""#"">Contact Us</a></li>
                                    <li><a href=""#"">Returns & Exchanges</a></li>
                                    <li><a href=""#"">Shipping & Delivery</a></li>
                                    <li><a href=""#"">Privacy Policy</a></li>
                                </ul>
                       ");
                WriteLiteral(@"     </div>
                        </div>
                    </div>
                    <!-- footer widget item end -->
                    <!-- footer widget item start -->
                    <div class=""col-xl-2 col-lg-3 offset-xl-1 col-md-6"">
                        <div class=""widget-item mt-40"">
                            <h5 class=""widget-title"">Quick Links</h5>
                            <div class=""widget-body"">
                                <ul class=""useful-link"">
                                    <li><a href=""#"">Store Location</a></li>
                                    <li><a href=""#"">My Account</a></li>
                                    <li><a href=""#"">Orders Tracking</a></li>
                                    <li><a href=""#"">Size Guide</a></li>
                                    <li><a href=""#"">Shopping Rates</a></li>
                                    <li><a href=""#"">Contact Us</a></li>
                                </ul>
                            </div>
  ");
                WriteLiteral(@"                      </div>
                    </div>
                    <!-- footer widget item end -->
                </div>
            </div>
        </div>
        <!-- footer main area end -->
        <!-- footer bottom area start -->
        <div class=""footer-bottom"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 order-2 order-md-1"">
                        <div class=""copyright-text text-center text-md-left"">
                            <p>Copyright 2019 <a href=""index.html"">Juan</a>. All Rights Reserved</p>
                        </div>
                    </div>
                    <div class=""col-md-6 order-1 order-md-2"">
                        <div class=""footer-social-link text-center text-md-right"">
                            <a href=""#""><i class=""fa fa-facebook""></i></a>
                            <a href=""#""><i class=""fa fa-twitter""></i></a>
                            <a href=""#""><i class=""fa fa-link");
                WriteLiteral(@"edin""></i></a>
                            <a href=""#""><i class=""fa fa-instagram""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- footer bottom area end -->
    </footer>
    <!-- End Footer Area Wrapper -->
    <!-- offcanvas search form start -->
    <div class=""offcanvas-search-wrapper"">
        <div class=""offcanvas-search-inner"">
            <div class=""offcanvas-close"">
                <i class=""ion-android-close""></i>
            </div>
            <div class=""container"">
                <div class=""offcanvas-search-box"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc96f48be62f7c5df5e937b32f38820f937655a29667", async() => {
                    WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"Search entire storage here...\">\r\n                        <button class=\"search-btn\"><i class=\"ion-ios-search-strong\"></i>search</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                                <div class=""minicart-conte");
                WriteLiteral(@"nt"">
                                    <h3 class=""product-name"">
                                        <a href=""product-details.html"">Flowers bouquet pink for all flower lovers</a>
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
                    ");
                WriteLiteral(@"            </div>
                                <div class=""minicart-content"">
                                    <h3 class=""product-name"">
                                        <a href=""product-details.html"">Jasmine flowers white for all flower lovers</a>
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
                            ");
                WriteLiteral(@"    <span><strong>$300.00</strong></span>
                            </li>
                            <li>
                                <span>Eco Tax (-2.00)</span>
                                <span><strong>$10.00</strong></span>
                            </li>
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
                </div>");
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <!-- offcanvas mini cart end -->
    <!-- Scroll to top start -->
    <div class=""scroll-top not-visible"">
        <i class=""fa fa-angle-up""></i>
    </div>
    <!-- Scroll to Top End -->
    <!--=======================Javascript============================-->
    <!--=== All Vendor Js ===-->
    <script src=""assets/js/vendor.js""></script>
    <!--=== All Plugins Js ===-->
    <script src=""assets/js/plugins.js""></script>
    <!--=== Active Js ===-->
    <script src=""assets/js/active.js""></script>
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
            WriteLiteral("\r\n\r\n\r\n<!-- Mirrored from demo.hasthemes.com/juan-preview-v1/juan/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sun, 07 Mar 2021 22:36:53 GMT -->\r\n</html>");
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
