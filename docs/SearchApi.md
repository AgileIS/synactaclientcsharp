# IO.Swagger.Api.SearchApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSearchGet**](SearchApi.md#apisearchget) | **GET** /_api/search | Executes the search.


<a name="apisearchget"></a>
# **ApiSearchGet**
> List<Object> ApiSearchGet (string authorization)

Executes the search.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiSearchGetExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Executes the search.
                List&lt;Object&gt; result = apiInstance.ApiSearchGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| access token | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

