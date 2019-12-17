﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GitHub.DistributedTask.Expressions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IReadOnlyArray : IReadOnlyList<Object>
    {
    }
}