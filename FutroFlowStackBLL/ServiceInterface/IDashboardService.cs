﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutroFlowStackBLL.ServiceInterface
{
    public interface IDashboardService
    {
        Task<object> GetHomePage(int Token);
    }
}
