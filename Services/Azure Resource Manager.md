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
