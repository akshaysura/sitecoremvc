﻿using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface IBreadcrumb:IGlassBase
    {
        string BreadcrumbTitle { get; set; }
    }
}
