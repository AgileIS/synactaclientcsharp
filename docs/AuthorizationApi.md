# IO.Swagger.Api.AuthorizationApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAuthorizationPrincipalsByIdGet**](AuthorizationApi.md#apiauthorizationprincipalsbyidget) | **GET** /_api/authorization/Principals/{id} | Provides a principal by his identifier.
[**ApiAuthorizationPrincipalsGet**](AuthorizationApi.md#apiauthorizationprincipalsget) | **GET** /_api/authorization/Principals | Gets the principals.
[**ApiAuthorizationRightsGet**](AuthorizationApi.md#apiauthorizationrightsget) | **GET** /_api/authorization/Rights | Gets the rights.
[**ApiAuthorizationRolesAddGet**](AuthorizationApi.md#apiauthorizationrolesaddget) | **GET** /_api/authorization/Roles/Add | Gets the role container.
[**ApiAuthorizationRolesAddPut**](AuthorizationApi.md#apiauthorizationrolesaddput) | **PUT** /_api/authorization/Roles/Add | Adds the role.
[**ApiAuthorizationRolesByIdDelete**](AuthorizationApi.md#apiauthorizationrolesbyiddelete) | **DELETE** /_api/authorization/Roles/{id} | Deletes the role.
[**ApiAuthorizationRolesByIdGet**](AuthorizationApi.md#apiauthorizationrolesbyidget) | **GET** /_api/authorization/Roles/{id} | Gets the role.
[**ApiAuthorizationRolesByIdPost**](AuthorizationApi.md#apiauthorizationrolesbyidpost) | **POST** /_api/authorization/Roles/{id} | Updates the role.
[**ApiAuthorizationRolesGet**](AuthorizationApi.md#apiauthorizationrolesget) | **GET** /_api/authorization/Roles | Gets the roles.


<a name="apiauthorizationprincipalsbyidget"></a>
# **ApiAuthorizationPrincipalsByIdGet**
> PrincipalSearchResult ApiAuthorizationPrincipalsByIdGet (string id, string authorization)

Provides a principal by his identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationPrincipalsByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var id = id_example;  // string | The principal identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Provides a principal by his identifier.
                PrincipalSearchResult result = apiInstance.ApiAuthorizationPrincipalsByIdGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationPrincipalsByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The principal identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**PrincipalSearchResult**](PrincipalSearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationprincipalsget"></a>
# **ApiAuthorizationPrincipalsGet**
> List<PrincipalSearchResult> ApiAuthorizationPrincipalsGet (string authorization)

Gets the principals.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationPrincipalsGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the principals.
                List&lt;PrincipalSearchResult&gt; result = apiInstance.ApiAuthorizationPrincipalsGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationPrincipalsGet: " + e.Message );
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

[**List<PrincipalSearchResult>**](PrincipalSearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrightsget"></a>
# **ApiAuthorizationRightsGet**
> List<Right> ApiAuthorizationRightsGet (string authorization)

Gets the rights.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRightsGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the rights.
                List&lt;Right&gt; result = apiInstance.ApiAuthorizationRightsGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRightsGet: " + e.Message );
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

[**List<Right>**](Right.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesaddget"></a>
# **ApiAuthorizationRolesAddGet**
> Role ApiAuthorizationRolesAddGet (string authorization)

Gets the role container.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesAddGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the role container.
                Role result = apiInstance.ApiAuthorizationRolesAddGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesAddGet: " + e.Message );
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

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesaddput"></a>
# **ApiAuthorizationRolesAddPut**
> Role ApiAuthorizationRolesAddPut (string authorization, Role role = null)

Adds the role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesAddPutExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var authorization = authorization_example;  // string | access token
            var role = new Role(); // Role | The role. (optional) 

            try
            {
                // Adds the role.
                Role result = apiInstance.ApiAuthorizationRolesAddPut(authorization, role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| access token | 
 **role** | [**Role**](Role.md)| The role. | [optional] 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json, application/xml, text/xml
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesbyiddelete"></a>
# **ApiAuthorizationRolesByIdDelete**
> bool? ApiAuthorizationRolesByIdDelete (string id, string authorization)

Deletes the role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesByIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var id = id_example;  // string | The role identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Deletes the role.
                bool? result = apiInstance.ApiAuthorizationRolesByIdDelete(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The role identifier. | 
 **authorization** | **string**| access token | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesbyidget"></a>
# **ApiAuthorizationRolesByIdGet**
> Role ApiAuthorizationRolesByIdGet (string id, string authorization)

Gets the role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var id = id_example;  // string | The role identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the role.
                Role result = apiInstance.ApiAuthorizationRolesByIdGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The role identifier. | 
 **authorization** | **string**| access token | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesbyidpost"></a>
# **ApiAuthorizationRolesByIdPost**
> Role ApiAuthorizationRolesByIdPost (string id, string authorization, Role role = null)

Updates the role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesByIdPostExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var id = id_example;  // string | The role identifier.
            var authorization = authorization_example;  // string | access token
            var role = new Role(); // Role | The role. (optional) 

            try
            {
                // Updates the role.
                Role result = apiInstance.ApiAuthorizationRolesByIdPost(id, authorization, role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesByIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The role identifier. | 
 **authorization** | **string**| access token | 
 **role** | [**Role**](Role.md)| The role. | [optional] 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json, application/xml, text/xml
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiauthorizationrolesget"></a>
# **ApiAuthorizationRolesGet**
> List<Role> ApiAuthorizationRolesGet (string authorization)

Gets the roles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAuthorizationRolesGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var authorization = authorization_example;  // string | access token

            try
            {
                // Gets the roles.
                List&lt;Role&gt; result = apiInstance.ApiAuthorizationRolesGet(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationRolesGet: " + e.Message );
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

[**List<Role>**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

