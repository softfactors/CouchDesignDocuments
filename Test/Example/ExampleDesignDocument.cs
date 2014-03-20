﻿namespace TheDmi.CouchDesignDocuments.Test.Example
{
    using TheDmi.CouchDesignDocuments;

    public class ExampleDesignDocument : DesignDocument
    {
        public override string Name { get { return "example"; } }

        public class Views : ViewsSection<Views>
        {
            public static ViewSpec ByDate { get { return MapView(); } }

            public static ViewSpec SumQuantities { get { return MapReduceView(); } }
        }

        public class Shows : ShowsSection<Shows>
        {
            public static FunctionSpec Index { get { return Show(); } }
        }
    }
}
