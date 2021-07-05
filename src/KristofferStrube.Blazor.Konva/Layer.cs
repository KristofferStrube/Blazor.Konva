using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferStrube.Blazor.Konva
{
    public class Layer
    {
        internal readonly IJSObjectReference jSLayer;
        private readonly IJSInProcessObjectReference konvaWrapper;

        internal Layer(IJSObjectReference jSLayer, IJSInProcessObjectReference konvaWrapper)
        {
            this.jSLayer = jSLayer;
            this.konvaWrapper = konvaWrapper;
        }

        public async Task AddAsync(IShape shape) => await konvaWrapper.InvokeVoidAsync("add", jSLayer, shape.jSShape);

        public async Task Draw() => await konvaWrapper.InvokeVoidAsync("draw", jSLayer);
    }
}
