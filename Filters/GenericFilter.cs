using Microsoft.AspNetCore.Mvc.Filters;
using OrchardCore.DisplayManagement;
using OrchardCore.DisplayManagement.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejzbolNet.MainTheme.Filters
{
    public class GenericFilter : IAsyncResultFilter
    {
        private readonly IShapeFactory _shapeFactory;
        private readonly ILayoutAccessor _layoutAccessor;

        public GenericFilter(ILayoutAccessor layoutAccessor, IShapeFactory shapeFactory)
        {
            _layoutAccessor = layoutAccessor;
            _shapeFactory = shapeFactory;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            dynamic layout = await _layoutAccessor.GetLayoutAsync();
            var zone = layout.Zones["Header"];
            var shape = await _shapeFactory.New.GenericShape();
            await zone.AddAsync(shape);
            await next();
        }
    }
}
