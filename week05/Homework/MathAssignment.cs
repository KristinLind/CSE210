using System;

namespace assignment_class
{
    public class MathAssignment: Assignment
    {
        private string _textbookSection;
        private string _problems;
        // Constructor
        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
            :base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }
        // Getters
        public string GetTextbookSection()
        {
            return _textbookSection;
        }
        public string GetProblems()
        {
            return _problems;
        }
        // Setters
        public void SetTextbookSection(string section)
        {
            _textbookSection = section;
        }
        public void SetProblems(string problems)
        {
            _problems = problems;
        }
        // Method to return homework list
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}