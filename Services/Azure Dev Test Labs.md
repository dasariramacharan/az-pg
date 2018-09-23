
#Azure Dev Test Labs

* Can put restrictions on usage, monitor usage, creating VMs, type of VM,s can be created, etc easily.

* Used to test out Azure environment with the company by dev teams,etc

* As with any azure service can use webhooks for notifications

* use **Repositories** option to share resources within the lab

* can create claimable machines 
 
* **artifacts** -
    * items you want to configure/install on the vm by default when Vm is created. 
    * The option to choose atifacts is available during VM creation.
    * there are open source items / private items you could choose from
    * can create our own artifacts and host them on github ( need min 3 files in a folder - azureDeploy.json(ARM template), param file, metadata.json) 
    * using **Chocolatey** atrifacts
      * used for software management automation 
      * you can choose chocolatey during artifacts selection and then choose your desired package name from [available list](https://chocolatey.org/packages).

* You may use activity log,etc to debug VM setup issues using artifacts.

* BYOT - bring your own template to DEv test labs

* Dev Test Labs Automate - can use CI/CD for deploying Resources to your DEV test labs e.g using vsts

* To use CI/CD using VSTS 
    - Goto Market place and look for **AZure dev test labs" and install it to the VSTS subscription.
    - this creates the below the tasks available in the VSTS task catalog under the "deploy" section for the build pipleline
       * Azure dev tests Create VM
       * Azure dev tests Create custom image
       * Azure dev tests Delete Vm
    - You need to add **'Pester'** from the marketplace to run pester tests
    - You need to add **Publish test results** task to the build pipeline in order to view pester results in a graphical interactive way. 
         change the format of tests to nunit in the task configuration.

References 

* [Azure DevTestLab artifacts, scripts and samples](https://github.com/Azure/azure-devtestlab)
