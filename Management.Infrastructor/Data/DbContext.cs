using Management.Domain.Madels;

namespace Management.Infrastructor.Data
{
    public class DbContext
    {
        public DbContext()
        {
            this.Students = new Student[12];
        }
        public Student[] Students { get; set; }
        public int StudentCount { get; set; } = 0; 
    }
}
