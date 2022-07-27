// DocSection: import_linked_upsert_Sec_variant
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('456')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'title'
      },
      value: 'Donate with us'
    },
    {
      element: {
        codename: 'related_articles'
      },
      value: [  
        {
          "external_id":"123"
        }
      ]
    }
  ])
  .toPromise();
// EndDocSection