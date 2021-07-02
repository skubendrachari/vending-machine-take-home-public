## Vending Machine App

This sample mocks the functionality of Vending Machine with the basic ability of vending snacks. An attempt to build using the TDD approach (Red/Green/Refactor).

## Tools/SDK Required 
- [VS Code](https://code.visualstudio.com/)
- [.NET Core 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)

## Building the application

- After cloning the repoistory 
- Open VSCode and open the source code directory by clicking on File -> Open Folder -> Selecting the Folder
![alt text](https://user-images.githubusercontent.com/17605340/124309930-79527d00-db39-11eb-8701-65a162123378.PNG)
- VSCode will prepare the environment and download all required extensions automatically
- After VSCode loads the solution, Select the VendingMachine project on the Explorer menu and from the menu select Run -> Start Debugging.
  ![alt text](https://user-images.githubusercontent.com/17605340/124310362-101f3980-db3a-11eb-8954-01555bf6032c.png)
- When prompted for the launch option select the VendingMachine app
  ![alt text](https://user-images.githubusercontent.com/17605340/124310892-db5fb200-db3a-11eb-839f-1cafb54813ab.png)
- This process will both compile the application and facilitate the application Debugging 
  ![alt text](https://user-images.githubusercontent.com/17605340/124311020-0ea24100-db3b-11eb-814d-53a3ea2a9e0d.png)
- To Stop Debugging, Selcect Run -> Stop Debugging

 ## Running the Test Suite
- To run the test suite within VSCode you would need to instal the [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
  ![alt text](https://user-images.githubusercontent.com/17605340/124311997-9b99ca00-db3c-11eb-9703-3a8745b061f2.png)
- After the extension instal, Go to View -> Testing. This would discover and load all the test in the Test Explorer View
  ![alt text](https://user-images.githubusercontent.com/17605340/124312266-021ee800-db3d-11eb-86ee-3b9461397008.png)
- Click on the Run All Test
  ![alt text](https://user-images.githubusercontent.com/17605340/124312514-7194d780-db3d-11eb-82ca-833606db8807.png)
- Test results will be displayed 
  ![alt text](https://user-images.githubusercontent.com/17605340/124312479-65a91580-db3d-11eb-9ec5-e4d8d55ef21a.png)

 ## Building the application using console
- Open visual studio command prompt by clicking on the Windows key -> Search for Developer Command Prompt
```console
dotnet build VendingMachine.sln --no-restore
```
![alt text](https://user-images.githubusercontent.com/17605340/123356573-f4160980-d535-11eb-8d56-701ddb168552.PNG) 

## CI/CD

- The application has CI/CD pipeline setup for every commit with the below 3 tasks
  - Build
  - Test
  - Deploy

https://github.com/skubendrachari/vending-machine-take-home-public/blob/main/.github/workflows/CICD.yml 
 
![alt text](https://user-images.githubusercontent.com/17605340/123356537-e3659380-d535-11eb-9e02-af01d07cf7e0.PNG)
 
## Debug Tools with Visual Studio

You can debug Source Link enabled .NET Tools with Visual Studio, using the Developer Command Prompt for VS 2019. 

![alt text](https://user-images.githubusercontent.com/17605340/123356426-b4e7b880-d535-11eb-939d-b1f342a49c64.PNG)
