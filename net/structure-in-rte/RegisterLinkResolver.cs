// DocSection: structure_in_rte_register_link_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://github.com/Kentico/kontent-delivery-sdk-net/wiki/Resolving-links-to-content-items#registering-a-resolver
using Kentico.Kontent.Delivery;

// Sets the resolver as an optional dependency of the `IDeliveryClient` instance
IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_PROJECT_ID>")
    .WithContentLinkUrlResolver(new CustomContentLinkUrlResolver())
    .Build();
// EndDocSection