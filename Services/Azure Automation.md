## Azure Automation 
* Azure solution for managing Infrastructure as Code (Ias)
* Powershell 
* Desired State Management (DSE)  
* Run Books
  * Browse Gallery = to browse, resuse and extend existing run-books from open source
  * Powershell Workflow Runbooks = allows to create checkpoint and save state.(e.g to resume from the saved state during resume).
                                  use the command 'Checkpoint-Workflow' in powershell script where you want to create a checkpoint.    
* Assets -a way of abstracting resources in run books
* using certificates to interact with resources
* Parameters
* Run As Account - to authenticate your Azure automation against azure
* Works per subscription - has access to complete subscription, only admin can create , anyone can run
* WebHooks - ability to expose the runbook as a REST end point, e.g publish to slack channel 
* Alert Rules within resources (need not use AA for the same) - you could run a run book directly 
* 

Ref: 
  1) [Azure Automation in Depth: Runbook Authoring](https://azure.microsoft.com/en-au/blog/azure-automation-in-depth-runbook-authoring/)
  2) [Learning Path](https://azure.microsoft.com/en-au/documentation/learning-paths/automation/)
  3) 
