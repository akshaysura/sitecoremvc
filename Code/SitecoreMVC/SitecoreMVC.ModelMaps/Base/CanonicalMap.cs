﻿using Glass.Mapper.Sc.Maps;
using SitecoreMVC.Models.TemplateModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.ModelMaps.Base
{
    public class CanonicalMap : SitecoreGlassMap<ICanonical>
    {
        public override void Configure()
        {
            Map(x =>
            {
                x.AutoMap();
            });
        }
    }
}
