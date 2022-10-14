[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](/LICENSE.md)

# Introduction
A Blazor wrapper for the JavaScript library Konva.js
**This is not a full wrapper but a sample of how to get started wrapping a library.**
# Demo

The sample project can be demoed at [https://kristofferstrube.github.io/Blazor.Konva/](https://kristofferstrube.github.io/Blazor.Konva/)

# Getting Started
## Prerequisites
You need to install .NET 5.0 or newer to use the library.

[Download .NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)

## Installation
Not on Nuget

# Usage
The package can be used in Blazor WebAssembly projects.
## Assets
You first need to reference `Konva.js` since this is only a wrapper. You can do this using you favorite JS package manager (e.g. `NPM` or `Library Manager`) or just add the following to the body of your `index.html` file after the point where you reference `_framework/blazor.webassembly.js`.
```html
<script src="https://unpkg.com/konva@8/konva.min.js"></script>

```
## Import
You also need to reference the package in order to use it in you packages. This can be done in `_Import.razor` by adding the following.
```csharp
@using KristofferStrube.Blazor.Konva
```
## Add to service collection
An easy way to make Konva available in all your pages is by registering it in the `IServiceCollection` so that it can be dependency injected in the pages that need it. This is done in `Program.cs` by adding the following before you build the service collection.
```csharp
public static async Task Main(string[] args)
{
    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");

    // Other services are added.

    builder.Services.AddScoped(sp => new Konva(sp.GetService<IJSRuntime>()));

    await builder.Build().RunAsync();
}
```
## Inject in page
TODO but look in the index page

# Related articles
This repository was build on top of the work done in the following series of articles:

- [Wrapping JavaScript libraries in Blazor WebAssembly/WASM](https://blog.elmah.io/wrapping-javascript-libraries-in-blazor-webassembly-wasm/)
- [Call anonymous C# functions from JS in Blazor WASM](https://blog.elmah.io/call-anonymous-c-functions-from-js-in-blazor-wasm/)
- [Using JS Object References in Blazor WASM to wrap JS libraries](https://blog.elmah.io/using-js-object-references-in-blazor-wasm-to-wrap-js-libraries/)
- [Blazor WASM 404 error and fix for GitHub Pages](https://blog.elmah.io/blazor-wasm-404-error-and-fix-for-github-pages/)
- [How to fix Blazor WASM base path problems](https://blog.elmah.io/how-to-fix-blazor-wasm-base-path-problems/)
