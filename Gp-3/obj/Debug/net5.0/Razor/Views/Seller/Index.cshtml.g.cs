#pragma checksum "C:\Users\Voli\Documents\GitHub\GP-3\Gp-3\Views\Seller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6499280c6375abb9702d7de26005e7b6367897c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Index), @"mvc.1.0.view", @"/Views/Seller/Index.cshtml")]
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
#line 1 "C:\Users\Voli\Documents\GitHub\GP-3\Gp-3\Views\_ViewImports.cshtml"
using Gp_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Voli\Documents\GitHub\GP-3\Gp-3\Views\_ViewImports.cshtml"
using Gp_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6499280c6375abb9702d7de26005e7b6367897c2", @"/Views/Seller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24aff37f62a436d6804e336eb3afc78cbca03912", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6499280c6375abb9702d7de26005e7b6367897c24567", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>AdminLTE 3 | Fixed Sidebar</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""../../plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""../../dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6499280c6375abb9702d7de26005e7b6367897c26447", async() => {
                WriteLiteral(@"
    <!-- Site wrapper -->
    <div class=""wrapper"">
        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""../../index3.html"" class=""nav-link"">Home</a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""#"" class=""nav-link"">Contact</a>
                </li>
            </ul>

            <!-- SEARCH FORM -->
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6499280c6375abb9702d7de26005e7b6367897c27515", async() => {
                    WriteLiteral(@"
                <div class=""input-group input-group-sm"">
                    <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-navbar"" type=""submit"">
                            <i class=""fas fa-search""></i>
                        </button>
                    </div>
                </div>
            ");
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

            <!-- Right navbar links -->
            <ul class=""navbar-nav ml-auto"">

                <!-- Notifications Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-bell""></i>
                        <span class=""badge badge-warning navbar-badge"">15</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                        <div class=""dropdown-divider""></div>

                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-file mr-2""></i> 3 new reports
                            <span class=""float-right text-muted text-sm"">2 days</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" ");
                WriteLiteral(@"class=""dropdown-item dropdown-footer"">See All Notifications</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"">
                        <i class=""fas fa-th-large""></i>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""../../index3.html"" class=""brand-link"">
                <img src=""../../dist/img/AdminLTELogo.png""
                     alt=""AdminLTE Logo""
                     class=""brand-image img-circle elevation-3""
                     style=""opacity: .8"">
                <span class=""brand-text font-weight-light"">Seller</span>
            </a>

            <!-- Sidebar -->
            <div class=""sidebar"">
                <!-- Sideba");
                WriteLiteral(@"r user (optional) -->
                <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                    <div class=""image"">
                        <img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"">
                    </div>
                    <div class=""info"">
                        <a href=""#"" class=""d-block"">Alexander Pierce</a>
                    </div>
                </div>

                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
                        with font-awesome or any other icon font library -->







                        <li class=""nav-header"">EXAMPLES</li>
                        <li class=""nav-item"">
                            <a href=""../calendar.html"" class=""nav-link"">
                       ");
                WriteLiteral(@"         <i class=""nav-icon far fa-calendar-alt""></i>
                                <p>
                                    Calendar
                                    <span class=""badge badge-info right"">2</span>
                                </p>
                            </a>
                        </li>


                        <li class=""nav-item has-treeview"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""nav-icon fas fa-book""></i>
                                <p>
                                    Pages
                                    <i class=""fas fa-angle-left right""></i>
                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""../examples/invoice.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon"">");
                WriteLiteral(@"</i>
                                        <p>Invoice</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""../examples/profile.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Profile</p>
                                    </a>
                                </li>

                                <li class=""nav-item"">
                                    <a href=""../examples/projects.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Products</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""../examples/project_add.html"" class=""nav-link"">
    ");
                WriteLiteral(@"                                    <i class=""far fa-circle nav-icon""></i>
                                        <p>Add product</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""../examples/project_edit.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Edit product</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""../examples/project_detail.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Product Details</p>
                                    </a>
                                </li>

                            </ul>
                     ");
                WriteLiteral(@"   </li>


                    </ul>
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>

    </div>
    <section class=""content-header""style=""padding-left:200px"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Profile</h1>
                </div>
                
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <section class=""content"">
        <div class=""container-fluid"" style=""padding-left:200px"">
            <div class=""row"">
                <div class=""col-md-3"">

                    <!-- Profile Image -->
                    <div class=""card card-primary card-outline"">
                        <div class=""card-body box-profile"">
                            <div class=""text-center"">
                                <img class=""profile-user-img img-fluid img-circle"" src=""../../dist/im");
                WriteLiteral(@"g/user4-128x128.jpg"" alt=""User profile picture"">
                            </div>

                            <h3 class=""profile-username text-center"">Nina Mcintire</h3>

                            <p class=""text-muted text-center"">Software Engineer</p>

                       </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                    <!-- About Me Box -->
                    <div class=""card card-primary"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">About Me</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <strong><i class=""fas fa-book mr-1""></i> Education</strong>

                            <p class=""text-muted"">
                                B.S. in Computer Science from the University of Tennessee at Knoxville
                           ");
                WriteLiteral(@" </p>

                            <hr>

                            <strong><i class=""fas fa-map-marker-alt mr-1""></i> Location</strong>

                            <p class=""text-muted"">Malibu, California</p>

                            <hr>

                            <strong><i class=""fas fa-pencil-alt mr-1""></i> Skills</strong>

                            <p class=""text-muted"">
                                <span class=""tag tag-danger"">UI Design</span>
                                <span class=""tag tag-success"">Coding</span>
                                <span class=""tag tag-info"">Javascript</span>
                                <span class=""tag tag-warning"">PHP</span>
                                <span class=""tag tag-primary"">Node.js</span>
                            </p>

                            <hr>

                            <strong><i class=""far fa-file-alt mr-1""></i> Notes</strong>

                            <p class=""text-muted"">Lorem ipsum dolor sit ");
                WriteLiteral(@"amet, consectetur adipiscing elit. Etiam fermentum enim neque.</p>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills"">
                                
                                <li ><a >Settings</a></li>
                            </ul>
                        </div><!-- /.card-header -->
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                
                               

                                <div  id=""settings"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6499280c6375abb9702d7de26005e7b6367897c220067", async() => {
                    WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">First Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputName"" placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputName2"" class=""col-sm-2 col-form-label"">Last Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputName2"" placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form");
                    WriteLiteral(@"-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label for=""inputExperience"" class=""col-sm-2 col-form-label"">Experience</label>
                                            <div class=""col-sm-10"">
                                                <textarea class=""form-control"" id=""inputExperience"" placeholder=""Experience""></textarea>
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                       ");
                    WriteLiteral(@"                     <div class=""offset-sm-2 col-sm-10"">
                                                <div class=""checkbox"">
                                                    <label>
                                                        <input type=""checkbox""> I agree to the <a href=""#"">terms and conditions</a>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""submit"" class=""btn btn-danger"">Submit</button>
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <!-- /.tab-pane -->
                            </div>
                            <!-- /.tab-content -->
                        </div><!-- /.card-body -->
                    </div>
                    <!-- /.nav-tabs-custom -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>

    <!-- ./wrapper -->
    <!-- REQUIRED SCRIPTS -->
    <!-- jQuery -->
    <script src=""../../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/adminlte.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
