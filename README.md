# Application to test Rest API

.Net core application to mock a Rest API on Azure Web Apps.

## Swagger 

Import via OpenAPI tool on Azure API Management.

```
# First go to this page
$host/swagger/index.html

# Then identify the 
$host/swagger/v1/swagger.json
```
As per the picture bellow:
![](media/swagger-version-01.png)


## On Azure API Management side import the schema

On the Azure Portal go to your APIM and then **APIs** then **OpenAPI**

![](media/swagger-import-apim-01.png)

Now add the address with the swagger schema.

![](media/swagger-version-apim-01.png)