﻿using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interface
{
    public interface IInterview
    {
       public void ScheduleInterview();
      public List<Interview> GetInterviews();
    }
}