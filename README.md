# StudySync
StudySync is an app that syncs all your studying material across all platforms(Windows,Android, Mac/IOS, Linux). This project utilizes ASP.NET Core and C#.

# What is ASP.NET Core?
- ASP.NET Core is an open source C# web-development framework for building web apps on the .NET platform.
- ASP or "Active Server Pages" - Dynamic web pages, usually connected to a database.
- ASP.NET Core is a flexible Full Stack solution to DBMS, Business Logic, HTML. It can also be combined with popular front-end services like React, Angular, Vue.
- The .NET framework consists of runtime engine and libraries for executing programs written in a complaint language.
- C# is the most popular programming language to write applications for the .NET framework *(so thats what we'll be using)*. 


*The open-source version of ASP.NET, that runs on macOS, Linux, and Windows.(cross platform)*



An ASP.NET page contains a mix of HTML markup and dynamic ASP markup: 


![ASP.NET](image.png)

ASP.NET is run on a server combining the static HTML code, and updating the dynamic ASP elements to produce a final HTML page.

# MVC (Model Views and Controllers)
- Model: classes (objects)
    - For this app I will be creating a model for index cards for studying that has a question, answer, and an Id number.     
- View: web page (in this context -> Razor HTML)
    - The view will be the web pages that mangages the display of data.
- Controller: connects models, business logic and web pages.
    - The controller handles the code, page events, and navigation.  
- The MVC design pattern helps to enforce separation of concerns to help you avoid mixing presentation logic, business logic, and data access logic together. 
    - This means that we can create apps that optimize space/ file sizes, code is modular, and can be run and managed by multiple people. 

