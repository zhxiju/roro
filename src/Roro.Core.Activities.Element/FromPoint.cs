﻿using System;

namespace Roro.Core.Activities.Element
{
    public sealed class FromPoint : Activity
    {
        public InArgument<int> X { get; set; }

        public InArgument<int> Y { get; set; }

        public InArgument<double> Z { get; set; }

        public OutArgument<bool> Element { get; set; }

        public override void Execute(ActivityContext context)
        {
            var x = context.Get(X);
            var y = context.Get(Y);
            context.Set(Element, true);
        }
    }
}
