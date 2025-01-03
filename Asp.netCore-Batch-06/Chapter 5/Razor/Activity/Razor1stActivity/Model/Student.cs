﻿namespace Razor1stActivity.Model
{
    public class Student
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Address { get; set; }
    }
}
