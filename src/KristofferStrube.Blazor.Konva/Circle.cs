using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferStrube.Blazor.Konva
{
    public class Circle : IShape
    {
        internal IJSObjectReference jSShape { get; init; }
        IJSObjectReference IShape.jSShape { get => jSShape; init => jSShape = value; }

        private readonly IJSInProcessObjectReference konvaWrapper;

        internal Circle(IJSObjectReference jSCircle, IJSInProcessObjectReference konvaWrapper)
        {
            jSShape = jSCircle;
            this.konvaWrapper = konvaWrapper;
        }
    }
}
