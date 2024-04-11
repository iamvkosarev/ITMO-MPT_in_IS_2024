using System.Collections.ObjectModel;

namespace WpfHello
{
    public class StudentList : ObservableCollection<Student>
    {
        public StudentList()
        {
            Add(new Student("Lorin Kanev", true));
            Add(new Student("Ivan Petrov", true));
            Add(new Student("Sergey Masov", false));
            Add(new Student("Tais Frolova", true));
            Add(new Student("Elena Diva", false));
        }
    }
}
