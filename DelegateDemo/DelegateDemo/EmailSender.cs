﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class EmailSender
    {
        private int sendResult;

        public int SendEmail()
        {
            Console.WriteLine("Simulatin sending email...");

            sendResult = 0;
            return sendResult;
        }
    }
}
