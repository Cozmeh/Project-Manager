# Project Management System

![GitHub top language](https://img.shields.io/badge/Language-VB.NET-brightgreen?style=for-the-badge) ![GitHub contributors](https://img.shields.io/badge/Contributor-Cozmeh%20&%20Mr0weird0guy-red?style=for-the-badge) ![GitHub](https://img.shields.io/github/license/Cozmeh/Hover-SearchEffect?style=for-the-badge)

# Aim
A Desktop Application which help layout the time division and help organize the Life Cycle of the Projects Using Basic `WaterFall Model`.

# Description
A VB.NET based project management software which makes a schedules layout of any project that is planed to be developed.\
It uses informations like the time duration and number of people involved in the process of any project development.\
It will only allow the edit access to the schedule and the ability to assign employees only to the Project Manager/Head.\
Once assigned the employees can check their deadline and update weather they have completed their task (on time or delayed) in the software.

# Modules
	- Login Page
	- Manager Home Page(Previous Project)
	- Employee Home Page(Current Project)
	- Add New Project
	- Project layout
	- Contributors Page
	- Edit Project
	- Task Update

# Usage
> ### Prerequisites

1. ***SQL Environment***
   - Open Visual Studio
   - Goto Tools >> Get Tools and Features.. >> Individual Components 
   - Search for `"sql"`
   - Download the following Components
	
		![Components](https://user-images.githubusercontent.com/117145297/227540826-bd92404f-7976-41da-a438-46a84e05e727.jpg)

2. ***NuGet Packages***
   - Open the Project `.sln` file in Visual Studio
   - Goto Solution Explorer >> right click on `ProjectManager` >> click on `Manage NuGet Packages..`
   - Search for `"sql"` 
   - Install the following package
   
   		![Sql-NuGet](https://user-images.githubusercontent.com/117145297/227549661-92b0ebe6-65f6-4fde-8f24-21af60478d98.jpg)
		
3. ***DataBase Setup***
   - Open the Project in Visual Studio `.sln` file 
   - Goto View >> Click on `SQL Server Object Explorer`
   - Copy the Data Source name , For example : `(localdb)\MSSQLLocalDB` , (right click and click rename to copy the name)
   		
		![DataS](https://user-images.githubusercontent.com/117145297/227561430-3c6f926e-5306-4549-9b0f-1015eee647ab.gif)

   - Open the project folder `ProjectManager` in file explorer 
   - Goto `Resources` folder 
   - Copy the file path of the file `employeeDB.mdf`, For example : `D:\Coding\Projects\Visual Studio\ProjectManager\Resources\employeeDB.mdf`
   - Create your Sql Connection String from the `Data Source` and `DataBase file path` that you have copied
   Example:
   ```
   Public sql As New SqlConnection With {
            .ConnectionString = "Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = D:\Coding\Projects\Visual Studio\ProjectManager\Resources\employeeDB.mdf"
    }
   ```
   > Change the Data Source = "Datasource name that copied" and Initial Catalog = "Path that you copied"
	
   - Open the Project in Visual Studio 
   - Goto `LoginForm`, open up the code for LoginForm
   - Replace the Existing Connection String with your Personal Connection String for the SQL 
   
   		![DBCon](https://user-images.githubusercontent.com/117145297/227583844-36d7b45b-eae3-4f64-9f77-06a786f6fe0a.gif)
		
Note - Open the DataBase file from the Solutions Explorer inside Visual Studio before running the Application!

# Module Interface
![Login](https://user-images.githubusercontent.com/117145297/227587790-d4af58be-99bd-4929-938f-9f9ba556fea3.jpeg)
![Admin](https://user-images.githubusercontent.com/117145297/227587764-efc64b99-2aed-48a9-a691-6a6e64e4652f.jpeg)
![Manager](https://user-images.githubusercontent.com/117145297/227587794-b601e11c-91b8-43e7-bd56-816106e4945a.jpeg)
![NewProject](https://user-images.githubusercontent.com/117145297/227587799-41b0eed4-991a-4183-b4a9-8d94940d7da5.jpeg)
![ProjectLayout](https://user-images.githubusercontent.com/117145297/227587803-33ffc461-d57c-4610-92b8-bb205f9c5dfd.jpeg)
![EditProject](https://user-images.githubusercontent.com/117145297/227587779-c3475a4a-5d03-4606-83fb-4cab5c5dce51.jpeg)
![Contributors](https://user-images.githubusercontent.com/117145297/227587774-681b6a26-a256-4963-aa6c-8bb76c68ba14.jpeg)
![TaskContributor](https://user-images.githubusercontent.com/117145297/227587815-8162ff9e-ffa4-44ec-9528-1012bc4fe743.jpeg)
![EmployeeHomePage](https://user-images.githubusercontent.com/117145297/227587783-37ab48d6-7066-457a-8e32-1501f5f05f86.jpeg)
![Task Status](https://user-images.githubusercontent.com/117145297/227587810-aead8a79-268a-4fc2-948c-25f9eebd88a9.jpeg)

### Note 
- Incase of any major problem, let us know by Creating an [Issue](https://docs.github.com/en/issues/tracking-your-work-with-issues/quickstart) on Github
- Feel free to `Contribute` to this project if your interesed.
- This is **Not** suitable for `commercial/real world` use , it is only for `Educational and learning purpose` and could be used as a College or school project. 
