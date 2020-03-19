﻿using cRegis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cRegis.Core.Interfaces
{
    public interface IEnrollService
    {
        void drop(int eid);

        Task<Enrolled> getEnrollAsync(int eid);
        void updateEnroll(Enrolled newEnroll);

        List<Enrolled> getEnrollsForStudent(int sid);

        List<Enrolled> getCurrentEnrollsForStudent(int sid);

        List<Enrolled> getCompletedEnrollsForStudent(int sid);
    }
}
