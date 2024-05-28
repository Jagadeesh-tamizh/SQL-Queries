# PATCH 2.0
- **AUTHOR** `Jagadeesh T`
-  ```txt
    - IMPROVED OVERALL APPLICATION
    ```
-  ```xml
     <!-- INSIDE THE App.config add the below configuration settings -->
    <appSettings>
	    <!-- Path here corresponding where .csv files present -->
	    <add key="BackUpFilePath" value="C:\Developers\{DEVELOPER_NAME}\HubstreamFinancePlatform\HubstreamFinancePlatform\Log"/>
	    <!-- Required azure blob container name -->
	    <add key="BackUpContainerName" value="hubstreamfinanceplatform"/>
	    <!-- Base URL of the JSON provider -->
	    <add key="ApiUrl" value="http://localhost:5000/providers"/>
    </appSettings>
   ```
# PATCH NOTES: 
   

### AzureStorage
- **AzureMyModule**
  - `FileUploadMethodAsync`: Created method to upload files.
  - `DownloadFileAsync`: Created method to download files.
### OnlineCourses
- **CourseProviders.cs**
  - `DisplayCourses`: Created method to display available courses from fetched data.
  - `FetchProviders`: Created method to fetch JSON data from the external API.
### DBService
- **ForumDBOperations.cs**
  - `SelectForumMessagesAsync`: Created method to fetch forum messages for a particular session.
  - `InsertForumMessageAsync`: Created method to insert the message into the Forums Table.
  
- **AssignmentDBOperation.cs**
  - `SelectCompletedAssignmentForInstructorAsync`: Created method to fetch the completed assignments of students.

- **CourseDBOperation.cs**
  - `CheckValidCourseId`: Created method to check whether a CourseID is present in the COURSEDETAILS table.
  - `AssignCourseToInstructor`: Created method to assign a course to the instructor while registering into the application.

- **ForumDBOperation.cs**
  - `SelectForumMessages`: Created method to fetch the top 100 messages of corresponding session.
  - `InsertForumMessage`: Created method to insert the message into the corresponding session.
- **StudentDBOperation.cs**
  - `SelectStudentsOfCurrentSession`: Created method to fetch the students of a particular session.
- **SessionDBOperation.cs**
  - `RescheduleSessionAsync`: Created method to Reschedule the Existing session to another date.
  - `CompleteSessionAsync`: Created method to mark a session is completed.

- **UserDBOperation.cs**
  - `CheckUserAlreadyExistsAsync`: Created method to check whether a User already exists in the database.
  - `FindUserIdWithUserName`: Created method to find the UserID of the user with username.

### HFPJobModule
- **JobSchedule**
  - `InitiatePeriodicActionAsync`: Created method to initiate required periodic actions.

### Navigation
- **HubstreamFinEduNavigation.cs**
  - `CollectStudentInformationAsync`, `ValidatePlace`, `CollectUserInformationAsync`: Input format and validations fixed.
  - `UserRegisterAsync`: Added functionality to let the instructor select his course with dynamic validation of course.

- **InstructorNavigation.cs**
  - Added functionality to display the list of assignments in `AssignmentSection` for ease of session selection.
  - Added functionality to display the list of completed assignments in `AssignmentSection` for ease of assignment selection.
  - Added functionality to display the list of Students of the particular session `ViewStudentTableOfSession` for ease of student selection.

- **OrganiserNavigation.cs**
  - Fixed Table output in the `ViewSessionForOrganiser` method.
  - Added functionality to display list of Courses, Instructors, Batched in `SessionSectionAsync` for ease of input entry by organizer.
- **StudentNavigation.cs**
  - Added method `AdditionalResourcesAsync` to display list of external additional resources from the internet.

### TableParticulator
- Created new model `ForumPost`.

### Utility
- **SystemAdmin.cs**
  - Created new method `GetTablesFromDatabaseAsync`.
  - Created new mehtod `MoveFilesToCloudAsync` to move csv files from local to storage one by one.

### DATABASE
- Created new Table `ForumPosts`.

