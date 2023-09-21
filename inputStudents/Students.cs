using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhập_liệu_sinh_viên
{
    public class Students
    {
        private int stt;
        private string id;
        private string name;
        private string faculty;
        private int score;


        public int Stt { get; set; }
        public string Id { get { return id; } set {  id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Faculty { get {  return faculty; } set { faculty = value; } }
        public int Score { get { return score; } set { score = value; } }

        
    }
}
