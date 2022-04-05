using System;
using System.Collections.Generic;
using EasyEnglishSayapina.Enums;

namespace EasyEnglishSayapina.Models
{
    public class LessonGroup
    {
        public LessonGroupTypeEnum Type { get; set; }
        public IList<Lesson> Lessons { get; set; }

        public LessonGroup()
        {
            Lessons = new List<Lesson>();
        }
    }
}
