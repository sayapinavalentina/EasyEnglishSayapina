using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Enums;
using EasyEnglishSayapina.Interfaces;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        private string _colorLevel5 = "#EACAF9";
        private string _colorLevel4 = "#EACAF9";
        private string _colorLevel3 = "#EACAF9";
        private string _colorLevel2 = "#EACAF9";
        private string _colorLevel1 = "#EACAF9";
        private string _colorLevel0 = "#EACAF9";
        private string _colorBonus = "#EACAF9";

        public async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroup>
                {
                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Introduction", "5", "lesson_egg", _colorLevel5, 1.0)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Greeting", "4", "lesson_dialog", _colorLevel4, 0.8),
                            GetNewLesson("Travel", "3", "lesson_airplane", _colorLevel3, 0.0)


                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Food", "2", "lesson_hamburger", _colorLevel2, 0.7),
                            GetNewLesson("Family", "1", "lesson_baby", _colorLevel1, 0.1)

                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bonus", string.Empty, "lesson_plus", _colorBonus, 0.0)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Shop", string.Empty, "lesson_sock", _colorLevel0, 0.0),
                            GetNewLesson("Study", "1", "lesson_pencil", _colorLevel1, 0.3),
                            GetNewLesson("Activity", "2", "lesson_hat", _colorLevel2, 0.4)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Meeting", "1", "lesson_bag", _colorLevel1, 0.9)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson(string.Empty, "1", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    }, 

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Routine", "1", "lesson_bike", _colorLevel1, 0.6),
                            GetNewLesson("Emotions", string.Empty, "lesson_heart", _colorLevel0, 0.5)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson(string.Empty, "2", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    },
                };
            });
        }

        private Lesson GetNewLesson(string name, string level, string icon, string color, double progress)
        {
            return new Lesson
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color,
                Progress = progress
            };
        }
    }
}
