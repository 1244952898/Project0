using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elasticsearch.Core_Demo.Models;
using Elasticsearch.Core_Demo.Provider;
using Microsoft.AspNetCore.Mvc;
using Nest;



namespace Elasticsearch.Core_Demo.Controllers
{
    public class ValueController : Controller
    {
        private readonly ElasticClient _client;

        public ValueController(IEsClientProvider clientProvider)
        {
            _client = clientProvider.GetClient();
        }

        [HttpPost]
        [Route("value/index")]
        public IndexResponse Index(Post post)
        {
            return _client.IndexDocument(post);
        }

        [HttpPost]
        [Route("value/search")]
        public IReadOnlyCollection<Post> Search(string type)
        {
            return _client.Search<Post>(s => s
                .From(0)
                .Size(10)
                .Query(q => q.Match(m => m.Field(f => f.Type).Query(type)))).Documents;
        }

    }
}