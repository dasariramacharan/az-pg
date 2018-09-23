##  [Azure Resource Manager](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-overview#the-benefits-of-using-resource-manager): 
   Azure Resource Manager enables you to work with the resources in your solution as a group. 
   
   * [ResourceProvider](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-manager-supported-services) - Provides resources e.g
                        Microsoft.Compute => supplies VM , 
                        Microsoft.Storage => supplies storage,
                        Microsoft.Web => supplies resources related to web apps,
                        Microsoft.KeyVault =>  supplies vaults for creating the key vault
            
   * Deploy resources using 
     * Azure Resource Manager templates or ARM Templates
     * [Azure PowerShell](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy)
     * [Azure CLI](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-cli)
     * [Azure portal](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-portal)
     * [Resource Manager REST API](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-rest)         
## [Activity logs](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-audit)
      Resource Manager logs all operations that create, modify, or delete a resource.
You can use the activity logs to find an error when troubleshooting or to monitor how a user in your organization modified a resource.
You can filter the logs by many different values including which user initiated the operation. 
   
##Custom policies
      You define policies with JSON and then apply those policies either across your subscription or within a resource group. Policies are different than role-based access control because they're applied to resource types. Policies help reduce costs and maintain consistency in your subscription.
   e.g : *   naming convention on resources, 
         *   limit which types and instances of resources can be deployed, 
         *   limit which regions can host a type of resource.
         *   You can require a tag value on resources to organize billing by departments.       

##Enables Access Control
       Resource Manager enables you to control who has access to specific actions for your organization. It natively integrates role-based access control (RBAC) into the management platform and applies that access control to all services in your resource group. 

##Tags
Resource Manager provides a tagging feature that enables you to categorize resources according to your requirements for managing or billing. Use tags when you have a complex collection of resource groups and resources, and need to visualize those assets in the way that makes the most sense to you.

##SDKs or REST API
Azure SDKs are available for multiple languages and platforms. e.g Azure SDK for .NET/JAVA/Node.js ,etc
If the SDK doesn't provide the required functionality, you can also call to the Azure REST [API](https://docs.microsoft.com/rest/api/resources/) directly.

##Tools
* Use Azure REsource manager tools extension for vs code to get intellisense support
* [ARMVIZ website is a tool to visualise ARM templates and can also modify ARM using the same](http://armviz.io/)
* 

##References
* [Quick start ARM templates that deploy on Microsoft Azure Stack] (http://aka.ms/AzureStackGitHub) or [Searc them](https://azure.microsoft.com/en-us/resources/templates/)
* 
