﻿using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara
{

    public static class Globals
    {
        public static bool UserConnected { get; set; }
    }


    public enum EventType
    {
        CreateAccount,
        Login,
        Logout,
        GetUserData,
        GetItemData,
        UpdateUserBillingInfo
    }


    [ProtoContract]
    [ProtoInclude(50, typeof(CreateAccountEvent))]


    public class BaseEvent
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }
    }

    [ProtoContract]
    public class CreateAccountEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string UserName { get; set; }

        [ProtoMember(2)]
        public string UserEmail { get; set; }

        [ProtoMember(3)]
        public string UserPassword { get; set; }

        [ProtoMember(4)]
        public string UserRepeatPassword { get; set; }


        public CreateAccountEvent()
        {
            Type = EventType.CreateAccount;
            UserName = null;
            UserEmail = null;
            UserPassword = null;
            UserRepeatPassword = null;
        }

        public CreateAccountEvent(string name, string email, string password, string userRepeatPassword)
        {
            Type = EventType.CreateAccount;
            UserName = name;
            UserEmail = email;
            UserPassword = password;
            UserRepeatPassword = userRepeatPassword;
        }
    }

}
