
## Setting up billing alerts
    This feature is in preview (as of 2/9/18). Visit the Preview Features page and enable Billing Alert Service.
    After you receive the email confirmation that the billing service is turned on for your subscription,
    visit the Subscriptions page in the account portal. 
    Click the subscription you want to monitor, and then click Alerts. Next you can add alerts (upto total of 5 alerts/subscription).
    
    
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
            
## Tags
   * Resources do not need to reside in the same resource group to share a tag.
   * Create your own tag taxonomy
   

        
##  Access Control
  * Azure provides the following four platform roles:
      *  Owner - can manage everything, including access
      *  Contributor - can manage everything except access
      *  Reader - can view everything, but can't make changes
      *  User Access Administrator - can manage user access to Azure resources

  * Azure also provides several resource-specific roles. Some common ones are:
      *  Virtual Machine Contributor - can manage virtual machines but not grant access to them, and can't manage the virtual network or storage account to which they're connected
      *  Network Contributor - can manage all network resources, but not grant access to them
      *  Storage Account Contributor - Can manage storage accounts, but not grant access to them
      *  SQL Server Contributor - Can manage SQL servers and databases, but not their security-related policies
      *  Website Contributor - Can manage websites, but not the web plans to which they're connected

Complete list of [Roles](https://docs.microsoft.com/en-au/azure/role-based-access-control/built-in-roles) which can be managed using Role Based Access Control ([RBAC](https://docs.microsoft.com/en-au/azure/role-based-access-control/overview)) . Manage roles using Access Control (IAM) under your subscription.
        
##  
            
