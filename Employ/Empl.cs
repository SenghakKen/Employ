using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    public class Empl
    {
        private string id;
        private string name;
        private string sex;
        private string position;
        private string salary;
        //---------------
        public Empl(string id,string name,string sex,string pos,string sal)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.position = pos;
            this.salary = sal;

        }
        public void setId(string id) { this.id = id; }
        public void setName(string name) { this.name = name; }
        public void setSex(string sex) { this.sex = sex; }
        public void setPosition(string pos) { this.position = pos; }
        public void setSalarry(string salary) { this.salary = salary; }
        //----------------
        public string getId() { return id; }
        public string getName() { return name; }
        public string getSex() { return sex; }
        public string getPosition() { return position; }
        public string getSalary() { return salary; }
    }
}
