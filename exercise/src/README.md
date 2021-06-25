## Vending Machine App

This sample mocks the functionality of Vending Machine with the basic ability of vending snacks. An attempt to build using the TDD approach (Red/Green/Refactor).
You must have the .NET SDK installed. .NET Core 5.0 is recommended.

## Executing

- After cloning the application 
- If Visual studio code is available open the solution file VendingMachine.sln and set the VendingMachine console application as startup and fire up VS
- Or else from the visual studio command prompt execute
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
