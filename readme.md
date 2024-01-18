# QA Atlantbh task


## Project description

In this project, we were asked to write test plan, UI and API test cases as well as automation smoke test. We had to create the user, log the user in and enable them to perform CRUD operations. The project/task itself contains multiple parts:
- Automation script written in C# using Selenium
- Test-Plan
- Test-Cases (UI and API)
- Bug report
- Postman collection


In the automation part we have used C# as our main technology with Selenium to perform smoke test of the most important features. In order to run this you need to have specific NuGet packages which can be found in this path `.\ContactListApp\obj\ContactListApp.csproj.nuget.g.targets`.

In the Test-Plan file we have the following structure:
- brief description
- list of features and their brief explanation
- list of test objectives where we describe what we want to achieve and test with this process
- list of deliverables, which is separated into three sections: before, during, and after the testing
- description of how will we report the bugs
- list of tools that we will be using
- list of questions and things to discuss regarding the way of how the product works (list of things to discuss with Product Owners, Project Managers, Delivery Managers, etc.)

In the Test-Cases part we will list test cases in which each of them will be:
- described thoroughly
- separated by features
- focused on positive and negative flows
- steps needed to execute them
- expected results

In the Bug Report section you can find the list of bugs where each of them contain the following:
- Bug ID
- Bug Name
- Prioritization
- Details
- Environment
- Additional Notes

And finally you can access the Postman Collection as a part of this repo here `.\Contact List Tests.postman_collection.json`



## Using the project

Besides automation part of the project/task there is no classical way of using/executing/running the rest of the project. Also, this readme.md file only serves the purpose of giving a high-level overview of the things that have been done in the sections mentioned above. For more detail, open the projects or the `.docx` files attached to this repository.