﻿using System.ComponentModel;

namespace MudBlazor
{
    public enum MaxWidth
    {
        [Description("lg")]
        Large,
        [Description("md")]
        Medium,
        [Description("sm")]
        Small,
        [Description("xl")]
        ExtraLarge,
        [Description("xs")]
        ExtraSmall,
        [Description("false")]
        False,
    }
}
