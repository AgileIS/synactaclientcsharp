# IO.Swagger.Api.BaseApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiBaseByTypeByIdAddByNewContainerTypeGet**](BaseApi.md#apibasebytypebyidaddbynewcontainertypeget) | **GET** /_api/base/{type}/{id}/Add/{newContainerType} | Gets the empty container.
[**ApiBaseByTypeByIdAddPut**](BaseApi.md#apibasebytypebyidaddput) | **PUT** /_api/base/{type}/{id}/Add | Saves the new container.
[**ApiBaseByTypeByIdCheckinPut**](BaseApi.md#apibasebytypebyidcheckinput) | **PUT** /_api/base/{type}/{id}/Checkin | Checkins the specified .
[**ApiBaseByTypeByIdCheckoutPut**](BaseApi.md#apibasebytypebyidcheckoutput) | **PUT** /_api/base/{type}/{id}/Checkout | Checkouts the specified .
[**ApiBaseByTypeByIdChildrenGet**](BaseApi.md#apibasebytypebyidchildrenget) | **GET** /_api/base/{type}/{id}/Children | Gets the children of container.
[**ApiBaseByTypeByIdChildrenTypesGet**](BaseApi.md#apibasebytypebyidchildrentypesget) | **GET** /_api/base/{type}/{id}/Children/Types | Gets the container types.
[**ApiBaseByTypeByIdDelete**](BaseApi.md#apibasebytypebyiddelete) | **DELETE** /_api/base/{type}/{id} | Deletes the container.
[**ApiBaseByTypeByIdDocumentsGet**](BaseApi.md#apibasebytypebyiddocumentsget) | **GET** /_api/base/{type}/{id}/Documents | Gets the documents.
[**ApiBaseByTypeByIdDocumentsTypesGet**](BaseApi.md#apibasebytypebyiddocumentstypesget) | **GET** /_api/base/{type}/{id}/Documents/Types | Gets the documents types.
[**ApiBaseByTypeByIdGet**](BaseApi.md#apibasebytypebyidget) | **GET** /_api/base/{type}/{id} | Gets the container by identifier.
[**ApiBaseByTypeByIdGetFileGet**](BaseApi.md#apibasebytypebyidgetfileget) | **GET** /_api/base/{type}/{id}/GetFile | Gets the file.
[**ApiBaseByTypeByIdLookupListByLookupListNameGet**](BaseApi.md#apibasebytypebyidlookuplistbylookuplistnameget) | **GET** /_api/base/{type}/{id}/LookupList/{lookupListName} | Gets the lookup list entries.
[**ApiBaseByTypeByIdMovePost**](BaseApi.md#apibasebytypebyidmovepost) | **POST** /_api/base/{type}/{id}/Move | Moves the object.
[**ApiBaseByTypeByIdPost**](BaseApi.md#apibasebytypebyidpost) | **POST** /_api/base/{type}/{id} | Updates the container.
[**ApiBaseByTypeByIdUploadFilePost**](BaseApi.md#apibasebytypebyiduploadfilepost) | **POST** /_api/base/{type}/{id}/UploadFile | Uploads the file.
[**ApiBaseByTypeByIdVersionsByVersionIdGet**](BaseApi.md#apibasebytypebyidversionsbyversionidget) | **GET** /_api/base/{type}/{id}/Versions/{versionId} | Gets the version by identifier.
[**ApiBaseByTypeByIdVersionsByVersionIdGetFileGet**](BaseApi.md#apibasebytypebyidversionsbyversionidgetfileget) | **GET** /_api/base/{type}/{id}/Versions/{versionId}/GetFile | Gets the file for version.
[**ApiBaseByTypeByIdVersionsByVersionIdRestorePost**](BaseApi.md#apibasebytypebyidversionsbyversionidrestorepost) | **POST** /_api/base/{type}/{id}/Versions/{versionId}/Restore | Restores the version.
[**ApiBaseByTypeByIdVersionsGet**](BaseApi.md#apibasebytypebyidversionsget) | **GET** /_api/base/{type}/{id}/Versions | Gets the versions.
[**ApiBaseByTypeGet**](BaseApi.md#apibasebytypeget) | **GET** /_api/base/{type} | Gets containers by a type.
[**ApiBaseRootGet**](BaseApi.md#apibaserootget) | **GET** /_api/base/Root | Gets the root.
[**ApiBaseTypesGet**](BaseApi.md#apibasetypesget) | **GET** /_api/base/Types | Gets the container types.


<a name="apibasebytypebyidaddbynewcontainertypeget"></a>
# **ApiBaseByTypeByIdAddByNewContainerTypeGet**
> Container ApiBaseByTypeByIdAddByNewContainerTypeGet (string type, string id, string newContainerType, string authorization)

Gets the empty container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdAddByNewContainerTypeGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var newContainerType = newContainerType_example;  // string | New type of the container.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the empty container.
                Container result = apiInstance.ApiBaseByTypeByIdAddByNewContainerTypeGet(type, id, newContainerType, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdAddByNewContainerTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **newContainerType** | **string**| New type of the container. | 
 **authorization** | **string**| access token | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidaddput"></a>
# **ApiBaseByTypeByIdAddPut**
> Container ApiBaseByTypeByIdAddPut (string type, string id, string authorization, Container newContainer = null)

Saves the new container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdAddPutExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token
            var newContainer = new Container(); // Container | The new container. (optional) 

            try
            {
                // Saves the new container.
                Container result = apiInstance.ApiBaseByTypeByIdAddPut(type, id, authorization, newContainer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 
 **newContainer** | [**Container**](Container.md)| The new container. | [optional] 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidcheckinput"></a>
# **ApiBaseByTypeByIdCheckinPut**
> Container ApiBaseByTypeByIdCheckinPut (string type, string id, string authorization, Container container = null)

Checkins the specified .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdCheckinPutExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var authorization = authorization_example;  // string | access token
            var container = new Container(); // Container | The container. (optional) 

            try
            {
                // Checkins the specified .
                Container result = apiInstance.ApiBaseByTypeByIdCheckinPut(type, id, authorization, container);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdCheckinPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **authorization** | **string**| access token | 
 **container** | [**Container**](Container.md)| The container. | [optional] 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidcheckoutput"></a>
# **ApiBaseByTypeByIdCheckoutPut**
> Container ApiBaseByTypeByIdCheckoutPut (string type, string id, string authorization, Container container = null)

Checkouts the specified .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdCheckoutPutExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var authorization = authorization_example;  // string | access token
            var container = new Container(); // Container | The container. (optional) 

            try
            {
                // Checkouts the specified .
                Container result = apiInstance.ApiBaseByTypeByIdCheckoutPut(type, id, authorization, container);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdCheckoutPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **authorization** | **string**| access token | 
 **container** | [**Container**](Container.md)| The container. | [optional] 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidchildrenget"></a>
# **ApiBaseByTypeByIdChildrenGet**
> List<Container> ApiBaseByTypeByIdChildrenGet (string type, string id, string authorization)

Gets the children of container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdChildrenGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the children of container.
                List&lt;Container&gt; result = apiInstance.ApiBaseByTypeByIdChildrenGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**List<Container>**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidchildrentypesget"></a>
# **ApiBaseByTypeByIdChildrenTypesGet**
> List<string> ApiBaseByTypeByIdChildrenTypesGet (string type, string id, string authorization)

Gets the container types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdChildrenTypesGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the container types.
                List&lt;string&gt; result = apiInstance.ApiBaseByTypeByIdChildrenTypesGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdChildrenTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyiddelete"></a>
# **ApiBaseByTypeByIdDelete**
> bool? ApiBaseByTypeByIdDelete (string type, string id, string authorization)

Deletes the container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Deletes the container.
                bool? result = apiInstance.ApiBaseByTypeByIdDelete(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyiddocumentsget"></a>
# **ApiBaseByTypeByIdDocumentsGet**
> List<Container> ApiBaseByTypeByIdDocumentsGet (string type, string id, string authorization)

Gets the documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdDocumentsGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the documents.
                List&lt;Container&gt; result = apiInstance.ApiBaseByTypeByIdDocumentsGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdDocumentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**List<Container>**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyiddocumentstypesget"></a>
# **ApiBaseByTypeByIdDocumentsTypesGet**
> List<string> ApiBaseByTypeByIdDocumentsTypesGet (string type, string id, string authorization)

Gets the documents types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdDocumentsTypesGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the documents types.
                List&lt;string&gt; result = apiInstance.ApiBaseByTypeByIdDocumentsTypesGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdDocumentsTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidget"></a>
# **ApiBaseByTypeByIdGet**
> Container ApiBaseByTypeByIdGet (string type, string id, string authorization)

Gets the container by identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifer.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the container by identifier.
                Container result = apiInstance.ApiBaseByTypeByIdGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifer. | 
 **authorization** | **string**| access token | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidgetfileget"></a>
# **ApiBaseByTypeByIdGetFileGet**
> void ApiBaseByTypeByIdGetFileGet (string type, string id, string authorization)

Gets the file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdGetFileGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the file.
                apiInstance.ApiBaseByTypeByIdGetFileGet(type, id, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdGetFileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **authorization** | **string**| access token | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidlookuplistbylookuplistnameget"></a>
# **ApiBaseByTypeByIdLookupListByLookupListNameGet**
> List<KeyValuePairStringString> ApiBaseByTypeByIdLookupListByLookupListNameGet (string type, string id, string lookupListName, string authorization)

Gets the lookup list entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdLookupListByLookupListNameGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var lookupListName = lookupListName_example;  // string | Name of the lookup list.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the lookup list entries.
                List&lt;KeyValuePairStringString&gt; result = apiInstance.ApiBaseByTypeByIdLookupListByLookupListNameGet(type, id, lookupListName, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdLookupListByLookupListNameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **lookupListName** | **string**| Name of the lookup list. | 
 **authorization** | **string**| access token | 

### Return type

[**List<KeyValuePairStringString>**](KeyValuePairStringString.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidmovepost"></a>
# **ApiBaseByTypeByIdMovePost**
> Container ApiBaseByTypeByIdMovePost (string type, string id, string authorization, Container container = null)

Moves the object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdMovePostExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token
            var container = new Container(); // Container | The container. (optional) 

            try
            {
                // Moves the object.
                Container result = apiInstance.ApiBaseByTypeByIdMovePost(type, id, authorization, container);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdMovePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 
 **container** | [**Container**](Container.md)| The container. | [optional] 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidpost"></a>
# **ApiBaseByTypeByIdPost**
> Container ApiBaseByTypeByIdPost (string type, string id, string authorization, Container newContainer = null)

Updates the container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdPostExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var id = id_example;  // string | The container identifier.
            var authorization = authorization_example;  // string | access token
            var newContainer = new Container(); // Container | The new container. (optional) 

            try
            {
                // Updates the container.
                Container result = apiInstance.ApiBaseByTypeByIdPost(type, id, authorization, newContainer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **id** | **string**| The container identifier. | 
 **authorization** | **string**| access token | 
 **newContainer** | [**Container**](Container.md)| The new container. | [optional] 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyiduploadfilepost"></a>
# **ApiBaseByTypeByIdUploadFilePost**
> void ApiBaseByTypeByIdUploadFilePost (string type, string id, string authorization)

Uploads the file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdUploadFilePostExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Uploads the file.
                apiInstance.ApiBaseByTypeByIdUploadFilePost(type, id, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdUploadFilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **authorization** | **string**| access token | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidversionsbyversionidget"></a>
# **ApiBaseByTypeByIdVersionsByVersionIdGet**
> DocumentVersion ApiBaseByTypeByIdVersionsByVersionIdGet (string type, string id, string versionId, string authorization)

Gets the version by identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdVersionsByVersionIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var versionId = versionId_example;  // string | The version identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the version by identifier.
                DocumentVersion result = apiInstance.ApiBaseByTypeByIdVersionsByVersionIdGet(type, id, versionId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdVersionsByVersionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **versionId** | **string**| The version identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**DocumentVersion**](DocumentVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidversionsbyversionidgetfileget"></a>
# **ApiBaseByTypeByIdVersionsByVersionIdGetFileGet**
> void ApiBaseByTypeByIdVersionsByVersionIdGetFileGet (string type, string id, string versionId, string authorization)

Gets the file for version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdVersionsByVersionIdGetFileGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document .
            var id = id_example;  // string | The document identifier.
            var versionId = versionId_example;  // string | The version identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the file for version.
                apiInstance.ApiBaseByTypeByIdVersionsByVersionIdGetFileGet(type, id, versionId, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdVersionsByVersionIdGetFileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document . | 
 **id** | **string**| The document identifier. | 
 **versionId** | **string**| The version identifier. | 
 **authorization** | **string**| access token | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidversionsbyversionidrestorepost"></a>
# **ApiBaseByTypeByIdVersionsByVersionIdRestorePost**
> Container ApiBaseByTypeByIdVersionsByVersionIdRestorePost (string type, string id, string versionId, string authorization)

Restores the version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdVersionsByVersionIdRestorePostExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document .
            var id = id_example;  // string | The document identifier.
            var versionId = versionId_example;  // string | The version identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Restores the version.
                Container result = apiInstance.ApiBaseByTypeByIdVersionsByVersionIdRestorePost(type, id, versionId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdVersionsByVersionIdRestorePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document . | 
 **id** | **string**| The document identifier. | 
 **versionId** | **string**| The version identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypebyidversionsget"></a>
# **ApiBaseByTypeByIdVersionsGet**
> List<DocumentVersion> ApiBaseByTypeByIdVersionsGet (string type, string id, string authorization)

Gets the versions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeByIdVersionsGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the document.
            var id = id_example;  // string | The document identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the versions.
                List&lt;DocumentVersion&gt; result = apiInstance.ApiBaseByTypeByIdVersionsGet(type, id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeByIdVersionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the document. | 
 **id** | **string**| The document identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**List<DocumentVersion>**](DocumentVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasebytypeget"></a>
# **ApiBaseByTypeGet**
> List<Container> ApiBaseByTypeGet (string type, string authorization)

Gets containers by a type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseByTypeGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var type = type_example;  // string | Type of the container.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets containers by a type.
                List&lt;Container&gt; result = apiInstance.ApiBaseByTypeGet(type, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseByTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the container. | 
 **authorization** | **string**| access token | 

### Return type

[**List<Container>**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibaserootget"></a>
# **ApiBaseRootGet**
> List<Container> ApiBaseRootGet (string authorization)

Gets the root.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseRootGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the root.
                List&lt;Container&gt; result = apiInstance.ApiBaseRootGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseRootGet: " + e.Message );
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

[**List<Container>**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibasetypesget"></a>
# **ApiBaseTypesGet**
> List<string> ApiBaseTypesGet (string authorization)

Gets the container types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiBaseTypesGetExample
    {
        public void main()
        {
            
            var apiInstance = new BaseApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the container types.
                List&lt;string&gt; result = apiInstance.ApiBaseTypesGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BaseApi.ApiBaseTypesGet: " + e.Message );
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

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

