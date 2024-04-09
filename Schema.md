Here's the finalized schema of all tables:

1. **Trains:**
   - TrainID (INT, PRIMARY KEY)
   - TrainName (VARCHAR(255))
   - FirstClassCapacity (INT)
   - SecondClassCapacity (INT)
   - ThirdClassCapacity (INT)
   - IsUnderMaintenance (BIT)

2. **Stations:**
   - StationID (INT, PRIMARY KEY)
   - StationName (VARCHAR(255))
   - Location (VARCHAR(255))
   - IsRunning (BIT)

3. **TrainSchedules:**
   - ScheduleID (INT, PRIMARY KEY)
   - TrainID (INT, FOREIGN KEY from Trains)
   - SourceStationID (INT, FOREIGN KEY from Stations)
   - DestinationStationID (INT, FOREIGN KEY from Stations)
   - RouteID (INT, FOREIGN KEY from RouteIDs)
   - TrainName (VARCHAR(255))
   - DepartureTime (DATETIME)
   - ArrivalTime (DATETIME)
   - IsFirstClassPresent (BIT)
   - IsSecondClassPresent (BIT)
   - IsThirdClassPresent (BIT)

4. **TrainSeats:**
   - TrainID (INT, FOREIGN KEY from Trains)
   - BookedFirstClass (INT)
   - BookedSecondClass (INT)
   - BookedThirdClass (INT)

5. **TrainRoutes:**
   - RouteID (INT, PRIMARY KEY)
   - TrainID (INT, FOREIGN KEY from Trains)
   - StationID (INT, FOREIGN KEY from Stations)
   - StopOrder (INT)
   - JourneyTime (TIME)
   - HasStopping (BIT)

6. **RouteIDs:**
   - RouteID (INT, PRIMARY KEY)
   - SourceStationID (INT, FOREIGN KEY from Stations)
   - DestinationStationID (INT, FOREIGN KEY from Stations)

7. **Bookings:**
   - BookingID (INT, PRIMARY KEY)
   - UserID (INT, FOREIGN KEY from Users)
   - ScheduleID (INT, FOREIGN KEY from TrainSchedules)
   - BookingDate (DATETIME)
   - FirstClassCount (INT)
   - SecondClassCount (INT)
   - ThirdClassCount (INT)
   - BoardingStationID (INT, FOREIGN KEY from Stations)
   - DepartureStationID (INT, FOREIGN KEY from Stations)

8. **Notifications:**
   - NotificationID (INT, PRIMARY KEY)
   - UserID (INT, FOREIGN KEY from Users)
   - Message (TEXT)
   - Timestamp (DATETIME)

9. **Users:**
    - UserID (INT, PRIMARY KEY)
    - PhoneNumber (BIGINT)
    - Username (VARCHAR(255))
    - Password (VARBINARY(64))
    - Role (VARCHAR(50))

10. **Reports:**
    - ReportID (INT, PRIMARY KEY)
    - ReportType (VARCHAR(255))
    - ReportDate (DATETIME)
    - Details (TEXT)

This schema outlines the structure of each table with appropriate data types and relations.
