#pragma checksum "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4548960e23d9433ecf747dffa34dce1fce3b922d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#line 1 "/Users/azim/Desktop/C-upsB/C-upsB/Views/_ViewImports.cshtml"
using C_upsB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/azim/Desktop/C-upsB/C-upsB/Views/_ViewImports.cshtml"
using C_upsB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4548960e23d9433ecf747dffa34dce1fce3b922d", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a80f693106e4413e19e0924e1a4e5f7bdf48ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-widget"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""blog-detail-intro"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""intro-content"">
                        <h1>Blog</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""blog-main-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-12"">
                    <div class=""blog-wrapper"">
                        <div class=""blog-image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4548960e23d9433ecf747dffa34dce1fce3b922d5800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 674, "~/images/", 674, 9, true);
#nullable restore
#line 25 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
AddHtmlAttributeValue("", 683, Model.Image, 683, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                        <ul class=""info"">
                            <li>
                                <a class=""after"" href=""#0"">
                                    <i class=""fa fa-file""></i>
                                    Coffee
                                </a>
                            </li>
                            <li>
                                <a  class=""after"" href=""#0"">
                                    <i class=""fa fa-comments""></i>
                                    30 Comments
                                </a>
                            </li>
                            <li>
                                <a href=""#0"">
                                    <i class=""fa fa-calendar-alt""></i>
                                    04th March 2019
                                </a>
                            </li>
                        </ul>
                        <div class=""blog-content"">
                            <h2 class=""title m");
            WriteLiteral("b-10\">");
#nullable restore
#line 48 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                               Write(Model.ContentHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                            <p>");
#nullable restore
#line 49 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>");
#nullable restore
#line 50 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleSecond);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>");
#nullable restore
#line 51 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleThird);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <h3>");
#nullable restore
#line 52 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                           Write(Model.ContentHeaderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 53 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleFourth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>");
#nullable restore
#line 54 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleFifth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <h3>");
#nullable restore
#line 55 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                           Write(Model.ContentHeaderThird);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 56 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleSix);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>");
#nullable restore
#line 57 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleSeven);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>");
#nullable restore
#line 58 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                          Write(Model.TitleEight);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        </div>
                        <div class=""tag-social"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <h4>Releted Tags</h4>
                                    <div class=""tagcloud"">
                                        <a href=""#0"">Popular</a>
                                        <a href=""#0"">Desgin</a>
                                        <a href=""#0"">UX</a>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <h4 class=""float"">Social Share</h4>
                                    <div class=""social-share"">
                                        <a href=""#0""><i class=""fab fa-facebook-f""></i></a>
                                        <a href=""#0""><i class=""fab fa-twitter""></i></a>
                                        <a href=""#0""><i class=""fab fa-google-plu");
            WriteLiteral(@"s-g""></i></a>
                                        <a href=""#0""><i class=""fab fa-instagram""></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""navigation-border""></div>
                            </div>
                            <div class=""col-lg-5"">
                                <div class=""prev-post"">
                                    <a href=""#0""><span>Prev Post</span></a>
                                    <h4><a href=""#0"">Tips On Minimalist</a></h4>
                                </div>
                            </div>
                            <div class=""col-lg-2"">
                                <div class=""blog-filter text-left text-md-center"">
                                    <a href=""#0""><img src=""https://xpressrow.com/html/cafena/cafena/a");
            WriteLiteral("ssets/images/icons/filter.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4381, "\"", 4387, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                            </div>
                            <div class=""col-lg-5"">
                                <div class=""next-post"">
                                    <a href=""#0""><span>Next Post</span></a>
                                    <h4><a href=""#0"">Less Is More</a></h4>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""navigation-border""></div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <h2 class=""related-post-heading"">Related Post</h2>
                                    </div>
                                </div>
                                <div class=""row");
            WriteLiteral("\">\n                                    <div class=\"col-lg-12 related-post d-flex\">\n");
#nullable restore
#line 115 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                         foreach (var item in ViewBag.BlogRelateds)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col-lg-6\">\n                                                <div class=\"related-post-image\">\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 5825, "\"", 5842, 1);
#nullable restore
#line 119 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
WriteAttributeValue("", 5831, item.Image, 5831, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5843, "\"", 5849, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                </div>
                                                <div class=""related-post-content"">
                                                    <ul class=""meta list-unstyled d-flex align-items-center"">
                                                        <li><a href=""#0""><i class=""fa fa-calendar-alt""></i> ");
#nullable restore
#line 123 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                                                                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                                    </ul>\n                                                    <h2 class=\"title border-effect mb-15\">\n                                                        <a href=\"blog-details.html\">");
#nullable restore
#line 126 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                                                               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                                    </h2>\n                                                    <p>");
#nullable restore
#line 128 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                    </p>\n                                                </div>\n                                            </div>\n");
#nullable restore
#line 132 "/Users/azim/Desktop/C-upsB/C-upsB/Views/Blog/Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""author-box"">
                            <div class=""author-image"">
                                <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/author/author-1.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 7184, "\"", 7190, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""author-content"">
                                <span>Written by</span>
                                <h3 class=""name"">Rosalina D. Habdilan</h3>
                                <p>Stephen Romero has worked a Italy Report since its launch in 2011. In the years since, he has led by example the company's tech news team and published over 5,000 articles...</p>
                            </div>
                        </div>
                        <div class=""comments-box"">
                            <h2 class=""p-5"">03 Comments</h2>
                            <div class=""latest-comments"">
                                <ul class=""list-unstyled"">
                                    <li>
                                        <div class=""item-image"">
                                            <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/author/c-author-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 8162, "\"", 8168, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""item-text"">
                                            <h5>Rosalina Kelian</h5>
                                            <span><i class=""fa fa-calendar-alt""></i> 19th May 2018</span>
                                            <a class=""reply"" href=""#"">
                                                <i class=""fa fa-reply""></i>
                                                Reply
                                            </a>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                                tempor incididunt
                                                ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                                exercitation
                                                ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
          ");
            WriteLiteral(@"                              </div>
                                    </li>
                                    <div class=""col-lg-12"">
                                        <div class=""navigation-border""></div>
                                    </div>
                                    <li>
                                        <div class=""item-image"">
                                            <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/author/c-author-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 9690, "\"", 9696, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""item-text"">
                                            <h5>Rosalina Kelian</h5>
                                            <span><i class=""fa fa-calendar-alt""></i> 21th May 2018</span>
                                            <a class=""reply"" href=""#"">
                                                <i class=""fa fa-reply""></i>
                                                Reply
                                            </a>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                                tempor incididunt
                                                ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                                exercitation
                                                ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
          ");
            WriteLiteral(@"                              </div>
                                    </li>
                                    <div class=""col-lg-12"">
                                        <div class=""navigation-border""></div>
                                    </div>
                                    <li>
                                        <div class=""item-image"">
                                            <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/author/c-author-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 11218, "\"", 11224, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""item-text"">
                                            <h5>Rosalina Kelian</h5>
                                            <span><i class=""fa fa-calendar-alt""></i> 25th May 2018</span>
                                            <a class=""reply"" href=""#"">
                                                <i class=""fa fa-reply""></i>
                                                Reply
                                            </a>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                                tempor incididunt
                                                ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                                exercitation
                                                ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
          ");
            WriteLiteral(@"                              </div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""comments-form"">
                            <div class=""col-lg-12"">
                                <div class=""navigation-border""></div>
                            </div>
                            <h2 class=""title"">Post Comments</h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4548960e23d9433ecf747dffa34dce1fce3b922d24119", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-lg-12 d-flex"">
                                        <input  class=""input"" type=""text"" placeholder=""Your Comments..."">
                                        <i class=""fa fa-pen""></i>
                                    </div>
                                    <div class=""col-lg-12 d-flex"">
                                        <input  type=""text"" placeholder=""Your Name.... "">
                                        <i class=""fa fa-user""></i>
                                    </div>
                                    <div class=""col-lg-12 d-flex"">
                                        <input  type=""text"" placeholder=""Your Email.... "">
                                        <i class=""fa fa-envelope""></i>
                                    </div>
                                    <div class=""col-lg-12 d-flex"">
                                        <input  type=""text"" placeholder=""Your Website");
                WriteLiteral(@".... "">
                                        <i class=""fa fa-globe""></i>
                                    </div>
                                    <div class=""col-lg-12"">
                                        <button class=""site-btn mt-10 d-flex"" type=""submit""><i class=""fa fa-comments""></i> Post
                                            comment</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-12"">
                    <div class=""blog-sidebar"">
                        <div class=""search-box"">
                            <h2>Search Here</h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4548960e23d9433ecf747dffa34dce1fce3b922d27384", async() => {
                WriteLiteral("\n                                <input type=\"search\" name=\"search\" id=\"search\" placeholder=\"Serach Product\">\n                                <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""category-side"">
                            <h2>Categories</h2>
                            <ul>
                                <li><a href=""#"">Burger</a> <span>04</span></li>
                                <li><a href=""#"">2x Pizza</a> <span>06</span></li>
                                <li><a href=""#"">Cold Drinks</a> <span>08</span></li>
                                <li><a href=""#"">Chicken</a> <span>10</span></li>
                                <li><a href=""#"">Stuck Dish</a> <span>12</span></li>
                            </ul>
                        </div>
                        <div class=""category-box"">
                            <h2 class=""title"">Categories</h2>
                            <div class=""category-items"">
                                <div class=""category-item"">
                                    <div class=""item-image"">
                                        <img src=""https://xpressrow.com/html/cafena/cafena/");
            WriteLiteral("assets/images/blog/recent-posts/b-sm-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 15929, "\"", 15935, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""item-content"">
                                        <h5><a href=""blog-detail.html"">10 Reasons To Do A Digital Detox Challenge</a></h5>
                                        <a href=""#"" class=""date""><i class=""fa fa-calendar-alt""></i>  24th March 2021</a>
                                    </div>
                                </div>
                                <div class=""category-item"">
                                    <div class=""item-image"">
                                        <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/blog/recent-posts/b-sm-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 16625, "\"", 16631, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""item-content"">
                                        <h5><a href=""blog-detail.html"">10 Reasons To Do A Digital Detox Challenge</a></h5>
                                        <a href=""#"" class=""date""><i class=""fa fa-calendar-alt""></i>  24th March 2021</a>
                                    </div>
                                </div>
                                <div class=""category-item"">
                                    <div class=""item-image"">
                                        <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/blog/recent-posts/b-sm-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 17321, "\"", 17327, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""item-content"">
                                        <h5><a href=""blog-detail.html"">10 Reasons To Do A Digital Detox Challenge</a></h5>
                                        <a href=""#"" class=""date""><i class=""fa fa-calendar-alt""></i>  24th March 2021</a>
                                    </div>
                                </div>
                                <div class=""category-item"">
                                    <div class=""item-image"">
                                        <img src=""https://xpressrow.com/html/cafena/cafena/assets/images/blog/recent-posts/b-sm-4.png""");
            BeginWriteAttribute("alt", " alt=\"", 18017, "\"", 18023, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""item-content"">
                                        <h5><a href=""blog-detail.html"">10 Reasons To Do A Digital Detox Challenge</a></h5>
                                        <a href=""#"" class=""date""><i class=""fa fa-calendar-alt""></i>  24th March 2021</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""popular-tag"">
                            <h2 class=""title"">Popular Tag</h2>
                            <div class=""tagcloud"">
                                <a href=""#"">Design</a>
                                <a href=""#"">Web Design</a>
                                <a href=""#"">Brand</a>
                                <a href=""#"">Ui/Ux</a>
                                <a href=""#"">NNC</a>
                                <a href=""#"">Design</a>
                               ");
            WriteLiteral(@" <a href=""#"">Construction</a>
                                <a href=""#"">Web Design</a>
                                <a href=""#"">Design</a>
                                <a href=""#"">Theme</a>
                                <a href=""#"">App</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
<style>
    #blog-main-section .container{
        height: 4800px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
