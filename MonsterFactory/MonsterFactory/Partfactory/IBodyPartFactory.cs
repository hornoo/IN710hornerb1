﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public interface IBodyPartFactory
    {
        BodyPart requiredpart(int partIndex);
    }
}
