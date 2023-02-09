using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    public class EmDB
    {
        List<Empl> db = new List<Empl>();
        //-----------------
        public void AddEmp(Empl e) { db.Add(e); }
        public List<Empl> GetAllEmployee() { return db; }
   //----------------------------------
        public List<Empl> filterId(string id)
        {
            List<Empl> l = new List<Empl>();
            if (id.Length == 0) return GetAllEmployee();
            foreach(Empl e in GetAllEmployee())
            {
                string i = e.getId();
                if (id.Length > i.Length) continue;
                i = i.Substring(0, id.Length);
                if (i.Equals(id)) l.Add(e);
            }
            return l;
        }// end filter by id
        //----------------------------------
        public List<Empl> filerName(string name)
        {
            List<Empl> l = new List<Empl>();
            if (name.Length == 0) return GetAllEmployee();
            foreach(Empl e in GetAllEmployee())
            {
                string n = e.getName();
                if(name.Length>n.Length) continue;
                n = n.Substring(0, name.Length);
                if (name.ToUpper().Equals(n.ToUpper())) l.Add(e);
            }
            return l;
        }// end filter name
        //--------------------------------
        public void DeletEmp(string id)
        {
            foreach(Empl e in GetAllEmployee())
            {
                if (e.getId().Equals(id))
                {
                    db.Remove(e);
                    break;
                }
            }
        }// end DeletEmp
        public Empl getEmpById(string id)
        {
            foreach(Empl e in GetAllEmployee())
            {
                if (e.getId().Equals(id)) return e;
            }
            return null;
        }//-------------
        public void UpdatEmp(Empl e,string id)
        {
            for(int i =0; i<db.Count; i++)
            {
                if (db[i].getId().Equals(id))
                {
                    db[i] = e;
                    break;
                }
            }
        }// end update
    }
}
