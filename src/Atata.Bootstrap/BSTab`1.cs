﻿namespace Atata.Bootstrap
{
    [ControlDefinition("li[parent::ul[contains(concat(' ', normalize-space(@class), ' '), ' nav-tabs ')]]", ComponentTypeName = "tab")]
    [ControlFinding(FindTermBy.Content)]
    public class BSTab<TOwner> : BSNavItem<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
