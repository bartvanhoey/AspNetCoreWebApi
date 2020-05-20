#pragma checksum "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec0f76f4df8d8bd8ee59ddaaa580accaa37f0d8"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Web.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CenteredCardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class Signup : SignupBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                  User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                                        RegisterUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, "<div>\r\n        <br><br><br>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(6, "<div>\r\n        <h3 style=\"font-weight:bold; color:purple\">Book Stores Signup</h3>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(7, "<div>\r\n        <br>\r\n    </div>\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12 row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "class", "form-control col-12");
                __builder2.AddAttribute(13, "placeholder", "email address");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                                                  User.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.EmailAddress = __value, User.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-12 row");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "password");
                __builder2.AddAttribute(23, "class", "form-control col-12");
                __builder2.AddAttribute(24, "placeholder", "password");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                                                                  User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Password = __value, User.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    <br>\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-12 row");
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control col-12");
                __builder2.AddAttribute(35, "placeholder", "confirm password");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                                                                  User.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.ConfirmPassword = __value, User.ConfirmPassword));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(40, "<div class=\"col-12 row\">\r\n        <span class=\"col-12\"></span>\r\n        <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Signup\">\r\n    </div>\r\n    <br>\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-12 row");
                __builder2.AddAttribute(43, "style", "text-align:left; font-weight:bold");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "span");
                __builder2.AddAttribute(46, "class", "col-12");
                __builder2.AddContent(47, 
#nullable restore
#line 32 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Login\Signup.razor"
                              LoginMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591