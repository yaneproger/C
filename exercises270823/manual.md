* Yazik razmetki MarkDown
# Git user manual
## 1. Local repository
* git init - initializes local repository
## 2. Working with branches
* git branch - retunrs list of branches
* git branch "name" - creates branch with "name"
>>>>>citate to test
* git checkout -b "name" -creates branch with "name" and check out  to it
* git merge "branch name" - merges branch with "branch name" with current branch
* git checkout - Switching branches and restoring working tree files
* git branch -v -a - displaying branches with all info
## 3. Working with remote branches
* git remote -v - displays remote branches
* git fetch --all - fetches all remotes - even if your updated file not in git initialized repository, but in repository some level under
* git remote add origin https://github.com/yaneproger/C.git - Adds remote reposiroty named "origin"
* git pull origin master - downloads all changes made on remote repo, in to your local repo, before this, if you got an error, you may enter "git fetch -all" command
* git reset commit_name - moves both the HEAD and branch refs to the specified commit.
* git reset HEAD~2 command moves the current branch backward by two commits, effectively removing the two snapshots we just created from the project history. Remember that this kind of reset should only be used on unpublished commits. Never perform the above operation if you’ve already pushed your commits to a shared repository.
* git pull --rebase - this command compiles 2 commands git pull (which consist of 2 commands -git fetch and git merge), and git rebase command

  

  






