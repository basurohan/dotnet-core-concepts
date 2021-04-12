namespace GradeBook
{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStats();
        string Name { get; }
    }
}