// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
       
    List<string> animalEmoji = new List<string>()
{
        "🐶","🐶",
        "🐺","🐺",
        "🐮","🐮",
        "🦊","🦊",
        "🐱","🐱",
        "🦁","🦁",
        "🐯","🐯",
        "🐹","🐹",
    };

    List<string> shuffledAnimals = new List<string>();

    protected override void OnInitialized()
    {
        SetUpGame();
    }

    private void SetUpGame()
    {
        Random random = new Random();
        shuffledAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .ToList();
    }

    string lastAnimalFound = string.Empty;

    private void ButtonClick(string animal)
    {
        if (lastAnimalFound == string.Empty)
        {
            // Remember first selection of the pair
            lastAnimalFound = animal;
        } else if (lastAnimalFound == animal)
        {
            // Match found. Reset for next pair
            lastAnimalFound = string.Empty;

            // Replace found animals with empty string to hide them
            shuffledAnimals = shuffledAnimals
                .Select(a => a.Replace(animal, string.Empty))
                .ToList();
        } else
        {
            // user selected an unmatched pair
            // reset selection
            lastAnimalFound = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
