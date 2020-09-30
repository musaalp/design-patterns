﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public class WebServer
    {
        private readonly Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            _handler.Handle(httpRequest);
        }
    }
}
