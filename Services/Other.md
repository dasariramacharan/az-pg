

=> Setting up billing alerts
    This feature is in preview (as of 2/9/18). Visit the Preview Features page and enable Billing Alert Service.
    After you receive the email confirmation that the billing service is turned on for your subscription,
    visit the Subscriptions page in the account portal. 
    Click the subscription you want to monitor, and then click Alerts. Next you can add alerts (upto total of 5 alerts/subscription).
    
    
  ##  Azure Resource Manager: 
     * Purpose
         *  Azure Resource Manager enables you to work with the resources in your solution as a group. 
         *  Deploy, update, or delete all the resources for your solution in a single, coordinated operation. 
         *  Use a template for deployment and that template can work for different environments such as testing, staging, and production.          *  Resource Manager (RM) provides security, auditing, and tagging features to help you manage your resources after deployment.
         *  RM provides a consistent management layer to perform tasks through Azure PowerShell, Azure CLI, Azure portal, REST API, and client SDKs.
     *  Terms :
        * Resource - a managable item
        * Resource group- container to hold related items  
        * [resource provider](https://docs.microsoft.com/en-au/azure/azure-resource-manager/resource-manager-supported-services) - Provides resources e.g
                        Microsoft.Compute => supplies VM , 
                        Microsoft.Storage => supplies storage,
                        Microsoft.Web => supplies resources related to web apps,
                        Microsoft.KeyVault =>  supplies vaults for creating the key vault
        * resource manager template - A JSON file that defines one or more resources to deploy to a resource group,
                                       dependencies between deployed resources. 
        * declarative syntax - 
        * Azure Resource Manager API,
        * Resource Manager service, 
           
      * Benifits
           * deploy as a group than each item 
           * deploy repeatedly
           * manage your infrastructure through declarative templates rather than scripts.
           * define the dependencies between resources - to ensure deployment in correct order
           * can apply access control to all services in your resource group because Role-Based Access Control (RBAC) is natively integrated into the management platform.
           * use tags to organise 
           * Can clarify your organization's billing => Can view costs for a group of resources sharing the same tag.
           
           
           
           
           
           
            
            
            
