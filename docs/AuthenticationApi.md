# IO.PacerPro.Api.AuthenticationApi

All URIs are relative to *https://api.pacerpro.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionCreate**](AuthenticationApi.md#sessioncreate) | **POST** /session | Initial authentication.
[**SessionDelete**](AuthenticationApi.md#sessiondelete) | **DELETE** /session | Revoke all JWT tokens (logout).
[**SessionRefresh**](AuthenticationApi.md#sessionrefresh) | **GET** /session | Refresh authentication token


<a name="sessioncreate"></a>
# **SessionCreate**
> Session SessionCreate (User user)

Initial authentication.

Use this call to generate an authorization token for use in future calls. Provide your PacerPro credentials (email & password) in the User object. You will get a Session object in return.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PacerPro.Api;
using IO.PacerPro.Client;
using IO.PacerPro.Model;

namespace Example
{
    public class SessionCreateExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var user = new User(); // User | User credentials

            try
            {
                // Initial authentication.
                Session result = apiInstance.SessionCreate(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SessionCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)| User credentials | 

### Return type

[**Session**](Session.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessiondelete"></a>
# **SessionDelete**
> Empty SessionDelete (string authorization = null)

Revoke all JWT tokens (logout).

Revoke JWT tokens by spinning a new JTI. All current tokens will no longer work.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PacerPro.Api;
using IO.PacerPro.Client;
using IO.PacerPro.Model;

namespace Example
{
    public class SessionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authorization = authorization_example;  // string | Bearer {...JSON Web Token...} (optional) 

            try
            {
                // Revoke all JWT tokens (logout).
                Empty result = apiInstance.SessionDelete(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SessionDelete: " + e.Message );
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

[**Empty**](Empty.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionrefresh"></a>
# **SessionRefresh**
> Session SessionRefresh (string authorization = null)

Refresh authentication token

Using a valid auth token, you can use this to refresh it, thus extending the time unti it expires. See POST /session for instructions on the initial authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PacerPro.Api;
using IO.PacerPro.Client;
using IO.PacerPro.Model;

namespace Example
{
    public class SessionRefreshExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authorization = authorization_example;  // string | Bearer {...JSON Web Token...} (optional) 

            try
            {
                // Refresh authentication token
                Session result = apiInstance.SessionRefresh(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SessionRefresh: " + e.Message );
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

[**Session**](Session.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

