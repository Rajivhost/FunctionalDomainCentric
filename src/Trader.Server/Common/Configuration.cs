using Hse.Application.Contracts;
using Rebus.Compression;
using Rebus.Config;
using Rebus.Retry.Simple;
using Rebus.Routing.TypeBased;
using Rebus.Transport.InMem;

namespace Hse.Configuration
{
    public class RebusConfig
    {
        public static RebusConfigurer Configure(RebusConfigurer configuration) => configuration
                .Logging(conf => conf.Serilog())
                .Serialization(conf => conf.UseWire())
                .Transport(conf => conf.UseInMemoryTransport(new InMemNetwork(), "server-commands"))
                .Routing(conf => conf.TypeBased().MapAssemblyOf<WarehouseCommand>("server-commands"))
                .Options(conf =>
                {
                    conf.SimpleRetryStrategy();
                    conf.SetMaxParallelism(1);
                    conf.EnableCompression();
                });
    }
}