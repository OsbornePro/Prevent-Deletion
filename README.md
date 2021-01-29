# Prevent-Deletion
![OsbornePro](https://raw.githubusercontent.com/tobor88/OsbornePro-The-Blue-Team-PowerShell-Security-Package/master/WEF%20Application/WEF/WEF/wwwroot/images/Logo.png) <br>

### Summary
This application is used to prevent the deletion of a defined file or directory to the Everyone group. This then forces the use of Admin credentials to delete the file or directory. This appears to not work when a computer is joined to a domiain enivornment and only works on standalone Windows devices. This is because it removes Delete permissions from the Everyone group.

### How To Use
To use the "__Prevent Deletion__" app follow these steps.
1. Double Click the app to open it. This opens the application which will open the below Window.
![Application Window](https://raw.githubusercontent.com/tobor88/Prevent-Deletion/main/Images/AppWindow.png)

2. In the text box which has a default value of "C:\Users", enter the absolute path to the file or directory you wish to prevent the deletion of. In the below image you can see I changed my value from C:\Users to C:\Test\test.txt.
![Entered Absolute Path Value In Text Box](https://raw.githubusercontent.com/tobor88/Prevent-Deletion/main/Images/TestValue.png)

3. Next simply click the "__Prevent Deletion__" button. This will modify the Everyone group permissions to prevent the deletion of the file or directory you defined. In my case this is the file C:\Test\test.txt. If the value you select is a directory that has a lot of child items this process can take a few minutes to complete. Although Windows is cycling through all the child NTFS permissions, only the file or directory defined will have it's permissions modified. You will received a message in the window letting you know the process could take a few minutes after clicking "__Prevent Deletion__". THis message can be seen when the process is taking more than a second to complete. 
![Final Results](https://raw.githubusercontent.com/tobor88/Prevent-Deletion/main/Images/Results.png)

__CONTACT:__ rosborne@osbornepro.com
