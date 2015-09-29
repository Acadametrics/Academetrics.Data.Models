using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadametrics.Data.Models
{
  public class Planner
  {
    public int Id { get; set; }
    public Teacher Teacher { get; set; }
    public IList<Day> Days { get; set; }

    public static Planner CreatePlanner(int groupId, int teacherId)
    {
      Planner planner = new Planner()
      {
        Id = 1,
        Teacher = Teacher.CreateTeacher(teacherId),
        Days = Day.CreateDays(groupId)
      };

      return planner;
    }
  }
}
