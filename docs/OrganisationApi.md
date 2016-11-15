# IO.Swagger.Api.OrganisationApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiOrgByIdAddGet**](OrganisationApi.md#apiorgbyidaddget) | **GET** /_api/org/{id}/Add | Gets the new organisation.
[**ApiOrgByIdAddPut**](OrganisationApi.md#apiorgbyidaddput) | **PUT** /_api/org/{id}/Add | Saves the new organisation.
[**ApiOrgByIdByTypeGet**](OrganisationApi.md#apiorgbyidbytypeget) | **GET** /_api/org/{id}/{type} | Gets all containers.
[**ApiOrgByIdChildrenGet**](OrganisationApi.md#apiorgbyidchildrenget) | **GET** /_api/org/{id}/Children | Gets the child organisations.
[**ApiOrgByIdDelete**](OrganisationApi.md#apiorgbyiddelete) | **DELETE** /_api/org/{id} | Deletes the organisation.
[**ApiOrgByIdGet**](OrganisationApi.md#apiorgbyidget) | **GET** /_api/org/{id} | Gets the organisation.
[**ApiOrgByIdMovePost**](OrganisationApi.md#apiorgbyidmovepost) | **POST** /_api/org/{id}/Move | Moves the organisation.
[**ApiOrgByIdPost**](OrganisationApi.md#apiorgbyidpost) | **POST** /_api/org/{id} | Updates the organisation.
[**ApiOrgByIdRecycleBinByRecycleBinIdGet**](OrganisationApi.md#apiorgbyidrecyclebinbyrecyclebinidget) | **GET** /_api/org/{id}/RecycleBin/{recycleBinId} | Gets the recycle bin entry.
[**ApiOrgByIdRecycleBinByRecycleBinIdRestorePost**](OrganisationApi.md#apiorgbyidrecyclebinbyrecyclebinidrestorepost) | **POST** /_api/org/{id}/RecycleBin/{recycleBinId}/Restore | Restores the recycle bin entry.
[**ApiOrgByIdRecycleBinGet**](OrganisationApi.md#apiorgbyidrecyclebinget) | **GET** /_api/org/{id}/RecycleBin | Gets the recycle bin.
[**ApiOrgGet**](OrganisationApi.md#apiorgget) | **GET** /_api/org | Gets all organisations.
[**ApiOrgOrgTreeGet**](OrganisationApi.md#apiorgorgtreeget) | **GET** /_api/org/OrgTree | Gets all organisations with childs.


<a name="apiorgbyidaddget"></a>
# **ApiOrgByIdAddGet**
> Organisation ApiOrgByIdAddGet (string id, string authorization)

Gets the new organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdAddGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the new organisation.
                Organisation result = apiInstance.ApiOrgByIdAddGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdAddGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidaddput"></a>
# **ApiOrgByIdAddPut**
> Organisation ApiOrgByIdAddPut (string id, string authorization, Organisation newOrganisation = null)

Saves the new organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdAddPutExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token
            var newOrganisation = new Organisation(); // Organisation | The new organisation. (optional) 

            try
            {
                // Saves the new organisation.
                Organisation result = apiInstance.ApiOrgByIdAddPut(id, authorization, newOrganisation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 
 **newOrganisation** | [**Organisation**](Organisation.md)| The new organisation. | [optional] 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json, application/xml, text/xml
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidbytypeget"></a>
# **ApiOrgByIdByTypeGet**
> List<Container> ApiOrgByIdByTypeGet (string id, string type, string authorization)

Gets all containers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdByTypeGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var type = type_example;  // string | Type of the container.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets all containers.
                List&lt;Container&gt; result = apiInstance.ApiOrgByIdByTypeGet(id, type, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdByTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
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

<a name="apiorgbyidchildrenget"></a>
# **ApiOrgByIdChildrenGet**
> List<Organisation> ApiOrgByIdChildrenGet (string id, string authorization)

Gets the child organisations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdChildrenGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the child organisations.
                List&lt;Organisation&gt; result = apiInstance.ApiOrgByIdChildrenGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**List<Organisation>**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyiddelete"></a>
# **ApiOrgByIdDelete**
> bool? ApiOrgByIdDelete (string id, string authorization)

Deletes the organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Deletes the organisation.
                bool? result = apiInstance.ApiOrgByIdDelete(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidget"></a>
# **ApiOrgByIdGet**
> Organisation ApiOrgByIdGet (string id, string authorization)

Gets the organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the organisation.
                Organisation result = apiInstance.ApiOrgByIdGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidmovepost"></a>
# **ApiOrgByIdMovePost**
> Organisation ApiOrgByIdMovePost (string id, string authorization, Organisation organisation = null)

Moves the organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdMovePostExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token
            var organisation = new Organisation(); // Organisation | The organisation. (optional) 

            try
            {
                // Moves the organisation.
                Organisation result = apiInstance.ApiOrgByIdMovePost(id, authorization, organisation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdMovePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 
 **organisation** | [**Organisation**](Organisation.md)| The organisation. | [optional] 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json, application/xml, text/xml
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidpost"></a>
# **ApiOrgByIdPost**
> Organisation ApiOrgByIdPost (string id, string authorization, Organisation pOrganisation = null)

Updates the organisation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdPostExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token
            var pOrganisation = new Organisation(); // Organisation | The organisation. (optional) 

            try
            {
                // Updates the organisation.
                Organisation result = apiInstance.ApiOrgByIdPost(id, authorization, pOrganisation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 
 **pOrganisation** | [**Organisation**](Organisation.md)| The organisation. | [optional] 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json, application/xml, text/xml
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidrecyclebinbyrecyclebinidget"></a>
# **ApiOrgByIdRecycleBinByRecycleBinIdGet**
> RecycleBinEntry ApiOrgByIdRecycleBinByRecycleBinIdGet (string id, string recycleBinId, string authorization)

Gets the recycle bin entry.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdRecycleBinByRecycleBinIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var recycleBinId = recycleBinId_example;  // string | The recycle identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the recycle bin entry.
                RecycleBinEntry result = apiInstance.ApiOrgByIdRecycleBinByRecycleBinIdGet(id, recycleBinId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdRecycleBinByRecycleBinIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **recycleBinId** | **string**| The recycle identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**RecycleBinEntry**](RecycleBinEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidrecyclebinbyrecyclebinidrestorepost"></a>
# **ApiOrgByIdRecycleBinByRecycleBinIdRestorePost**
> Container ApiOrgByIdRecycleBinByRecycleBinIdRestorePost (string id, string recycleBinId, string authorization)

Restores the recycle bin entry.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdRecycleBinByRecycleBinIdRestorePostExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var recycleBinId = recycleBinId_example;  // string | The recycle bin identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Restores the recycle bin entry.
                Container result = apiInstance.ApiOrgByIdRecycleBinByRecycleBinIdRestorePost(id, recycleBinId, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdRecycleBinByRecycleBinIdRestorePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **recycleBinId** | **string**| The recycle bin identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgbyidrecyclebinget"></a>
# **ApiOrgByIdRecycleBinGet**
> List<RecycleBinEntry> ApiOrgByIdRecycleBinGet (string id, string authorization)

Gets the recycle bin.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgByIdRecycleBinGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var id = id_example;  // string | The organisation identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the recycle bin.
                List&lt;RecycleBinEntry&gt; result = apiInstance.ApiOrgByIdRecycleBinGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgByIdRecycleBinGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The organisation identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**List<RecycleBinEntry>**](RecycleBinEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgget"></a>
# **ApiOrgGet**
> List<Organisation> ApiOrgGet (string authorization)

Gets all organisations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets all organisations.
                List&lt;Organisation&gt; result = apiInstance.ApiOrgGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgGet: " + e.Message );
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

[**List<Organisation>**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorgorgtreeget"></a>
# **ApiOrgOrgTreeGet**
> List<Organisation> ApiOrgOrgTreeGet (string authorization)

Gets all organisations with childs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiOrgOrgTreeGetExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets all organisations with childs.
                List&lt;Organisation&gt; result = apiInstance.ApiOrgOrgTreeGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.ApiOrgOrgTreeGet: " + e.Message );
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

[**List<Organisation>**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

