using Management.Domain.Madels;
using Management.Infrastructor.Data;

namespace Management.Application.Services
{
    public class StudentService
    {
        public int index= 0;
        public DbContext DbContext { get; set; }

        public StudentService()
        {
           this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
		{
			Student newStudent = new Student
			{
				Id = new Random().Next(1, 1000).ToString(),
				FirstName = firstName,
				LastName = lastName,
			};

			this.DbContext.Students[this.DbContext.StudentCount] = newStudent;
			this.DbContext.StudentCount++;
		}
    } 
}
