using System;
using System.Collections.Generic;
using System.Text;

namespace QualExam
{
    class App
    {
        string name;
        string creator;
        double price;

        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }
        public string Creator
        {
            get => this.creator;
            set
            {
                this.creator= value;
            }
        }
        public double Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }
    }
}
