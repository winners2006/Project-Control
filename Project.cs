using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Control
{
    class Project
    {
        public int id { get; set; }
        private string nameProject, textProject, castomer, dataStart, dataStop, userLevel;
        public int amount;

        public int AmountProject
        {
            get { return amount; }
            set { amount = value; }
        }

        public string NameProject
        {
            get { return nameProject; }
            set { nameProject = value; }
        }
        public string TextProject
        {
            get { return textProject; }
            set { textProject = value; }
        }
        public string Castomer
        {
            get { return castomer; }
            set { castomer = value; }
        }
        public string DataStart
        {
            get { return dataStart; }
            set { dataStart = value; }
        }
        public string DataStop
        {
            get { return dataStop; }
            set { dataStop = value; }
        }
        public string UserProgect
        {
            get { return userLevel; }
            set { userLevel = value; }
        }
        

        public Project() { }

        public Project(string nameProject, string textProject, string castomer, string dataStart, string dataStop, string userLevel, int amount)
        {
            this.nameProject = nameProject;
            this.textProject = textProject;
            this.castomer = castomer;
            this.dataStart = dataStart;
            this.dataStop = dataStop;
            this.userLevel = userLevel;
            this.amount = amount;
        }

        public override string ToString()
        {
            return "Проект: " + nameProject + " Дата начала: " + dataStart + ", Дата окончания: " + dataStop + ", Исполнитель: " + userLevel;
        }
    }
}
