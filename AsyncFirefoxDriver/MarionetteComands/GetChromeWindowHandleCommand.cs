﻿// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCommunicationLib.Communication.MarionetteComands
{
    public class GetChromeWindowHandleCommand : MarionetteDebuggerCommand
    {
        public GetChromeWindowHandleCommand(int id = 0, string commandName = "getChromeWindowHandle") : base(id, commandName)
        {
        }

        public override void ProcessResponse(JToken response)
        {
            base.ProcessResponse(response);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(
                new object[]
                {
                   0,
                   Id,
                   CommandName,
                });

        }
    }
}
