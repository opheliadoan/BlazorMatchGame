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
#nullable restore
#line 2 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
using System.Timers;

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
#line 43 "/Users/phuonganhdoan/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
       
    List<string> animalEmoji = new List<string>()
{
        "🐶",
        "🐺",
        "🐮",
        "🦊",
        "🐱",
        "🦁",
        "🐯",
        "🐹",
        "🐧",
        "🐸",
        "🐤",
        "🐙",
        "🐞",
        "🐨",
        "🐲",
        "🐳",
    };

    List<string> shuffledAnimals = new List<string>();
    int matchesFound = 0;
    Timer timer;
    int tenthsOfSecondsElapsed = 0;
    string timeDisplay;
    double currentRecord;
    double updatedRecord;
    string bestRecord;
    int countdown = 30;

    protected override void OnInitialized()
    {
        timer = new Timer();
        timer.Elapsed += Timer_Tick;

        SetUpGame();
    }

    private void SetUpGame()
    {
        Random random = new Random();

        shuffledAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .Take(8)
            .ToList();

        shuffledAnimals = shuffledAnimals
            .Concat(shuffledAnimals)
            .OrderBy(item => random.Next())
            .ToList();

        matchesFound = 0;

        // tenthsOfSecondsElapsed = 0;
        countdown = 300;
    }

    string lastAnimalFound = string.Empty;
    string lastDescription = string.Empty;

    private void ButtonClick(string animal, string animalDescription)
    {
        if (lastAnimalFound == string.Empty)
        {
            // Remember first selection of the pair
            lastAnimalFound = animal;
            lastDescription = animalDescription;
            timer.Start();
        } else if ((lastAnimalFound == animal) && (lastDescription != animalDescription))
        {
            // Match found. Reset for next pair
            lastAnimalFound = string.Empty;

            // Replace found animals with empty string to hide them
            shuffledAnimals = shuffledAnimals
                .Select(a => a.Replace(animal, string.Empty))
                .ToList();

            matchesFound++;

            if (matchesFound == 8)
            {
                timer.Stop();
                timeDisplay += " - Play Again?";

                // currentRecord = tenthsOfSecondsElapsed;
                currentRecord = countdown;

                if (updatedRecord > currentRecord) ;

                updatedRecord = currentRecord;
                bestRecord = ((300 - updatedRecord) / 10F).ToString("0.0s");

                SetUpGame();
            }
        } else
        {
            // user selected an unmatched pair
            // reset selection
            lastAnimalFound = string.Empty;
        }
    }

    private void Timer_Tick(Object source, ElapsedEventArgs e)
    {
        InvokeAsync(() =>
        {
            // tenthsOfSecondsElapsed++;
            // timeDisplay = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            countdown--;
            if (countdown < 1)
            {
                timer.Stop();
            }
            timeDisplay = (countdown / 10F).ToString("0.0s");
            StateHasChanged();
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
