using System;
using System.Collections.Generic;
using System.Text;

namespace 班级平均成绩作业
{
    class Student
    {
        
        private int id;
        private string name;
        private int nCourse = 0, coursenum = 0;

        private Course[] courses;

        public Student() { }
        public Student(int id, string name, int nCourse)
        {
            this.id = id;
            this.name = name;
            this.nCourse = nCourse;
            courses = new Course[100];
        }
        /**
         * 往学生类中添加课程对象
         * @param course
         */
        public void AddCourse(Course course)
        {
            if (coursenum > nCourse - 1)
                return;
            courses[coursenum] = course;
            coursenum++;
        }

        /**
         * 返回所学课程数
         * @param index
         * @return
         */
        public int GetCourseNum()
        {
            return nCourse;
        }

        /**
         * 返回对应下标的课程对象
         * @param index
         * @return
         */
        public Course GetCourse(int index)
        {
            return courses[index];
        }

        public int CalculateAvgGrade()
        {
            int sum = 0, sumn = 0;
            for (int i = 0; i < nCourse; i++)
            {
                if (courses[i].gethk())
                    continue;
                sum += courses[i].getcj();
                sumn++;
            }
            return sum / sumn;
        }



       public override string ToString()
        {
            String Courses = "";
            for (int i = 0; i < nCourse; i++)
                Courses += courses[i] + "\n";
            return "\n  id:" + id + "\n  name:" + name + "\n  number of course:" + nCourse + "\n  Course:" + Courses;
        }
    }
}
