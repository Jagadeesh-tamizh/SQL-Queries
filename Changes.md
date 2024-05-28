# HubstreamFinancePlatform PATCH 2.0
- **AUTHOR** `Jagadeesh T`
- **Changes to be made in** `App.config`
  
  ```xml
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
- **Package to be installed**
  - Open `Tools` > `Nugget Package Manager` > `Nugget Package Manager Console`
    
   ```console
   	Install-Package Newtonsoft.Json

   ```
   
- **STEPS TO CREATE JSON SERVER FOR ADDITIONAL RESOURCES**
  - Create a new folder and open terminal.
  - make sure `node` and `npm` is already installed.
   ```node
	npm install json-server
   ```
  - Create a new file named `db.json` and paste the below content.
    ```json
    {
    "providers":[
        {
            "name": "Udemy",
            "courses": [
              {
                "name": "Python for Beginners",
                "description": "Learn Python programming language from scratch.",
                "price": 59.99,
                "tags": ["Python", "Programming", "Beginner"]
              },
              {
                "name": "Web Development Bootcamp",
                "description": "Master HTML, CSS, JavaScript, and more.",
                "price": 79.99,
                "tags": ["Web Development", "HTML", "CSS", "JavaScript", "Bootcamp"]
              },
              {
                "name": "Java Programming Masterclass",
                "description": "Become an expert Java programmer.",
                "price": 89.99,
                "tags": ["Java", "Programming", "Masterclass"]
              },
              {
                "name": "Data Science and Machine Learning Bootcamp",
                "description": "Comprehensive bootcamp covering data science and machine learning.",
                "price": 99.99,
                "tags": ["Data Science", "Machine Learning", "Bootcamp"]
              },
              {
                "name": "iOS App Development Course",
                "description": "Learn to develop iOS apps using Swift.",
                "price": 69.99,
                "tags": ["iOS", "App Development", "Swift"]
              },
              {
                "name": "Android Development for Beginners",
                "description": "Get started with Android app development.",
                "price": 49.99,
                "tags": ["Android", "App Development", "Beginner"]
              },
              {
                "name": "JavaScript Essentials",
                "description": "Learn essential JavaScript concepts and techniques.",
                "price": 39.99,
                "tags": ["JavaScript", "Programming", "Beginner"]
              },
              {
                "name": "React Native Crash Course",
                "description": "Build mobile apps with React Native quickly.",
                "price": 59.99,
                "tags": ["React Native", "Mobile Development"]
              },
              {
                "name": "Django Web Development",
                "description": "Build web applications with Django framework.",
                "price": 79.99,
                "tags": ["Django", "Web Development"]
              },
              {
                "name": "Unity Game Development",
                "description": "Create games with Unity game engine.",
                "price": 89.99,
                "tags": ["Unity", "Game Development"]
              }
            ]
          },
          {
            "name": "Coursera",
            "courses": [
              {
                "name": "Machine Learning",
                "description": "Explore the fundamentals of machine learning and build your own projects.",
                "price": 49.99,
                "tags": ["Machine Learning", "Data Science", "Algorithm"]
              },
              {
                "name": "Data Science Specialization",
                "description": "Become a data scientist and learn data analysis, manipulation, and visualization.",
                "price": 99.99,
                "tags": ["Data Science", "Specialization", "Data Analysis"]
              },
              {
                "name": "Blockchain Basics",
                "description": "Learn the basics of blockchain technology.",
                "price": 29.99,
                "tags": ["Blockchain", "Technology", "Basics"]
              },
              {
                "name": "Digital Marketing Masterclass",
                "description": "Comprehensive course covering all aspects of digital marketing.",
                "price": 79.99,
                "tags": ["Digital Marketing", "Masterclass"]
              },
              {
                "name": "Artificial Intelligence: Principles and Techniques",
                "description": "Introduction to principles and techniques of AI.",
                "price": 59.99,
                "tags": ["Artificial Intelligence", "Principles", "Techniques"]
              },
              {
                "name": "Cybersecurity Fundamentals",
                "description": "Learn the fundamentals of cybersecurity.",
                "price": 39.99,
                "tags": ["Cybersecurity", "Fundamentals"]
              },
              {
                "name": "Python for Data Science",
                "description": "Learn Python for data science applications.",
                "price": 69.99,
                "tags": ["Python", "Data Science"]
              },
              {
                "name": "HTML5 Fundamentals",
                "description": "Master the fundamentals of HTML5.",
                "price": 29.99,
                "tags": ["HTML5", "Web Development"]
              },
              {
                "name": "JavaScript Algorithms and Data Structures",
                "description": "Learn essential algorithms and data structures in JavaScript.",
                "price": 49.99,
                "tags": ["JavaScript", "Algorithms", "Data Structures"]
              },
              {
                "name": "Advanced React and Redux",
                "description": "Advanced concepts in React and Redux for building complex web applications.",
                "price": 89.99,
                "tags": ["React", "Redux", "Advanced"]
              }
            ]
          },
          {
            "name": "edX",
            "courses": [
              {
                "name": "Introduction to Computer Science",
                "description": "Learn the fundamentals of computer science.",
                "price": 49.99,
                "tags": ["Computer Science", "Programming", "Beginner"]
              },
              {
                "name": "Data Analysis with Python",
                "description": "Learn data analysis techniques using Python.",
                "price": 69.99,
                "tags": ["Data Analysis", "Python"]
              },
              {
                "name": "Introduction to Artificial Intelligence",
                "description": "Introduction to AI concepts and applications.",
                "price": 59.99,
                "tags": ["Artificial Intelligence", "Introduction"]
              },
              {
                "name": "Microsoft Azure Fundamentals",
                "description": "Learn the basics of Microsoft Azure cloud platform.",
                "price": 39.99,
                "tags": ["Microsoft Azure", "Cloud Computing", "Fundamentals"]
              },
              {
                "name": "Microservices Architecture",
                "description": "Design scalable and resilient microservices architecture.",
                "price": 79.99,
                "tags": ["Microservices", "Architecture", "Scalability"]
              },
              {
                "name": "Full-Stack Web Development",
                "description": "Master both front-end and back-end web development.",
                "price": 89.99,
                "tags": ["Full-Stack", "Web Development"]
              },
              {
                "name": "iOS App Development with Swift",
                "description": "Develop iOS apps using Swift programming language.",
                "price": 69.99,
                "tags": ["iOS", "App Development", "Swift"]
              },
              {
                "name": "Android App Development with Kotlin",
                "description": "Develop Android apps using Kotlin programming language.",
                "price": 59.99,
                "tags": ["Android", "App Development", "Kotlin"]
              },
              {
                "name": "Cybersecurity Essentials",
                "description": "Learn essential concepts and techniques in cybersecurity.",
                "price": 49.99,
                "tags": ["Cybersecurity", "Essentials"]
              },
              {
                "name": "Game Development with Unity",
                "description": "Learn to develop games using Unity game engine.",
                "price": 79.99,
                "tags": ["Game Development", "Unity"]
              }
            ]
          },
          {
            "name": "Pluralsight",
            "courses": [
              {
                "name": "C# Fundamentals",
                "description": "Learn the basics of C# programming language.",
                "price": 49.99,
                "tags": ["C#", "Programming", "Beginner"]
              },
              {
                "name": "Java Fundamentals",
                "description": "Learn the basics of Java programming language.",
                "price": 59.99,
                "tags": ["Java", "Programming", "Beginner"]
              },
              {
                "name": "React Fundamentals",
                "description": "Learn the basics of React library for building user interfaces.",
                "price": 39.99,
                "tags": ["React", "Web Development", "Front-End"]
              },
              {
                "name": "Node.js Fundamentals",
                "description": "Learn the basics of Node.js for server-side JavaScript development.",
                "price": 49.99,
                "tags": ["Node.js", "JavaScript", "Back-End"]
              },
              {
                "name": "Python Fundamentals",
                "description": "Learn the basics of Python programming language.",
                "price": 39.99,
                "tags": ["Python", "Programming", "Beginner"]
              },
              {
                "name": "AWS Certified Solutions Architect",
                "description": "Prepare for the AWS Certified Solutions Architect exam.",
                "price": 99.99,
                "tags": ["AWS", "Certification", "Solutions Architect"]
              },
              {
                "name": "Data Science with R",
                "description": "Learn data science techniques using R programming language.",
                "price": 69.99,
                "tags": ["Data Science", "R", "Statistics"]
              },
              {
                "name": "Angular Fundamentals",
                "description": "Learn the basics of Angular framework for building web applications.",
                "price": 49.99,
                "tags": ["Angular", "Web Development", "Front-End"]
              },
              {
                "name": "SQL Server Fundamentals",
                "description": "Learn the basics of SQL Server database management system.",
                "price": 39.99,
                "tags": ["SQL Server", "Database", "Beginner"]
              },
              {
                "name": "Docker Fundamentals",
                "description": "Learn the basics of Docker containerization technology.",
                "price": 59.99,
                "tags": ["Docker", "Containerization", "DevOps"]
              }
            ]
          }
       ]
    }
 
    ```
  - Update `package.json` file
    ```json
	{
		"scripts": {
			"server": "json-server --watch db.json --port 5000"
  		},
  		"dependencies": {
			"json-server": "^1.0.0-beta.0"
  		}
	}
    
    ```
  - Open terminal and run
    ```node
    npm run server
    ```
  - Open `http://localhost:5000/providers/` and ensure the payload is received.
    
# PATCH NOTES: 
   
### App Configuration
- Added configuration in `App.config` file.
  
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
  - 
### SQLQuery
- Created new Folder `UTILS` which contains predefined queries to help the user.
- Created `HubstreamEducationStoredProcedureForLocalTableExport.sql` which helps to download tables as `.csv` files.

### TableParticulator
- Created new model `ForumPost`.

### Utility
- **SystemAdmin.cs**
  - Created new method `GetTablesFromDatabaseAsync`.
  - Created new mehtod `MoveFilesToCloudAsync` to move csv files from local to storage one by one.

### DATABASE
- Created new Table `ForumPosts`.

