using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

namespace theme_switcher.Shared
{
    public partial class ThemeSwitcher
    {
        public sealed class ThemesSelectorContainerContext {
            public bool ThemesSelectorVisible { get;}
            public RenderFragment ThemesSelectorView { get; }

            public ThemesSelectorContainerContext(bool visible, RenderFragment fragment) {
                ThemesSelectorVisible = visible;
                ThemesSelectorView = fragment;
            }
        }
        public sealed class AffectedAreaContext {
            public string CurrentThemeUrl { get; }
            public bool ThemesSelectorVisible { get; }
            public Action HideThemesContainer { get; }
            public Action ShowThemesContainer { get; }
            public RenderFragment ToggleButton { get; }
            public RenderFragment ThemesSelectorContainer { get; }
            public AffectedAreaContext(ThemeSwitcher owner, RenderFragment toggleButton, RenderFragment themesSelectorContainer) {
                ThemesSelectorVisible = owner.themesVisible;
                CurrentThemeUrl = $"/themes/{owner.appliedTheme}/bootstrap.min.css";
                ToggleButton = toggleButton;
                ThemesSelectorContainer = themesSelectorContainer;
                HideThemesContainer = () => {
                    owner.themesVisible = false;
                    owner.StateHasChanged();
                };
                ShowThemesContainer = () => {
                    owner.themesVisible = true;
                    owner.StateHasChanged();
                };
                
            }
        }
        public sealed class ToggleButtonContainerContext { 
            public string CurrentTheme { get; }
            public Action ToggleThemesContainer { get; }

            public ToggleButtonContainerContext(ThemeSwitcher owner) {
                var toggleArg = !owner.themesVisible;
                CurrentTheme = owner.appliedTheme;
                ToggleThemesContainer = () => {
                    owner.themesVisible = toggleArg;
                    owner.StateHasChanged();
                };
            }

        }
        sealed class JSModuleSource : Lazy<TaskCompletionSource<IJSObjectReference>>, IAsyncDisposable {
            public JSModuleSource() : base(() => new TaskCompletionSource<IJSObjectReference>(TaskCreationOptions.RunContinuationsAsynchronously)) { }

            public async ValueTask Attach(IJSRuntime runtime) {
                try {
                    var module = await runtime.InvokeAsync<IJSObjectReference>("import", "/theme-switcher.js");
                    Value.TrySetResult(module);
                } catch (OperationCanceledException e) {
                    Value.TrySetCanceled(e.CancellationToken);
                } catch (AggregateException e) {
                    Value.TrySetException(e.InnerExceptions);
                } catch (Exception e) {
                    Value.TrySetException(e);
                }
            }
            public async ValueTask<string> PrepareInstantLoadAsync(string theme) {
                try {
                    var module = await Value.Task;
                    return await module.InvokeAsync<string>("preloadStylesheetResource", theme);
                } catch (OperationCanceledException) { }
                return string.Empty;
            }
            public async  ValueTask DisposeAsync() {
                try {
                    if(IsValueCreated && !Value.TrySetCanceled()) {
                        await Value.Task.Result.DisposeAsync().ConfigureAwait(false);
                    }
                } catch (OperationCanceledException) { }
            }
        }
    }
}
