## Azure Automation 
* Azure solution for managing Infrastructure as Code (Ias)
* Powershell   
* Desired State Management (DSC) 
* Run Books
  * Browse Gallery = to browse, resuse and extend existing run-books from open source
  * Powershell Workflow Runbooks = allows to create checkpoint and save state.(e.g to resume from the saved state during resume).
                                  use the command 'Checkpoint-Workflow' in powershell script where you want to create a checkpoint. 
  * Graphical Runbook - graphical , can't run outside azure , use commandlets search to find and add items to the script
  
* Assets -a way of abstracting resources in run books
* using certificates to interact with resources
* Parameters
* Run As Account - to authenticate your Azure automation against azure
* Works per subscription - has access to complete subscription, only admin can create , anyone can run
* WebHooks - ability to expose the runbook as a REST end point, e.g publish to slack channel 
* Alert Rules within resources (need not use AA for the same) - you could run a run book directly 
* Logging and Tracing - can *enable Log and trace at Runbook level* to help with debugging. Use Verbose cmd to see step by step execution details.
* Jobs - if you dont have tracing/logging enabled for your scripts then the information is logged at the AA account level under Jobs  section.
*  

##Powershell
  * Runs cross platform   
  * remotely administer servers 
  * power of cmdlets and modules
  * allows meaningful structured automation.
  *  *Pester* : -  a testing framework which allows you to unit test your PowerShell scripts.
  * inbuilt package manager - to search for modulees within console
  * code analysis using script analyzer
  * works with Visual Studio Code which means you can
      * write PowerShell backed by Git repositories
      * unit test them
      * CI them
      * CD them
  * classes - to do structured programming
  * JEE - security 
  * audit logs
  * Powershell gallery
  * imperative syntax(old style) vs declarative (new style)
      *  imperative syntax - kind of assuming an early stage of where the script is running as in the base state and  then the script is really building on top from there. So if the base changes, the scripts is bound to fail
      *  the declarative syntax - leveraging the capabilities of the OS (OS has Local configuration manager (LCM) which we leverage). So rather than script what you want, you tell the OS what you need. This helps use DSC. 
  * Powershell with DSC
      * uses Powershell to achieve DSC in Microsoft stack
      * need to use declarative syntax to implement DSC
  * Powershell credential provider - to save credentials instead of typing credentials everytime
  * 
  
  
#Desired State Configuration (DSC) / 
  * its a cross platform concept (not just for windows)
  * Prevent server configuration drift
  * works anywhere - cloud / on prem - in same manner
  * can reuse existing powershell scripts
  * DSC Arch
      * Push - push our script to server
      * Pull - push script central (pull) server and target machines pull from pull server.
             - Azure automation can host the pull server 
  * [Best Practices for DSC Powershell scripts](https://github.com/PowerShell/DscResources/blob/master/BestPractices.md)     

Ref: 
  1) [Azure Automation in Depth: Runbook Authoring](https://azure.microsoft.com/en-au/blog/azure-automation-in-depth-runbook-authoring/)
  2) [Learning Path](https://azure.microsoft.com/en-au/documentation/learning-paths/automation/)
  3) 
