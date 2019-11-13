# **C# / Selenium Crash Course**

## **Git Fundamentals**

### **Overview**
Having created a pair of C# projects locally on one's machine, a next logical stage is to put these into into a Version Control System (VCS), a.k.a. source control _repository_.
The _de facto_ standard at the present time is Git.

The object of this exercise is to create an account on GitHub, then create and use repositories on GitHub for the coding exercises undertaken.

Along the way, common Git operations will be covered:
* Create
* Commit
* Push

* Clone
* Checkout
* Pull

* Branches

### **Background**
At this stage one should have at least two C# Solutions on a PC, one for C# fundamentals and one for C#/Selenium development exercises.
Each of these should go in a separate Git repository.

Whilst Git repositories can 'live' on one's development machine, in team environments and/or where one wants to share their work, Git repositories are typically hosted on a server somewhere.
In team environments, e.g. within a development program/project hosted in an Azure environment, each project typically has one or more Git repositories accessible from a given project in TFS/VSTS/ADO.

Git itself has a globally available space to host code repositories: [GitHub](https://github.com)

### **Exercise A - Create a GitHub Account and Repositories**
#### 1. Create a GitHub Account
1. In a web browser, navigate to [GitHub](https://github.com)
1. Click the "Join ..." or "Sign Up" button
1. Enter a username of the form: _{your first initial}{your surname}-planit_
   * E.g.: Jane Doe -> **jdoe-planit**
1. Enter your Planit email address in the appropriate field
1. Enter a password per the instructions
1. Click "Next: Verify..."
1. Click "Next: Choose a Plan"
1. Click "Choose Free"
1. [OPTIONAL] Fill in the "Welcome to GitHub" form and click "Continue"
OR
1. Click "Skip this Step"

Next, verify your email from GitHub from your Planit email.

#### 2. Create a new Repository (C# Fundamentals)
Assumes successful verification / login to GitHub account

1. On the top right of the GitHub page, near your avatar icon, click the "+" icon
1. From the contextual menu, select "New Repository"
1. Enter "cs-cookie-objects" as the Repository name
1. [OPTIONAL] Add a description
1. Make the repository Public for now
1. [OPTIONAL] Check or uncheck "Initialise this repository with a README
1. Click "Create Repository"

#### 3. Add Files from your PC via GitHub Website
Assumes you already have your new "cs-cookie-objects" repo[sitory] open in GitHub

1. In GitHub, you should be on the "Code" tab of your repo
1. Click the button "Upload files", then click the link to "choose files".  A Windows Explorer window should appear
1. Move this Explorer window so that the "Drag files here" graphic is visible in GitHub site
1. In Windows Explorer, navigate to the folder on your computer where your Cookie Example C# solution is located
1. Open the folder containing the solution
1. Select ALL files and folders in the top level of the Visual Studio Solution folder
1. Drag the selected top-level files and folders to the "Drag files here" graphic on GitHub website
1. After a minute or two, the files should have been imported to the repository in GitHub

Behind the web interface, this action performed a _git **add**_ of the new/modified files

#### 3a. Your First Git Commit!
Note that there is a "Commit changes" box under the list of files imported

1. Change the first editable text box to "Initial commit"
1. [OPTIONAL] Fill in the extended description
1. Click "Commit changes"

Behind the web interface, this action performed a _git **commit**_

#### 4. Your First Git Clone / Checkout
This step assumes that :
* all instances of Visual Studio are closed on your PC
* In a web browser, you are logged into your GitHub account and are in the top-level of the new repository
* Visual Studio has the Git / GitHub plugins and support installed

1. Open Visual Studio (do not open existing project)
1. You should be presented with a splash screen, whereby one can open a recent project, or a number of other actions under "Get Started"
1. Choose "Clone or check out code"
1. In the browser, click the "Clone or download" button (right of screen, above the area that lists the repo's files)
1. Click the copy button to get the URL of the repo
1. Paste this into the "Repository Location" text box (in the open Clone or Checkout Code dialogue) in Visual Studio
1. Click the "Clone" button in Visual Studio

Behind the VS user interface, this action performed:
* a _git **clone {repository name/url}**_
* a _git **checkout master**_
... which pulled down the files in the repo to your PC, then using Git, ensured you have the latest code on the "master" branch

#### 5. Commits / Pushes from Visual Studio
1. With the cloned C# Cookie Example open in Visual Studio, make some simple changes to the code (such as add/change comments)
1. Ensure the "Team Explorer" pane is open in Visual Studio
1. Click the Home button in the Team Explorer Pane
1. Click the "Changes" button under "Project" in the Team Explorer Pane
1. Add a commit message
1. Click the "Commit All" button
1. Note the message in Visual Studio Team Explorer
1. Try to 'Sync' changes with the (GitHub) server
1. **Note the results**
1. _**What now needs to be done to get the modified files from your PC to the GitHub server?**_


### **Exercise B - Create a Repository for the C# / Selenium code and import the files**
As for the 'Cookie Object' code, the C# / Selenium Code will need to go into GitHub, so that it can be worked on further.

#### 1. Create a New Repository in GitHub
1. Create a new, public repository, "cs-selenium-tute"
1. Set a gitignore file.  Choose type, "Visual Studio"
  1. This should exclude build products and 'internal', hidden visual studio files from the repository

#### 2. Clone / Checkout the New, Empty Repository to your PC
This step assumes that :
* all instances of Visual Studio are closed on your PC
* In a web browser, you are logged into your GitHub account and are in the top-level of the new repository
* Visual Studio has the Git / GitHub plugins and support installed

1. Open Visual Studio (do not open existing project)
1. You should be presented with a splash screen, whereby one can open a recent project, or a number of other actions under "Get Started"
1. Choose "Clone or check out code"
1. In the browser, click the "Clone or download" button (right of screen, above the area that lists the repo's files)
1. Click the copy button to get the URL of the repo
1. Paste this into the "Repository Location" text box (in the open Clone or Checkout Code dialogue) in Visual Studio
1. Ensure the destination folder is of the form: Users\{YOUR_USER_NAME}\source\repos\cs-selenium-tute
1. Click the "Clone" button in Visual Studio

#### 3. Add files to the new local copy of cs-selenium-tute
1. Copy Contents of the Original C# / Selenium Solution Folder into the new cs-selenium-tute folder
2. Ensure the project / solution builds OK

#### 4. Commits / Pushes from Visual Studio
1. With the cloned cs-selenium-tute open in Visual Studio:
1. Ensure the "Team Explorer" pane is open in Visual Studio
1. Click the Home button in the Team Explorer Pane
1. Click the "Changes" button under "Project" in the Team Explorer Pane
1. Add a commit message (e.g.: initial commit)
1. Click the "Commit All" button
1. Note the message in Visual Studio Team Explorer
1. Try to 'Sync' changes with the (GitHub) server

