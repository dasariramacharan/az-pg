

The **Application settings** and **Properties** of an Azure App Service Web App are used to define and manage software.

=> Application settings blade include:
                    General Settings(specify version no for server side technologies), Debugging, App settings,
                    Connection strings, Default documents
 
 =>Properties Blade : - This blade contains important information about your app that is commonly used in dev tasks,
                   such as the address and credentials of your app.
   Some of the settings that you can access from the Properties blade include:
              Status: This setting indicates the state of the App, such as Running or Stopped.
              URL: This is the URL for you App. Every Web App in Azure has a url that ends in *.azurewebsites.net.
              Outbound IP Addresses: This setting is not commonly used
              Deployment Trigger URL: This setting is useful if you are looking to run an automated process every time new code is deployed to the site (perhaps send an email about new features?).
              Several FTP settings that provide information for the Web site. Since an Azure Web site is, in the end, just a folder running in IIS (if running on Windows this is the wwwroot folder, new linux based Web Apps - coming soon for Node.js and Python! - will likely have a slightly different folder structure), it's accessible via FTP.
              Resource, Location, and Subscription information is provided near the bottom of the blade.
              

