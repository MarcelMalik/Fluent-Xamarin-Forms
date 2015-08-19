# Fluent Xamarin Forms
[![](https://img.shields.io/badge/gitter-join%20chat%20→-brightgreen.svg)](https://gitter.im/MarcelMalik/Fluent-Xamarin-Forms "Join chat")
[![](https://img.shields.io/badge/twitter-follow%20%40MarcelMalik-blue.svg)](https://twitter.com/intent/follow?original_referer=https%3A%2F%2Fgithub.com%2FMarcelMalik%2FFluent-Xamarin-Forms&screen_name=MarcelMalik&tw_p=followbutton "Follow me on Twitter")
[![](https://img.shields.io/github/release/MarcelMalik/Fluent-Xamarin-Forms.svg)](https://github.com/MarcelMalik/Fluent-Xamarin-Forms/releases "Latest release")
[![](https://www.myget.org/BuildSource/Badge/fluent-xamarin-forms?identifier=2d689f98-504a-48b8-8cf0-d9d32db980b8)](https://www.myget.org/ "Build Status")

NuGet (`master`): [![](http://img.shields.io/nuget/v/fluent-xamarin-forms.svg)](http://www.nuget.org/packages/fluent-xamarin-forms) [![](http://img.shields.io/nuget/dt/fluent-xamarin-forms.svg)](http://www.nuget.org/packages/fluent-xamarin-forms)

MyGet (`dev`):
[![](http://img.shields.io/myget/fluent-xamarin-forms/v/FluentXamarinForms.svg)](https://www.myget.org/gallery/fluent-xamarin-forms) 

Fluent Xamarin Forms is a [fluent interface](http://en.wikipedia.org/wiki/Fluent_interface "Fluent Interface") for Xamarin.Forms to build the layout of your UI in a fluent way.

### Usage
```csharp
using FluentXamarinForms;

public class SamplePage : ContentPAge
{
    public SamplePage()
    {
        // Modify already created objects, like this ContentPage, with handover as a parameter
        Create.ContentPage (this)
            .Title("Todo List")
            // Add directly a toolbar item and bind it
            .AddToolbarItem (Create.ToolbarItem ()
                .Text ("Add")
                .BindCommand ("Add"))
                // And define the content, like a list view and bind it to "Items"
                .Content (Create.ListView ()
                    .BindItemSource ("Items")
                    .ItemTemplate (new DataTemplate (typeof(TodoItemCell)))
                    .SeperatorVisibility(SeparatorVisibility.None))
                // With the final build the Xamarin.Forms controls are created
                .Build ();
    }
}
```
# Thanks to
- [@adamjwolf](https://twitter.com/adamjwolf) for the great articles on his [blog](https://www.syntaxismyui.com/) with articles like [Xinions – Xamarin.Forms style minions that do the dirty work for you](https://www.syntaxismyui.com/xinions-xamarin-forms-style-minions-that-do-the-dirty-work-for-you/) and [Xamarin.Forms - Nugget - Paddington](https://www.syntaxismyui.com/xamarin-forms-nugget-paddington/). 

# Maintainer(s)
- [@marcelmalik](https://github.com/MarcelMalik) | Twitter: [@marcelmalik](https://twitter.com/MarcelMalik)

# License
- [MIT License (MIT)](https://raw.githubusercontent.com/MarcelMalik/Fluent-Xamarin-Forms/master/LICENSE)