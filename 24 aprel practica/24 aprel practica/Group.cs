using System;
using System.Collections.Generic;
using System.Text;

namespace _24_aprel_practica
{
    class Group
    {
        private string _groupno;
        private int _studentlimit;
        private Student[] Students = new Student[0];
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public Student GetStudents(int? id)
        {
            if (Array.Exists(Students, s=>s.Id == id))
            {
                Student student=Array.Find(Students,s=>s.Id==id);
                return student;
            }
            else
            {
                Console.WriteLine("Bele Id-li telebe yoxdur");
                return null;
            }
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
        public int StudentLimit
        {
            get => _studentlimit;
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentlimit = value;
                }
            }
        }
        public string GroupNo
        {
            get => _groupno;
            set
              { 
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                }
                  }   
        }
        public bool CheckGroupNo(string groupno)
        {
            if (groupno.Length==5)
            {
                    if (char.IsUpper(groupno[0]) && char.IsUpper(groupno[1]) && char.IsUpper(groupno[2]) && char.IsUpper(groupno[3]) && char.IsUpper(groupno[4]))
                    {
                        return true;

                    }
               
            }
            
            return false;
         }
            }
        }               

    

