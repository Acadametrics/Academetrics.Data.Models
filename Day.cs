using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadametrics.Data.Models
{
  public class Day
  {
    public DateTime Date { get; set; }
    public int GroupId { get; set; }
    public IList<Period> Periods { get; set; }

    public static IList<Day> CreateDays(int groupId)
    {
      // Hi Toby
        // you should now be able to use this snippet to create/set the periods in the code below
        // it pulls the data from a .json file in the Unit Tests project
        // but will obviously be swappable for a different ObjectFactory that talks to a proper back end

       // IDataObjectFactory objectFactory = new TestDataObjectFactory("DataSetToby");
     //   TeacherPlannerDay teacherPlannerDay = objectFactory.GetTeacherPlannerDay(1001, new DateTime(2014, 10, 11));
     //   var periods = teacherPlannerDay.Periods;
        // inline it to use it directly below, i.e.
			//Periods = new TestDataObjectFactory("DataSetToby").GetTeacherPlannerDay(1001, new DateTime(2014, 10, 11)).Periods;

        // I'll work on swapping out the rest and looking at the backend after that.
        // This may all make no sense - worth a quick chat on the phone?
        // Stuart

      List<Day> dayList = new List<Day>(){
				new Day{
          Date=DateTime.Now.AddDays(-3),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        },
				new Day{
          Date=DateTime.Now.AddDays(-2),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        },
        new Day{
          Date=DateTime.Now.AddDays(-1),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        },
        new Day{
          Date=DateTime.Now,
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        },
        new Day{
          Date=DateTime.Now.AddDays(1),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        }
				,
        new Day{
          Date=DateTime.Now.AddDays(2),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        },
        new Day{
          Date=DateTime.Now.AddDays(3),
          GroupId=groupId,
          Periods=Period.CreatePeriods()
        }
      };

      return dayList;
    }

  }
}
