using System;
using System.Collections.Generic;
using System.Text;

namespace 班级平均成绩作业
{
    class Course
    {
        private int id;
        private string name;
        private int credit;
        private bool hk;
        private int score;

        public Course() { }
        public Course(int id, string name, int credit)
        {
            this.credit = credit;
            this.id = id;
            this.name = name;
        }
        /**
         * 设置缓考
         * @param hk
         */
        public void sethk(bool hk)
        {
            this.hk = hk;
        }
        /**
         * 返回是否学生缓考
         * @return
         */
        public bool gethk()
        {
            return hk;
        }

        /**
         * 设置成绩
         * @param cj
         */
        public void setcj(int cj)
        {
            if (cj < 0 || cj > 100)
                return;
            this.score = cj;
        }

        /**
         * 返回成绩
         * @return
         */
        public int getcj()
        {
            return score;
        }

        /**
         * 返回该课程的学分
         * @return
         */
        public int getCredit()
        {
            return credit;
        }

        public override string ToString()
        {
            return "\n    id:" + id + "\n    name:" + name + "\n    credit:" + credit + "\n    ispostpone:" + hk + "\n    score:" + score;
        }

        /*public void setcj{
            get{
                return setcj;
            }
            set{
                if(cj<0 || cj>10) return cj;
                score = cj;
            }
                
        }

        public int getcj{ get; private set; }*/
    }
}
