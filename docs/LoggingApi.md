# IO.Swagger.Api.LoggingApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiLogAddGet**](LoggingApi.md#apilogaddget) | **GET** /_api/log/Add | Gets the log container.
[**ApiLogAddPut**](LoggingApi.md#apilogaddput) | **PUT** /_api/log/Add | Adds the log.
[**ApiLogGet**](LoggingApi.md#apilogget) | **GET** /_api/log | Gets all logs.


<a name="apilogaddget"></a>
# **ApiLogAddGet**
> Log ApiLogAddGet (string authorization)

Gets the log container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiLogAddGetExample
    {
        public void main()
        {
            
            var apiInstance = new LoggingApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the log container.
                Log result = apiInstance.ApiLogAddGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.ApiLogAddGet: " + e.Message );
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

[**Log**](Log.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apilogaddput"></a>
# **ApiLogAddPut**
> Log ApiLogAddPut (string authorization, Log log = null)

Adds the log.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiLogAddPutExample
    {
        public void main()
        {
            
            var apiInstance = new LoggingApi();
            var authorization = authorization_example;  // string | access token
            var log = new Log(); // Log | The log. (optional) 

            try
            {
                // Adds the log.
                Log result = apiInstance.ApiLogAddPut(authorization, log);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.ApiLogAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| access token | 
 **log** | [**Log**](Log.md)| The log. | [optional] 

### Return type

[**Log**](Log.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apilogget"></a>
# **ApiLogGet**
> List<Log> ApiLogGet (string authorization)

Gets all logs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiLogGetExample
    {
        public void main()
        {
            
            var apiInstance = new LoggingApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets all logs.
                List&lt;Log&gt; result = apiInstance.ApiLogGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.ApiLogGet: " + e.Message );
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

[**List<Log>**](Log.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

