# Project Management System

![GitHub top language](https://img.shields.io/badge/Language-VB.NET-brightgreen?style=for-the-badge) ![GitHub contributors](https://img.shields.io/badge/Contributor-Cozmeh%20&%20Mr0weird0guy-red?style=for-the-badge) ![GitHub](https://img.shields.io/github/license/Cozmeh/Hover-SearchEffect?style=for-the-badge)

# Aim
A desktop application which help layout the time division and help organize the Life Cycle of the Projects.

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
   
   ```
   Example:
   Public sql As New SqlConnection With {
            .ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D:\Coding\Projects\Visual Studio\ProjectManager\Resources\employeeDB.mdf"
    }
   ```
   - Open the Project in Visual Studio 
   - Goto `LoginForm`, open up the code for LoginForm
   - 
