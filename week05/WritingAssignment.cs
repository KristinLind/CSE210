using System;

namespace assignment_class
{
    public string WritingAssignment: Assignment
    {
        private string _title;
        
        // Constructor
        public WritingAssignment(string studentName, string topic, string title)
            :base(studentName, topic)
        {
            _title = title;
        }

        // Method to call writing information
        public string GetWritingInformation()
        {
            return $"{title} by {GetStudentName()}";
        }

    }
}
        
