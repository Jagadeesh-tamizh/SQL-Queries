-- Insert data into Users table
INSERT INTO Users (UserID, PhoneNumber, Username, Password, Role) VALUES
(1001, 987654321, 'admin1', CONVERT(VARBINARY(64), 'admin123'), 'admin'),
(1002, 988763295, 'master1', CONVERT(VARBINARY(64), 'master12'), 'railway master'),
(1003, 735859437, 'superuser', CONVERT(VARBINARY(64), 'superpass'), 'admin'),
(1004, 385638393, 'devadmin', CONVERT(VARBINARY(64), 'devpass'), 'developer'),
(1005, 747367398, 'support1', CONVERT(VARBINARY(64), 'support12'), 'customer support');

-- Insert data into Reports table
INSERT INTO Reports (ReportID, ReportType, ReportDate, Details) VALUES
(3001, 'Bug', '2024-04-06', 'Issue with login page'),
(3002, 'Enhancement', '2024-04-07', 'Improve search functionality'),
(3003, 'Bug', '2024-04-08', 'Incorrect calculation'),
(3004, 'Feedback', '2024-04-09', 'UI suggestion'),
(3005, 'Enhancement', '2024-04-10', 'Add new feature');

-- Insert data into Trains table
INSERT INTO Trains (TrainID, TrainName, FirstClassCapacity, SecondClassCapacity, ThirdClassCapacity, IsUnderMaintenance) VALUES
(101, 'Express 1', 50, 80, 100, 0),
(102, 'Local 2', 40, 60, 80, 1),
(103, 'Superfast', 60, 100, 120, 0),
(104, 'Metro 4', 0, 0, 120, 1),
(105, 'Bullet 5', 0, 0, 120, 0);


-- Insert data into Stations table
INSERT INTO Stations (StationID, StationName, Location, IsRunning) VALUES
(1, 'Station A', 'City X', 1),
(2, 'Station B', 'City Y', 1),
(3, 'Station C', 'City Z', 1),
(4, 'Station D', 'City P', 1),
(5, 'Station E', 'City Q', 1);

-- Insert data into Notifications table
INSERT INTO Notifications (NotificationID, UserID, Message, Timestamp) VALUES
(5001, 1001, 'Your booking for Train 101 is confirmed.', '2024-04-06 10:30:00'),
(5002, 1002, 'Maintenance scheduled for Train 102.', '2024-04-07 14:15:00'),
(5003, 1003, 'New report submitted: Bug in search feature.', '2024-04-08 09:45:00'),
(5004, 1004, 'Reminder: Meeting with developers at 3 PM.', '2024-04-09 13:30:00'),
(5005, 1005, 'Your password has been reset successfully.', '2024-04-09 13:30:00');



-- Insert data into TrainSeats table
INSERT INTO TrainSeats (TrainID, ClassType, BookedSeats) VALUES
(101, 'FirstClass', 20),
(101, 'SecondClass', 50),
(101, 'ThirdClass', 20),
(102, 'FirstClass', 20),
(102, 'SecondClass', 50),
(102, 'ThirdClass', 30),
(103, 'FirstClass', 20),
(103, 'SecondClass', 50),
(103, 'ThirdClass', 40),
(104, 'FirstClass', 0),
(104, 'SecondClass', 0),
(104, 'ThirdClass', 30),
(105, 'FirstClass', 0),
(105, 'SecondClass', 0),
(105, 'ThirdClass', 40);

-- Insert data into RouteIDs table
INSERT INTO RouteIDs (RouteID, SourceStationID, DestinationStationID) VALUES
(1, 1, 5),
(2, 1, 4),
(3, 1, 3),
(4, 2, 4),
(5, 2, 5);


-- Insert data into TrainRoutes table
INSERT INTO TrainRoutes (RouteID, StationID, StopOrder, JourneyTime, HasStopping) VALUES
(1, 1, 1, '00:00:00', 1),
(1, 2, 2, '00:00:30', 0),
(1, 3, 3, '00:01:30', 1),
(2, 3, 1, '00:02:30', 1),
(2, 4, 2, '00:00:00', 1);




-- Insert data into TrainSchedules table
INSERT INTO TrainSchedules (ScheduleID, TrainID, SourceStationID, DestinationStationID, RouteID, TrainName, DepartureTime, ArrivalTime, IsFirstClassPresent, IsSecondClassPresent, IsThirdClassPresent) VALUES
(1000, 101, 1, 5, 1, 'Express 1', '2024-04-08 08:00:00', '2024-04-08 18:00:00', 1, 1, 1),
(1001, 102, 3, 7, 2, 'Local 2', '2024-04-08 08:00:00', '2024-04-08 18:00:00', 1, 1, 1),
(1002, 103, 2, 6, 3, 'Superfast', '2024-04-08 08:00:00', '2024-04-08 18:00:00', 0, 0, 1),
(1003, 104, 4, 8, 4, 'Metro 4', '2024-04-08 08:00:00', '2024-04-08 18:00:00', 0, 1, 1),
(1004, 105, 5, 9, 5, 'Bullet 5', '2024-04-08 08:00:00', '2024-04-08 18:00:00', 0, 1, 1);



-- Insert data into Bookings table
INSERT INTO Bookings (BookingID, UserID, ScheduleID, BookingDate, FirstClassCount, SecondClassCount, ThirdClassCount, BoardingStationID, DepartureStationID) VALUES
(1001, 1001, 1000, '2024-04-06', 2, 2, 2, 1, 5),
(1002, 1002, 1001, '2024-04-07', 1, 1, 1, 3, 7),
(1003, 1003, 1002, '2024-04-08', 3, 3, 3, 2, 6),
(1004, 1004, 1003, '2024-04-09', 2, 0, 6, 4, 8),
(1005, 1005, 1004, '2024-04-10', 4, 0, 7, 5, 9);
