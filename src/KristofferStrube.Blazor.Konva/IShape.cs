using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferStrube.Blazor.Konva
{
    public interface IShape
    {
        internal IJSObjectReference jSShape { get; init; }
    }
}
