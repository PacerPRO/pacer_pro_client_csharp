# IO.PacerPro.Api.MattersApi

All URIs are relative to *https://api.pacerpro.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MattersGetCollection**](MattersApi.md#mattersgetcollection) | **GET** /matters | A collection of matters.
[**MattersGetOne**](MattersApi.md#mattersgetone) | **GET** /matters/{matterId} | A single matter.


<a name="mattersgetcollection"></a>
# **MattersGetCollection**
> List<Matter> MattersGetCollection (string authorization = null)

A collection of matters.

Get all matters relevant to the firm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PacerPro.Api;
using IO.PacerPro.Client;
using IO.PacerPro.Model;

namespace Example
{
    public class MattersGetCollectionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new MattersApi();
            var authorization = authorization_example;  // string | Bearer {...JSON Web Token...} (optional) 

            try
            {
                // A collection of matters.
                List&lt;Matter&gt; result = apiInstance.MattersGetCollection(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MattersApi.MattersGetCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Bearer {...JSON Web Token...} | [optional] 

### Return type

[**List<Matter>**](Matter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mattersgetone"></a>
# **MattersGetOne**
> Matter MattersGetOne (string matterId, string authorization = null)

A single matter.

Get a single matter, specified by `matterId` in the path.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PacerPro.Api;
using IO.PacerPro.Client;
using IO.PacerPro.Model;

namespace Example
{
    public class MattersGetOneExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new MattersApi();
            var matterId = matterId_example;  // string | The database identifier of the matter.
            var authorization = authorization_example;  // string | Bearer {...JSON Web Token...} (optional) 

            try
            {
                // A single matter.
                Matter result = apiInstance.MattersGetOne(matterId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MattersApi.MattersGetOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matterId** | **string**| The database identifier of the matter. | 
 **authorization** | **string**| Bearer {...JSON Web Token...} | [optional] 

### Return type

[**Matter**](Matter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

