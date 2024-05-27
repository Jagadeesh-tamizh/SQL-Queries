

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

- **OrganiserNavigation.cs**
  - Fixed Table output in the `ViewSessionForOrganiser` method.
  - Added functionality to display list of Courses, Instructors, Batched in `SessionSectionAsync` for ease of input entry by organizer.

### TableParticulator
- Created new model `ForumPost`.

### DATABASE
- Created new Table `ForumPosts`.

These method-level changes provide a detailed overview of the modifications made within each module or class.
