﻿namespace TheDmi.CouchDesignDocuments
{
    public class ViewIdentifier
    {
        public ViewIdentifier(string designDocumentName, string viewId)
        {
            DesignDocumentName = designDocumentName;
            ViewId = viewId;
        }

        public string DesignDocumentId => "_design/" + DesignDocumentName;

        public string DesignDocumentName { get; }

        public string ViewId { get; }
    }
}