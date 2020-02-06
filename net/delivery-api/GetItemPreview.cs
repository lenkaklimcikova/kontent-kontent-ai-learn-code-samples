// DocSection: delivery_api_get_item_preview
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("<YOUR_PROJECT_ID>")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Generate strongly typed models via https://github.com/Kentico/kontent-generators-net
DeliveryItemResponse response = await client.GetItemAsync("my_article");
ContentItem item = response.Item;
// EndDocSection
