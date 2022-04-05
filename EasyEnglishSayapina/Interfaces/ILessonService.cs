using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyEnglishSayapina.Models;

namespace EasyEnglishSayapina.Interfaces
{
    public interface ILessonService
    {
        Task<IList<LessonGroup>> GetLessonsGroup();
    }
}
