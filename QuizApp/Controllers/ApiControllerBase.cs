﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
    }
}
