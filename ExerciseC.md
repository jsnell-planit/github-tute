# Exercise C - C# / Selenium
## Creating a new Git Branch

### Overview
In standard development practice, when a developer starts to work on a new feature or update to a code project, they create a new branch and work in the branch, leaving the (presumably) working code in the 'master' branch intact.
Branching strategy is often a little more complex on larger projects.

Common forms of branch names are:
* {developer_name}-{Story/PBI_ID}-{VERY_Short_Description}
* feature/{developer_name}-{Story/PBI_ID}-{VERY_Short_Description}
* feature/{feature_name}/{developer_name}-{Story/PBI_ID}-{VERY_Short_Description}

Prior to making changes to the C# / Selenium exercise (cs-selenium-tute), we will create a branch for the next round of changes

**This exercise presumes Exercise B was successfully completed**

### 1. Add a Local Branch to cs-selenium-tute Solution in Visual Studio
1. Open the cs-selenium-tute Solution in Visual Studio
2. Select the **Team Explorer** tab  at the bottom of the Solution Explorer pane
3. Click the **Home** icon at the top of Team Explorer
4. Click **Branches**
5. Click **New Branch**
6. In the highlighted field, enter a new Branch Name: {your_first_name}-ex2-cleanup-tests-round1
7. Ensure that the droplist under the field says 'master', since we want to branch directly from master in this example
8. Ensure that the "Checkout branch" checkbox is checked:  We want to immediately start work in the new branch
9. Click the **Create Branch** button

### 2. Minor update to code
1. Switch back to the **Solution Explorer** pane
2. In each test class, add a comment (just before the first test method):
```C
  // TODO: Create WebDriver and configure it ONCE per test class
```
3. Save the file(s)

### 3. Commit Changes and Publish Branch
1. Switch back to the **Team Explorer** pane
2. Click **Home**
3. Click **Changes**
4. For the change comment, enter "prepare for ex2 changes"
5. In the drop list below the comment box (Should say "Commit All"), Select **Commit All and Sync**
6. This should 'publish' the new branch to the 'origin' (GitHub is the origin in this case)

7. In GitHub, refresh the view on the repository and confirm the new branch is present
8. _The solution is now ready for the implementation and testing of the next round of changes_
