﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lesson
    {
        /// <summary>
        /// The lecturer details that teaches the Lesson.
        /// </summary>
        public Lecturer lecturer { get; set; }
        /// <summary>
        /// The Module details that the Lesson will take place for.
        /// </summary>
        public Module module { get; set; }
        /// <summary>
        /// the value given based on constraints broken
        /// </summary>
        private int fitness;
        /// <summary>
        ///     The default constructor of the Lesson object.
        /// </summary>
        public Lesson()
        {
        }
        /// <summary>
        ///     The constructor of Lesson object with a set of properties.
        /// </summary>
        /// <param name="lecturer">The name of the Lecturer</param>
        /// <param name="module">The name of the Module</param>
        /// <param name="room">The name/number of the Room</param>
        public Lesson(Lecturer lecturer, Module module)
        {
            this.lecturer = lecturer;
            this.module = module;
        }
        public string ToString()
        {
             return lecturer.name + "\n " + module.name + "\n";
        }
    }
}
