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
    public class SelectController : Controller
    {
        private readonly ElasticClient _client;
        public SelectController(IEsClientProvider esClientProvider)
        {
            _client = esClientProvider.GetClient();
        }
        public Person GetUser()
        {
            var searchResponse = _client.Search<Person>(s => s
                 .From(0)
                 .Size(10)
                 .Query(q => q
                      .Match(m => m
                         .Field(f => f.FirstName)
                         .Query("Yu")
                      )
                 )
             );

            var peoples = searchResponse.Documents.GetEnumerator();
            return peoples.Current;
        }

        public async Task GetUserByAllIndicesAsync()
        {
            var result =await _client.SearchAsync<Person>(s => s
            .AllIndices()
            .From(0)
            .Size(10)
            .Query(q => q.Match(m=>m.Field(f=>f.FirstName)
            .Query("Yu"))));

        }

        public async Task GetUserByMatchAllAsync()
        {
            var searchResponse =await _client.SearchAsync<Person>(s => s
            .Query(q => q.MatchAll())
            );
            var a = searchResponse;
        }

        public async Task HLTest()
        {
            string queryString = "second blog";
            var filters = new List<Func<QueryContainerDescriptor<WebsiteModel>, QueryContainer>>();
            filters.Add(fb=>fb.Bool(
                fm=>fm.Must(
                    fmt=>fmt.Match(
                        ff=>ff.Field(
                            f=>f.Text
                            )
                        .Query("")
                        )
                    )
                ));
        }
    }
}