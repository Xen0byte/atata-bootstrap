﻿namespace Atata.Bootstrap.Tests
{
    using _ = PillsPage;

    [Url("Pills.html")]
    [TermFindSettings(FindTermBy.Id, Case = TermCase.LowerMerged)]
    public class PillsPage : Page<_>
    {
        public TabPane1 Pane1 { get; private set; }

        public TabPane2 Pane2 { get; private set; }

        public TabPane3 Pane3 { get; private set; }

        public BSPill<_> Menu1 { get; private set; }

        public BSPill<_> Menu2 { get; private set; }

        public BSPill<_> Menu3 { get; private set; }

        public BSPill<_> Menu4 { get; private set; }

        [FindByClass("active")]
        public BSPill<_> ActiveMenu { get; private set; }

        public class TabPane1 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }

            [FindFirst]
            public TextInput<_> TextInput { get; private set; }
        }

        public class TabPane2 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }

            [FindFirst]
            public CheckBox<_> CheckBox { get; private set; }
        }

        public class TabPane3 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }
        }
    }
}
