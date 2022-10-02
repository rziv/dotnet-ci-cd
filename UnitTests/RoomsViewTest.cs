using Bci.Utility;
using Kmh.Rooms.Models;
using Kmh.Rooms.Presenters;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kmh.UnitTests
{

    public class RoomsViewTest
    {

        [OneTimeSetUp]
        public virtual void Init()
        {
        }

        [SetUp]
        public virtual void TestStart()
        {
        }

        [TearDown]
        public virtual void TestsFinish()
        {
        }

        [OneTimeTearDown]
        public virtual void Finish()
        {
        }

        [Test]
        public void WeeklyPresenter_ConflictingCalendarActivities_ShouldBeInTheSameGroup()
        {
            //Arrange
            RoomModel room = new RoomModel() { BuildingID = "10", RoomName = "Room1" };
            RoomWeeklyPresenter roomPresenter = new RoomWeeklyPresenter(room);
            IScheduledActivityModel studySession1 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession2 =
                createActivity(new DateTime(2020, 10, 8, 12, 30, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession3 =
                createActivity(new DateTime(2020, 10, 8, 13, 30, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession4 =
               createActivity(new DateTime(2020, 10, 8, 18, 00, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession5 =
                createActivity(new DateTime(2020, 10, 8, 19, 30, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession6 =
               createActivity(new DateTime(2020, 10, 15, 13, 30, 0), ActivityType.StudySession);

            //Act
            roomPresenter.AddActivityToRoom(studySession1, RoomsViewType.CalendarView);
            roomPresenter.AddActivityToRoom(studySession2, RoomsViewType.CalendarView);
            roomPresenter.AddActivityToRoom(studySession3, RoomsViewType.CalendarView);
            roomPresenter.AddActivityToRoom(studySession4, RoomsViewType.CalendarView);
            roomPresenter.AddActivityToRoom(studySession5, RoomsViewType.CalendarView);
            roomPresenter.AddActivityToRoom(studySession6, RoomsViewType.CalendarView);
            roomPresenter.GroupConflictingActivities();

            //Assert
            Assert.AreEqual(0, studySession1.ConflictGroup);
            Assert.AreEqual(1, studySession2.ConflictGroup);
            Assert.AreEqual(1, studySession3.ConflictGroup);
            Assert.AreEqual(2, studySession4.ConflictGroup);
            Assert.AreEqual(2, studySession5.ConflictGroup);
            Assert.AreEqual(0, studySession6.ConflictGroup);
            Assert.AreEqual(true, roomPresenter.HasSchedulingConflict);
        }

        [Test]
        public void WeeklyPresenter_ConflictingSemesterialActivities_ShouldBeInTheSameGroup()
        {
            //Arrange
            RoomModel room = new RoomModel() { BuildingID = "10", RoomName = "Room1" };
            RoomWeeklyPresenter roomPresenter = new RoomWeeklyPresenter(room);
            IScheduledActivityModel studySession1 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession2 =
                createActivity(new DateTime(2020, 10, 8, 12, 30, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession3 =
                createActivity(new DateTime(2020, 10, 8, 13, 30, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession4 =
                createActivity(new DateTime(2020, 10, 15, 13, 30, 0), ActivityType.StudySession);

            //Act
            roomPresenter.AddActivityToRoom(studySession1, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession2, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession3, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession4, RoomsViewType.SemesterialView);
            roomPresenter.GroupConflictingActivities();

            //Assert
            Assert.AreEqual(0, studySession1.ConflictGroup);
            Assert.AreEqual(1, studySession2.ConflictGroup);
            Assert.AreEqual(1, studySession3.ConflictGroup);
            Assert.AreEqual(1, studySession3.ConflictGroup);
            Assert.AreEqual(true, roomPresenter.HasSchedulingConflict);
        }
        [Test]
        public void WeeklyPresenter_EqualSemesterialActivities_ShouldBeAggregated()
        {
            //Arrange
            RoomModel room = new RoomModel() { BuildingID = "10", RoomName = "Room1" };
            RoomWeeklyPresenter roomPresenter = new RoomWeeklyPresenter(room);
            IScheduledActivityModel studySession1 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession2 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession3 =
                createActivity(new DateTime(2020, 10, 8, 12, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession4 =
                createActivity(new DateTime(2020, 10, 8, 12, 0, 0), ActivityType.StudySession);
            var studySession4Model = (StudySessionActivityModel)studySession4;
            studySession4Model.FullLessonCode = "1234-12";

            //Act
            roomPresenter.AddActivityToRoom(studySession1, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession2, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession3, RoomsViewType.SemesterialView);
            roomPresenter.AddActivityToRoom(studySession4, RoomsViewType.SemesterialView);
            roomPresenter.GroupConflictingActivities();

            //Assert
            var addedActivities = roomPresenter.ActivitiesPerDay[new System.DateTime(2020, 10, 8).DayOfWeek];
            Assert.AreEqual(3, addedActivities.Count);
            Assert.AreEqual(2, addedActivities[0].ActivityModel.ActivitiesDates.Count);
            Assert.AreEqual(true, roomPresenter.HasSchedulingConflict);
        }

        [Test]
        public void DailyPresenter_RoomWithConflictingActivities_ShouldHaveDuplicateIndication()
        {
            //Arrange
            RoomModel room = new RoomModel() { BuildingID = "10", RoomName = "Room1" };
            RoomDailyPresenter roomPresenter = new RoomDailyPresenter(room);
            IScheduledActivityModel studySession1 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);
            IScheduledActivityModel studySession2 =
                createActivity(new DateTime(2020, 10, 8, 8, 0, 0), ActivityType.StudySession);

            //Act
            roomPresenter.AddActivityToRoom(studySession1);
            roomPresenter.AddActivityToRoom(studySession2);
            roomPresenter.SetScheduleConflictIndicator();

            //Assert
            Assert.AreEqual(2, roomPresenter.ActivitiesPerHour[8].Count);
            Assert.AreEqual(true, roomPresenter.HasSchedulingConflict);
        }

        private IScheduledActivityModel createActivity(DateTime activityDate, ActivityType activityType, int activityDuration = 2)
        {
            TimeOfDay startTime = new TimeOfDay((byte)activityDate.Hour, (byte)activityDate.Minute);
            TimeOfDay endTime = new TimeOfDay((byte)(activityDate.Hour + activityDuration), (byte)activityDate.Minute);
            ActivityTime activityTime = new ActivityTime(startTime, endTime, activityDate);
            switch (activityType)
            {
                case ActivityType.StudySession:
                    return new StudySessionActivityModel()
                    {
                        ActivityTime = activityTime,
                        ActivitiesDates = new List<DateTime> { activityDate }
                    };
                case ActivityType.Event:
                    return new ScheduledEventModel()
                    {
                        ActivityTime = activityTime,
                        ActivitiesDates = new List<DateTime> { activityDate }
                    };
                case ActivityType.AssignmentTerm:
                    return new AssignmentTermActivityModel()
                    {
                        ActivityTime = activityTime,
                        ActivitiesDates = new List<DateTime> { activityDate }
                    };
                default:
                    throw new Exception("Activity Type Not Supported");
            }
        }
    }
}
