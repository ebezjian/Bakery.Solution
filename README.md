<div align="center">
<img src="https://user-images.githubusercontent.com/49379604/99859318-b8f5c700-2b5d-11eb-9977-056ef61ecdb3.png">
</div>
<br>
<h1 align = "center">
<b> Pierre's Bakery Treats and Flavors </b>
</h1>

<p align = "center">
This application allows the user to keep track of Flavors and Treats in Pierre's Bakery </p>
<p align = "center"> Created January 15, 2021 </p>



--------------------

## 📖  Description

This application allows the user to keep track of Flavors and Treats in Pierre's Bakery. The user can add Treats to an Flavor who is authorzed to do so and add Flavors to a Treat. 

This is the Independent Project for Epicodus week 12 as part of the "Many-to-Many Relationships" coursework. 

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3.0
- .NET Core v2.2.0
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core
- Identity

-------------------

## Specifications

<div >
<img src="https://cdn.discordapp.com/attachments/537816642122547212/799799427434283048/flowchartbakery.PNG">
</div>


<details>
<summary>User Stories</summary>

| Story # | User Story | Complete |
| :------------- | :------------- | :------------- |
| 01 | As the User , I need to be able to see a list of all Flavors, and I need to be able to see a list of all Treats. | true |
| 02 | As the User , I need to be able to select a Flavor, see their details, and see a list of all Treats that Flavor is associated to it. I also need to be able to select a treat, see its details, and see a list of all Flavors associated to it. | true |
| 03 | As the User , I need to add new Flavors to our system when they are hired. I also need to add new Treats to our system when they are installed. | true |
| 04 | As the User , I should be able to add new Treats even if no Flavors are employed. I should also be able to add new Flavors even if no Treats are installed. | true |
| 05 | As the User , I need to be able to add or remove Treats that a specific Flavor is associated to. I also need to be able to modify this relationship from the other side, and add or remove Flavors from a specific treat. | true |
| 06 | I should be able to navigate to a splash page that lists all Flavors and Treats. Users should be able to click on an individual Flavor or treat to see all the Flavors/Treats that belong to it. | true |
| 07 | As the User I can Register, Login and Logout | true |
| 08 | As the User when I am logged in I should be the only User that can create, update and delete treats while other users may be able to just read | true |

</details>

-------------------

## 🐛 Known Bugs

-------------------

## 🔧 Setup & Requirements

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### ⚙️ Open & Use

#### To Download:

Go to my GitHub repository here, [https://github.com/ebezjian/Bakery.Solution](https://github.com/ebezjian/Bakery.Solution), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/ebezjian/Bakery.Solution.git`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.


#### AppSettings:

After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=bakery;uid=root;pwd=epicodus;"
  }
}
```
*Please note you will need to replace `epicodus` with the password you created for your MySQL server.

#### Import Database using Entity Framework Core (option 1 continued):

 - In the command line run ` cd Desktop/Bakery.Solution/Bakery` to navigate to the "Bakery" folder. 
 - Next, run `dotnet ef database update` to generate the database. You can confirm the database was created by checking MySQL workbench.

*to make changed to the database you can run `dotnet ef migrations add <MigrationName>`

#### Import Database using MySQL Workbench (option 2):

 - Open MySQL workbench and go to the navigation bar and select `Server > Data Import`. 
 - Next, select the option `Import from Self-Contained File` and confirm you have the file `bakery.sql` set to be imported (this files exists in the root directory of this project). 
 - Then, set the `Defaul Target Schema` or create a new schema and select all the the Schema Objects you want to be imported. 
 - Check that the option `Dump Structure and Data` is selected. Once you confirm you have all of the correct settings click `Start Import`.


#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'Bakery' folder (`cd Bakery) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:ebezjian@gmail.com).

---------------------------

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2021 Ellie Lambert