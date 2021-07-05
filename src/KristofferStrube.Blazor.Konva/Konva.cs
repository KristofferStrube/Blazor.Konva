using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;

namespace KristofferStrube.Blazor.Konva
{
    public class Konva
    {
        private readonly IJSRuntime jSRuntime;
        public Konva(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task<Stage> CreateStageAsync(string container, double width, double height)
        {
            var konvaWrapper = await jSRuntime.InvokeAsync<IJSInProcessObjectReference>("import", "./_content/KristofferStrube.Blazor.Konva/KristofferStrube.Blazor.konva.js");
            var jSStage = await konvaWrapper.InvokeAsync<IJSObjectReference>("createStage", container, width, height);
            return new Stage(jSStage, konvaWrapper);
        }

        public async Task<Layer> CreateLayerAsync()
        {
            var konvaWrapper = await jSRuntime.InvokeAsync<IJSInProcessObjectReference>("import", "./_content/KristofferStrube.Blazor.Konva/KristofferStrube.Blazor.konva.js");
            var jSLayer = await konvaWrapper.InvokeAsync<IJSObjectReference>("createLayer");
            return new Layer(jSLayer, konvaWrapper);
        }

        public async Task<Circle> CreateCircleAsync(double x, double y, double radius, string fill, string stroke, double strokeWidth)
        {
            var konvaWrapper = await jSRuntime.InvokeAsync<IJSInProcessObjectReference>("import", "./_content/KristofferStrube.Blazor.Konva/KristofferStrube.Blazor.konva.js");
            var jSCircle = await konvaWrapper.InvokeAsync<IJSObjectReference>("createCircle", x, y, radius, fill, stroke, strokeWidth);
            return new Circle(jSCircle, konvaWrapper);
        }
    }
}
