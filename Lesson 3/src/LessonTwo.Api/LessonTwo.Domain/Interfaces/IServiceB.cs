﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo.Domain.Interfaces
{
    public interface IServiceB
    {
        Guid ServiceBId { get; set; }
        string GetService();
    }
}