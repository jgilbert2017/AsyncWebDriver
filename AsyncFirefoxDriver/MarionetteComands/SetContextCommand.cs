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
    public class SetContextCommand : MarionetteDebuggerCommand
    {
        public enum Contexts { chrome, content };
        public SetContextCommand(Contexts c, int id = 0, string commandName = "setContext") : base(id, commandName)
        {
            Context = c;
        }
        public Contexts Context { get; set; }

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
                   new {
                        value = GetContextStr()
                   }

                });

        }

        private string GetContextStr()
        {
            switch(Context)
            {
                case Contexts.content: return "content";
                case Contexts.chrome: return "chrome";
            }
            return null;
        }
    }
}
