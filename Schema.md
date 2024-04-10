-- Create the Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    PhoneNumber BIGINT,
    Username VARCHAR(255),
    Password VARBINARY(64),
    Role VARCHAR(50)
);

-- Create the Reports table
CREATE TABLE Reports (
    ReportID INT PRIMARY KEY,
    ReportType VARCHAR(255),
    ReportDate DATETIME,
    Details TEXT
);

-- Create the Trains table
CREATE TABLE Trains (
    TrainID INT PRIMARY KEY,
    TrainName VARCHAR(255),
    FirstClassCapacity INT,
    SecondClassCapacity INT,
    ThirdClassCapacity INT,
    IsUnderMaintenance BIT
);

-- Create the Stations table
CREATE TABLE Stations (
    StationID INT PRIMARY KEY,
    StationName VARCHAR(255),
    Location VARCHAR(255),
    IsRunning BIT
);

-- Create the Notifications table
CREATE TABLE Notifications (
    NotificationID INT PRIMARY KEY,
    UserID INT,
    Message TEXT,
    Timestamp DATETIME,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Create the TrainSeats table
CREATE TABLE TrainSeats (
    TrainID INT,
    ClassType VARCHAR(20),
    BookedSeats INT,
    PRIMARY KEY (TrainID, ClassType),
    FOREIGN KEY (TrainID) REFERENCES Trains(TrainID)
);

-- Create the RouteIDs table
CREATE TABLE RouteIDs (
    RouteID INT PRIMARY KEY,
    SourceStationID INT,
    DestinationStationID INT,
    FOREIGN KEY (SourceStationID) REFERENCES Stations(StationID),
    FOREIGN KEY (DestinationStationID) REFERENCES Stations(StationID)
);

-- Create the TrainRoutes table
CREATE TABLE TrainRoutes (
    RouteID INT,
    StationID INT,
    StopOrder INT,
    JourneyTime TIME,
    HasStopping BIT,
    PRIMARY KEY (RouteID, StationID),
    FOREIGN KEY (RouteID) REFERENCES RouteIDs(RouteID),
    FOREIGN KEY (StationID) REFERENCES Stations(StationID)
);

-- Create the TrainSchedules table
CREATE TABLE TrainSchedules (
    ScheduleID INT PRIMARY KEY,
    TrainID INT,
    SourceStationID INT,
    DestinationStationID INT,
    RouteID INT,
    TrainName VARCHAR(255),
    DepartureTime DATETIME,
    ArrivalTime DATETIME,
    IsFirstClassPresent BIT,
    IsSecondClassPresent BIT,
    IsThirdClassPresent BIT,
    FOREIGN KEY (TrainID) REFERENCES Trains(TrainID),
    FOREIGN KEY (SourceStationID) REFERENCES Stations(StationID),
    FOREIGN KEY (DestinationStationID) REFERENCES Stations(StationID),
    FOREIGN KEY (RouteID) REFERENCES RouteIDs(RouteID)
);

-- Create the Bookings table
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY,
    UserID INT,
    ScheduleID INT,
    BookingDate DATETIME,
    FirstClassCount INT,
    SecondClassCount INT,
    ThirdClassCount INT,
    BoardingStationID INT,
    DepartureStationID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ScheduleID) REFERENCES TrainSchedules(ScheduleID),
    FOREIGN KEY (BoardingStationID) REFERENCES Stations(StationID),
    FOREIGN KEY (DepartureStationID) REFERENCES Stations(StationID)
);
