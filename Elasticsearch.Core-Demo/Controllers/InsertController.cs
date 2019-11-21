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
    public class InsertController : Controller
    {
        private readonly ElasticClient _client;
        public InsertController(IEsClientProvider esClientProvider)
        {
            _client = esClientProvider.GetClient();
        }
        [HttpGet]
        public void AddPerson()
        {
            var person = new Person
            {
                Id = 1,
                FirstName = "Yu",
                LastName = "Zhuang"
            };
            var ndexResponse = _client.IndexDocument(person);
        }

        public void AddPerson1()
        {
            var person = new Person
            {
                Id = 1,
                FirstName = "Yu",
                LastName = "Zhuang"
            };
            var ndexResponse = _client.IndexDocument(person);
        }

        public void AddPerson2()
        {
            var person = new Person
            {
                Id = 1,
                FirstName = "Yu",
                LastName = "Zhuang"
            };
        }
    }
}