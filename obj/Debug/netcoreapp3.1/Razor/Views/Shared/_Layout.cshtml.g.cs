#pragma checksum "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "853dcf019a12adb9336b517e4e668d31c377d658"
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
#line 1 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"853dcf019a12adb9336b517e4e668d31c377d658", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419faa760c6c307eccb65dec4c048e073b2e08a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n\r\n<html lang=\"ru\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d6585885", async() => {
                WriteLiteral("\r\n\t\t<meta charset=\"utf-8\">\r\n\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n        <meta property=\"og:site_name\" content=\"Openwheels.tk\"/>\r\n         \r\n         \r\n");
#nullable restore
#line 10 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
         if(Model is Post)
        {
            var imageLink = "https://openwheels.tk" + @Model.ImageFile;
            var directLink = "https://openwheels.tk/Home/PostView/" + @Model.Id;
            

#line default
#line hidden
#nullable disable
                WriteLiteral("<meta property = \"og:url\"");
                BeginWriteAttribute("content", " content = \"", 474, "\"", 497, 1);
#nullable restore
#line 14 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 486, directLink, 486, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <meta property = \"og:image\"");
                BeginWriteAttribute("content", " content = \"", 540, "\"", 562, 1);
#nullable restore
#line 15 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 552, imageLink, 552, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 16 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
        }else
        {
            
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        
        <meta property=""og:image:width"" content=""640"" /> 
        <meta property=""og:image:height"" content=""442"" />
		 
		
		<meta name=""keywords"" content=""формула1, формула, гонки, ЯП, яплакал"">
		<meta name=""author"" content=""Pitchie"">
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.0/jquery.js"" integrity=""sha256-r/AaFHrszJtwpe+tHyNi/XCfMxYpbsRg2Uqn0x3s2zc="" crossorigin=""anonymous""></script> 
        <link href=""/css/fileinput.min.css"" media=""all"" rel=""stylesheet"" type=""text/css"" />
		<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
        <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
        <script src=""/js/fileinput.min.js""></script>
         <script type=""text/javascript"" src=""/js/FeedEk.js""></script>
         <script src=""/js/bootstrap-switch.js""></script>
        <!------ Include the above in your HEAD tag ---------->
         
        <link href=""//m");
                WriteLiteral(@"axcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"" rel=""stylesheet"">
		<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css"" integrity=""sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb"" crossorigin=""anonymous"">
        <link rel=""stylesheet"" href=""/css/style.css"">
        <link rel=""stylesheet"" href=""/css/social.css"">
        <link rel=""stylesheet"" href=""/css/FeedEk.css"">
         
        <link href=""/css/bootstrap-switch.css"" rel=""stylesheet"">
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
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d65810146", async() => {
                WriteLiteral(@"
        <div class=""content"">
             
            <nav class=""navbar navbar-expand-lg navbar-dark mx-background-top-linear"">
                <div class=""container"">
                <a class=""navbar-brand"" rel=""nofollow"" href=""/Home/Index"" style=""text-transform: uppercase;""> F1 Flooder</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">

                    <ul class=""navbar-nav ml-auto"">

                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/Home/Index"">ГЛАВНАЯ
                        <span class=""sr-only"">(current)</span>
                        </a>
                    </li>

                    
                    <li c");
                WriteLiteral(@"lass=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Index"">Новости</a>
                    </li>

                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Форум</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Chat"">Чятик</a>
                    </li>
");
#nullable restore
#line 74 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
                     if(User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span style=\"color: beige; margin-top: 12px;font-size: smaller;\">");
#nullable restore
#line 76 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
                                                                                    Write(User.FindFirst("Name").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <li>\r\n                            \r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d65812658", async() => {
                    WriteLiteral(@"
                                    <span style=""margin-top: 12px; font-size: smaller;"">
                                        <input style=""margin-top: 5px; margin-left: 10px;"" class=""logout-btn btn btn-outline-dark btn-sm"" type=""submit"" value=""Выход"" />
                                    </span>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 85 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Account/Register"">Регистрация</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Account/Login"">Вход</a>
                        </li>
");
#nullable restore
#line 93 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n                </div>\r\n            </nav>\r\n            <main role=\"main\">\r\n                \r\n                \r\n                ");
#nullable restore
#line 101 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </main>\r\n        \r\n        </div>\r\n\t\t<footer role=\"contentinfo\" class=\"footer\">\r\n            \r\n\t\t\t<div class=\"container\">\r\n\t\t\t\t<span style=\"color: beige;\">© F1 говорильня - 2020 - </span>\r\n\t\t\t</div>\r\n\t\t</footer>\r\n\t");
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
            WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/aspnet-signalr/1.1.4/signalr.min.js\" integrity=\"sha256-LeAW7V38b1z8nHHlrckbnAfx5W4Ge57nDlsDz6GzJjc=\" crossorigin=\"anonymous\"></script>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d65817315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d65818359", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "853dcf019a12adb9336b517e4e668d31c377d65819403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 116 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script type=""text/javascript"" src=""/js/FeedEk.js""></script>
    <script>
        $('#divRss').FeedEk({
            FeedUrl : 'f1news.ru/export/news.xml',
            MaxCount : 5,
            ShowDesc : true,
            ShowPubDate:true,
            DescCharacterLimit:100,
            TitleLinkTarget:'_blank',
            DateFormat : 'dd/MM/yyyy',
            DateFormatLang : 'ru'
        });
    </script>
    <script>
        
        let elem = $('.iframe-link');
        elem.on('click', function(e){
            e.preventDefault();
            alert(elem.attr('href'));
            $('#modalWindow').addClass(""visible""); 
            $('#iframe-window').attr('src', $(this).attr('href'));
            
            $('#linkToF1').attr('href', $(this).attr('href'))
            
            
        });
        function showModal(self) {
            var modal = document.getElementById('modalWindow');
            modal.style.display = 'block';
            var iframe = modal.get");
            WriteLiteral(@"ElementsByTagName('iframe')[0];
            $('#iframe-window').attr('src', elem.attr('href'));
            $('#modalWindow').css('display', 'block');
            
            $('.modal-window').css('display', 'block');
            return false;
        }
        $(document).mouseup(function (e) {
            var container = $(""#modalWindow"");
            if (container.has(e.target).length === 0){
                container.hide();
                $('.overlay').hide();
            }
        });
        
    </script>
    <script src=""https://yastatic.net/es5-shims/0.0.2/es5-shims.min.js""></script>
    <script src=""https://yastatic.net/share2/share.js""></script>
    ");
#nullable restore
#line 164 "G:\work\dotnet\openwheels\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>\r\n");
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
