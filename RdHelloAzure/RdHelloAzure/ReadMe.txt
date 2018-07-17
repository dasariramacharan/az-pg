
--Below commands to push your code to Azure through git
git init
git status
git remote add azureprod https://atrdwadc@rdhelloazure.scm.azurewebsites.net:443/rdhelloazure.git
git push azureprod master

------------------------------------------------------------------------------------------------------------------------
--using deployment slots

configuring staging deployment slot
git remote add azurestage https://atrdwadc@rdhelloazure-staging.scm.azurewebsites.net:443/rdhelloazure.git
git add .                       #add any files that haven't been staged
git commit -a -m "showing a configurable greeting"

git push azurestage master

--deployment swap slots =>gives zero downtime deployment 
az webapp deployment slot swap -g RdHelloAzure -n RdHelloAzure --slot staging --target-slot production 

------------------------------------------------------------------------------------------------------------------------

application logs contain what is written into system.Diagnostics.
az webapps logs download # to download the web logs

------------------------------------------------------------------------------------------------------------------------

TODO: Refer to 'Azure key vault' on how to manage confidential information like connectionstrings

------------------------------------------------------------------------------------------------------------------------

cosmos db returns http 429 errors when requests cross the limit of RU/s
_etag field used for concurrency control
_ts is timestamp field
------------------------------------------------------------------------------------------------------------------------
some azure storage types are 
blob storage , table storage , queue storage, file storage , disk storage,
azure cosmos db,

BLOB Storage
----------
there are no folders. you may use slash to logically manage like folders.

https://azure.microsoft.com/en-us/features/storage-explorer/ --use tool to manage storage 
install windowsAzure.storage nuget pkg to use blob storage

 you need to use 'shared access singatures' to access the content saved in the blob storage not just the url of the content.


------------------------------------------------------------------------------------------------------------------------




