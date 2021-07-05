using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferStrube.Blazor.Konva
{
    public class Stage
    {
        private readonly IJSObjectReference jSStage;
        private readonly IJSInProcessObjectReference konvaWrapper;

        internal Stage(IJSObjectReference jSStage, IJSInProcessObjectReference konvaWrapper)
        {
            this.jSStage = jSStage;
            this.konvaWrapper = konvaWrapper;
        }

        public async Task AddAsync(Layer Layer) => await konvaWrapper.InvokeVoidAsync("add", jSStage, Layer.jSLayer);

        public async Task<double> WidthAsync() => await jSStage.InvokeAsync<double>("width");
        public async Task<double> HeightAsync() => await jSStage.InvokeAsync<double>("height");
    }
}
