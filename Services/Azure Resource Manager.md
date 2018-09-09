##  [Azure Resource Manager](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-overview#the-benefits-of-using-resource-manager): 
   Azure Resource Manager enables you to work with the resources in your solution as a group. 
   
   * [ResourceProvider](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-manager-supported-services) - Provides resources e.g
                        Microsoft.Compute => supplies VM , 
                        Microsoft.Storage => supplies storage,
                        Microsoft.Web => supplies resources related to web apps,
                        Microsoft.KeyVault =>  supplies vaults for creating the key vault
            
   * Deploy resources with Resource Manager templates and using (any of the below)
        * [Azure PowerShell](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy)
        * [Azure CLI](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-cli)
        * [Azure portal](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-portal)
        * [Resource Manager REST API](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-template-deploy-rest)  
        
        
## [Activity logs](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-group-audit)
      Resource Manager logs all operations that create, modify, or delete a resource.
You can use the activity logs to find an error when troubleshooting or to monitor how a user in your organization modified a resource.
You can filter the logs by many different values including which user initiated the operation. 
   
