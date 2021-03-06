using System;
using System.Collections.Generic;

namespace Cloud5mins.AzShortener
{
    public class ListResponse
    {
        public List<ShortUrlEntity> UrlList { get; set; }

        public ListResponse(){}
        public ListResponse (List<ShortUrlEntity> list)
        {
            UrlList = list;
        }
    }
}