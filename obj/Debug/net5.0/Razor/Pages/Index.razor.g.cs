#pragma checksum "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e922a208297ae64d578db06e5dc96424aec443c0"
// <auto-generated/>
#pragma warning disable 1591
namespace grid_handle_prerender.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using grid_handle_prerender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/_Imports.razor"
using grid_handle_prerender.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using DevExtreme.AspNet.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using DevExtreme.AspNet.Data.ResponseModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxDataGrid<SurveySmallDto>>(0);
            __builder.AddAttribute(1, "CustomData", new System.Func<DevExtreme.AspNet.Data.DataSourceLoadOptionsBase, System.Threading.CancellationToken, System.Threading.Tasks.Task<DevExtreme.AspNet.Data.ResponseModel.LoadResult>>(
#nullable restore
#line 9 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                         LoadSurveysAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "KeyFieldName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                          nameof(SurveySmallDto.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "DataNavigationMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.DataGridNavigationMode>(
#nullable restore
#line 12 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                                DataGridNavigationMode.VirtualScrolling

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                      25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ShowDetailRow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AutoCollapseDetailRow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowColumnDragDrop", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                                 false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "AllowSort", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                       false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ShowColumnHeaders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "CssClass", "survey-grid");
            __builder.AddAttribute(11, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(12);
                __builder2.AddAttribute(13, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                                 nameof(SurveySmallDto.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(15);
                __builder2.AddAttribute(16, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
                                 nameof(SurveySmallDto.Field1)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/akorenchikov/Development/blazor-projects/grid-handle-prerender/Pages/Index.razor"
       
    readonly TaskCompletionSource attachTcs; 
    public Index() {
        attachTcs = new TaskCompletionSource();
    }

    async Task<LoadResult> LoadSurveysAsync(DataSourceLoadOptionsBase options, CancellationToken ct = default) {
        try {
            Console.WriteLine("LoadSurveysAsync: wait attach");
            await attachTcs.Task;
            await Task.Delay(400);
            Console.WriteLine("LoadSurveysAsync: fetch data");
            return DataSourceLoader.Load(Enumerable.Range(0, 1000).Select(i => SurveySmallDto.Create(i)), options);
        } catch(OperationCanceledException) {
            Console.WriteLine("LoadSurveysAsync: catch cancel");
            throw;
        }
    }
    protected override void OnAfterRender(bool firstRender) {
        if(firstRender) {
            Console.WriteLine("OnAfterRender: attach");
            attachTcs.TrySetResult();
        }
    }
    public void Dispose() {
        Console.WriteLine("Dispose: throw cancel");
        attachTcs.TrySetCanceled();
    }

    
    class SurveySmallDto {
        [Key]
        public int Id { get; set; }
        public string Field1 { get; set; }

        public static SurveySmallDto Create(int id) {
            return new SurveySmallDto() {
                Id = id,
                Field1 = $"Field1 = {id}"
            };
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
