# Gist
+ An ASP.NET Core MVC web application which creates, reads, updates and deletes customers and orders, enabling efficient management of customer data and order processing.
  + Tech Stack: C#, ASP.NET Core MVC, Docker, MSSQL, Azure Data Studio.
+ Download the database from the database folder in the repository. 
+ NOTE: This project works on a Mac (Intel chip). Not sure if it's compatible with M1/M2. It's not compatible with Windows.

# Prerequisites
+ Before you begin, ensure you have the following installed on your Mac (Intel chip) [Kindly go through the "Setup" section for smooth installation]:
  1. [Docker](https://www.docker.com/products/docker-desktop/) (Select the "Download for Mac-Intel Chip" from the dropdown "Download for Mac - Apple Chip)
  2. [Visual Studio for Mac 2022](https://visualstudio.microsoft.com/vs/mac/). Please tick the dotnet package while installing
  3. [Azure Data Studio](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?tabs=macOS-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall#download-azure-data-studio) (Again download the .zip that says "Intel Chip")
  4. Dotnet SDK (You can directly install it via the terminal)
  5. The database
 
# Setup
+ Kindly follow the steps in the given link - [Setup Instructions](https://builtin.com/software-engineering-perspectives/sql-server-management-studio-mac).

# Approach
+ To leverage Entity Framework Core's ability to automate model and DbContext creation, I opted for the database-first approach. This involved scaffolding the models and DbContext directly from the existing database, saving me significant development time.

# Running the application
1. Place the database in the path /var/opt/mssql/data/ inside Azure Data Studio. Kindly follow this link for smooth setup - https://sqlblog.org/2020/03/15/attaching-restoring-databases-inside-a-container. Refer to the "PlaceDatabaseHere.png" screenshot in the screenshots folder. Once the database is uploaded, please connect to the server. For connection, please use the following:
    + Server: localhost
    + Username: sa (You should use the same username that you used while setup)
    + Password: dockerStrongPwd123 (You should use the same password that you used while setup)
    + Authentication Type: SQL Login
    + Trust Server Certificate: True
 2. Clone this repository into local or download ZIP.
 3. Open Visual Studio for Mac and Click on Open and navigate to the project file "CustomersOrdersCRUDWeb.csproj" via the path CustomersOrdersCRUD/CustomersOrdersCRUDWeb/CustomersOrdersCRUDWeb.csproj (wherever you've stored the project folder in your local).
 4. In the menu bar, navigate to "Project", click on "Manage Nuget Packages..." and check if the following packages are installed:
    + Microsoft.EntityFrameworkCore.Sqlite 7.0.16
    + Microsoft.EntityFrameworkCore.SqlServer 7.0.16 
    + Microsoft.EntityFrameworkCore.Tools 7.0.16
    + Microsoft.Extensions.Configuration 7.0.0
    + Microsoft.VisualStudio.Web.CodeGeneration.Design 7.0.12
  5. If not, please install them and add them to the project.
  6. In the menu bar of Visual Studio, navigate to "Build" and in the dropdown, click on "Clean All".
  7. Once the clean is successful, navigate to "Build" and in the dropdown, click on "Rebuild Solution" and wait for successful build.
  8. On the top-left, click on the play icon to run the project (You can also use "command + return") and wait for 2-3 seconds.
  9. Click on "Customers" and "Orders" to view customers and orders respectively.
  10. You can create new customers/orders by clicking on "Create New". You can read existing customers/orders by clicking on "Details". You can update existing customers/orders by clicking on "Edit". You can delete existing customers/orders by clicking on "Delete".
+ NOTE: Relevant screenshots are attached. Please check the screenshots folder.

# Limitations
+ Minimal front-end.
+ Isn't deployed. So, it can be tested only locally for now. However, you can always deploy it and test it. It should work.
