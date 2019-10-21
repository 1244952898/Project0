using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elasticsearch.Core_Demo.Provider
{
    public interface IEsClientProvider
    {
        ElasticClient GetClient();
    }
}
