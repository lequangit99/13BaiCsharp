namespace Bai_14
{
    class Student
    {
        private string name;
        private string faculty;
        private int khoa;
        private string giaoTrinh;

        public Student(string name, string faculty, int khoa, string giaoTrinh)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Khoa = khoa;
            this.GiaoTrinh = giaoTrinh;
        }

        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Khoa { get => khoa; set => khoa = value; }
        public string GiaoTrinh { get => giaoTrinh; set => giaoTrinh = value; }
        public override string ToString()
        {
            return Name + " Khoa: " + Faculty + " Khoá: " + Khoa + " " + GiaoTrinh;
        }
    }
}
